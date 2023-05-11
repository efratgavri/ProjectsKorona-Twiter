using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Dto;
namespace BLL
{
    public class cityBLL
    {

        //החזרת כל הערים
        public static List<cityDTO> GetAllcities()
        {
            return cityDTO.toDTO_List(cityDAL.getAll());
        }


       // הוספת רשומה לטבלת ערים
        public static bool AddNewcities(string city_name)
        {
            cityDTO NewaddNewcities = new cityDTO();
            NewaddNewcities.city_name = city_name;
            return cityDAL.AddNew(cityDTO.toEmpTBL(NewaddNewcities));
        }

     


        //המרת קוד עיר לשם עיר
        public static string getcityid(int id_city)
        {
            return cityDAL.getcityid(id_city);
        }
   

    }
}
