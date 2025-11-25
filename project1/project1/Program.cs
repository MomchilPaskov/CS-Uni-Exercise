using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = -1;
            int y = 2;

            int z = x + y;
            int c = y - x;
            int d = x^(2) - y^(2);
            int f = x ^ 2 - y ^ 2;
            int e = (x*x) + (y*y);

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine("----------------------------");
            Console.WriteLine(z);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(f);
            Console.WriteLine(e);
            Console.ReadLine();

            Console.WriteLine("What is your name?");

            string name = Console.ReadLine();
            Console.WriteLine("What is your surname");

            string surname = Console.ReadLine();

            Console.WriteLine("How old are you?");

            string age = Console.ReadLine();

            int Age = Convert.ToInt32(age);

            Console.WriteLine("Hello " + name + " " + surname + ".");
            if (Age > 15)
            {
                Console.WriteLine("You are older than me! I am 15 and you are " + age);
            }
            else
            {
                Console.WriteLine("You are younger than me, I am 15 and you are " + age);
            }


            string SomeString = "I have to go";
            int CharPos = SomeString.IndexOf("o");
            string OtherString = SomeString.Substring(CharPos);

            Console.WriteLine(SomeString);
            Console.WriteLine(OtherString);

            int day = 7;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Mondey");
                    break;
                case 2: 
                    Console.WriteLine("Tuesday"); 
                    break;
                case 3: 
                    Console.WriteLine("Wednesday"); 
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
            
        }
    }
}