using CodeShuai.BLL;
using CodeShuai.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
//using System.Web.Http;
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
        public string GetBills(int pageIndex, int pageSize, int id)
        {
            pageIndex--;

            List<Bill> list = h.GetBills(id);
            decimal pageA = Convert.ToDecimal(Convert.ToDecimal(list.Count) / Convert.ToDecimal(pageSize));
            int pages = Convert.ToInt32(Math.Ceiling(pageA));
            if (pages == pageIndex)
            {
                return "{'data':'null','pages':0}";
            }
            else
            {
                string jsonList = JsonConvert.SerializeObject(list.Skip(pageIndex * pageSize).ToList().Take(pageSize).ToList());
                return "{\"data\":" + jsonList + ",\"pages\":" + pages + "}";
            }
            //return Ok()
        }
        [HttpGet]
        public string GetBillStatistics(string id, string aDate, string bDate)
        {
            List<BillStatistics> billStatistics = h.GetBillStatistics(id, aDate, bDate).OrderByDescending(b => b.BillCountMoney).ToList();
            BillMoneyCountAndAmount billMoneyCountAndAmount = h.GetBillMoneyCount(id, aDate, bDate);
            //1. 总预算 - 剩余
            //2.  统计 - 时间段 - 排行
            return "{\"data\":" + JsonConvert.SerializeObject(billStatistics) + ",\"count\":" + JsonConvert.SerializeObject(billMoneyCountAndAmount) + "}";
        }



        [HttpGet]
        public List<Label> GetLabels()
        {
            return h.GetLabels();
        }
        #endregion
    }
}
