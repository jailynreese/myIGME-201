using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Web;

namespace PE27
{
    class TriviaResult
    {
        public string category;
        public string type;
        public string difficulty;
        public string question;
        public string correct_answer;
        public List<string> incorrect_answers;
    }
    class Trivia
    {
        public int response_code;
        public List<TriviaResult> results;
    }
    //{"response_code":0,"results":[{"category":"General Knowledge","type":"multiple","difficulty":"easy",
     //   "question":"Virgin Trains, Virgin Atlantic and Virgin Racing, are all companies owned by which famous entrepreneur?   ","correct_answer":"Richard Branson","incorrect_answers":["Alan Sugar","Donald Trump","Bill Gates"]
    //}]}
    class Program
    {
        static void Main(string[] args)
        {
            string url = null;
            string s = null;

            HttpWebRequest request;
            HttpWebResponse response;
            StreamReader reader;

            url = "https://opentdb.com/api.php?amount=1";

            request = (HttpWebRequest)WebRequest.Create(url);
            response = (HttpWebResponse)request.GetResponse();
            reader = new StreamReader(response.GetResponseStream());
            s = reader.ReadToEnd();
            reader.Close();

            Trivia trivia = JsonConvert.DeserializeObject<Trivia>(s);

            trivia.results[0].question = HttpUtility.HtmlDecode(trivia.results[0].question);
            trivia.results[0].correct_answer = HttpUtility.HtmlDecode(trivia.results[0].correct_answer);

            for(int i = 0; i < trivia.results[0].incorrect_answers.Count; ++i)
            {
                trivia.results[0].incorrect_answers[i] = HttpUtility.HtmlDecode(trivia.results[0].incorrect_answers[i]);
            }

            Console.WriteLine(trivia.results[0].question);

            List<string> answers = new List<string>();
            answers = trivia.results[0].incorrect_answers;

            Random rand = new Random();
            int randomIndex = rand.Next(4);

            answers.Insert(randomIndex, trivia.results[0].correct_answer);

            for (int i = 0; i < answers.Count; ++i)
            {
 
                   Console.WriteLine((i+1) + ". " + answers[i]);  
            }

            string input = Console.ReadLine();
            int result;
            while(!Int32.TryParse(input, out result))
            {
                Console.WriteLine("Please enter a number that corresponds to one of the answers.");
                input = Console.ReadLine();
            }
            

            if(result == randomIndex + 1)
            {
                Console.WriteLine("Congrats you are correct!");
            }
            else
            {
                Console.WriteLine("Sorry the correct answer is " + trivia.results[0].correct_answer);
            }



        }
    }
}
