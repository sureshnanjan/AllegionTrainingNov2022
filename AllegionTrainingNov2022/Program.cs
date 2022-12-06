using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllegionTrainingNov2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyAllegionUtility.Geetings inst1 = new MyAllegionUtility.Geetings();
            string ans1 = inst1.SayHelloQA();
            if (ans1.Equals("Welcome to QA"))
            {
                Console.WriteLine("Success");
            }
            else { Console.WriteLine("Failure"); }




        }
    }
}
