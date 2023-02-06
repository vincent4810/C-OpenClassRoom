using System;

namespace switchWithEnum{

    public class MyDirection{
        enum Direction{
            nord,
            est,
            sud,
            ouest
        }

        public static void Main(string[] args){
            Direction direction = Direction.nord;
            
            switch(direction){
                case Direction.nord:
                    Console.WriteLine("Vous allez au Nord");
                    break;
                case Direction.est:
                    Console.WriteLine("Vous allez au Est");
                    break;
                case Direction.sud:
                    Console.WriteLine("Vous allez au Sud");
                    break;
                case Direction.ouest:
                    Console.WriteLine("Vous allez à l'Ouest");
                    break;
            }
        }


    }
}