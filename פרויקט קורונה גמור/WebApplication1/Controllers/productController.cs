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
    public class productController : ApiController
    {
        // GET: api/product
        public List<productDTO> Get()
        {
            return productBLL.GetAllproducs().ToList();
        }

        //public List<List<dynamic>> GetProductwithKategoryname()
        //{
        //    return productBLL.GetProductwithKategoryname().ToList();
        //}

        ////מוצרים על פי קטגוריה
        //public List<ProductDTO> Getofcategory(int id)
        //{
        //    return ProductBLL.GetcategorProduct(id).ToList();
        //}

        //
        ////מוצרים על פי קטגוריה
        //[HttpGet]
        //[Route("api/product/Getofcategory/{id}")]

        //public List<ProductDTO> Getofcategory(int id)
        //{
        //    return ProductBLL.GetcategorProduct(id);
        //}

        ////מוצרים על פי קוד מוצר
        //[HttpGet]
        //[Route("api/product/GetProductbyid/{id}")]
        //public ProductDTO GetProductbyid(int id)
        //{

        //    return ProductBLL.GetProductbyid(id);
        //}
        //// GET: api/product/5
        //public string Get(int id)
        //{
        //    return "value";
        //}



        ////POST: api/product
        ////public bool Post([FromBody] List<dynamic> value)
        ////{
        ////    ProductDTO p = value[1].ToObject<ProductDTO>();
        ////    var prod = ()value[0];
        ////    return ProductBLL.AddNewproduct(value.nameproduct, value.costproduct, value.idkategory, value.discribproduct, value.buycost);

        ////}
        ////הוספת מוצר
        public bool Post([FromBody] productDTO value)
        {

            return productBLL.AddNewproduct(value.name_product);

        }
        ////עדכון פרטי מוצר
        ////מחיר

        //public bool Update_cost(List<dynamic> value)
        //{

        //    var id = (int)value[0];
        //    var cost = decimal.Parse(value[1]);
        //    cost = (float)cost;
        //    return ProductBLL.insertbuycostprod(id, cost);


        //}

        ////public bool Update_cost(List<dynamic> value)
        ////{

        ////    var c = value[1];
        ////    var id = (int)value[0];

        ////    return ProductBLL.insertcostprod(id, c);
        ////}
        ////תאור
        //public bool Update_Discribe_product(List<dynamic> value)
        //{

        //    var id = (int)value[0];
        //    var describe = (string)value[1];
        //    return ProductBLL.insertdiscribeprod(id, describe);

        //}
        //public bool Update_discribe(List<dynamic> value)
        //{

        //    var c = value[1];
        //    var id = (int)value[0];

        //    return ProductBLL.insertdiscribeprod(id, c);
        //}
        ////מחיר עלות
        //public bool Update_buycost(List<dynamic> value)
        //{

        //    var id = (int)value[0];
        //    var cost = decimal.Parse(value[1]);
        //    cost = (float)cost;

        //    return ProductBLL.insertbuycostprod(id, cost);
        //}

        //// PUT: api/product/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/product/5
        //[HttpDelete]
        //public bool Delete(int id)
        //{
        //    return ProductBLL.deleatproduct(id);
        //}
    }
}
