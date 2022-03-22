using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTest4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MstestFirst moodAnalyzer = new MstestFirst("");
            Console.WriteLine(moodAnalyzer.AnalyseMood());
            Console.ReadLine();
        }
    }
}
