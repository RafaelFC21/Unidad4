using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc=0;
            Console.WriteLine("¿A que arbol desea acceder?: " +
                "\n1.- a" +
                "\n2.- b" +
                "\n3.- c" +
                "\nElija una opción: ");
            opc = Convert.ToInt16(Console.ReadLine());
            switch(opc)
            {
                case 1:
                    Arbol_1 arbol_1 = new Arbol_1();
                    arbol_1.Tree();
                    break;
                case 2:
                    Arbol_2 arbol_2 = new Arbol_2();
                    arbol_2.Tree();
                    break;
                case 3:
                    Arbol_3 arbol_3 = new Arbol_3();
                    arbol_3.Tree();
                    break;
                default:
                    Console.WriteLine("Opción incorrecta...");
                    break;
            }
            Console.WriteLine("\nPreciona una tecla para salir del programa.");
            Console.ReadKey();
        }
    }
}
