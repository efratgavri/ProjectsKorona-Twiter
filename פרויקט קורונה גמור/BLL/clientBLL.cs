using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Dto;

namespace BLL
{
    public class clientBLL
    {
        //החזרת כל הלקוחות
        public static List<clientDTO> GetAllCustomers()
        {
            return clientDTO.toDTO_List(clientDAL.getAll());
        }
        public static List<List<dynamic>> GetCostumerwithcityname()
        {
            var client = clientDTO.toDTO_List(clientDAL.getAll());
            List<List<dynamic>> clientdynamic = new List<List<dynamic>>();
            foreach (var item in client)
            {
                List<dynamic> indynamic = new List<dynamic>();
                indynamic.Add(item.id_client);
                indynamic.Add(item.first_name);
                indynamic.Add(item.last_name);
                indynamic.Add(item.address);
                indynamic.Add(item.birthday);
                string cityname = cityBLL.getcityid(item.id_city);
                indynamic.Add(cityname);
                indynamic.Add(item.phone);
                indynamic.Add(item.mobile_phone);


                clientdynamic.Add(indynamic);
            }
            return clientdynamic;
        }




        //הוספת רשומה לטבלת לקוחות
        public static bool AddNewclient(string id_client, string first_name,string last_name,int id_city , string address, DateTime birthday,  string phone, string mobile_phone)
        {
            clientDTO NewaddNewclient = new clientDTO();
            NewaddNewclient.id_client = id_client;
            NewaddNewclient.first_name = first_name;
            NewaddNewclient.last_name = last_name;
            NewaddNewclient.address = address;
            NewaddNewclient.birthday = birthday;
            NewaddNewclient.id_city = (int)id_city;
            NewaddNewclient.phone = phone;
            NewaddNewclient.mobile_phone = mobile_phone;



            return clientDAL.AddNew(clientDTO.toEmpTBL(NewaddNewclient));
        }

    }
}

