using CodeTest.Models;
using CodeTest.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CodeTest.Controllers
{
    public class CodeTestApiController : ApiController
    {

        public IHttpActionResult GetUser(UserModel model)
        {
            using(var repo = new CodeTestRepository())
            {
                var res = repo.GetUser(model);

                return  Ok(res);
            }
        }


        public IHttpActionResult GetNotes(string  userId)
        {
            using (var repo = new CodeTestRepository())
            {
                var res = repo.GetNotes(userId);

                return Ok(res);
            }
        }

    }
}
