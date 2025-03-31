using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDP
{
    public sealed class SingletonLogger
    {
        private static readonly SingletonLogger _instance = new SingletonLogger();
            private static readonly object _lock = new object();
            private static int counter = 0;
        private SingletonLogger()
        {
            counter++;
            Console.WriteLine($"Singletone instance number {counter}");
        }

        public static SingletonLogger intance
        {
            get
            {
                return _instance;
            }
        }

        public void Log(string message)
        {
            lock (_lock)
            {
                Console.WriteLine(message);
            }
        }

    }
}
