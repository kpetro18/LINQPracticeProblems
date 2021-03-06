﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemsLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 1
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var probOneAnswer = LinqProblems.RunProblem1(words);

            Console.WriteLine("Problem 1 answer: ");

            foreach (var word in probOneAnswer)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine("\n\n");

            //Problem 2
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            var probTwoAnswer = LinqProblems.RunProblem2(names);

            Console.WriteLine("Problem 2 answer: ");

            foreach (var name in probTwoAnswer)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("\n\n");

            //Problem 3 & Problem 4
            List<Customer> customers = new List<Customer>()
            {
                new Customer(1, "Mike", "Rodgers"),
                new Customer(2, "Nick", "Allen"),
                new Customer(3, "Jason", "Ryan"),
                new Customer(4, "Dan", "Laffey")
            };
            var probThreeAnswer = LinqProblems.RunProblem3(customers);
            Console.WriteLine($"Problem 3 answer: \n{probThreeAnswer.Id}\n{probThreeAnswer.FirstName}\n{probThreeAnswer.LastName}\n\n");

            var probFourAnswer = LinqProblems.RunProblem4(customers);
            Console.WriteLine($"Problem 4 answer: \n{probFourAnswer.FirstName}\n{probFourAnswer.LastName}\n\n");
            
            //Problem 5
            List<string> classGrades = new List<string>()
            {
                "80,100,92,89,65", 
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
            };
            var probFiveAnswer = LinqProblems.RunProblem5(classGrades);
            Console.WriteLine($"Problem 5 answer: \n{probFiveAnswer}\n\n");
            //--------------------
            //Bonus Problem 1
            string letters = "terrill";
            var probBonusAnswer = LinqProblems.RunBonusProblem1(letters);
            Console.WriteLine($"Bonus answer 1: \n{probBonusAnswer}\n\n");
            Console.ReadLine();
        }
    }
}
