using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;



namespace Dto
{
    public class cityDTO
    {
        public int id_city { get; set; }
        public string city_name { get; set; }

        public cityDTO()
        {

        }
        public cityDTO(string city_name)
        {
            this.city_name = city_name;
        }

        //פונקצית המרת אוביקט שלנו לשל מיקרוסופט - משמש בהוספת אוביקט חדש למסד
        public static city toEmpTBL(cityDTO em)
        {
            city newEmp = new city();
            newEmp.id_city = em.id_city;
            newEmp.city_name = em.city_name;


            return newEmp;
        }


        //פונקצית המרת אוביקט מיקרוסופט  לשלנו- משמש בשליפת אוביקט 
        public static cityDTO toEmpDTO(city em)
        {
            cityDTO newEmp = new cityDTO();
            newEmp.id_city = (int)em.id_city;
            newEmp.city_name = em.city_name;


            return newEmp;
        }


        //המרת אוסף ממיקרוסופט לשלנו
        public static List<cityDTO> toDTO_List(List<city> ee)
        {
            List<cityDTO> eList = new List<cityDTO>();
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
        public static List<city> toTBL_List(List<cityDTO> ee)
        {
            List<city> eList = new List<city>();
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
