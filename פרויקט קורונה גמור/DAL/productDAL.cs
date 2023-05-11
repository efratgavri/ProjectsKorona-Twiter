using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class productDAL
    {
        public static List<product> getAll()
        {
            using (koronaEntities db = new koronaEntities())
            {
                try
                {
                    return db.products.ToList();

                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }

      



        public static bool AddNew(product e)
        {
            try
            {
                using (koronaEntities db = new koronaEntities())
                {
                    db.products.Add(e);
                    db.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }

        }
        //המרת שם מוצר לקוד מוצר
        public static int getproductid(string productname)
        {
            try
            {
                using (koronaEntities db = new koronaEntities())
                {
                    return db.products.FirstOrDefault(p => p.name_product == productname).id_product;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        //המרת קוד מוצר לשם מוצר
        public static string getproductname(int id)
        {
            try
            {
                using (koronaEntities db = new koronaEntities())
                {
                    return db.products.FirstOrDefault(p => p.id_product == id).name_product;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

     

    }
}
