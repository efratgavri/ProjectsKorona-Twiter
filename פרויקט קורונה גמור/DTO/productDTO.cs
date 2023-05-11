using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;





namespace Dto
{
    public class productDTO
    {

        public int id_product { get; set; }
        public string name_product { get; set; }

        public productDTO()
        {

        }
        public productDTO(int id_product, string name_product)
        {
            this.id_product = id_product;
            this.name_product = name_product;
        }

        //פונקצית המרת אוביקט שלנו לשל מיקרוסופט - משמש בהוספת אוביקט חדש למסד
        public static product toEmpTBL(productDTO em)
        {
            product newEmp = new product();
            newEmp.id_product = em.id_product;
            newEmp.name_product = em.name_product;


            return newEmp;
        }


        //פונקצית המרת אוביקט מיקרוסופט  לשלנו- משמש בשליפת אוביקט 
        public static productDTO toEmpDTO(product em)
        {
            productDTO newEmp = new productDTO();
            newEmp.id_product = (int)em.id_product;
            newEmp.name_product = em.name_product;


            return newEmp;
        }


        //המרת אוסף ממיקרוסופט לשלנו
        public static List<productDTO> toDTO_List(List<product> ee)
        {
            List<productDTO> eList = new List<productDTO>();
            try
            {
                foreach (var item in ee)
                {
                    eList.Add(toEmpDTO(item));
                }
                return eList;
            }
            catch (Exception e)
            {
                return null;
            }


        }
        //המרת אוסף  שלנו לשל מיקרוסופט
        public static List<product> toTBL_List(List<productDTO> ee)
        {
            List<product> eList = new List<product>();
            try
            {
                foreach (var item in ee)
                {
                    eList.Add(toEmpTBL(item));
                }
                return eList;
            }
            catch (Exception e)
            {
                return null;
            }

        }
    }
}
