using System;
using System.Text.Json;

namespace ProbpracticeGen
{
    public class Practice
    {
        public string? Name { get; set; }
        public List<string>? Problem { get; set; }
    }
    internal class Program
    {
        static string GetJsonString()

        {
            string fileName = "Practice.json"; //simple string called filename
            // Class file, Method readalltext, filename is a parameter that requires a path

            string jsonString = File.ReadAllText(fileName);
            //creates list of practice from the Json file
            //Defining variables

            return jsonString;
        }

        static void Main(string[] args)
        {

            var jsonstring = GetJsonString();

            List<Practice> Practices = JsonSerializer.Deserialize<List<Practice>>(jsonstring)!;
            List<string>? Problem = new List<string>();
            //below - practice var already declared?
            foreach (var practice in Practices)
            {
                foreach (var problem in practice.Problem)
                {
                    Problem.Add(problem);

                }
            }

            Console.WriteLine("Welcome to the Problem Practice Generator");
            Console.WriteLine($"What is the problem you are encountering?\nHere are your options: {string.Join("/ ", Problem)}");

            string? userProblem = Console.ReadLine();

            foreach (var practice in Practices)
            {

                if (practice.Problem.Contains(userProblem))

                {
                    Console.WriteLine($"{practice.Name}");
                }
            }

            //        {
            //            //add practice here: practice file name may have to be converted from JSON file
            //            Console.WriteLine(${ string.Join("", )}/ n"do you have another problem?");
            //    else
            //}

            //string answer = Console.ReadLine();

            //Console.WriteLine("Are you encountering another problem?");

            //string YVsN = Console.ReadLine();
            ////if (YVsN == "N")
            ////{goto  StartProblem}

            //var YVsN = Console.ReadLine();
            ////if (YvsN = Y) //loop to "What is the problem you are encountering?"//
            ////else (YvsN = N) https://stackoverflow.com/questions/47604100/c-sharp-loop-back-to-a-previous-part-of-code
            ////else (Console.ReadLine = )
        }
    }
}