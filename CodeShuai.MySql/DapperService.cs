using CodeShuai.Models;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CodeShuai.MySql
{
    public class DapperService<T> where T : class, new()
    {
        /// <summary>
        /// 连接MySql 数据库
        /// </summary>
        /// <returns></returns>
        public static MySqlConnection MySqlConnection()
        {
            string mysqlConnectionStr = "Database=codeshuai;Data Source=codeshuai.mysql.rds.aliyuncs.com;User Id=code_shuai;Password=Dabao3597;CharSet=utf8;port=3306";
            var connection = new MySqlConnection(mysqlConnectionStr);
            connection.Open();
            return connection;
        }

        /// <summary>
        /// 查询
        /// select * from Person where id=@ID
        /// </summary>
        /// <typeparam name="T">模型</typeparam>
        /// <param name="sql">Sql 语句</param>
        /// <returns></returns>
        public static List<T> QuerySqlString(string sql)
        {
            using (IDbConnection conn = MySqlConnection())
            {
                return conn.Query<T>(sql).ToList();
            }
        }
        public static T QuerySqlString(string sql, T t)
        {
            using (IDbConnection conn = MySqlConnection())
            {
                return conn.Query<T>(sql, t).SingleOrDefault();
            }
        }


        /// <summary>
        /// 增删改
        /// </summary>
        /// <param name="sql">Sql 语句</param>
        /// <returns></returns>
        public static int ExcuteSqlString(string sql,T t)
        {
            using (IDbConnection conn = MySqlConnection())
            {
                return conn.Execute(sql,t);
            }
        }
        public static int ExcuteSqlString(string sql, List<T> t)
        {
            using (IDbConnection conn = MySqlConnection())
            {
                return conn.Execute(sql, t);
            }
        }




        //public static int Insert(Person person)
        //{
        //    using (IDbConnection connection = new SqlConnection(connectionString))
        //    {
        //        return connection.Execute("insert into Person(Name,Remark) values(@Name,@Remark)", person);
        //    }
        //}

    }
}
