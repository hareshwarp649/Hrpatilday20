using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTest4
{
    public class MstestFirst
    {

        public string message;

        public MstestFirst()
        {
            Console.WriteLine("Default Constructor");
        }

        //Constructor for initializing the message
        public MstestFirst(string message)
        {
            this.message = message;
        }

        //Method to analyse mood form a given message
        public string AnalyseMood()
        {
            //Custom Exception Handling
            try
            {
                if (this.message.Equals(null))
                {
                    throw new MoodTestAnaly(MoodTestAnaly.ExceptionTypes.NULL_MOOD_EXCEPTION, "Message should not be null");
                }
                else if (this.message.Equals(string.Empty))
                {
                    throw new MoodTestAnaly(MoodTestAnaly.ExceptionTypes.EMPTY_MOOD_EXCEPTION, "Message should not be empty");
                }
                else if (this.message.ToLower().Contains("sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (MoodTestAnaly)
            {
                return "HAPPY";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "HAPPY";
            }
        }
    }
}
