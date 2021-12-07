using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumatoriawhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num;
            Console.WriteLine("Escriba el numero para sumatoria");
            Num = Convert.ToInt32(Console.ReadLine());
            Num = Num * (Num + 1) / 2;
            Console.WriteLine(Num);
            Console.ReadLine();
        }
    }
}
