using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeShuai.BLL;
using CodeShuai.Models;
using CodeShuai.MySql;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeShuai.MVC.Controllers
{
    [ApiController]
    public class ValuesController : ControllerBase
    {
        Helper h = new Helper();
        
        [Route("adduser")]
        [HttpGet]
        public int AddUser(string acc,string pwd)
        {
            return h.AddUser(new User { Account = acc, Password = pwd });
        }
        [HttpGet]
        [Route("uPwd")]
        public int UpdatePassword(int id,string pwd)
        {
            return h.UpdatePwd(new User { ID = id, Password = pwd });
        }
    }
}
