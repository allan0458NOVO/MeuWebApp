using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NPS_PROJECT_API.Data;
using NPS_PROJECT_API.Models;

namespace NPS_PROJECT_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PesquisaGeralController : ControllerBase
    {
        private readonly PesquisaGeralContext _contextPG;

        public PesquisaGeralController(PesquisaGeralContext context)
        {
            _contextPG = context;
        }

        public EnumPesquisaGeral MyProperty { get; set; }

        public enum EnumPesquisaGeral
        {
            chave,
            valor
        }

        ////POST api/<PostRelCliente>
        //[HttpPost]
        //public IActionResult PostPesqGeral([FromBody] EnumPesquisaGeral[] PesqGer)
        //{
        //    foreach(var item in PesqGer)
        //    {
        //        string a = item.chave;

        //    }
        //    return Ok(PesqGer);
        //}


        //POST api/<PostRelCliente>
        [HttpPost]
        public IActionResult PostPesqGeral([FromBody] PesquisaGeral[] PesqGer)
        {
            foreach (PesquisaGeral obj in PesqGer)
            {
                _contextPG.Add(obj);
                _contextPG.SaveChanges();
            }

            //_context.Add(RelCli);
            //_context.SaveChanges();
            return Ok(PesqGer);
        }



    }
}
