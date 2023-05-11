using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;





namespace Dto
{
    public class vaccinationDTO
    {

        public int id_vaccination { get; set; }
        public string id_client { get; set; }
        public DateTime date_vaccination { get; set; }
        public int id_product { get; set; }

        public vaccinationDTO()
        {

        }
        public vaccinationDTO(string id_client, DateTime date_vaccination, int id_product)
        {
            this.id_client = id_client;
            this.date_vaccination = date_vaccination;
            this.id_product = id_product;
        }

        //פונקצית המרת אוביקט שלנו לשל מיקרוסופט - משמש בהוספת אוביקט חדש למסד
        public static vaccination toEmpTBL(vaccinationDTO em)
        {
            vaccination newEmp = new vaccination();
            newEmp.id_client = em.id_client;
            newEmp.date_vaccination = em.date_vaccination;
            newEmp.id_product = em.id_product;


            return newEmp;
        }


        //פונקצית המרת אוביקט מיקרוסופט  לשלנו- משמש בשליפת אוביקט 
        public static vaccinationDTO toEmpDTO(vaccination em)
        {
            vaccinationDTO newEmp = new vaccinationDTO();
            newEmp.id_client = em.id_client;
            newEmp.date_vaccination = (DateTime)em.date_vaccination;
            newEmp.id_product = (int)em.id_product;

            return newEmp;
        }


        //המרת אוסף ממיקרוסופט לשלנו
        public static List<vaccinationDTO> toDTO_List(List<vaccination> ee)
        {
            List<vaccinationDTO> eList = new List<vaccinationDTO>();
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
        public static List<vaccination> toTBL_List(List<vaccinationDTO> ee)
        {
            List<vaccination> eList = new List<vaccination>();
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
