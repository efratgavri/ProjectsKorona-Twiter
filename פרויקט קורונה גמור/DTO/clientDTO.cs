using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;




namespace Dto
{
    public class clientDTO
    {
        public string id_client { get; set; }

        public string first_name { get; set; }
        public string last_name { get; set; }
        public int id_city { get; set; }
        public string address { get; set; }
        public DateTime birthday { get; set; }
        public string phone { get; set; }

        public string mobile_phone { get; set; }

        public clientDTO()
        {

        }
        public clientDTO(string id_client, string first_name, string last_name, int id_city, string address, DateTime birthday, string phone, string mobile_phone)
        {
            this.id_client = id_client;
            this.first_name = first_name;
            this.last_name = last_name;
            this.id_city = id_city;
            this.address = address;
            this.birthday = birthday;
            this.phone = phone;
            this.mobile_phone = mobile_phone;



        }


        //פונקצית המרת אוביקט שלנו לשל מיקרוסופט - משמש בהוספת אוביקט חדש למסד
        public static client toEmpTBL(clientDTO cl)
        {
            client newClient = new client();
            newClient.id_client = cl.id_client;
            newClient.first_name = cl.first_name;
            newClient.last_name = cl.last_name;
            newClient.id_city = (int)cl.id_city;
            newClient.address = cl.address;
            newClient.birthday = (DateTime)cl.birthday;
            newClient.phone = cl.phone;
            newClient.mobile_phone = cl.mobile_phone;


            return newClient;
        }


        //פונקצית המרת אוביקט מיקרוסופט  לשלנו- משמש בשליפת אוביקט 
        public static clientDTO toEmpDTO(client cl)
        {
            clientDTO newClient = new clientDTO();
            newClient.id_client = cl.id_client;
            newClient.first_name = cl.first_name;
            newClient.last_name = cl.last_name;
            newClient.id_city = (int)cl.id_city;
            newClient.address = cl.address;
            newClient.birthday = (DateTime)cl.birthday;
            newClient.phone = cl.phone;
            newClient.mobile_phone = cl.mobile_phone;



            return newClient;
        }


        //המרת אוסף ממיקרוסופט לשלנו
        public static List<clientDTO> toDTO_List(List<client> ee)
        {
            List<clientDTO> eList = new List<clientDTO>();
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
        public static List<client> toTBL_List(List<clientDTO> ee)
        {
            List<client> eList = new List<client>();
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
