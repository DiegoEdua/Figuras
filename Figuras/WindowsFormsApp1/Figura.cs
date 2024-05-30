using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    abstract class Figura // Clase padre
    {  /*clase va permitir elingreso de uno lado, para poder crear
        *una nueva figura geometrica. Recuerda que una figura para existir
        *requiere minimo un lado, esta clase es tipo abstrac es un molde, ella
        *solo define elcomportamiento de una figura*/

        /*declaramos las variables que
         * se va a pasar a las clases hijas
         * nos serviran para guardar en cajas
         * de memoria el valor delprimer lado*/

        //la variable sera privada
        private float lado1;//permite decimales
        public float Lado1
        {
            /*METODO O MODIFICADOR
             * PARA PONER EL
             * VALOR (#) EN LA CAJA DE
             * MEMORIA*/
            set //poner valor
            {
                //pregunta se el valor <0
                if (value < 0)
                {
                    lado1 = 0; //manda el valor a 0
                } //NO EXISTE LADOS NEGATIVOS
                else
                {
                    lado1 = value;
                    //value esel valor del textbox
                }
            }
            get //obtener elvalor
            {
                return lado1; //regresa o cacha elvalor de la variable lado1
            }
        }
        // defino métodos, funciones, operaciones de la clase
        // padre quen tambien van a tener los hijos 
        // metodos de tipo publico para que todos los usen
        // metodos abstractos van vacios ya que cada hijo 
        // definira sus operaciones
        public abstract float area();
        public abstract float perimetro();
        public abstract float volumen();




    }
}
