using System;
using System.IO;
namespace aplicaciónemiliii
{
    class Program
    {
        static void Main(string[] args)
        {
            char op = 's';
            string archivo;
            int OP;



            while (op == 's')
            {
                Console.WriteLine("Que desea hacer: \n1. Crear Archivo \n2. Salir");
                OP = int.Parse(Console.ReadLine());



                if (OP == 1)
                {
                    StreamWriter ar;




                    archivo = Console.ReadLine();
                    Console.WriteLine("Que nombre le gustaría poner: ");
                    ar = File.CreateText(Console.ReadLine() + ".txt");

                    ar.Close();




                }



                Console.ReadKey();
                if (OP == 2)
                {
                    Console.WriteLine("Usted a deseado Salir");

                }



                Console.Clear();
                Console.WriteLine("Desea Continuar ['s/n']");
                op = char.Parse(Console.ReadLine());





            }



            Console.ReadKey();
        }
    }
}
