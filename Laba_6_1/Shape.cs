using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_6_1
{/*-	конструктор не может быть виртуальным;
-	переопределение виртуальной функции с иным 
перечнем параметров и изменением типа возвращаемого 
значения невозможно;
-	виртуальный механизм можно выключить, используя при вызове функции оператор разрешения видимости ::.
*/
    public class Shape
    {
        protected double a, b, c, d;
        public Shape(double a)
        {
            this.a = a;
        }
        public Shape(double a, double b)
        {

        }
        public virtual double GetSquare()
        {
            return 0;
        }

    }
    public class Square : Shape
    {
        public Square(double a):base(a)
        {

        }
        public override double GetSquare()
        {
            return a * a;
        }

    }

}
