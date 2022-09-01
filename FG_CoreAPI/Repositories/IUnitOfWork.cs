
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FG_CoreAPI.Repositories
{
    public interface IUnitOfWork
    {
        ILeadRepository lead { get; }
        IUserRepository user { get; }
        IOpportunityRepository Opportunity { get; }
        Task Save();
    }
}
