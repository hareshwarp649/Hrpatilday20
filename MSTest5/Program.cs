using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTest5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MoodAnalyFir moodAnalyzer = new MoodAnalyFir("");
            Console.WriteLine(moodAnalyzer.AnalyseMood());
            Console.ReadLine();
        }
    }
}
