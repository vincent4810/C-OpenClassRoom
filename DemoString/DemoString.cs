using System;

namespace DemoString{

    public class DemoString{

        public static void Main(string[] args){

            string phraseChoc  = "Le type String de c# est en fait une classe, pas un type simple !";

            Console.WriteLine(phraseChoc.ToUpper());

            Console.WriteLine(phraseChoc.Replace("simple", "primitif"));
            
        }
    }
}