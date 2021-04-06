using System;
using System.Collections.Generic;
using System.Text;

namespace Agencia
{
    class Alojamiento
    {
         int codigo; { get; set; }
         String ciudad;
         String barrio;
         String estrellas;
         int cantPersonas;
         bool tv;
        
        public Alojamiento (int code, String city , String barr , String stars , int cantP, bool teve)
        {
            codigo = code;
            ciudad = city;
            barrio = barr;
            estrellas = stars;
            cantPersonas = cantP;
            tv = teve;
        }

        public int cantPersonas   
        {
            get { return cantPersonas; }   
            set { cantPersonas = value; } 
        }
    }
 }



