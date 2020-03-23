using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.Api.Data;
using DatingApp.Api.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public DataContext _Context ;
        public ValuesController(DataContext context)
        {
            _Context = context;

        }


        // GET api/values
        [HttpGet]
        //public IActionResult Getvalues()
        public async Task<IActionResult> Getvalues()
        {
            //var values=_Context.Values.ToList();
             var values=await _Context.Values.ToListAsync();
            return Ok(values);
           
        }

        // GET api/values/5
        [HttpGet("{id}")]
        // public IActionResult Get(int id)
         public async Task<IActionResult> GGetvalues(int id)
        {
            var values=await _Context.Values.FirstOrDefaultAsync(x=>x.Id==id);
            return Ok(values);
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