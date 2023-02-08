using System;

namespace Methode{

    public class CarreMethode{

        public static void Main(string[] args){

            Carre carre = new Carre(10,4);
            // Console.WriteLine(carre.longueur);
            Console.WriteLine(carre.Longueur);
            Console.WriteLine(carre.Largeur);
            carre.Longueur = 16;
            carre.Largeur = 25;
            Console.WriteLine(carre.Longueur);
            Console.WriteLine(carre.Largeur);
        }
    }

    public class Carre{
        private int longueur;
        private int largeur;

        public Carre(int longueur, int largeur){

            this.longueur = longueur;
            this.largeur = largeur;

        }

        public int Longueur{

            get{
                return this.longueur;
            }set{
                this.longueur = value;
            }
        }

        public int Largeur{

            get{
                return this.largeur;
            }set{
                this.largeur = value;
            }
        }
    }
}