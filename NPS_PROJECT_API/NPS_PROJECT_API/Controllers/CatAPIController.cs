using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NPS_PROJECT_API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NPS_PROJECT_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatAPIController : ControllerBase
    {

        List<CatAPI> cats = new List<CatAPI>();

        // GET: api/<CatAPIController>
        [HttpGet]
        public IActionResult GetCat([FromBody] IEnumerable<string> cats) 
        {
            return Ok(cats);
            //return new string[] { "Carlito", "Cacia" , "Allan", "Sandro"};
        }



        //POST api/<CatAPIController>
        [HttpPost]
        public IActionResult PostCat(CatAPI[] cat)
        {
            return Ok(cat);
        }



        //// POST api/<CatAPIController>
        //[HttpPost]
        //public IActionResult PostCat(CatAPI[] cat)
        //{
        //   return Ok(cat);
        //}


        //public IActionResult PostCat([FromBody] IEnumerable<string> cat)
        //{
        //    //foreach (var kvp in cats)
        //    //{
        //    //    string a = kvp.Key;
        //    //    string b = kvp.Value;
        //    //}
        //    return Ok(cat);

        //}

    }
}
