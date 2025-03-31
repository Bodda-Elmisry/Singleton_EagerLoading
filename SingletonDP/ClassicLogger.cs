using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDP
{
    public class ClassicLogger
    {
        private static int counter = 0;
        public ClassicLogger()
        {
            counter++;
            Console.WriteLine($"Classic instance number {counter}");
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }



    }
}
