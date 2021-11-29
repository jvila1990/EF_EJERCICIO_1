using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_EJERCICIO_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lista de pedidos por orden de llegada");
            Console.WriteLine("");

            Queue<ClaseAlumno> cola1 = new Queue<ClaseAlumno>();
            // Agregar elementos

            ClaseAlumno alumno1 = new ClaseAlumno
            {
                prioridad = 1,
                id = 10010,
                pedido = "Ceviche",
                cliente = "Jonathan Vila",
                costo = 50
            };

            ClaseAlumno alumno2 = new ClaseAlumno
            {
                prioridad = 1,
                id = 10011,
                pedido = "Causa de atún",
                cliente = "Carlos Salazar",
                costo = 25
            };

            ClaseAlumno alumno3 = new ClaseAlumno
            {
                prioridad = 1,
                id = 10012,
                pedido = "Pollo a la brasa",
                cliente = "Fernando Vargas",
                costo = 70
            };

            ClaseAlumno alumno4 = new ClaseAlumno
            {
                prioridad = 1,
                id = 10013,
                pedido = "Jalea mixta",
                cliente = "Claudia Palacios",
                costo = 60
            };

            ClaseAlumno alumno5 = new ClaseAlumno
            {
                prioridad = 1,
                id = 10014,
                pedido = "Parrilla familiar",
                cliente = "Andres Diaz",
                costo = 200
            };

            cola1.Enqueue(alumno1);
            cola1.Enqueue(alumno2);
            cola1.Enqueue(alumno3);
            cola1.Enqueue(alumno4);
            cola1.Enqueue(alumno5);


            //Recorrer elementos 
            foreach (var ele in cola1)
            {
                Console.WriteLine("Prioridad: " + ele.prioridad);
                Console.WriteLine("Id: " + ele.id);
                Console.WriteLine("Pedido: " + ele.pedido);
                Console.WriteLine("Cliente: " + ele.cliente);
                Console.WriteLine("Costo: " + ele.costo);
                Console.WriteLine("");
            }
            Console.WriteLine("");


            ArbolBinario arbol = new ArbolBinario();
            arbol.InsertarNodo(1, 10010, "Ceviche", "Jonathan Vila", 50);
            arbol.InsertarNodo(1, 10011, "Causa de Atún", "Carlos Salazar", 25);
            arbol.InsertarNodo(1, 10012, "Pollo a la brasa", "Fernando Vargas",70);
            arbol.InsertarNodo(1, 10013, "Jalea Mixta", "Claudia Palacios", 60);
            arbol.InsertarNodo(1, 10014, "Parrilla familiar", "Andres Diaz", 200);

            //INORDEN - PREORDEN - POSTORDEN

    
            Console.WriteLine("Preorden:");
            arbol.Preorden(arbol.GetRaiz());
            Console.WriteLine("");


            Console.WriteLine("Inorden:");
            arbol.Inorden(arbol.GetRaiz());
            Console.WriteLine("");

      
            Console.WriteLine("Postorden:");
            arbol.Postorden(arbol.GetRaiz());
            Console.WriteLine("");


            //INSERTAMOS UN PEDIDO POR PRIORIDAD
            Console.WriteLine("------------> Ingresamos un pedido de prioridad \n");
            arbol.InsertarNodo(1, 10015, "Picarones", "Pedro Ramirez", 40);


            Console.WriteLine("--------------------------");
            Console.WriteLine("Preorden:");
            arbol.Preorden(arbol.GetRaiz());
            Console.WriteLine("");

            Console.WriteLine("--------------------------");
            Console.WriteLine("Inorden:");
            arbol.Inorden(arbol.GetRaiz());
            Console.WriteLine("");

            Console.WriteLine("--------------------------");
            Console.WriteLine("Postorden:");
            arbol.Postorden(arbol.GetRaiz());
            Console.WriteLine("");



            Console.Read();

        }
    }
}
