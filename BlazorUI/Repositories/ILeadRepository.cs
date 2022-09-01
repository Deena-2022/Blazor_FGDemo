using FG.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorUI.Repositories
{
    public interface ILeadRepository
    {
        Task<IEnumerable<Lead>> GetAll();
        Task<Lead> GetbyId(int id);
        Task<Lead> Update(Lead lead);
        Task Delete(int id);
    }
}
