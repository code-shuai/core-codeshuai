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
        [HttpGet]
        [Route("get")]
        public List<User> GetUsers()
        {
            return h.GetUsers();
        }




        #region Bill
        [HttpPost]
        [Route("addBill")]
        public int AddBill(Bill b)
        {
            return h.AddBill(b);
        }
        [HttpPost]
        [Route("deleteBill")]
        public int DeleteBill(Bill b)
        {
            return h.DeleteBill(b);
        }
        [HttpPost]
        [Route("updateBill")]
        public int UpdateBill(Bill b)
        {
            return h.UpdateBill(b);
        }
        [HttpGet]
        [Route("getBills")]
        public List<Bill> GetBills(int userID)
        {
            return h.GetBills(userID);
        }
        #endregion
    }
}
