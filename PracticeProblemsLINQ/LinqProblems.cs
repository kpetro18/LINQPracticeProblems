﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemsLINQ
{
    public static class LinqProblems
    {
        //Weighted project points: /10
        //Project points: /25
       
        #region Problem 1 
        //(5 points) Problem 1
        //Using LINQ, write a method that takes in a list of strings and returns all words that contain the substring “th” from a list.
        public static List<string> RunProblem1(List<string> words)
        {
            //code
            List<string> probOne = words.FindAll(w => w.Contains("th"));
            //return
            return probOne;
        }
        #endregion

        #region Problem 2 
        //(5 points) Problem 2
        //Using LINQ, write a method that takes in a list of strings and returns a copy of the list without duplicates.
        public static List<string> RunProblem2(List<string> names)
        {
            //code
            var probTwo = names.Distinct();
            //return
            return probTwo.ToList();
        }
        #endregion

        #region Problem 3
        //(5 points) Problem 3
        //Using LINQ, write a method that takes in a list of customers and returns the lone customer who has the name of Mike. 
        public static Customer RunProblem3(List<Customer> customers)
        {
            //code
            Customer probThree = customers.Find(c => c.FirstName == "Mike");
            //return
            return probThree;
        }
        #endregion

        #region Problem 4
        //(5 points) Problem 4
        //Using LINQ, write a method that takes in a list of customers and returns the customer who has an id of 3. 
        //Then, update that customer's first name and last name to completely different names and return the newly updated customer from the method.
        public static Customer RunProblem4(List<Customer> customers)
        {
            //code
            var probFour = customers.Find(c => c.Id == 3);
            probFour.FirstName = "Foo"; //not sure if this is quite what was wanted
            probFour.LastName = "Bar";
            
            
            //return
            return probFour;
        }
        #endregion

        #region Problem 5
        //(5 points) Problem 5
        //Using LINQ, write a method that calculates the class grade average after dropping the lowest grade for each student.
        //The method should take in a list of strings of grades (e.g., one string might be "90,100,82,89,55"), 
        //drops the lowest grade from each string, averages the rest of the grades from that string, then averages the averages.
        //Expected output: 86.125
        public static double RunProblem5(List<string> classGrades)
        {
            //code
            double addedStudentAverages = 0;
            foreach (string item in classGrades)
            {
                string[] studentGrades = item.Split(',');
                var intGrades = studentGrades.Select(s => Int32.Parse(s)).ToList();
                intGrades.Remove(intGrades.Min());
                addedStudentAverages += intGrades.Average();
            }
            var classAverage = addedStudentAverages / classGrades.Count;
            //return
            return classAverage;

        }
        #endregion

        #region Bonus Problem 1
        ////(5 points) Bonus Problem 1
        ////Write a method that takes in a string of letters(i.e. “Terrill”) 
        ////and returns an alphabetically ordered string corresponding to the letter frequency(i.e. "E1I1L2R2T1")
        public static string RunBonusProblem1(string word)
        {
            //code
            word = word.ToUpper();
            char[] lettersList = word.ToCharArray();
            Array.Sort(lettersList);
            string combinedString = "";
            int count = 1;

            for (int i = 0; i < lettersList.Length; i++)
            {
                if (i + 1 >= lettersList.Length)
                {
                    return combinedString;
                }
                else if (i == 0)
                {
                    combinedString += lettersList[i];
                    combinedString += count;
                }
                else if (lettersList[i] == lettersList[i+1])
                {
                    count++;
                }

                else
                {
                    combinedString += lettersList[i];
                    combinedString += count;
                    count = 1;
                }
            }
            //return
            return combinedString;
        }
        #endregion
    }
}