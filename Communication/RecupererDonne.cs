using System;

namespace Communication{

    public static class RecupererDonne{

        public static void Main(string[] args){

            string stringUrl = "";

            int nbArguments;

            if(args == null){
                nbArguments = 0;
            }else{
                nbArguments = args.Length;
            }

            switch(nbArguments){
                case 0:
                    stringUrl = RequestUrl();
                    break;
                case 1:
                    stringUrl = args[0];
                    break;
                default:
                    Console.WriteLine("Veuillez exécuter le programme en spécifiant une url ou aucun argument");
                    Environment.Exit(-1);
                    break;
            }

            Console.WriteLine("Vérification de l'Url : " + stringUrl);

            if(URLValide(stringUrl)){

                Console.WriteLine(stringUrl + " est une URL Valide");
            }else{

                Console.WriteLine(stringUrl + " n'est pas une URL valide");
            }
        }

        public static string RequestUrl(){
            
            Console.WriteLine("Veuillez saisir une URL valide");

            string url = Console.ReadLine();

            return url;
        }

        public static bool URLValide(string stringUrl){

            if(Uri.IsWellFormedUriString(stringUrl, UriKind.Absolute)){

                return true;
            }else{

                return false;
            }
        }
    }
}