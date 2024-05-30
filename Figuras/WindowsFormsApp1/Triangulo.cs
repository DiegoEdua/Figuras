using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Triangulo : Figura
    {
        public Triangulo (float H)
        {
            Lado1 = H;
        }

        private float LB;
        public float LaB
        {
            set
            {
                if (value < 0) { LB = 0; } else { LB = value; }
            }
            get 
            {
                return LB; 
            }
        }
        public override float area()
        {
            return Lado1 * LB / 2;
        }

        public override float perimetro()
        {
            return LB + LB + LB;
        }
        public override float volumen()
        {
            throw new NotImplementedException();
        }
    }
}
