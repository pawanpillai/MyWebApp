using System.Collections.Generic;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace MyWebApp.API
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        //private readonly IConfiguration configuration;


        //public ValuesController(IConfiguration config)
        //{
        //    configuration = config;
        //}

        //// GET api/values
        //[HttpGet]
        //public JsonResult GetAllData()
        //{
        //    //ValuesDataHandler objValuesDataHander = new ValuesDataHandler(configuration);
        //    //return Json(objValuesDataHander.GetValues());
        //}

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public string GetDataById(int id)
        //{
        //    return "value";
        //}

        //[HttpPost]
        //public JsonResult PostData([FromBody] MyModel objModel)
        //{
        //    if (objModel.FirstName == "Pawan")
        //    {
        //        return Json("{'status':'matched'}");
        //        //return Json("matched");
        //    }
        //    else
        //    {
        //        return Json("{'status':'not-matched'}");
        //        //return Json("not-matched");
        //    }
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }

    [Route("admin/[controller]")]
    public class MyClsController : Controller
    {

    }
}
