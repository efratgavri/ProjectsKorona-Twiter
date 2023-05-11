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
    public class vaccinationController : ApiController
    {
        //GET: api/vaccination
        public List<List<dynamic>> Get()
        {
            return vaccinationBLL.Getvaccinationwithproductname().ToList();
        }
        [HttpGet]
        [Route("api/vaccination/Getvaccinationwithproductname_by_id_client/{id}")]
        public List<List<dynamic>> Getvaccinationwithproductname_by_id_client(string id)
        {

            return vaccinationBLL.Getvaccinationwithproductname_by_id_client(id).ToList();
        }

        // GET: api/vaccination/5
        public string Get(int id)
        {
            return "value";
        }
     
        // POST: api/vaccination
        public bool Post([FromBody] vaccinationDTO value)
        {
            return vaccinationBLL.AddNewvaccination(value.id_client,value.date_vaccination,value.id_product);
        }

        // PUT: api/vaccination/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/vaccination/5
        public void Delete(int id)
        {
        }
    }
}
