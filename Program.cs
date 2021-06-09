using System;
using System.Collections;

namespace P7_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //"hola" -> "HOLA"
            string valor1 = "hola";
            string valor2= valor1.ToLower();

            Console.WriteLine("\"hola\" -> \"HOLA\"");

            Console.WriteLine("-----");

            valor1="John,Peter,Charlie";
            string[] valor2array = valor1.Split(",");

            Console.WriteLine(valor1);

            foreach(string value in valor2array)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("-----");

            valor1 = "Pizza";
            char[] charArray = valor1.ToCharArray();
            Array.Reverse(charArray);

            valor2= new string (charArray);
            Console.WriteLine (valor2);

            Console.WriteLine("-----");

            valor1 = "Tacos > Hamburguesa";
            valor2= valor1.Replace( ">", "&gt;");
            Console.WriteLine(valor1);
            Console.WriteLine(valor2);

            Console.WriteLine("-----");

            valor1 = "Pizza > Hamburguesa";
            valor2= valor1.Replace( ">", "&it;");
            Console.WriteLine(valor1);
            Console.WriteLine(valor2);

            Console.WriteLine("-----");

            valor1 = "Azul, verde, Morado";
            valor2array= valor1.Split(", ");
            foreach (string val in valor2array)
            {
                Console.WriteLine(val);
                Console.WriteLine("Morado");
            }

             Console.WriteLine("-----");

            valor1 = "ave, banco, comida, duda, ejercicio, fuente, girasol";
            string mayusculas= valor1.ToLower();
            char[] charArray1 = valor1.ToCharArray();
            Array.Reverse(charArray1);
            valor2array = valor1.Split(", ");

            valor2 = new string(charArray1);
            Console.WriteLine(valor1);
            Console.WriteLine(valor2);
            Console.WriteLine(valor2array);
            
            
           


             
             




            

            



        }
    }
}
