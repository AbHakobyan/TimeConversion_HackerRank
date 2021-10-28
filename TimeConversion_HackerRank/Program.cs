using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConversion_HackerRank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "12:01:00AM";
            string x = timeConversion(s);
            Console.WriteLine(x);
        }

        public static string timeConversion(string s)
        {
            DateTime dt = DateTime.Parse(s);
            return dt.ToString("HH:mm:ss");
        }
    }
}
