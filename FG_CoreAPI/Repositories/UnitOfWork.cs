
using FG_CoreAPI.DataContext;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FG_CoreAPI.Repositories
{ 
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext context;
        public ILeadRepository LeadRepository { get; }
        public IUserRepository UserRepository { get; }
        public IOpportunityRepository OpportunityRepository { get; }

        public UnitOfWork(ApplicationDbContext context,ILeadRepository leadRepository,
            IUserRepository userRepository,IOpportunityRepository opportunityRepository)
        {
            this.context = context;
            LeadRepository = leadRepository;
            UserRepository = userRepository;
            OpportunityRepository = opportunityRepository;
        }
        public ILeadRepository lead => new LeadRepository(context);

        public IUserRepository user =>  new UserRepository(context);

        public IOpportunityRepository Opportunity =>new OpportunityRepository(context);

        public Task Save()
        {
            return context.SaveChangesAsync();
        }
    }
}
