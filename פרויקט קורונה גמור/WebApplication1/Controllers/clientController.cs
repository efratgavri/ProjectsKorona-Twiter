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
    public class clientController : ApiController
    {
        // GET: api/client
        public List<clientDTO>  Get()
        {
            return clientBLL.GetAllCustomers().ToList();
        }
        public List<List<dynamic>> GetCostumerwithcityname()
        {
            return clientBLL.GetCostumerwithcityname().ToList();
        }



        // GET: api/customers/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/client
        public bool Post([FromBody] clientDTO value)
        {
            return clientBLL.AddNewclient(value.id_client, value.first_name,value.last_name,value.id_city,value.address,value.birthday,value.phone,value.mobile_phone);
        }
       
        ////עדכון פרטי לקוח
        ////מייל
        //public bool Update_fmail(List<dynamic> value)
        //{

        //    var c = value[1];
        //    var id = (int)value[0];

        //    return clientBLL.insertcustmail(id, c);
        //}
        ////שם פרטי
        //public bool Update_fitstname(List<dynamic> value)
        //{

        //    var c = value[1];
        //    var id = (int)value[0];

        //    return clientBLL.insertcustname(id, c);
        //}
        ////שם משפחה

        //public bool Update_lastname(List<dynamic> value)
        //{

        //    var c = value[1];
        //    var id = (int)value[0];

        //    return clientBLL.insertcustlastname(id, c);
        //}
        ////טלפון
        //public bool Update_phone(List<dynamic> value)
        //{

        //    var c = value[1];
        //    var id = (int)value[0];

        //    return clientBLL.insertcustphone(id, c);
        //}
        ////כתובת
        //public bool Update_adress(List<dynamic> value)
        //{

        //    var c = value[1];
        //    var id = (int)value[0];

        //    return clientBLL.insertcustaddress(id, c);
        //}
        ////עיר
        //public bool Update_city(List<dynamic> value)
        //{
        //    var id = (int)value[0];
        //    var c = (int)value[1];
            

        //    return clientBLL.insertcustcity(id, c);
        //}


        //// PUT: api/customers/5
        //public bool Put(int id, [FromBody]string value)
        //{
        //    return clientBLL.insertcustmail(id, value);
        //}

        //// DELETE: api/customers/5
        //public void Delete(int id)
        //{
        //}
    }
}
