using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeShuai.BLL;
using CodeShuai.Models;
using CodeShuai.MySql;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace CodeShuai.MVC.Controllers
{
    //[ApiController]
    //[Route("[controller]/[action]")]
    public class ValuesController : Controller
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
        [HttpPost]
        public string Login(User u)
        {
            return h.Login(u);
        }


        #endregion


        #region Bill
        [HttpPost]
        public string AddBill(Bill b)
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
        public string DeleteBill(Bill b)
        {
            if (h.DeleteBill(b) == 1)
            {
                return "1001";
            }
            return "1002";
        }
        [HttpPost]
        public string UpdateBill(Bill b)
        {
            if (h.UpdateBill(b) == 1)
            {
                return "1001";
            }
            return "1002";
        }
        [HttpGet]
        public List<Bill> GetBills(int pageIndex, int pageSize, int id)
        {
            List<Bill> list = h.GetBills(id);
            if (list.Count < pageIndex * pageSize + pageSize)
            {
                return new List<Bill>();
            }
            else
            {
                return list.Skip(pageIndex * pageSize).ToList().Take(pageSize).ToList();
            }
        }



        [HttpGet]
        public List<Label> GetLabels()
        {
            return h.GetLabels();
        }
        #endregion
    }
}
