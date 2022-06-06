using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using NPS_PROJECT_API.Data;
using NPS_PROJECT_API.Models;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;


namespace NPS_PROJECT_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RelacionalClienteController : ControllerBase
    {
        private readonly RelacionalClienteContext _context;

        public RelacionalClienteController(RelacionalClienteContext context)
        {
              _context = context;
        }



        [HttpGet]
        [Route("api/NPS_PROJECT_API/Get")]
        public IActionResult Get()
        {
            
            return Ok(_context.RelacionalClientes);
        }


        ////POST api/<PostRelCliente>
        //[HttpPost]
        //public IActionResult PostRelCliente((RelacionalCliente[] RelCli)
        //{

        //    return Ok(RelCli);
        //}




        ////POST api/<PostRelCliente>
        //[HttpPost]
        //public  JObject PostRelCliente([FromBody] JObject RelCli)
        //{

        //    JObject myJO = JObject.Parse(RelCli.ToString());

        //    return RelCli;
        //}







        //POST api/<PostRelCliente>
        [HttpPost]
        public IActionResult PostRelCliente(RelacionalCliente[] RelCli)
        {
            foreach (RelacionalCliente obj in RelCli)
            {
                _context.Add(obj);
                _context.SaveChanges();
            }


            return Ok(RelCli);
        }





    }
}
