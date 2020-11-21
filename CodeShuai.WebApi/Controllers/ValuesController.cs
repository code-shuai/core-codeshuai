using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeShuai.BLL;
using CodeShuai.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CodeShuai.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ValuesController : ControllerBase
    {

        Helper h = new Helper();

        #region User
        [HttpPost]
        public int AddUser([FromForm] User u)
        {
            u.CreateTime = DateTime.Now;
            return h.AddUser(u);
        }
        [HttpGet]
        public int UpdatePassword(int id, string pwd)
        {
            return h.UpdatePwd(new User { ID = id, Password = pwd });
        }
        [HttpGet]
        public List<User> GetUsers()
        {
            return h.GetUsers();
        }


        #endregion


        #region Bill
        [HttpPost]
        public string AddBill([FromForm]Bill b)
        {
            b.AddTime = DateTime.Now;
            b.State = 1;
            if (h.AddBill(b) == 1)
            {
                return "1001";
            }
            return "1002";
        }
        [HttpPost]
        public string DeleteBill([FromForm] Bill b)
        {
            if (h.DeleteBill(b) == 1)
            {
                return "1001";
            }
            return "1002";
        }
        [HttpPost]
        public string UpdateBill([FromForm] Bill b)
        {
            if (h.UpdateBill(b) == 1)
            {
                return "1001";
            }
            return "1002";
        }
        [HttpGet]
        public List<Bill> GetBills(int id)
        {
            return h.GetBills(id);
        }
        #endregion

    }
}
