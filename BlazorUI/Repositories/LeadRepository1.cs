using FG.DataEntity;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;


namespace BlazorUI.Repositories
{
    public class LeadRepository1 : ILeadRepository
    {
        private readonly HttpClient httpClient;

        public LeadRepository1(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task Delete(int id)
        {
             await httpClient.DeleteAsync($"api/LeadsRepo/{id}");

        }

        public async Task<IEnumerable<Lead>> GetAll()
        {
            return await httpClient.GetJsonAsync<Lead[]>("api/LeadsRepo");
        }

        public async Task<Lead> GetbyId(int id)
        {
            return await httpClient.GetJsonAsync<Lead>($"api/LeadsRepo/{id}");

        }

        public async Task<Lead> Update(Lead lead)
        {
            /* await httpClient.PutJsonAsync<Lead>($"api/LeadsRepo", lead);
*/

            lead= await httpClient.PutJsonAsync<Lead>($"api/LeadsRepo", lead);
            return JsonConvert.DeserializeObject<Lead>(lead.ToString());
        }
    }
}
