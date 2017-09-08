using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mesqYonelimli
{
    class Class1
    {
        public int eded1;
        public int eded2;
        public char simvol;

        public Class1(int _eded1, int _eded2, char _simvol)
        {
            this.eded1 = _eded1;
            this.eded2 = _eded1;
            this.simvol = _simvol;

            if (this.simvol == '+')
            {
                int cem = _eded1 + _eded2;
                Console.WriteLine("Sizin Netice " + cem);
            }

            if (this.simvol == '-')
            {
                int ferq = _eded1 - _eded2;
                Console.WriteLine("Sizin Netice " + ferq);
            }

            if (this.simvol == '/')
            {
                int qismet = _eded1 / _eded2;
                Console.WriteLine("Sizin Netice " + qismet);
            }

            if (this.simvol == '*')
            {
                int hasil = _eded1 * _eded2;
                Console.WriteLine("Sizin Netice " + hasil);
            }
        }


    }
}