using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_EJERCICIO_1
{
    class ArbolBinario
    {
        public Nodo raiz;

        public Nodo GetRaiz()
        {
            return raiz;
        }

        public void Inorden(Nodo raiz)
        {
            if (raiz != null)
            {
                Inorden(raiz.izquierdo);
                Console.WriteLine("{0},  {1} ,{2},  {3} ,{4}", raiz.valor, raiz.valor2, raiz.valor3, raiz.valor4, raiz.valor5);
                Inorden(raiz.derecho);
            }
        }

        public void Preorden(Nodo raiz)
        {
            if (raiz != null)
            {
                Console.WriteLine("{0},  {1} ,{2},  {3} ,{4}", raiz.valor, raiz.valor2, raiz.valor3, raiz.valor4, raiz.valor5);
                Preorden(raiz.izquierdo);
                Preorden(raiz.derecho);
            }
        }

        public void Postorden(Nodo raiz)
        {
            if (raiz != null)
            {
                Postorden(raiz.izquierdo);
                Postorden(raiz.derecho);
                Console.WriteLine("{0},  {1} ,{2},  {3} ,{4}", raiz.valor, raiz.valor2, raiz.valor3, raiz.valor4, raiz.valor5);
            }
        }

        public void InsertarNodo(int valor, int valor2, string valor3, string valor4, int valor5)
        {
            Nodo puntero;
            Nodo padre;
            Nodo nodo = new Nodo
            {
                valor = valor,
                valor2 = valor2,
                valor3 = valor3,
                valor4 = valor4,
                valor5 = valor5,
            };
            if (raiz != null)
            {
                puntero = raiz;
                while (true)
                {
                    padre = puntero;
                    if (valor < puntero.valor)
                    {
                        puntero = puntero.izquierdo;
                        if (puntero == null)
                        {
                            padre.izquierdo = nodo;
                            break;
                        }
                    }
                    else
                    {
                        puntero = puntero.derecho;
                        if (puntero == null)
                        {
                            padre.derecho = nodo;
                            break;
                        }
                    }
                }
            }
            else
            {
                raiz = nodo;
            }
        }


    }
}
