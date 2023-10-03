using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using certest.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace certest.Controllers
{
    [Route("api/[controller]")]
    public class AddendasController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            using (var context = new CerAddendasContext())
            {
                List<Models.Addenda>result = context.Addendas.Take(50).ToList();
                return (IEnumerable<string>)result;
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
            var adenda = new Addenda
            {
                NombreAddenda = "Nombre",
                Xml = "",
                Usuario = "Prueba626"
            };
            var context = new CerAddendasContext();
            context.Add(adenda);
            context.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

