using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01Aula04
{
    class EqSegundoGrau
    {
        private string a;
        private string b;
        private string c;

        //a
        public void setA(string _a) { a = _a; }
        public String getA() { return a; }

        //b
        public void setB(string _b) { b = _b; }
        public String getB() { return b; }

        //c
        public void setC(string _c) { c = _c; }
        public String getC() { return c; }

        
        public string calcDelta()
        {
            float _a = float.Parse(a);
            float _b = float.Parse(b);
            float _c = float.Parse(c);

            return ((_b * _b) - 4 * _a * _c).ToString();
        }

        public string calcX1()
        {
            float _a = float.Parse(a);
            float _b = float.Parse(b);
            float _d = float.Parse(calcDelta());

            return ((-_b + Math.Sqrt(_d))/(2 * _a)).ToString();
        }

        public string calcX2()
        {
            float _a = float.Parse(a);
            float _b = float.Parse(b);
            float _d = float.Parse(calcDelta());

            return ((-_b - Math.Sqrt(_d)) / (2 * _a)).ToString();
        }
         

      
        
    }
}
