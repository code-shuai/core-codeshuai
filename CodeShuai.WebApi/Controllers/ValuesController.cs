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
    public class ValuesController : Controller
    {

        Helper h = new Helper();
        [HttpPost]
        public int AddPoetry(string json)
        {

        }
    }
}
