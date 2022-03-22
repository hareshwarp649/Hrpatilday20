using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Threading.Tasks;

namespace MTest4
{
    public class MoodAnalyzeFactory
    {
        public static object CreateMoodAnalyse(string className, string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(className, pattern);

            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnaylseType = executing.GetType(className);
                    return Activator.CreateInstance(moodAnaylseType);
                }
                catch (ArgumentNullException)
                {
                    throw new MoodTestAnaly(MoodTestAnaly.ExceptionTypes.NO_SUCH_CLASS, "Class Not Found");
                }
            }
            else
            {
                throw new MoodTestAnaly(MoodTestAnaly.ExceptionTypes.NO_SUCH_METHOD, "Constructor is Not Found");
            }
        }
    }
}
