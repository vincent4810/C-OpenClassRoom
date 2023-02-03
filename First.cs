using System;
// using System.Object;
using System.Collections.Generic;

public class First{
    public static void Main(string[] args){

        // Créer un array multidimensssionel

        string[,] mesSieges = new string[30,12];

        mesSieges[9,5] = "Vincent MICHEL";

        foreach(string vip in mesSieges){
            Console.WriteLine(vip);
        }

        // List ordonnées

        IList<int> mesInt = new List<int>();
        // .Add() equivaut au .add() java
        mesInt.Add(7);
        mesInt.Add(8);
        mesInt.Add(2);
        // .Insert() equivaut au .set() java
        mesInt.Insert(1,9);

        //.RemoveAt() equivaut a .remove() en java removeAt pour liste ordonnée et on met l'index si liste non-ordonnées Remove et le nom du contenu

        mesInt.RemoveAt(0);

        foreach(int chiffre in mesInt){
            Console.WriteLine(chiffre);
        }
        // .Count equivaut .size() en java
        Console.WriteLine(mesInt.Count);

        //List non-ordonnées

        ISet<string> ingredients = new HashSet<string>();
        //.Add ajouter
        
        ingredients.Add("oeufs");
        ingredients.Add("sucre");
        ingredients.Add("beurre");
        ingredients.Add("sel");
        // .Remove("string ou int ou float ...");
        ingredients.Remove("beurre");
        foreach(string ingredient in ingredients){
            Console.WriteLine(ingredient);
        }

        //Dictionnaire(Array clef -> valeurs php)
        //  !!!!! clef sensible à la casse !!!!!! //
        IDictionary<string, int> friends = new Dictionary<string, int>();
        const string kJulie = "Julie";
        friends.Add("Ines", 29);
        friends.Add("Marion", 38);
        friends.Add("Vincent", 33);
        friends.Add("Claire", 29);
        friends.Add("Aurelien", 40);
        friends.Add(kJulie, 28);

        Console.WriteLine(friends["Claire"]);

        foreach(KeyValuePair<String, int> friend in friends){
            Console.WriteLine("{0} -> {1}", friend.Key, friend.Value);
        }


    }
}