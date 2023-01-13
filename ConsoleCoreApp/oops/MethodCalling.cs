using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleCoreApp.oops
{
    internal class MethodCalling
    {
        public void CallByValue(int x , int y)
        {
            x = x + 20;
            y = y + 30;
            Console.WriteLine($"X:{x}\tY:{y}");
        }


        //Method Call by reference behaviour using ref keyword
        public void CallByRef(ref int x, ref int y)
        {
            x = x + 20;
            y = y + 30;
            Console.WriteLine($"X:{x}\tY:{y}");
        }

        //Method Call by reference behaviour using out keyword
        public void CallByOutput(int x,int y,out int s,out int m,out int d)
        {
            s = x + y;
            m = y * y;
            d = x / y;
        }

        //Method for call by Named/Optinal arguments
        public void CallByNamedOptinal(int id,string fname="Guest",string surname="",float salary=25000)
        {
            Console.WriteLine($"Welcome:{fname} {surname}");
            Console.WriteLine($"ID:{id}\t Salary:{salary}");
        }
    }
}
