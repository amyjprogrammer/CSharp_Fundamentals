using _10_IntroToAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _10_IntroToAPI
{
    class SWAPIService
    {
        //field
        private readonly HttpClient _httpClient = new HttpClient();

        public async Task<Person> GetPersonAsync(string uri)
        {
            /*HttpResponseMessage response = await _httpClient.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                Person person = await response.Content.ReadAsAsync<Person>();
                return person;
            }
            //If not successful
            return null;*/

            return await GetAsync<Person>(uri);//same as above, but calling the generic
        }

        public async Task<Vehicle> GetVehicleAsync(string uri)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                Vehicle vehicle = await response.Content.ReadAsAsync<Vehicle>();
                return vehicle;
            }
            //If not successful
            return null;

            //if statement and null could be written as a ternary
            //return response.IsSuccessStatusCode ? await response.Content.ReadAsAsync<Vehicle>() : null;
        }

        //Generics
        public async Task<T> GetAsync<T>(string uri)//could add a restraint of where T: class which would allow return null;
        {
            HttpResponseMessage response = await _httpClient.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                //another way to write the two lines below
                //return await response.Content.ReadAsAsync<T>();
                T obj = await response.Content.ReadAsAsync<T>();
                return obj;
            }
            return default;
        }

        public async Task<SearchResult<Person>> GetPersonSearchAsync(string query)
        {
            HttpResponseMessage response = await _httpClient.GetAsync("https://swapi.dev/api/people?search=" + query);

            if (response.IsSuccessStatusCode)
                return await response.Content.ReadAsAsync<SearchResult<Person>>();
            return null;
        }

        public async Task<SearchResult<T>> GetSearchAsync<T>(string query, string category)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"https://swapi.dev/api/{category}?search={query}");

            return response.IsSuccessStatusCode
                ? await response.Content.ReadAsAsync<SearchResult<T>>()
                : default;
        }

        public async Task<SearchResult<Vehicle>> GetVehicleSearchAsync(string query)
        {
            return await GetSearchAsync<Vehicle>(query, "vehicles");
        }
    }
}
