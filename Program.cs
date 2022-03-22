using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mtest1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" What is your Mood!");
            AnalyseMoodfirst message1= new AnalyseMoodfirst("i am ");
           Console.WriteLine( message1.AnalysingMood());
            Console.ReadLine();
        }
    }
}
