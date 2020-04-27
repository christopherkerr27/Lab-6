using System;
using System.Numerics;

namespace Lab6
{
    public class Program
    {
        static void Main(string[] args)
        {
            string response = "";
            string input = "";

            {
                Console.Write("Welcome to the Grand Circus Casino! Roll the dice? (y/n): ");
                input = Console.ReadLine();
                input = input.ToUpper();
                if (input == "Y") do
                    {
                        Console.Write("How many sides should each die have?");
                        string input2 = Console.ReadLine();
                        var number = int.Parse(input2);
                        var number2 = number;
                        Dice(number);
                        Console.WriteLine("Would you like to continue? (y/n)");
                        response = Console.ReadLine();
                        response = response.ToUpper();
                    }
                    while (response == "Y");


            }
        }
        public static void Dice(int number)
        {
            Random rnd = new Random();
            int dice = rnd.Next(1, number);
            Console.WriteLine("Roll 1:");
            Console.WriteLine(dice);
            int dice2 = rnd.Next(1, number);
            Console.WriteLine(dice2);
        }
    }
}