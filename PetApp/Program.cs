using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PetApp.Program;

namespace PetApp
{
    //Class: Program
    //Author: Nick Will
    //Purpose: Manages a list of pets and their actions
    //Restrictions: None
    internal class Program
    {
        //A class for a list of Pets
        public class Pets
        {
            public List<Pet> petList = new List<Pet>();

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

            public int Count
            {
                get
                {
                    return petList.Count;
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

        //An abstract class for defining a Pet
        public abstract class Pet
        {
            private string name;
            public int age;

            public Pet()
            {

            }

            public Pet(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }

            public abstract void Eat();
            public abstract void Play();
            public abstract void GotoVet();
        }

        //An interface for defining a Dog
        public interface IDog
        {
            void Eat();
            void Play();
            void Bark();
            void NeedWalk();
            void GotoVet();

        }

        //And inteface for defining a Cat
        public interface ICat
        {
            void Eat();
            void Play();
            void Scratch();
            void Purr();

        }

        //A class representing a Dog
        public class Dog : Pet, IDog
        {
            public string license;

            public Dog (string szLicense, string szName, int nAge) : base(szName, nAge)
            {
                this.license = szLicense;

            }

            public override void Eat()
            {
                Console.WriteLine($"{this.Name} eats their food. YUM!");
            }

            public override void Play()
            {
                Console.WriteLine($"{this.Name} chases the ball. FETCH!");
            }

            public void Bark()
            {
                Console.WriteLine($"{this.Name} says \"WOOF!\"");
            }

            public void NeedWalk()
            {
                Console.WriteLine($"{this.Name} has too much energy. They need to go for a walk.");
            }

            public override void GotoVet()
            {
                Console.WriteLine($"{this.Name} knows you're not actually going for a walk. You're going to the VET!!!");
            }
        }

        //A class representing a Cat
        public class Cat : Pet, ICat
        {
            public Cat(string szName, int szAge) : base(szName, szAge)
            {

            }

            public override void Eat()
            {
                Console.WriteLine($"{this.Name} eats their food. YUM!");
            }

            public override void Play()
            {
                Console.WriteLine($"{this.Name} chases the toy mouse.");
            }

            public void Purr()
            {
                Console.WriteLine($"{this.Name} purrs softly.");
            }

            public void Scratch()
            {
                Console.WriteLine($"{this.Name} scratched at you! OUCH!");
            }

            public override void GotoVet()
            {
                Console.WriteLine($"{this.Name} knows what getting in the crate means. You're going to the VET!!!");
            }
        }

        //Method: Main
        //Purpose: Manage and manipulate a list of Pets, performing random actions with random pets
        //Restrictions: None
        static void Main(string[] args)
        {
            Pet thisPet = null;
            Dog dog = null;
            Cat cat = null;
            IDog iDog = null;
            ICat iCat = null;

            string name = "";
            int age = 0;
            string license = "";

            Pets pets = new Pets();

            Random rand = new Random();

            for (int i = 0; i < 50; i++)
            {
                // 1 in 10 chance of adding an animal
                if (rand.Next(1, 11) == 1)
                {
                    if (rand.Next(0, 2) == 0)
                    {
                        // add a dog
                        Console.WriteLine("You bought a dog!");
                        Console.Write("Enter dog's name: ");
                        name = Console.ReadLine();

                        do
                        {
                            Console.Write("Enter dog's age: ");
                        }
                        while (!int.TryParse(Console.ReadLine(), out age));

                        Console.Write("Enter dog's license: ");
                        license = Console.ReadLine();

                        pets.Add(new Dog(license, name, age));


                    }
                    else
                    {
                        // else add a cat
                        Console.WriteLine("You bought a cat!");
                        Console.Write("Enter cat's name: ");
                        name = Console.ReadLine();

                        do
                        {
                            Console.Write("Enter cat's age: ");
                        }
                        while (!int.TryParse(Console.ReadLine(), out age));

                        pets.Add(new Cat(name, age));

                    }
                }
                else
                {
                    // choose a random pet from pets and choose a random activity for the pet to do
                    thisPet = pets[rand.Next(0, pets.Count)];
                    
                    if (thisPet == null)
                    {
                        continue;
                    }
                    
                    if (thisPet.GetType().Equals(typeof(Dog)))
                    {
                        iDog = (IDog)thisPet;

                        switch (rand.Next(0, 5))
                        {
                            case 0: iDog.Eat();
                                    break;

                            case 1: iDog.Play();
                                    break;

                            case 2: iDog.Bark();
                                    break;

                            case 3: iDog.NeedWalk();
                                    break;

                            case 4: iDog.GotoVet();
                                    break;
                        }
                    }

                    if (thisPet.GetType().Equals(typeof(Cat)))
                    {
                        iCat = (ICat)thisPet;

                        switch (rand.Next(0, 4))
                        {
                            case 0: iCat.Eat();
                                    break;

                            case 1: iCat.Play();
                                    break;

                            case 2: iCat.Scratch();
                                    break;

                            case 3: iCat.Purr();
                                    break;
                        }
                    }
                }

            }

        }
    }
}
