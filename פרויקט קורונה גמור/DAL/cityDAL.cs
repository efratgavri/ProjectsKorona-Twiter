using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class cityDAL
    {


        public static List<city> getAll()
        {
            using (koronaEntities db = new koronaEntities())
            {
                try
                {
                    return db.cities.ToList();

                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }




        public static bool AddNew(city e)
        {
            try
            {
                using (koronaEntities db = new koronaEntities())
                {
                    db.cities.Add(e);
                    db.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }

        }
        //המרת קוד עיר לשם עיר
        public static string getcityid (int idcity)
        {
            try
            {
                using (koronaEntities db=new koronaEntities())
                {
                    return db.cities.FirstOrDefault(p => p.id_city == idcity).city_name;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
      

    }   
}
