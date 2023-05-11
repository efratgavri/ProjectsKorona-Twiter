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
    public class koronaController : ApiController
    {
        // GET: api/korona
        public List<koronaDTO> Get()
        {
            return koronaBLL.GetAllkorona().ToList();
        }

        // GET: api/korona/5
        public string Get(int id)
        {
            return "value";
        }
       

        // השאלה על פי קוד פריט
        [HttpGet]
        [Route("api/korona/Getidclient/{id}")]
        public koronaDTO Getidclient(string id)
        {
            return koronaBLL.Getidclient(id);
        }
        // POST: api/korona
        public bool Post([FromBody] koronaDTO value)
        {
            return koronaBLL.AddNewkorona(value.id_client,value.date_sick,value.date_vecovery);
        }
        public bool Update_date_vecvery(List<dynamic> value)
        {

            var c = DateTime.Parse(value[1]);
            var id = value[0];

            return koronaBLL.Update_date_vecvery(id, c);
        }
        // PUT: api/korona/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/korona/5
        public void Delete(int id)
        {
        }
    }
}
