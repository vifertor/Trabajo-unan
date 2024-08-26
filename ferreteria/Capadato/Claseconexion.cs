using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Capadato
{
   public class Claseconexion
    {

        private SqlConnection connection = new SqlConnection("Data Source=ISAIASVINDELL\\SQLEXPRESS; Initial Catalog=Ferreteria;User ID=sa; Password=12345");

        public SqlConnection OpenConnection()
        {

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }


        public SqlConnection CloseConnection()
        {

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            return connection;
        }
    }
}
