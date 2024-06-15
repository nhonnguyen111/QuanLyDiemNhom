using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemNhom.DAO
{
    internal class DataProvider
    {
        private static DataProvider instance;
        internal static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }

        public string connectionData = "Data Source=NGUYENVANNHON\\SQLEXPRESS;Initial Catalog=QuanLyDiemNhom;Integrated Security=True";

        
        public DataTable ExecuQuery(string query, object[] parameter = null)
        {

            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionData))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(',');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionData))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(',');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }


                data = cmd.ExecuteNonQuery();

                connection.Close();
            }
            return data;
        }
        public int ExecuteNon(string query, Dictionary<string, object> parameters)
        {
            int affectedRows = 0;

            using (SqlConnection connection = new SqlConnection(connectionData))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    foreach (var param in parameters)
                    {
                        command.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                    }

                    connection.Open();
                    affectedRows = command.ExecuteNonQuery();
                }
            }

            return affectedRows;
        }

        public object Execute(string query, Dictionary<string, object> parameters)
        {
            object result = null;

            using (SqlConnection connection = new SqlConnection(connectionData))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    foreach (var param in parameters)
                    {
                        command.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                    }

                    connection.Open();
                    result = command.ExecuteScalar();
                }
            }

            return result;
        }


        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionData))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(',');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = cmd.ExecuteScalar();

                connection.Close();
            }
            return data;
        }

        internal DataTable ExecuteQuery(string query, object[] parameters)
        {
            throw new NotImplementedException();
        }
    }
}
