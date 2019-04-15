using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        double len, wid;

        public void method()
        {
            len = 2.5;
            wid = 2.5;
        }

        public double hey()
        {
            return len * wid;
        }

        public void getdata()
        {
            Console.WriteLine("Length :{0}", len);
            Console.WriteLine("Width  :{0}", wid);
            Console.WriteLine("Area : {0}", hey());

        }
    }

        class Hello{

            static void Main(String[] args)
            {

            Program p = new Program();
            p.method();
            p.getdata();
            Console.ReadKey();
        }
            
    }
}
