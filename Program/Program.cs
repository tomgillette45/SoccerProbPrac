using System;
using System.Text.Json;

namespace ProbpracticeGen
{
    public class Practice
    {
        public string Name { get; set; }
        public List<string> Problem { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = "Practice.json";
            string jsonString = File.ReadAllText(fileName);
            List<Practice> Practices = JsonSerializer.Deserialize<List<Practice>>(jsonString)!;
            Console.WriteLine(Practices.Count);
        }
    }
}