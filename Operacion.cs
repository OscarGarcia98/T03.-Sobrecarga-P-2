using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga
{
    class Operacion
    {

        //Métodos que utilizan la sobrecarga para realizar una multipliación
        public double Multiplicar(double num1, double num2, double num3)        //En este método se debe ingresar 3 parametros a la hora de invocarlo
        {
            return num1 * num2 * num3;
        }

        public double Multiplicar(double num1)      //Solo se debe ingresar 1 parametro y se multiplica por una constante
        {
            return num1 * 150;
        }

        public double Multiplicar()     //Mismo método solo que multiplica 2 constantes sin parametros
        {
            return 1200 * 1500;
        }


        public void Cargar()        //En este método se le pide los valores al usuario para poder realizar las multiplicaciones
        {
            double num1, num2, num3;        //Variables que sirven para guardar los datos
            

            Console.WriteLine("Ingrese un valor");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese un valor");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese un valor");
            num3 = Convert.ToDouble(Console.ReadLine());

            //el valor retornado por los métodos se guardarán en estas variables para poder mostrar los resultados posteriormente
           var res1 = Multiplicar(num1, num2, num3);
           var  res2 = Multiplicar(num1);
            var res3 = Multiplicar();


            //Muestro el resultado de las multiplicaciones y termina el método
            Console.WriteLine("El resultado de ({0} * {1} * {2}) es: {3}\n" +
                 "El resultado de ({0} * 150 ) es: {4}\n" +
                 "El resultado de (1200 * 1500) es: {5}\n", num1, num2, num3, res1, res2, res3);

           
            
        }
        
        
            



        
        
    }
}
