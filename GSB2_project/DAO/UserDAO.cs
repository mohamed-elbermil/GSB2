using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSB2_project.Models;
using MySql.Data.MySqlClient;

namespace GSB2_project.DAO
{
    internal class UserDAO
    {
        private readonly Database db = new Database();

        public User Login(string email, string password)
        {
            // variables initialisées
            int id = 0;
            string name = string.Empty;
            string firstname = string.Empty;
            bool role = false;

            using (var connection = db.GetConnection())
            {
                try
                {
                    connection.Open();

                    using (var myCommand = new MySqlCommand(
                        @"SELECT id_user, name, firstname, role 
              FROM users 
              WHERE email = @email AND password = @password;",
                        connection))
                    {
                        // paramètres protégés contre l’injection SQL
                        myCommand.Parameters.AddWithValue("@email", email);
                        myCommand.Parameters.AddWithValue("@password", password);

                        using (var myReader = myCommand.ExecuteReader())
                        {
                            if (myReader.Read())
                            {
                                id = myReader.GetInt32("id_user");
                                name = myReader.GetString("name");
                                firstname = myReader.GetString("firstname");
                                role = myReader.GetBoolean("role");

                                return new User(id, name, firstname, role);
                            }
                            else
                            {
                                // Aucun utilisateur trouvé
                                return null;
                            }
                        }
                    }
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
