using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciación de la clase Operacion para realizar el metodo Carga el cual permite ingresar los valores por el usuario
            //y realizar una serie de multiplicaciones utilizando la sobrecarga de metodos.
            Operacion op = new Operacion();
            op.Cargar();


            Datos data = new Datos();       //Instanciación de la clase Datos para ejecutar el método Obtener Datos para mostrar el resultado del metodo Multiplicar 
            data.ObtenerDatos();




        }
    }
}
