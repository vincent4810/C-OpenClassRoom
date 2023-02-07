using System;

namespace Methode{

    public class MethodeInstance{

        public static void Main(string[] args){

            MathMagic magicMath = new MathMagic();
            Console.WriteLine("a = " + magicMath.a + ", b = " + magicMath.b);
            // magicMath.ModifyValue();
            Console.WriteLine("a = " + magicMath.a + ", b = " + magicMath.b);

        }

        public class MathMagic{
            public int a;
            public int b;

            public MathMagic(){
                this.ModifyValue();
            }

            public void ModifyValue(){

                this.a = 1;
                this.b = 5;
            }
        }
    }
}