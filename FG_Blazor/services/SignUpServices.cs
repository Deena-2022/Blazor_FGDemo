
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace FG_Blazor.services
{
    public class SignUpServices : ISignUpServices
    {
        private readonly HttpClient httpClient;

        public SignUpServices(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public Task Add(User entity)
        {
            return  httpClient.PostJsonAsync<User[]>("api/SignUp",entity);
        }
    }
}
