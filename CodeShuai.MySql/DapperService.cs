using CodeShuai.Models;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CodeShuai.MySql
{
    public class DapperService
    {
        public static MySqlConnection MySqlConnection()
        {
            string mysqlConnectionStr = "Database=codeshuai;Data Source=codeshuai.mysql.rds.aliyuncs.com;User Id=code_shuai;Password=Dabao3597;CharSet=utf8;port=3306";
            var connection = new MySqlConnection(mysqlConnectionStr);
            connection.Open();
            return connection;
        }
        public List<User> GetUserList()
        {
            using (IDbConnection conn = MySqlConnection())
            {
                string sqlCommandStr = @"SELECT * FROM USER";
                List<User> userList = conn.Query<User>(sqlCommandStr).ToList();
                return userList;
            }
        }

    }
}
