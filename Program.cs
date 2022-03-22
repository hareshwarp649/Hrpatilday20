using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTest1a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Anayzer Program");

            
            HandleExcepFirst moodAnalyzer = new HandleExcepFirst("I am in Happy Mood");
            Console.WriteLine("Mood is: " + moodAnalyzer.AnalyseMood());
            Console.ReadLine();
        }
    }
}
