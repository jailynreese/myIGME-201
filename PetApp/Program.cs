using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApp
{
    // Class Program
    // Author: Jailyn Talavera
    // Purpose: PE13 More Classes
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: 
        // Restrictions: None
        static void Main(string[] args)
        {
            Pet thisPet = null;
            Dog dog = null;
            Cat cat = null;
            IDog iDog = null;
            ICat iCat = null;

            Pets pets = new Pets();
            Random rand = new Random();

            for(int i = 0; i < 50; i++)
            {
                //1 in 10 chance of adding an animal
                if(rand.Next(1, 11) == 1)
                {
                    //50% chance of adding a dog
                    if(rand.Next(0, 2) == 0)
                    {
                        Console.WriteLine("You bought a dog!");

                        Console.WriteLine("dog's name => ");
                        string name = Console.ReadLine();

                        Console.WriteLine("license => ");
                        string license = Console.ReadLine();
                        
                        Console.WriteLine("age => ");
                        string age = Console.ReadLine();
                        int nAge = Int32.Parse(age);
                        dog = new Dog(license, name, nAge);

                    } 
                    else
                    {
                        //else add a cat
                        Console.WriteLine("You bought a cat!");

                        Console.WriteLine("cat's name => ");
                        string name = Console.ReadLine();

                        Console.WriteLine("age => ");
                        string age = Console.ReadLine();

                        cat = new Cat();
                    }
                }
                else
                {

                    int random = rand.Next(pets.Count);
                    try
                    {
                        thisPet = pets.petList[random];
                    }
                    catch
                    {
                        continue;
                    }

                    //iDog = thisPet.GetType();
                    
                }

            }
        }
    }

    public abstract class Pet
    {
        private string name;
        public int age;
        public string Name;

        //constructors
        public Pet()
        {
        }

        public Pet(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public abstract void Eat();
        public abstract void Play();
        public abstract void GotoVet();

    }
    public class Pets
    {
        public List<Pet> petList = new List<Pet>();
        public int Count
        {
            get;
        }

        //given indexer prop
        public Pet this[int nPetEl]
        {
            get
            {
                Pet returnVal;
                try
                {
                    returnVal = (Pet)petList[nPetEl];
                }
                catch
                {
                    returnVal = null;
                }

                return (returnVal);
            }

            set
            {
                // if the index is less than the number of list elements
                if (nPetEl < petList.Count)
                {
                    // update the existing value at that index
                    petList[nPetEl] = value;
                }
                else
                {
                    // add the value to the list
                    petList.Add(value);
                }
            }
        }

        public void Add(Pet pet)
        {
            petList.Add(pet);
        }

        public void Remove(Pet pet)
        {
            petList.Remove(pet);
        }

        public void RemoveAt(int petEl)
        {
            petList.RemoveAt(petEl);
        }
    }

    public interface ICat
    {
        void Eat();
        void Play();
        void Scratch();
        void Purr();
       
    }

    public interface IDog
    {
        void Eat();
        void Play();
        void Bark();
        void NeedWalk();
        void GotoVet();

    }

    public class Cat : Pet, ICat
    {
        //constructor
        public Cat()
        {
        }
        public override void Eat()
        {
            Console.WriteLine(this.Name + " is eating! Nom Nom!");
        }

        public override void Play()
        {
            Console.WriteLine(this.Name + " is playing with their toy!!");
        }

        public void Purr()
        {
            Console.WriteLine(this.Name + " is purring. They must like you.");
        }

        public void Scratch()
        {
            Console.WriteLine(this.Name + " is scratching their belly");
        }

        public override void GotoVet()
        {
            Console.WriteLine(this.Name + " has to go to the vet.");
        }
    }

    public class Dog : Pet, IDog
    {
        public string license;

        public Dog()
        {
        }

        public Dog(string szLicense, string szName, int nAge): base(szName, nAge)
        {
        }
        public override void Eat()
        {
            Console.WriteLine(this.Name + " is eating! Nom Nom!");
        }

        public override void Play()
        {
            Console.WriteLine(this.Name +  "is playing with their toy!!");
        }

        public void Bark()
        {
            Console.WriteLine(this.Name + " says \"RUFF RUFF\"");
        }

        public void NeedWalk()
        {
            Console.WriteLine(this.Name + " needs a walk!");
        }

        public override void GotoVet()
        {
            Console.WriteLine(this.Name + " has to go to the vet.");
        }
    }
}
