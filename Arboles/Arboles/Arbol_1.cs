using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    class Arbol_1
    {
        public void Tree()
        {
            Arbol abo = new Arbol(); //Se crea un objeto de la clase arbol
            //Se insertan datos en nuestro arbol
            abo.Insertar(10, 'E');
            abo.Insertar(4, 'A');
            abo.Insertar(3, 'B');
            abo.Insertar(2, 'C');
            abo.Insertar(5, 'D');
            abo.Insertar(20, 'F');
            //Impresion de los datos
            abo.ImpresionDeLasWeas();
        }
    }
}
