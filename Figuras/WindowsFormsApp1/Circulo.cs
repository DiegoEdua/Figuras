using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Circulo : Figura //es una clase hija_Figura
    { //Usamos el constructor de la clase padre
        public Circulo(float radio) //radio se va a leer de la caja de texto con boton guardar
        {
            Lado1 = radio;
        }
        //Vamos a usar metodos de la clase padre y sobreescribir (override) el comportamiento deesta
        public override float area()
        /*Agregamos f al final de un número cuando es una constante no definida en una variable
         * previamente, asi el programa sabe que es un #*/
        {
            return 3.1416F * Lado1 * Lado1;
        }
        public override float perimetro()
        {
            return 3.1416F * 2 * Lado1;
        }
        public override float volumen()
        {
            throw new NotImplementedException(); 
        }
    }
}
