using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructToClass
{
    // Class Friend
    // Author: Jailyn Talavera
    // Purpose: Unit2 Exam #14
    // Restrictions: None
    public class Friend
    {
        public string name;
        public string greeting;
        public DateTime birthdate;
        public string address;

        //deep copy to prevent enemy having the same reference
        public Friend DeepCopy()
        {
            Friend other = (Friend)this.MemberwiseClone();
            other.name = String.Copy(name);
            other.greeting = String.Copy(greeting);
            other.address = String.Copy(address);
            return other;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Friend friend = new Friend();
            Friend enemy = new Friend();

            // create my friend Charlie Sheen
            friend.name = "Charlie Sheen";
            friend.greeting = "Dear Charlie";
            friend.birthdate = DateTime.Parse("1967-12-25");
            friend.address = "123 Any Street, NY NY 12202";

            // now he has become my enemy
            enemy = friend.DeepCopy();

            // set the enemy greeting and address without changing the friend variable
            enemy.greeting = "Sorry Charlie";
            enemy.address = "Return to sender.  Address unknown.";

            Console.WriteLine($"friend.greeting => enemy.greeting: {friend.greeting} => {enemy.greeting}");
            Console.WriteLine($"friend.address => enemy.address: {friend.address} => {enemy.address}");
        }
    }
}



