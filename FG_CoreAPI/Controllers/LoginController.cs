using FG.DataEntity;
using FG_CoreAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FG_CoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public LoginController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        [HttpPost]
        public string Post([FromBody] Login user)
        {
            var result= unitOfWork.user.FindByCondition(x => x.Email == user.Email && x.Password == user.Password).FirstOrDefault();
            if (result == null)
            {
                return "Login Failed.....!";
            }
            return "Login Successfully....!";
        }
    }
}
