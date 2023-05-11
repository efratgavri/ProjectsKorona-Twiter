using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;





namespace Dto
{
    public class koronaDTO
    {
        public string id_korona { get; set; }
        public string id_client { get; set; }
        public DateTime date_sick { get; set; }
        public DateTime date_vecovery { get; set; }

        public koronaDTO()
        {

        }
        public koronaDTO(string id_client, DateTime date_sick, DateTime date_vecovery)
        {
            this.id_client = id_client;
            this.date_sick = date_sick;
            this.date_vecovery = date_vecovery;
        }

        //פונקצית המרת אוביקט שלנו לשל מיקרוסופט - משמש בהוספת אוביקט חדש למסד
        public static korona toEmpTBL(koronaDTO em)
        {
            korona newEmp = new korona();
            newEmp.id_client = em.id_client;
            newEmp.date_sick = em.date_sick;
            newEmp.date_vecovery = em.date_vecovery
                ;


            return newEmp;
        }


        //פונקצית המרת אוביקט מיקרוסופט  לשלנו- משמש בשליפת אוביקט 
        public static koronaDTO toEmpDTO(korona em)
        {
            koronaDTO newEmp = new koronaDTO();
            newEmp.id_client = em.id_client;
            newEmp.date_sick = (DateTime)em.date_sick;
            newEmp.date_vecovery = (DateTime)em.date_vecovery;


            return newEmp;
        }


        //המרת אוסף ממיקרוסופט לשלנו
        public static List<koronaDTO> toDTO_List(List<korona> ee)
        {
            List<koronaDTO> eList = new List<koronaDTO>();
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
        public static List<korona> toTBL_List(List<koronaDTO> ee)
        {
            List<korona> eList = new List<korona>();
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
