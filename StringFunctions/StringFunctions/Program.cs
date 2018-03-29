using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Dave";
            //string quote = "The man said, \\Hello\", Dave. \n Hello on a new line. \n \t Hello on a tab.";
            //string fileName = @"C:\Users\Jesse";

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("e");

            //int length = name.Length;

            //name = name.ToLower();

            //Console.WriteLine(name);
            //Console.ReadLine();

            //string name = "Dave";
            //name = "Joe";

            //Console.WriteLine(name);
            //Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Jesse");


            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
