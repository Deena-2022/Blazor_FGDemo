
using FG.DataEntity;
using FG_CoreAPI.DataContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace FG_CoreAPI.Repositories
{
    public class UserRepository:GenericRepository<User>,IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {

        }
        
    }
}
