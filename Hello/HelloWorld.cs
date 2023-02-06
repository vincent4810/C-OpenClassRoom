using System;

namespace Hello{
    
    public class HelloWorld{
        
        public static void Main(String[] args){

            Console.WriteLine("Hello World !");

            Bonjour("Vincent");
        }

        public static void Bonjour(string destination){

            Console.WriteLine("Hello " + destination);
        }
    }
}