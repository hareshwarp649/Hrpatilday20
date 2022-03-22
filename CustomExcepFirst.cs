﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mtest3
{
    public class CustomExcepFirst
    {

        public string message;

        //Constructor for initializing the message
        public CustomExcepFirst(string message)
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
                    throw new CustomExceptionSec(CustomExceptionSec.ExceptionTypes.NULL_MOOD_EXCEPTION, "Message should not be null");
                }
                else if (this.message.Equals(string.Empty))
                {
                    throw new CustomExceptionSec(CustomExceptionSec.ExceptionTypes.EMPTY_MOOD_EXCEPTION, "Message should not be empty");
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
            catch (CustomExceptionSec)
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
