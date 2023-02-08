using System;

namespace Methode
{
    public class TestMethode{

        public static void Main(string[] args){
            Voiture.Increment();
            Voiture voitureRouge = new Voiture();
            Voiture.Increment();
            Console.WriteLine(voitureRouge.Compteur);

            Voiture voitureVerte = new Voiture();
            Voiture.Increment();
            voitureVerte.couleur = "Verte";
            // Voiture voitureRouge = new Voiture();
            // Voiture voitureRouge = new Voiture();
            // Voiture voitureRouge = new Voiture();
            Console.WriteLine(voitureVerte.couleur);
            Console.WriteLine(voitureRouge.Compteur);
            Console.WriteLine(voitureRouge.couleur);
            // Console.WriteLine(voitureRouge.compteur);
            // Console.WriteLine(Voiture.Increment());
        }

        class Voiture{
            public string couleur = "Rouge";
            private static int compteur = 0;
            public int Compteur => compteur;

            // public Voiture(string couleur1, int compteur1){
            //     couleur = couleur1;
            //     compteur = compteur1;
            // }
            public static void Increment(){

                Voiture.compteur += 1;
            }
        }
    }
}