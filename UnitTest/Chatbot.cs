using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public static class Chatbot
    {
        
        public static string Reply(string name, int number)
        {
            if (name == "")
            {
                return "hej";
            }
            else if (number >= 1)
            {
                return name + " är " + number + " år gammal";
            }
            else if (name == "Hjälp mig!")
            {
                return "Vad behöver du hjälp med?";
            }
            else
            {
                return "hej" + name;
            }

          
          


        


        }

    }
}
