
using FG.DataEntity;
using FG_CoreAPI.DataContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace FG_CoreAPI.Repositories
{
    public class OpportunityRepository:GenericRepository<Opportunity>,IOpportunityRepository
    {
        public OpportunityRepository(ApplicationDbContext context):base(context)
        {

        }
    }
}
