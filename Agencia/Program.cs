using System;

namespace Agencia
{
    public class Agencia
    {
        public int cantAloj {  get;  set; } 

        public Agencia(int cantAlojamiento)
        {
           cantAloj = cantAlojamiento;
           
        }
         // ME ENCANTAN TODAS LAS IDEAS PERO NO SE COMO PINGO IMPLEMENTARLAS idem.
        public static void Main(string[] args) {
            Console.WriteLine("Escoja un alojamiento de la lista.");
            Console.WriteLine("\ta - Hotel Malaya");
            Console.WriteLine("\tb - Cabaña Rote");
            Console.WriteLine("\tc - Hotel Wingo");     
            Console.Write("¿Tu opcion?\t");

            lugarAlojamiento();
              switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Elegiste Hotel Malaya");
                    break;
                case "b":
                    Console.WriteLine($"Elegiste Cabaña Rote");
                    break;
                case "c":
                    Console.WriteLine($"Elegiste el Hotel Wingo");
                    break;              
            }
        }

        //test
        public void lugarAlojamiento(int lugar){
            int lugarAlojamiento = 7;
                if (lugarAlojamiento < 10){
                    Console.WriteLine("Tenes lugar loro");
            }
        }


    } 
}
