using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern_thread_safe
{
    public class MySingletonClass
    {
        private static MySingletonClass _instance = null;
        private static readonly Object _padLock = new object();

        private MySingletonClass()
        {
            Console.WriteLine("singleton constructor is called");
        }
        public static MySingletonClass instance { get {
                lock (_padLock) {
                    if (_instance == null) {
                        _instance = new MySingletonClass();
                    }
                    return _instance;
                }
            } }
        public void Message()
        {
            Console.WriteLine("Hello from singleton class");

            Console.WriteLine("===========================");
        }

    }
}
