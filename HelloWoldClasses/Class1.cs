using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWoldClasses
{
    public class Calculator
    {
        
           public string divideby4(int number)
            {
                if (number % 4 == 0)
                {
                    return "Hello";
                }
                else
                {
                    return "";
                }
            }
        public string divideby6(int number)
        {
            if (number % 6 == 0)
            {
                return "World";
            }
            else
            {
                return "";
            }
        }
        public string dividebyboth(int number)
        {
            if ((number % 4 == 0) && (number % 6 == 0))
            {
                return "HelloWorld";
            }
            else
            {
                return "";
            }
        }
        public int dividewrong(int number)
        {
            if ((number % 4) != 0 && number % 6 != 0)
            {
                return number;
            }
            else { return 0; }
        }
        }
    }

