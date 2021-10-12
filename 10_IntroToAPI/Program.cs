using _10_IntroToAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _10_IntroToAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating an http client to query APIs
            HttpClient httpClient = new HttpClient();

            //creating a task
            Task<HttpResponseMessage> responseTask = httpClient.GetAsync("https://swapi.dev/api/people/1");

            //getting a response from the task
            HttpResponseMessage response = responseTask.Result;

            //these two lines above could be written 
            //var response = httpClient.GetAsync("https://swapi.dev/api/people/1").Result;

            //creating and getting the response
            HttpResponseMessage responseTwo = httpClient.GetAsync("https://swapi.dev/api/people/2").Result;

            if (response.IsSuccessStatusCode)
            {
                string stringResponse = response.Content.ReadAsStringAsync().Result;//gives the full json object
                //Console.WriteLine(stringResponse);

                Person person = response.Content.ReadAsAsync<Person>().Result;//serializes the data for us
                //can also use
                //var person = JsonConvert.DeserializeObject<Person>(stringResponse);

                Console.WriteLine("Name: " + person.Name);
                Console.WriteLine("Height: " + person.Height);
                Console.WriteLine("Hair Color: "+ person.HairColor);

                foreach (var vehicleUri in person.Vehicles)
                {
                    HttpResponseMessage vehicleResponse = httpClient.GetAsync(vehicleUri).Result;
                    Vehicle vehicle = vehicleResponse.Content.ReadAsAsync<Vehicle>().Result;
                    Console.WriteLine("Vehicle: "+ vehicle.Name);
                }
            }

            SWAPIService service = new SWAPIService();
            Person personTwo = service.GetPersonAsync("https://swapi.dev/api/people/5").Result;

            if(personTwo != null)
            {
                Console.WriteLine(personTwo.Name);

                foreach (var vehicleUri in personTwo.Vehicles)
                {
                    Vehicle vehicle = service.GetVehicleAsync(vehicleUri).Result;
                    Console.WriteLine(vehicle.Name);
                }
                foreach (var filmUri in personTwo.Films)
                {
                    Film film = service.GetAsync<Film>(filmUri).Result;
                    Console.WriteLine(film.Title);
                }
            }

            Person personThree = service.GetAsync<Person>("https://swapi.dev/api/people/12").Result;
            Console.WriteLine(personThree.Name);

            Console.WriteLine();

            SearchResult<Person> skywalkers = service.GetPersonSearchAsync("skywalker").Result;
            foreach (Person p in skywalkers.Results)
            {
                Console.WriteLine(p.Name);
            }

            //both lines below get the same info
            var genericSearch = service.GetSearchAsync<Vehicle>("speeder", "vehicles").Result;
            var vehicleSearch = service.GetVehicleSearchAsync("speeder").Result;
        }
    }
}
