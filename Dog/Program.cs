using System;

namespace Dog
{
    enum Gender
    {
        Male,
        Female
    }

    class Dog
    {
        public string name, owner;
        public int age;

        public Gender Gender { get; }

        public Type gender;

        internal Dog (string _name, string _owner, int _age, Gender _sex)
        {
            name = _name;
            owner = _owner;
            age = _age;
            Gender = _sex;
        }

        static void PrintGender (Gender gender)
        {
            switch (gender)
            {
                case Gender.Male:
                    Console.WriteLine("Male");
                    break;
                case Gender.Female:
                    Console.WriteLine("Female");
                    break;
                default:
                    Console.WriteLine("Unknown gender");
                    break;
            }
        }

        public void PrintBark(int i)
        {

            if (i > 0)
            {
                Console.WriteLine("Woof! ");
                i++;
            }
        }

        public void GetTag()
        {
            Console.WriteLine("If lost, call {0}. His name is {1} and he is {2} years old.", owner, name, age);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog a = new Dog ("Orion", "Shawn", 1, Gender.Male);
            a.PrintBark(3);
            Console.WriteLine(a.GetTag());
        }
    }
}
