using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Dto;

namespace BLL
{
    public class productBLL
    {
        //החזרת כל הערים
        public static List<productDTO> GetAllproducs()
        {
            return productDTO.toDTO_List(productDAL.getAll());
        }



        // הוספת רשומה לטבלת ערים
        public static bool AddNewproduct(string name_product)
        {
            productDTO NewaddNewproduct = new productDTO();
            NewaddNewproduct.name_product = name_product;

            return productDAL.AddNew(productDTO.toEmpTBL(NewaddNewproduct));
        }
        //המרת קוד יצרן לשם יצרן
        public static string getproductname(int id_product)
        {
            return productDAL.getproductname(id_product);
        }
    }
}
