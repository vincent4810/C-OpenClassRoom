using System;

namespace ParamValueOfReturn{
    
    public class Param{

        public static int sumLittleNumber = Sum(5, 8);
        public static int SumBigNumber = Sum(sumLittleNumber, 1150);

        public static void Main(string[] args){

            DisplayPerimeter();

            DisplayPerimeterWithParam(25, 25);

            Console.WriteLine(sumLittleNumber);

            Console.WriteLine(SumBigNumber);

            Voiture voiture = new Voiture();
            Console.WriteLine(voiture.couleur);
            Peindre(voiture, "verte");
            Console.WriteLine(voiture.couleur);
            Voiture voiture2 = new Voiture();
            Console.WriteLine(voiture2.couleur);

            
        }

        public static void DisplayPerimeter(){

            int perimeter = 2 * (6 + 4);

            Console.WriteLine(perimeter);
        }        
        
        
        public static void DisplayPerimeterWithParam(int length, int width){

            int perimeter = 2 * (length + width);

            Console.WriteLine(perimeter);
        }

        public static int Sum(int a, int b){

            int calc = a + b;

            return calc;
        }


        public class Voiture{
            
            public string couleur = "rouge";
        }

        public static void Peindre(Voiture voiture, string couleur){
            voiture.couleur = couleur;
        }

    }
}