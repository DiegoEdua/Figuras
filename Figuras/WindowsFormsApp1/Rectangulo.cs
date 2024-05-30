using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Rectangulo : Figura
    {
        public Rectangulo(float LaA) //esta parte esta herrada asi que solo se copia y cambnia unoque otro nombre
        {
            Lado1 = LaA;
        }

        private float LB;
         public float LaB
         {
            set //colocar valor
            {
                //if pregunta si el lado es menor a 0 regresa a un valor a cero y no existen los lados negativos
                // Si no existen lados negativos else vuelve el valor del textobox
                if (value < 0) { LB = 0; } else { LB = value; }
            }
            get //Obtener el valor
            {
                return LB; //regresa el valor de la variable lado1
            }
         }


        public Rectangulo(float LaA, float LaB)
        //Lado A y B se va a leer de la caja de texto usando el voton guardar
        {
            this.Lado1 = LaA; //Hace que unicamente el valor y la cantidad del lado sea disponible para esta clase
            this.LB = LaB;
        }
        public override float area()
        {
            return Lado1 * LaB;
        }
        public override float perimetro()
        {
            return (2 * Lado1) + (2 * LaB);
        }
        public override float volumen()
        {
            throw new NotImplementedException();
            //Extencion por default
        }
    }
}
