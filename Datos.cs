using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga
{
    class Datos
    {
        public void ObtenerDatos()      //Este método es parecido a Cargar solo que este instancia el objeto de la clase Operacion
            //para recibir sus metodos y poder realizar lo mismo.
        {
            Operacion op = new Operacion();
            Console.WriteLine("Bienvenido al método ObtenerDatos()");

            Console.WriteLine("Ingrese 3 datos");
            Console.WriteLine("Dato 1");
            double cool = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Dato 2");
            double cool2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Dato 3");
            double cool3 = Convert.ToDouble(Console.ReadLine());
            double res = op.Multiplicar(cool, cool2, cool3);

            Console.WriteLine("El resultado es = " + res);


            Console.ReadKey();

        }



    }
}
