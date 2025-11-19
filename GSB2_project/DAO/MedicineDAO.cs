using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSB2_project.Models;
using MySql.Data.MySqlClient;

namespace GSB2_project.DAO
{
    internal class MedicineDAO
    {
        private readonly Database db = new Database();

        public List<Medicine> GetAll()
        {
            List<Medicine> listMedicine = new List<Medicine>();

            using (var connection = db.GetConnection())
            {
                try
                {
                    connection.Open();

                    using (var myCommand = new MySqlCommand(@"SELECT * FROM Medicine;", connection))
                    {

                        using (var myReader = myCommand.ExecuteReader())
                        {
                            while (myReader.Read())
                            {
                                Medicine medicine = new Medicine(myReader.GetInt32("id_medicine"), myReader.GetInt32("id_user"), myReader.GetInt32("dosage"), myReader.GetString("name"), myReader.GetString("description"), myReader.GetString("molecule"));
                                listMedicine.Add(medicine);
                            }
                        }
                    }

                    return listMedicine;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erreur lors de la connexion : {ex.Message}");
                    return null;
                }
            }
        }
    }
}
