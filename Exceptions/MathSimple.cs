using System;
using System.Collections.Generic;

namespace Exceptions{

    public class MathSimple{

        public static int CalculateAverage(List<int> listeOfEntiers){
            int average = 0;

            foreach(int value in listeOfEntiers){

                average += value;
            }

            average /= listeOfEntiers.Count;

            return average;
        }
    }
}