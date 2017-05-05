using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloJenkins
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(printing());
        }

        public static String printing()
        {
            return "Hello World from Jenkins. Added Tests now";
        }
    }
}
