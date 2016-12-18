using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SwaggerTest.Api.Mock;
using SwaggerTest.Api.ViewModels;

namespace SwaggerTest.Api.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        [Produces(typeof(List<ValueViewModel>))]
        public IActionResult Get()
        {
            return new OkObjectResult(ValueGenerator.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}", Name = "GetValue")]
        [Produces(typeof(ValueViewModel))]
        public IActionResult Get(int id)
        {
            return new OkObjectResult(ValueGenerator.GetById(id));
        }

        // POST api/values
        [HttpPost]
        [ProducesResponseType(typeof(ValueViewModel), 201)]
        public IActionResult Post([FromBody]ValueViewModel model)
        {
            ValueGenerator.Insert(model);
            CreatedAtRouteResult result = CreatedAtRoute("GetValue", new { controller = "Value", id = model.Id }, model);
            
            return result;
        }

        [Route("Test")]
        [HttpPost]
        [ProducesResponseType(typeof(ValueViewModel), 201)]
        public IActionResult Test([FromBody]ValueViewModel model)
        {
            ValueGenerator.Insert(model);
            
            CreatedAtRouteResult result = CreatedAtRoute("GetValue", new { controller = "Value", id = model.Id }, model);

            return result;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]ValueViewModel model)
        {
            ValueGenerator.Update(id,model);
            return new OkResult();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            ValueGenerator.Delete(id);
            return new OkResult();
        }
    }
}
