using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    class Arbol
    {
        public int altura; //Variable que guardara el valor de la altura del arbol
        class Nodo //Clase nodo
        {
            public int info; //Guarda el valor que toma el nodo
            public Nodo izq, der; //Dos punteros
            public char letra;
        }
        Nodo raiz; //Se crea un objeto raiz;

        class Dato //Clase dato
        {
            public string lugar; //Almacena el camino al dato ingresado
            public int posicionaltura; //Almacena el nivel de cada dato
        }
        List<Dato> weita = new List<Dato>(); //Lista que guarda objetos de la clase Dato

        public Arbol() //Constructor de la clase Arbol
        {
            raiz = null;
        }

        public void Insertar(int info, char letra) //Metodo el cual inserta los datos en el arbol como un indice para insertar la letra
        {
            string concatenador = ""; //Nos permite guardar la ruta de cada nodo
            int contador = 1; //Contador
            Dato dato = new Dato(); //Se crea un nuevo nodo el cual va a guardar el dato ingresado
            Nodo nuevo;
            nuevo = new Nodo();
            nuevo.info = info;
            nuevo.letra = letra;
            nuevo.izq = null;
            nuevo.der = null;
            if (raiz == null) //Significa que es el primer dato y lo almacena directamente
            {
                raiz = nuevo;
                concatenador = Convert.ToString(raiz.info);
            }
            else //Significa que ya existe almenos un dato en el arbol
            {
                Nodo anterior = null, recorrido;
                recorrido = raiz;
                while (recorrido != null) //Nos permite localizar el ultimo nodo donde se va almacenar el dato ingresado
                {
                    anterior = recorrido;
                    if (info < recorrido.info)
                    {
                        concatenador = Convert.ToString(recorrido.letra) + "<-"; ;//Guarda la direccion
                        recorrido = recorrido.izq;
                    }
                    else
                    {
                        concatenador = Convert.ToString(recorrido.letra) + "<-";//Guarda la direccion
                        recorrido = recorrido.der;
                    }
                    contador++;
                }
                //Se ingresa el dato dependiendo si es menor o mayor al ultimo dato
                if (info < anterior.info)
                    anterior.izq = nuevo;
                else
                    anterior.der = nuevo;
                dato.posicionaltura = contador; //Se guarda el nivel que se encuentra el dato
                concatenador = concatenador + Convert.ToString(letra); //Se guarda la direccion
                dato.lugar = concatenador; //Se guarda la direccion
                weita.Add(dato); //Se guarda el objeto dato, en la lista weita
            }
        }

        public void ImpresionDeLasWeas() //Metodo recursivo que imprime los datos restantes
        {
            int Cont = 1;
            int conteo = weita.Count;
            foreach (Dato Item in weita) //Permite encontrar la altura del arbol
            {
                if (Cont == 1)
                {
                    altura = Cont - Item.posicionaltura;
                }
                else
                {
                    if (Item.posicionaltura > altura)
                    {
                        altura = Cont - Item.posicionaltura;
                    }
                }
                Cont++;
            }
            //Impresion de los datos
            Console.WriteLine("\nLa raiz es: {0}", raiz.letra);
            Console.WriteLine("Nodo izquierdo: {0}", raiz.izq.letra);
            Console.WriteLine("Nodo derecho: {0}", raiz.der.letra);
            Console.WriteLine("La altura es: {0}", altura);
            Console.WriteLine("La cantidad de niveles es: {0}", (altura - 1));
            Console.WriteLine("Camino(s) al(los) ultimo(s) elemento(s):");
            Cont = 1;
            foreach (Dato item in weita) //Busca la(s) direccion(es) de el(los) ultimo(s) dato(s) y la(los) imprime
            {
                if (item.posicionaltura == altura)
                {
                    Console.Write(raiz.letra + "<-" + item.lugar + "\n");
                }
            }
        }
    }
}
