using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeShuai.BLL;
using CodeShuai.Models;

namespace CodeShuai.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        Helper h = new Helper();

        [HttpGet]
        public int AddUser(string acc, string pwd)
        {
            return h.AddUser(new User { Account = acc, Password = pwd });
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




        #region Bill
        [HttpPost]
        public int AddBill(Bill b)
        {
            return h.AddBill(b);
        }
        [HttpPost]
        public int DeleteBill(Bill b)
        {
            return h.DeleteBill(b);
        }
        [HttpPost]
        public int UpdateBill(Bill b)
        {
            return h.UpdateBill(b);
        }
        [HttpGet]
        public List<Bill> GetBills(int userID)
        {
            return h.GetBills(userID);
        }
        #endregion

    }
}
