using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAllegionUtility
{
    public class Geetings
    {

        public string SayHelloQA() { return "Welcome to QA"; }
        public string SayHelloDEv() { return "Welcome to Development"; }

        public int SayHelloTimes(int count, string message) {

            for (int i = 0; i < 2; i++)
            {
                if (i>=count)
                {
                    return i;
                }

                //return 0;
               
            }
            return 0;
        }
    }
}
