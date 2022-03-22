using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mtest1
{
    public class AnalyseMoodfirst
    {
      
       public string message1;

            public AnalyseMoodfirst(string message1)
            {
                this.message1 = message1;
            }

            public string AnalysingMood()
            {
                 if (this.message1.ToLower().Contains("sad"))
                    {
                        return "SAD";
                    }
                    else
                    {
                        return "HAPPY";
                    }

                
           }
        
    }
}
