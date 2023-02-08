using System;

namespace Fonction
{
    
    public class Omelette{

        public static void Main(string[] args){

            faireUneOmelette();
            faireUneOmelette();
            faireUneOmelette();

            Omelette1();


        }

        public static void faireUneOmelette(){
            Console.WriteLine("Casser 2 oeufs dasn une poele");
            Console.WriteLine("Ajouter les légumes coupés");
            Console.WriteLine("Remuer de temps en temps pendant 2 min");
            Console.WriteLine(" ");
        }

        public static void Omelette1(){
            CasserOeuf();
            MelangerOeuf();
            CuireOeuf();
        }

        public static void CasserOeuf(){
            Console.WriteLine("Casser 4 oeufs par personne dans un cul de poule");
        }

        public static void MelangerOeuf(){
            Console.WriteLine("battre les oeufs en rythme");
        }

        public static void CuireOeuf(){
            Console.WriteLine("Verser dans les oeufs dans une poele bien chaude");
        } 


    }
}