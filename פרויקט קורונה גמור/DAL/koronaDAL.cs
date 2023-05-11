using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class koronaDAL
    {
        //קבלת כל הלקוחות
        public static List<korona> getAll()
        {
            using (koronaEntities db = new koronaEntities())
            {
                try
                {
                    return db.koronas.ToList();

                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }



        //הוספת לקוח
        public static bool AddNew(korona e)
        {
            try
            {
                using (koronaEntities db = new koronaEntities())
                {
                    db.koronas.Add(e);
                    db.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }

        }

        //בדיקה האם לקוח זה כבר חולה
        public static korona Getidclient(string id)
        {
            try
            {
                using (koronaEntities db = new koronaEntities())
                {
                    return db.koronas.Where(p => p.id_client == id).ToList().Last(); ;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

      //עדכון תאריך החלמה
        public static bool Update_date_vecvery(string id, DateTime date_vecvery)
        {
            try
            {
                using (koronaEntities db = new koronaEntities())
                {
                    db.koronas.FirstOrDefault(p => p.id_client == id).date_vecovery = date_vecvery;
                    db.SaveChanges();
                    return true;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
