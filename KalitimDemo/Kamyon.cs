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
            Console.WriteLine("Kamyonlar Contr. çalıştı");
            Console.WriteLine("yeni branch ekledim");
        }

        public Kamyon(int valu)
            : base(valu)
        {
            Console.WriteLine("Kamyon : {0}", valu);
            Console.WriteLine("Kamyon : {0}", val);
            Console.WriteLine(val);
        }

    }
}
