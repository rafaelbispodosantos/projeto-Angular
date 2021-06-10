using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProAgil.WebApi.Model;

namespace ProAgil.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Evento>> Get()
        {
            return new Evento[] { 
              new Evento() {
                EventId = 1,
                Tema = "Angular e .Net Core",
                Local =" São Paulo",
                Lote = "1º Lote",
                QtdPessoas = "250",
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
              },
              new Evento() {
                EventId = 2,
                Tema = "Angular e suas novidade",
                Local =" Rio de Janeiro",
                Lote = "2º",
                QtdPessoas = "250",
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy")
              },
             };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Evento> Get(int id)
        {
            return new Evento[] { 
              new Evento() {
                EventId = 1,
                Tema = "Angular e .Net Core",
                Local =" São Paulo",
                Lote = "1º Lote",
                QtdPessoas = "250",
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
              },
              new Evento() {
                EventId = 2,
                Tema = "Angular e suas novidade",
                Local =" Rio de Janeiro",
                Lote = "2º",
                QtdPessoas = "250",
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy")
              },
             }.FirstOrDefault(x => x.EventId ==id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
