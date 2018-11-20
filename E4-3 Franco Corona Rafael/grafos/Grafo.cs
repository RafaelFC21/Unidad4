using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grafos
{
    
    class Grafo
    {
        public void Desplegar()//Se crea metodo Desplegar
        {
            Console.WriteLine("Caminos posibles: " +
                "\n1.- A, B, C, D, E, F, G" +
                "\n2.- A, B, G, F, E, D, C" +
                "\n3.- A, B, C, G, F, D, E" +
                "\n4.- A, B, G, C, D, F, E" +
                "\n5.- C, D, E, F, G, B, A" +
                "\n6.- D, E, F, G, C, B, A" +
                "\n7.- F, E, D, C, G, B, A" +
                "\n8.- G, F, E, D, C, B, A" +
                "\n9.- E, F, D, C, G, B, A" +
                "\n10.- E, D, F, G, C, B, A");//Se Despliegan todas las rutas escritas manualmente...
            Console.ReadKey();
        }
        
    }
}
