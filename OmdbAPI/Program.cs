using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OmdbAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ievaiet filmas nossaukumu:");
            string nosaukums = Console.ReadLine();
          

            // http://www.omdbapi.com/?apikey=7ac2588c&s=batman

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.omdbapi.com");

                var response = client.GetAsync("http://www.omdbapi.com/?apikey=7ac2588c&s=" + nosaukums).Result;

                if (response.IsSuccessStatusCode)
                {
                    SearchResultData result = response.Content.ReadAsAsync<SearchResultData>().Result;

                    if (result.Response == "True")
                    {
                        Console.WriteLine("Atrastās filmas: ");
                        foreach (var movie in result.Search)
                        {
                            Console.WriteLine("{0} {1}.gads", movie.Title, movie.Year);

                        }
                    }

                    else
                    {
                        Console.WriteLine("eizdevās izsaukt Api");

                    }

                }
                else
                {
                    Console.WriteLine("Api nav pieejams");
                }
            }


            Console.Read();

        }
    }
}
