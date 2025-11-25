using System;

namespace MyProgram
{
    class Car
    {
        string color;
        string carMake;
        string carModel;
        string carEngine;
        int normalSpeed;
        int fastSpeed;
        int maxSpeed;
        static void Main(string[] args)
        {
            Car CustomCar = new Car();
            CustomCar.normalSpeed = 90;
            CustomCar.fastSpeed = 140;
            CustomCar.maxSpeed = 200;
            CustomCar.color = "red";
            CustomCar.carMake = "Audi";
            CustomCar.carModel = "A3";
            CustomCar.carEngine = "1.6 Petrol";
            Console.WriteLine($"Your {CustomCar.color} {CustomCar.carMake} {CustomCar.carModel} with {CustomCar.carEngine} Engine's top speed is {CustomCar.maxSpeed} km/h");
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("How fast are you going? :");
                int CurrentSpeed = Convert.ToInt32(Console.ReadLine());
                CheckForCurrentSpeed(CurrentSpeed, CustomCar.normalSpeed, CustomCar.fastSpeed, CustomCar.maxSpeed);
                i++;
            }
        }
        static void SlowSpeed()
        {
            Console.WriteLine("Let's go, drive this car bro!");
        }
        static void NormalSpeed()
        {
            Console.WriteLine("Here we go, this is a normal driving");
        }
        static void FastSpeed()
        {
            Console.WriteLine("You are driving really fast");
        }
        static void MaxSpeadReached()
        {
            Console.WriteLine("You reached the limit of this car!");
        }
        static void SuperFast()
        {
            Console.WriteLine("HOW DO YOU EVEN DRIVE THIS FAST BRO!!!!!");
        }
        static void CheckForCurrentSpeed(int CurrentSpeed, int normalSpeed, int fastSpeed, int maxSpeed)
        {
            if (CurrentSpeed <= normalSpeed)
            {
                SlowSpeed();
            }
            else if (CurrentSpeed > normalSpeed && CurrentSpeed <= fastSpeed)
            {
                NormalSpeed();
            }
            else if (CurrentSpeed > fastSpeed && CurrentSpeed < maxSpeed)
            {
                FastSpeed();
            }
            else if (CurrentSpeed == maxSpeed)
            {
                MaxSpeadReached();
            }
            else
            {
                SuperFast();
            }
        }
        





    }
        
    
}
    