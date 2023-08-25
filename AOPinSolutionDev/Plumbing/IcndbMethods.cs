#region Namespace Imports


using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;


#endregion Namespace Imports


namespace AOPinSolutionDev.Plumbing
{


    /// <summary>
    /// This utility class contains the methods that are responsible for
    /// interacting with the Internet Chuck Norris Database.
    /// </summary>
    public static class IcndbMethods
    {


        public static String FetchChuckNorrisJoke()
        {
            // URL for the Internet Chuck Norris Database to get a nerdy joke
            const String icndbUrl = "https://api.chucknorris.io/jokes/random?category=dev";
            String theJoke;

            // Make the HTTP call, process the JSON response, and extract the joke
            // so that it can be shown in the output "window."
            var requestJoke = WebRequest.Create(icndbUrl);
            var response = (HttpWebResponse)requestJoke.GetResponse();
            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                var jsonResponse = sr.ReadToEnd();
                theJoke = (JObject.Parse(jsonResponse))["value"].ToString();
            }

            return theJoke;
        }


    }
}
