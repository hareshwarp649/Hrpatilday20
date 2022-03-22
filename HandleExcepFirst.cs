﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTest1a
{
    public class HandleExcepFirst
    {
      
            public string message;

            //Constructor for initializing the message
            public HandleExcepFirst(string message)
            {
                this.message = message;
            }

            //Method to analyse mood form a given message
            public string AnalyseMood()
            {
                try
                {
                    if (this.message.ToLower().Contains("sad"))
                    {
                        return "SAD";
                    }
                    else
                    {
                        return "HAPPY";
                    }
                }
                catch (NullReferenceException)
                {
                    return "HAPPY";
                }
            }
        
    }
}
