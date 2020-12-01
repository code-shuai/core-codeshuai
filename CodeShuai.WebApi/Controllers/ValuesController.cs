using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeShuai.BLL;
using CodeShuai.Models;
using Newtonsoft.Json;

namespace CodeShuai.WebApi.Controllers
{
    [Route("[Controller]/[Action]")]
    public class ValuesController : Controller
    {

        PoetryHelper h = new PoetryHelper();
        [HttpPost]
        public int InsertAuthorList(Author author)
        {
            //JsonConvert.DeserializeObject<List<Author>>(JsonConvert.SerializeObject(json))
            int a = h.InsertAuthorList(author);
            return a;
        }
        public List<Author> Show()
        {
            return h.GetAuthors();
        }
    }
}
