using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    class Arbol_2
    {
        public void Tree()
        {
            Arbol abo = new Arbol(); //Se crea un objeto de la clase arbol
            //Se insertan datos en nuestro arbol
            abo.Insertar(45, 'C');
            abo.Insertar(4, 'D');
            abo.Insertar(3, 'F');
            abo.Insertar(5, 'G');
            abo.Insertar(55, 'A');
            abo.Insertar(65, 'B');
            abo.Insertar(75, 'E');
            //Impresion de los datos
            abo.ImpresionDeLasWeas(); 
        }
        public void Caminos() //Caminos que debieron salir...
        {
            Console.WriteLine("Camino a C: \nC");
            Console.WriteLine("Mas larga: \nC -> A -> B -> E");
        }
    }
}
