using System;
using System.Numerics;
using System.Text;



namespace Console1
{
    class Program
    {
        static void Main(string[] arg)
        {

            /*
            int myRange = int.Parse(Console.ReadLine());
            bool isPrime = true;

            for (int i = 0; i < myRange; i++)
            {
                for (int j = 0; j < myRange && isPrime; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                    }
                    j++;
                }
                if (isPrime)
                {
                    Console.WriteLine($"{i} is a prime number");
                }
                else
                {
                    Console.WriteLine($"{i} is not a prime number");
                }

                i++;
            }
            */




            /*----------------------------------------------------------------------------------------*/

            /*
            Console.WriteLine("How old are you?:");
            int age = int.Parse(Console.ReadLine());

            if (age <= 3) 
            {
                Console.WriteLine("You are just a baby");
            }
            else if (age > 3 && age <= 10) 
            {
                Console.WriteLine("You a toddler");
            }
            else if (age > 10 && age < 18) 
            {
                Console.WriteLine("You a kid");
            }
            else 
            {
                Console.WriteLine("You a grown man");
            }
            */
            /*-------------------------------------------------------------------------------*/
            /*
            Console.WriteLine("How many dogs?:");
            int dogs = int.Parse(Console.ReadLine());
            decimal dog_amount = Convert.ToDecimal(dogs);
            Console.WriteLine("How many other animals?:");
            int animals = int.Parse(Console.ReadLine());

            decimal dogs_food = 2.5m;
            int animals_food = 4;

            decimal dogs_food_price = dog_amount * dogs_food;
            int animal_food_price = animals * animals_food;
            decimal animals_food_price = Convert.ToDecimal(animal_food_price);

            decimal End_Price = animals_food_price + dogs_food_price;

            Console.WriteLine(End_Price);
            
            */
            /*----------------------------------------------------------------------------*/
            /*
            Console.WriteLine("Inches?:");
            decimal inches = decimal.Parse(Console.ReadLine());

            decimal cm = inches * 2.54m;
            Console.WriteLine($"Centimeters: {cm}");
            */
            /*-----------------------------------------------------------------------------*/

            /*
            Console.WriteLine("What is your deposit? :");
            decimal Deposit = decimal.Parse(Console.ReadLine());
            Console.WriteLine("After how many years will it end?:");
            int due = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your glp? :");
            decimal tax = decimal.Parse(Console.ReadLine());

             decimal price = Deposit + due * ((Deposit * tax) / 12);

            Console.WriteLine($"Price is : {price}");
            */

            /*--------------------------------------------------------------------------------------------------*/

            /*
            
            Console.WriteLine("Goal:");
            int goal = int.Parse(Console.ReadLine());
            int team1 = 0;
            int team2 = 0;
            int game_team1 = 0;
            int game_team2 = 0;
            int set_team1 = 0;
            int set_team2 = 0;
            int diff = 0;
            string score;
            while (true)
            {
                score = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                if (score == "1")
                {
                    team1++;
                    Console.WriteLine("Team 1 scored");
                    Console.WriteLine($"{team1} : {team2}");
                }
                else if (score == "2")
                {
                    team2++;
                    Console.WriteLine("Team 2 scored");
                    Console.WriteLine($"{team2} : {team1}");
                }
                else
                {
                    continue;
                }

                diff = Math.Abs(team1 - team2);

                if (team1 >= goal && team1 > team2 && diff > 1)
                    {
                        set_team1++;
                        Console.WriteLine("Team 1 set");
                        team1 = 0;
                        team2 = 0;
                    }
                    else if (team2 >= goal && team2 > team1 && diff > 1)
                    {
                        Console.WriteLine("Team 2 set");
                        set_team2++;
                        team1 = 0;
                        team2 = 0;
                    }



                    if (set_team1 == 2)
                    {
                        Console.WriteLine("Game team1");
                        break;
                    }
                    else if (set_team2 == 2)
                    {
                        Console.WriteLine("Game team2");
                        game_team2++;
                        break;
                    }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                
            }
            */
            /*
            int a = 53;
            int b = 35;
            int c = 48;

            int max;

            max = a > b ? 
                a > c ? a : c : 
                b > c ? b : c;

            a = 6;

           if (a % 2 == 0) {
                Console.WriteLine("even");
           }
           else
            {
                Console.WriteLine("odd");
            }

                Console.WriteLine($"{max} is the greatest number");
            Console.ReadLine();

            */

           /*  
            int x = int.Parse(Console.ReadLine());
            int y = 0;
            int mult = 1;
            int sum = 0;
            Console.WriteLine($"{x} =");



            while (x % 10 != 0) 
            {
                y = x % 10;
                x -= y;
                y = y * mult;
                x /= 10;

                sum += y;   
            }
            Console.WriteLine($"Sum of digits = {sum}");
            
            */

            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            for (int j = n; j <= m; j++)
            {
                int sum = 0;
                int t = j;
                while (t>0)
                {
                    int digit = t % 10;
                    t /= 10;
                    sum += digit;

                    j++;
                }
                if (j % sum == 0)
                {
                    Console.WriteLine(j);
                }
                
            }
        }
    }
}