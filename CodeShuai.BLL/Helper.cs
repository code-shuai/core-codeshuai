using System;
using System.Collections.Generic;
using CodeShuai.Models;
using CodeShuai.MySql;
namespace CodeShuai.BLL
{
    public class Helper
    {
        #region User
        /// <summary>
        /// 获取所有用户信息
        /// </summary>
        /// <returns></returns>
        public List<User> GetUsers()
        {
            return DapperService<User>.QuerySqlString("select * from user");
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="account">账号</param>
        /// <param name="pwd">密码</param>
        /// <returns>1=正确 0=密码错误 -1=无此账号 </returns>
        public string Login(User u)
        {
            List<User> user = DapperService<User>.QuerySqlString($"select * from user where Account='{u.Account}'");
            if (user.Count != 0)
            {
                if (user[0].Password == u.Password)
                {
                    return "1001";
                }
                return "1002";
            }
            return "1003";
        }

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public int AddUser(User u)
        {
            return DapperService<User>.ExcuteSqlString("insert into user (Account,Password,CreateTime) values(@Account,@Password,@CreateTime)", u);
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public int UpdatePwd(User u)
        {
            return DapperService<User>.ExcuteSqlString("update user set Password=@Password where ID=@ID", u);
        }
        #endregion


        #region Bill
        public int AddBill(Bill b)
        {
            return DapperService<Bill>.ExcuteSqlString("insert into bill (UserID,Money,Remark,LabelCode,LabelName,AddTime,State) values(@UserID,@Money,@Remark,@LabelCode,@LabelName,@AddTime,@State)", b);
        }
        public int DeleteBill(Bill b)
        {
            return DapperService<Bill>.ExcuteSqlString("update bill set State=0 where ID=@ID", b);
        }
        public int UpdateBill(Bill b)
        {
            return DapperService<Bill>.ExcuteSqlString("update bill set  money=@Money, remark=@Remark,labelName=@LabelName,labelCode=@LabelCode  where ID=@ID", b);
        }
        public List<Bill> GetBills(int userID)
        {
            return DapperService<Bill>.QuerySqlString("SELECT * FROM bill WHERE UserID = " + userID + " and State=1  order by AddTime DESC");
        }

        public List<BillStatistics> GetBillStatistics(string userId, string aDate, string bDate)
        {
            return DapperService<BillStatistics>.QuerySqlString("select  LabelCode,LabelName,count(money) BillCount,SUM(Money) BillCountMoney from bill where AddTime between  '" + aDate + "'  and '" + bDate + "'  and userid='" + userId + "' GROUP BY LabelCode,LabelName");
        }
        public BillMoneyCountAndAmount GetBillMoneyCount(string userId, string aDate, string bDate)
        {
            return DapperService<BillMoneyCountAndAmount>.QuerySqlString("select  count(*) Amount,sum(money) MoneyCount from bill where AddTime between  '" + aDate + "'  and '" + bDate + "'  and userid='" + userId + "'")[0];
        }
        #endregion

        #region Label
        public List<Label> GetLabels()
        {
            return DapperService<Label>.QuerySqlString("SELECT * FROM label ");
        }
        #endregion
    }
}
