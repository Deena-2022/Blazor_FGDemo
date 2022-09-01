using BlazorUI.DataContext;
using FG.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorUI.services
{
    public class LeadRepository:GenericRepository<Lead>,ILeadServices
    {
        public LeadRepository(ApplicationDbContext context):base(context)
        {

        }
    }
}
