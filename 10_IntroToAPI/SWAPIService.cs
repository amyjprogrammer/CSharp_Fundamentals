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
            HttpResponseMessage response = await _httpClient.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                Person person = await response.Content.ReadAsAsync<Person>();
                return person;
            }
            //If not successful
            return null;
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
        }

        //Generics
        public async Task<T> GetAsync<T>(string uri)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                T obj = await response.Content.ReadAsAsync<T>();
                return obj;
            }
            return default;
        }
    }
}
