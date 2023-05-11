using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;

//using System.IO;
//using Microsoft.AspNetCore.Mvc;

namespace DAL
{
    public class clientDAL
    {

        //קבלת כל הלקוחות
        public static List<client> getAll()
        {
            using (koronaEntities db = new koronaEntities())
            {
                try
                {
                    return db.clients.ToList();

                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }



        //הוספת לקוח
        public static bool AddNew(client e)
        {
            try
            {
                using (koronaEntities db = new koronaEntities())
                {
                    db.clients.Add(e);
                    db.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }

        }


        //        public void AddImagesToTable(string folderPath)
        //        {
        //            int idEvent = 21;

        //            string connectionString = "LAPTOP-M6BR14B1/SQLEXPRESS/korona";
        //            using (SqlConnection connection = new SqlConnection(connectionString))
        //            {
        //                connection.Open();
        //                using (SqlCommand command = connection.CreateCommand())
        //                {
        //                    // Iterate through files in the folder
        //                    foreach (string filePath in Directory.GetFiles(folderPath))
        //                    {
        //                        string fileName = Path.GetFileName(filePath);

        //                        // Check if the file is an image
        //                        string[] validExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".JPG" };
        //                        if (validExtensions.Contains(Path.GetExtension(fileName), StringComparer.OrdinalIgnoreCase))
        //                        {
        //                            // Generate MD5 hash for the image file
        //                            using (FileStream fileStream = File.OpenRead(filePath))
        //                            {
        //                                using (MD5 md5 = MD5.Create())
        //                                {
        //                                    byte[] hashBytes = md5.ComputeHash(fileStream);
        //                                    string imageHash = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();

        //                                    // Insert the image path and hash into the table
        //                                    string insertQuery = "INSERT INTO [korona] (idEvenrs, Image_path) VALUES (@IdEvent, @ImageHash)";
        //                                    command.CommandText = insertQuery;
        //                                    command.Parameters.AddWithValue("@IdEvent", idEvent);
        //                                    command.Parameters.AddWithValue("@ImageHash", imageHash);
        //                                    command.ExecuteNonQuery();
        //                                }
        //                            }
        //                        }
        //                    }
        //                }
        //            }
        //        }

        //    }
    }
}
