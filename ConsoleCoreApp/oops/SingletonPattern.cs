using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.oops
{
    internal class SingletonPattern
    {
        static SingletonPattern singleton;
        private SingletonPattern()
        {

        }
        public static SingletonPattern GetObject()
        {
            return singleton == null ? new SingletonPattern() : singleton;
        }
        public void Display()
        {

            Console.WriteLine("Display from Singleton Pattern");
        }

    }
        
}