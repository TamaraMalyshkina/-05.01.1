using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    class Class1
    {
        //как было показанно на видео
        static void Main(string[] args)
        {
            string conStr = @"Data Sourse = .\SQLEXPRESS; Initial Catalog = ShopDB; Intergrated Security = True";
            SqlConnection connection = new SqlConnection(conStr);
            try
            {
                connection.Open();
                Console.WriteLine(connection.State);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
                Console.WriteLine(connection.State);
            }
        }
        // как меня обучили на работе
        MySqlConnection connection = new MySqlConnection("serwer=localhost; port=3306; username=root; password=root; database=BD");

        public void open()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void close()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection get()
        {
            return connection;
        }
    }
}
