using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class vaccinationDAL
    {
        public static List<vaccination> getAll()
        {
            using (koronaEntities db = new koronaEntities())
            {
                try
                {
                    return db.vaccinations.ToList();

                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }
        public static bool AddNew(vaccination e)
        {
            try
            {
                using (koronaEntities db = new koronaEntities())
                {
                    db.vaccinations.Add(e);
                    db.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }

        }

        public static List<vaccination> getAllby_id_client(string id_client)
        {
            using (koronaEntities db = new koronaEntities())
            {
                try
                {
                   
                    return db.vaccinations.Where(p => p.id_client == id_client ).ToList();
                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }





    }
}
