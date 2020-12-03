using CodeShuai.Models;
using CodeShuai.MySql;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeShuai.BLL
{
    public class PoetryHelper
    {
        public int InsertAuthorList(Author author)
        {
            List<Author> a = DapperService<Author>.QuerySqlString("select * from author where LongID='" + author.LongID + "'");

            //user(Account, Password, CreateTime) values(@Account, @Password, @CreateTime)
            if (a.Count != 0)
            {
                return 0;
            }
            else
            {
                return DapperService<Author>.ExcuteSqlString("INSERT INTO `codeshuai`.`author` (`LongID`,`Desc`,`Name`) VALUES ('" + author.LongID + "','" + author.Desc + "','" + author.Name + "');");

            }
        }
        public List<Author> GetAuthors()
        {
            return DapperService<Author>.QuerySqlString("select * from author");
        }

        public int InsertPoetryParagraph(PoetryParagraph poetryParagraph)
        {
            return DapperService<PoetryParagraph>.ExcuteSqlString("insert into poetryparagraph (TaskID,Number,Paragraph) values(@TaskID,@Number,@Paragraph)", poetryParagraph);
        }
    }
}
