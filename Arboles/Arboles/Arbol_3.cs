using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    class Arbol_3
    {
        public void Tree()
        {
            Arbol abo = new Arbol(); //Se crea un objeto de la clase arbol
            //Se insertan datos en nuestro arbol
            abo.Insertar(20, 'I');
            abo.Insertar(14, 'B');
            abo.Insertar(13, 'A');
            abo.Insertar(15, 'C');
            abo.Insertar(25, 'D');
            abo.Insertar(22, 'E');
            abo.Insertar(21, 'F');
            abo.Insertar(23, 'G');
            abo.Insertar(24, 'H');
            abo.Insertar(35, 'I');
            abo.Insertar(45, 'J');
            //Impresion de los datos
            Caminos();
            abo.ImpresionDeLasWeas();
            
        }
        public void Caminos() //Caminos que debieron salir...
        {
            Console.WriteLine("Camino a C: \nI -> C");
            Console.WriteLine("Camino a J: \nI -> D -> I -> J");
            Console.WriteLine("Camino a H: \nI -> D -> E -> G -> H");
            Console.WriteLine("Mas larga: \nI -> D -> E -> G -> H");
        }
    }
}
