using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimDemo
{
    public class Kamyon : MotorluTasit
    {
        public Kamyon()
        {
            Console.WriteLine("Kamyon Contr. çalıştı");
        }

        public Kamyon(int valu)
            : base(valu)
        {
            Console.WriteLine("Kamyon : {0}", valu);
        }

    }
}
