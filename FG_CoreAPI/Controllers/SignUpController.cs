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
    public class SignUpController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public SignUpController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        [HttpPost]
        public JsonResult Post([FromBody] User user)
        {
            string msg = "email already exist";
            var validEmail = unitOfWork.user.FindByCondition(x => x.Email == user.Email).FirstOrDefault();
            if (validEmail!=null)
            {
                return Ok(msg);
            }
            else
            {
                unitOfWork.user.Add(user);
                unitOfWork.Save();
                return "User Created Successfully";
            }
        }
    }
}
