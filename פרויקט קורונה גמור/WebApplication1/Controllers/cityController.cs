using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BLL;
using Dto;

namespace WebApplication1.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class cityController : ApiController
    {
        // GET: api/city
        public List<cityDTO> Get()
        {


            return cityBLL.GetAllcities().ToList();
        }


        // GET: api/city/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/city
        public bool Post([FromBody] cityDTO value)
        {
            return cityBLL.AddNewcities(value.city_name);
        }

        // PUT: api/city/5
        public void Put(int id, [FromBody] string value)
        {

        }

        //// DELETE: api/city/5
        //[HttpDelete]
        //public bool Delete(int id)
        //{
           
        //}

    } 
}
