using System;
using System.Collections.Generic;

namespace Exceptions{

    public class AverageTemperatures{

        public static void Main(String[] args){
            
            try{

                List<int> temperaturesRecorded = new List<int>();

                    foreach(string stringTemperatures in args){
                        int temperature = int.Parse(stringTemperatures);
                
                        temperaturesRecorded.Add(temperature);
                    }

                int AverageTemperatures = MathSimple.CalculateAverage(temperaturesRecorded);

                    Console.WriteLine("La température moyenne est " + AverageTemperatures);
        
            }catch(FormatException e){

                Console.WriteLine("Les températures fournies doivent être des nombres");
                Environment.Exit(-1);
            }catch(DivideByZeroException e){
                
                Console.WriteLine("Vous devez fournir au moins une température");
                Environment.Exit(-1);
            }
        }
    }
}