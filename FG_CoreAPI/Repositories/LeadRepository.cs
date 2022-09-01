
using FG.DataEntity;
using FG_CoreAPI.DataContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace FG_CoreAPI.Repositories
{ 
    public class LeadRepository:GenericRepository<Lead>, ILeadRepository
    {
        public LeadRepository(ApplicationDbContext context):base(context)
        {

        }
    }
}
