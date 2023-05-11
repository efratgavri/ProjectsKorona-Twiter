using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Dto;


namespace BLL
{
    public class koronaBLL
    {
        //החזרת כל קורונה
        public static List<koronaDTO> GetAllkorona()
        {
            return koronaDTO.toDTO_List(koronaDAL.getAll());
        }


        // הוספת רשומה לטבלת קורונה
        public static bool AddNewkorona(string id_client, DateTime date_sick, DateTime date_vecovery)
        {
            koronaDTO NewaddNewkorona = new koronaDTO();
            NewaddNewkorona.id_client = id_client;
            NewaddNewkorona.date_sick = date_sick;
            NewaddNewkorona.date_vecovery = date_vecovery;
            return koronaDAL.AddNew(koronaDTO.toEmpTBL(NewaddNewkorona));
        }
        //public static koronaDTO Getfinebyid(int id)
        //{
        //    return koronaDTO.toEmpDTO(koronaDAL.Getfinebyid(id));
        //}

        //(שליפת מחלה על פי קוד לקוח(לדעת אם הוא כבר חולה
        public static koronaDTO Getidclient(string id)
        {
            return koronaDTO.toEmpDTO(koronaDAL.Getidclient(id));
        }
        public static bool Update_date_vecvery(string id, DateTime date_vecvery)
        {
            return koronaDAL.Update_date_vecvery(id, date_vecvery);
        }
        
    }
}
