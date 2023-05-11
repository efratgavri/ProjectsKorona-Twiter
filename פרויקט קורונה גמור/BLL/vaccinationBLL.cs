using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Dto;

namespace BLL
{
    public class vaccinationBLL
    {
        //החזרת כל חיסונים
        public static List<vaccinationDTO> GetAllvaccination()
        {
            return vaccinationDTO.toDTO_List(vaccinationDAL.getAll());
        }

        public static List<List<dynamic>> Getvaccinationwithproductname()
        {
            var vaccination = vaccinationDTO.toDTO_List(vaccinationDAL.getAll());
            List<List<dynamic>> vaccinationdynamic = new List<List<dynamic>>();
            foreach (var item in vaccination)
            {
                List<dynamic> indynamic = new List<dynamic>();
                indynamic.Add(item.id_client);
                indynamic.Add(item.date_vaccination);
                string productname = productBLL.getproductname(item.id_product);
                indynamic.Add(productname);

                vaccinationdynamic.Add(indynamic);
            }
            return vaccinationdynamic;
        }
        public static List<List<dynamic>> Getvaccinationwithproductname_by_id_client(string id_client)
        {
            var vaccination = vaccinationDTO.toDTO_List(vaccinationDAL.getAllby_id_client(id_client));
            List<List<dynamic>> vaccinationdynamic = new List<List<dynamic>>();
            foreach (var item in vaccination)
            {
                List<dynamic> indynamic = new List<dynamic>();
                indynamic.Add(item.id_client);
                indynamic.Add(item.date_vaccination);
                string productname = productBLL.getproductname(item.id_product);
                indynamic.Add(productname);

                vaccinationdynamic.Add(indynamic);
            }
            return vaccinationdynamic;
        }


        // הוספת רשומה לטבלת ערים
        public static bool AddNewvaccination(string id_client, DateTime date_vaccination, int id_product)
        {
            vaccinationDTO NewaddNewvaccination = new vaccinationDTO();
            NewaddNewvaccination.id_client = id_client;
            NewaddNewvaccination.date_vaccination = date_vaccination;
            NewaddNewvaccination.id_product = id_product;
            return vaccinationDAL.AddNew(vaccinationDTO.toEmpTBL(NewaddNewvaccination));
        }
    }
}
