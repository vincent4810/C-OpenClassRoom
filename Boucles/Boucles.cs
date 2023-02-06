using System;


namespace Boucles{

    public class Boucles{

        public static void Main(string[] args){

            For();
            
            ForCollection();
            
            Foreach();

            While();

            DoWhile();

            ForWithCondition();

            ForeachWithContidition();
        
        }
        // fonction for sans collection
        public static void For(){

            for(int i = 0; i < 8; i++){
                Console.WriteLine(i);
            }
        }

        // fonction for avec collection

        public static void ForCollection(){

            string[] myArray = new string[]{"azerty", "vincent", "Anastasia"};

            for(int i = 0; i < myArray.Length; i++){
                Console.WriteLine(myArray[i]);
            }
        }

        // Foreach 

        public static void Foreach(){
           
            string[] myArray = new string[]{"azerty", "vincent", "Anastasia"};

            foreach(string value in myArray){
                Console.WriteLine(value);
            }

        }

        // While

        public static void While(){
            int[] arrayInt = new int[]{
                87,
                89,
                25
            };
            int i = 0;
            while(i < arrayInt.Length){

                Console.WriteLine(arrayInt[i]);

                i++;
            }

            Console.WriteLine("Je sort de la condition du while, j'ai affiché tout le tableau arrayInt ! ");
        }

        // Do While

        public static void DoWhile(){
            int nbPompes = 0;

            do{
                nbPompes++;
                Console.WriteLine("Je viens de faire " + nbPompes + " pompes !");
            }while(nbPompes == 0);
        }

        // Boucle for avec conditions

        public static void ForWithCondition(){
            String[] panierDeFruits = new String[]{"pomme", "orange", "banane"};

            for(int i = 0; i < panierDeFruits.Length; i++){
                if(panierDeFruits[i] == "orange"){
                    Console.WriteLine("J'ai une " + panierDeFruits[i] + " !");
                }else{
                    Console.WriteLine("Je n'ai pas d'orange a ce moment la dans mon panier !");
                }
            }
        }

        // Boucle foreach avec conditions

        public static void ForeachWithContidition(){

            String[] panierDeFruits = new String[]{"pomme", "orange", "banane"};

            foreach(string value in panierDeFruits){

                if(value == "orange"){

                    Console.WriteLine("J'ai une orange !");

                }else{
                    Console.WriteLine("Je n'ai pas d'orange à ce moment la dans mon panier !");
                }
            }
        }

    }
}