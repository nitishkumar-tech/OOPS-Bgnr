//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS_Begnr
//{
//    internal class constring_2
//    {
//        class database
//        {
//            string connectionstring;
//            SqlConnection connection;

//            public database(string connectionstring)
//            {
//                this.connectionstring = connectionstring;
//                connection = new SqlConnection(connectionstring);
//            }

//            public void openconnection()
//            {
//                try
//                {
//                    connection.Open();
//                    Console.WriteLine("database connection is opened");
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine(ex.Message);
//                }
//            }

//            public void closeconnection()
//            {
//                if (connection.State == System.Data.ConnectionState.Open)
//                {
//                    connection.Close();
//                    Console.WriteLine("database connection is closed");
//                }
//            }

//            static void Main(string[] args)
//            {
//                string connstring =
//                "server=.\\SQLEXPRESS;Initial Catalog=ado;Integrated Security=true";
//                database db = new database(connstring);
//                db.openconnection();
//                db.closeconnection();
//            }
//        }
//    }
//}
