using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeShuai.Models;
using CodeShuai.MySql;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeShuai.MVC.Controllers
{
    [ApiController]
    public class ValuesController : ControllerBase
    {
        DapperService ds = new DapperService();
        [HttpGet]
        [Route("get")]
        public List<User> Get()
        {
            return ds.GetUserList();
        }
        [Route("getuserid")]
        [HttpGet]
        public int GetUserID()
        {
            return ds.GetUserList()[0].ID;
        }
    }
}
