using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAllegionUtility
{
    internal class Programcs
    {
        private string astring; 
        static void Main()
        {
            TestString objectOne = new TestString("mama");
            TestString objectTwo = new TestString("niku");
            //objectOne[0];

            Console.WriteLine(objectOne + objectTwo);       
        }
    }

    internal class TestString
    {
        public string astring;

        public TestString()
        {
        }

        public TestString(string astring)
        {
            this.astring = astring;
        }

        public static TestString operator +(TestString objectOne, TestString objectTwo)
        {
            TestString temp = new TestString();
            temp.astring = (objectOne.astring + objectTwo.astring);
            return temp;
        }
    }
}
