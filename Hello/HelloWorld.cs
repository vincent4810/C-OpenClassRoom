using System;

namespace Hello{
    
    public class HelloWorld{
        
        public static void Main(String[] args){

            Console.WriteLine("Hello World !");

            Bonjour("Vincent");

            if(args.Length == 1){
                Bonjour(args[0]);
            }else{
                Bonjour("World");
            }

            string meteo = "Il faît beau";

            if(meteo.StartsWith("Il fait")){
                Console.WriteLine("vraie");
            }else{
                Console.WriteLine("faux");
            }
        }

        public static void Bonjour(string destination){

            Console.WriteLine("Hello " + destination +" !");
        }
    }
}