using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mesqYonelimli
{
    class Program
    {
        static void Main(string[] args)
        {
            Basdan:
            Console.WriteLine("Birinci Ededi Yazin");
            int eded1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Simvolu Daxil Edin");
            char smvl = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Ikinci Ededi Yazin");
            int eded2 = Convert.ToInt32(Console.ReadLine());
            Class1 cs1 = new Class1(eded1, eded2,smvl);
            goto Basdan;


        }
    }
}