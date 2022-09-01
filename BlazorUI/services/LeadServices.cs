
using BlazorUI.DataContext;
using FG.DataEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorUI.services
{
    public class LeadServices
    {
        private readonly ApplicationDbContext context;

        public LeadServices(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Lead>> GetAll()
        {
            return await context.Lead.ToListAsync();
        }

        
    }

}
