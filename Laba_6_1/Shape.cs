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
        protected double a, b;
        protected int alpha;
        protected bool bisheight;

        public Shape(double a)
        {
            this.a = a;
        }
        public Shape(double a, double b,bool bisheight=false,int alpha = 0)
        {
            this.a = a;
            this.b = b;
            this.alpha = alpha;
            this.bisheight = bisheight;

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
    public class Rhombus : Shape
    {
        

        public Rhombus(double a,double b, bool bisheight= false, int alpha=0):base(a,b, bisheight,alpha)
        {
           
        }
        public override double GetSquare()
        {
            if(alpha == 0 && bisheight)
            {
                return a * b;
            }
            else if(bisheight== false && alpha ==0)
            {
                return 0.5 * a * b;
            }
            else if(alpha !=0)
            {
                double rads = alpha * Math.PI / 180;
                Console.WriteLine("Hi");
                return a * a * Math.Sin(rads);
            }
            return 0;
        }

    }


}
