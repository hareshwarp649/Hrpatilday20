using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection; 
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MSTest5
{
    public class MaFactory
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
                    throw new MoodAnalExcep(MoodAnalExcep.ExceptionTypes.NO_SUCH_CLASS, "Class Not Found");
                }
            }
            else
            {
                throw new MoodAnalExcep(MoodAnalExcep.ExceptionTypes.NO_SUCH_METHOD, "Constructor is Not Found");
            }
        }

        //uc-5 added
        public static object CreateMoodAnalyseUsingParameterizedConstructor(string className, string constructorName)
        {
            Type type = typeof(MoodAnalyFir);
            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo ctor = type.GetConstructor(new[] { typeof(string) });
                    object instance = ctor.Invoke(new object[] { "HAPPY" });
                    return instance;
                }
                else
                {
                    throw new MoodAnalExcep(MoodAnalExcep.ExceptionTypes.NO_SUCH_METHOD, "Constructor is Not Found");
                }

            }
            else
            {
                throw new MoodAnalExcep(MoodAnalExcep.ExceptionTypes.NO_SUCH_CLASS, "Class Not Found");
            }

        }
    }
}
