
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Threading.Tasks;
using BlazorUI.DataContext;
using BlazorUI.services;
using FG.DataEntity;
using Microsoft.AspNetCore.Components;

namespace BlazorUI.services
{
    public class SignUpServices : GenericRepository<User>, ISignUpServices
    {

        public SignUpServices(ApplicationDbContext context) : base(context)
        {

        }
    }
}
