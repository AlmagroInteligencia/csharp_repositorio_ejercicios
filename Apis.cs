using System;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace ejercicios
{
    internal class Apis
    {
        static public void Pepito()
        {
            Get("https://jsonplaceholder.typicode.com/posts/1");

            Post("https://jsonplaceholder.typicode.com/posts");

            Put("https://jsonplaceholder.typicode.com/posts/1");

            Patch("https://jsonplaceholder.typicode.com/posts/2");

            Get("https://jsonplaceholder.rickroll.typicode.com/posts/1");

        }

        static void Get(string url)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    //string url = "https://jsonplaceholder.typicode.com/posts/1";

                    client.DefaultRequestHeaders.Clear();
                    //client.DefaultRequestHeaders.Add("Accept", "application/json");
                    //client.DefaultRequestHeaders.Add("Authorization", "DHJKHASDBHGKJ874382JAKDSHK");

                    var response = client.GetAsync(url).Result;

                    var res = response.Content.ReadAsStringAsync().Result;

                    dynamic json = JObject.Parse(res);

                    Console.WriteLine(json);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Uy mirá, ocurrió un ERROR: {ex.Message}");
                } 
            }
        }

        static void Post(string url)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Clear();
                    string parametros = "{'title': 'hitman', 'body': 'agent', 'userId': '47'}";
                    dynamic jsonString = JObject.Parse($"{parametros}");

                    var httpContent = new StringContent(jsonString.ToString(), Encoding.UTF8, "application/json");
                    var response = client.PostAsync(url, httpContent).Result;
                    var res = response.Content.ReadAsStringAsync().Result;
                    dynamic json = JObject.Parse(res);
                    Console.WriteLine(json);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Uy mirá, ocurrió un ERROR: {ex.Message}");
                }  
            }
        }

        static void Put(string url)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Clear();
                    string parametros = "{'title': 'max', 'body': 'payne', 'userId': '1'}";
                    dynamic jsonString = JObject.Parse($"{parametros}");

                    var httpContent = new StringContent(jsonString.ToString(), Encoding.UTF8, "application/json");
                    var response = client.PutAsync(url, httpContent).Result;
                    var res = response.Content.ReadAsStringAsync().Result;
                    dynamic json = JObject.Parse(res);
                    Console.WriteLine(json);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Uy mirá, ocurrió un ERROR: {ex.Message}");
                }   
            }
        }

        static void Patch(string url)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Clear();
                    string parametros = "{'title': 'eradan', 'body': 'dunedain'}";
                    dynamic jsonString = JObject.Parse($"{parametros}");

                    var httpContent = new StringContent(jsonString.ToString(), Encoding.UTF8, "application/json");
                    var response = client.PatchAsync(url, httpContent).Result;
                    var res = response.Content.ReadAsStringAsync().Result;
                    dynamic json = JObject.Parse(res);
                    Console.WriteLine(json);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Uy mirá, ocurrió un ERROR: {ex.Message}");
                }
            }
        }
    }
}
