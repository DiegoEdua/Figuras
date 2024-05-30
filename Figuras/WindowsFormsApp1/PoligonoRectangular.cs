using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class PoligonoRectangular : Figura
    { 
        //Declara 2 valoes ploat para guardar número de lados y el apotema
        // privados para usarse solo en esta clase
        private float apo, n;

        public float Apo //validar apotema existente o real
        {
            set
            {
                //pregunta si el apotema (es el # del centro del poligono) <0
                if (value <=0)
                {
                    apo = 0; //manda el valor a 0
                }//NO EXISTE apotemas NEGATIVOS
                else
                {
                    apo = value;
                    //value es el valor el textbox
                }
            }
            get // obtener el valor
            {
                return apo; //regresa o cacha el valor de la variable lado1
            }
        }
        public float N //validar el número de lados >5
        {
            set
            {
                //preguntar se el # de lados (n) <5
                if (value < 5)
                {
                    n = 5; //manda el valor a 0
                } //NO EXISTE apotemas NEGATIPOS
                else
                {
                    n = value;
                    //value es el valor del textbox
                }
            }
            get //obtener el valor
            {
                return n; //regresar o cacha el valor de la variablelado1
            }
        }
        //usamos el constructor de la clase poligono regular
        public PoligonoRectangular (float lado, float apo, float n)
        {//radio se va a leer de la caja de texto con
            Lado1 = lado;
            Apo = apo;
            N = n;
        }
        //vamos a usar los metodos de la clase padre
        //vamos a sobreescribir el comportamiento de estos
        public float area(float peri)//metodo sobrecargado que recibe el perimetro y la utiliza
        {
            float peri;
            peri = n * Lado1;
            return peri;
        }
        public override float volumen()
        {
            throw new NotImplementedException();
            //esto es una exepcion de uso default del sistema
        }
        public override float area()//calculo de area papá
        {
            throw new NotImplementedException();
            //ESTO ES UNA EXEPCION DE USO DEFAULT DEL SISTEMA
        }
    }
}
