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
        public int Login(string account,string pwd)
        {
            List<User> list = DapperService<User>.QuerySqlString($"select * from user where Account='{account}'");
            if (list.Count==1)
            {
                if (list[0].Password==pwd)
                {
                    return 1;
                }
                return 0;
            }
            return -1;
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
            return DapperService<User>.ExcuteSqlString("update user set Password=@Password where ID=@ID",u);
        }
        #endregion


        #region Bill
        public int AddBill(Bill b)
        {
            return DapperService<Bill>.ExcuteSqlString("insert into bill (UserID,Money,Remark,Lable,AddTime,State) values(@UserID,@Money,@Remark,@Lable,@AddTime,@State)", b);
        }
        public int DeleteBill(Bill b)
        {
            return DapperService<Bill>.ExcuteSqlString("update bill set State=0 where ID=@ID", b);
        }
        public int UpdateBill(Bill b)
        {
            return DapperService<Bill>.ExcuteSqlString("update bill set  money=@Money, remark=@Remark,lable=@Lable  where ID=@ID", b);
        }
        public List<Bill> GetBills(int userID)
        {
            return DapperService<Bill>.QuerySqlString("select * from bill where userID="+userID);
        }
        #endregion
    }
}
