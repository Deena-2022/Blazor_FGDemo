using FG.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BlazorUI.services
{
    public interface ISignUpServices : IGenericRepository<User>
    {
    }
}
