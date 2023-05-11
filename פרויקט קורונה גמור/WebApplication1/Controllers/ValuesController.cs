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
    public class ValuesController : ApiController
    {
        // GET api/values
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/values/5
        public List<clientDTO> GetAll()
        {
            return clientBLL.GetAllCustomers().ToList();
        }

        //// POST api/values
        //public bool Post([FromBody] CustomersDTO value)
        //{
        //    return CustomersBLL.AddNewcustomer(value);
        //}


        //public dynamic dynamicPost([FromBody] List<dynamic> value)
        //{
        //    CustomersDTO stu = value[0].ToObject<CustomersDTO>();
        //    var name = (int)value[0];
        //    var res = CustomersBLL.AddNewcustomer(stu);
        //    if (res == true)
        //    {
        //        return "נוסף בהצלחה";
        //    }
        //    return null;
        //}

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
