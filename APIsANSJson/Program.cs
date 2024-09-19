using System;
using Newtonsoft.Json.Linq;


namespace APIsAndJSON;

class Program
{
    


    static void Main(string[] args)
    {
        var client = new HttpClient();
        
        
         // Build and api url from where the api call come from
            var kanyeUrl = "https://api.kanye.rest/";
            var ronUrl = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var kanyeUrl2 = "https://api.kanye.rest/";
            var ronUrl2 = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var kanyeUrl3 = "https://api.kanye.rest/";
            var ronUrl3 = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var kanyeUrl4 = "https://api.kanye.rest/";
            var ronUrl4 = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var kanyeUrl5 = "https://api.kanye.rest/";
            var ronUrl5 = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            
            
            // Using the HttClient instance
            // Sending a GET request to url created above, this is going to give us back a string of json
            var kanyeResponseJson = client.GetStringAsync(kanyeUrl).Result;
            var ronResponseJson = client.GetStringAsync(ronUrl).Result;
            var kanyeResponseJson2 = client.GetStringAsync(kanyeUrl2).Result;
            var ronResponseJson2 = client.GetStringAsync(ronUrl2).Result;
            var kanyeResponseJson3 = client.GetStringAsync(kanyeUrl3).Result;
            var ronResponseJson3 = client.GetStringAsync(ronUrl3).Result;
            var kanyeResponseJson4 = client.GetStringAsync(kanyeUrl4).Result;
            var ronResponseJson4 = client.GetStringAsync(ronUrl4).Result;
            var kanyeResponseJson5 = client.GetStringAsync(kanyeUrl).Result;
            var ronResponseJson5 = client.GetStringAsync(ronUrl).Result;

            //Parse the json response we just got back into a JObject, we do this so we can access certain parts of the json
           //In this case we will be getting the value of "quote" which will give me th actual quote itself and not the whole body of json
            var kanyeQuote = JObject.Parse(kanyeResponseJson).GetValue("quote").ToString();
            Console.WriteLine("kanye:");
            Console.WriteLine(kanyeQuote);
            Console.WriteLine();

            var ronQuote = JArray.Parse(ronResponseJson);
            Console.WriteLine("Ron:");
            Console.WriteLine(ronQuote);
            Console.WriteLine();

            var kanyeQuote2 = JObject.Parse(kanyeResponseJson2).GetValue("quote").ToString();
            Console.WriteLine("Kanye:");
            Console.WriteLine(kanyeQuote2);
            Console.WriteLine();

            var ronQuote2 = JArray.Parse(ronResponseJson2);
            Console.WriteLine("Ron:");
            Console.WriteLine(ronQuote2);
            Console.WriteLine();

            var kanyeQuota3 = JObject.Parse(kanyeResponseJson3).GetValue("quote").ToString();
            Console.WriteLine("Kanye:");
            Console.WriteLine(kanyeQuota3);
            Console.WriteLine();
            
            var ronQuote3 = JArray.Parse(ronResponseJson3);
            Console.WriteLine("Ron:");
            Console.WriteLine(ronQuote3);
            Console.WriteLine();

            var kanyeQuote4 = JObject.Parse(kanyeResponseJson4).GetValue("quote").ToString();
            Console.WriteLine("Kanye:");
            Console.WriteLine(kanyeQuote4);
            Console.WriteLine();

            var ronQuote4 = JArray.Parse(ronResponseJson4);
            Console.WriteLine("Ron:");
            Console.WriteLine(ronQuote4);
            Console.WriteLine();

            var kanyeQuote5 = JObject.Parse(kanyeResponseJson5).GetValue("quote").ToString();
            Console.WriteLine("Kanye:");
            Console.WriteLine(kanyeQuote5);
            Console.WriteLine();

            var ronQuote5 = JArray.Parse(ronResponseJson5);
            Console.WriteLine("Ron:");
            Console.WriteLine(ronQuote5);
            Console.WriteLine();
            
    }
}
    
    
    
    


