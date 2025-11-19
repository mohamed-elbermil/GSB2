using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GSB2_project.DAO
{
    internal class Database
    {
        private readonly string myConnectionString = "server=localhost;port=3306;uid=root;pwd=root;database=gsb2";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(myConnectionString);
        }
    }
}
