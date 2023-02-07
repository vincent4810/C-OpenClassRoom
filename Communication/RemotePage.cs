using System;
using System.Net;
using System.Reflection.Metadata;
using System.IO;

namespace Communication{

    public class RemotePage{

        public static void Main(string[] args){

            // string string2Url = UserData.RequestUrl();

            Console.WriteLine(RetrieveContent(RecupererDonne.RequestUrl()));
        }

        public static string RetrieveContent(string url){

            string content = "";

            try{

                using(WebClient webClient = new WebClient()){
                    
                    content = webClient.DownloadString(url);
                }
            }catch(WebException e){

                Console.WriteLine("Impossible d'établir une connexion " + e.ToString());
            }
                return content;
        }
    }
}