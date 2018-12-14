using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Repositories
{
    public class DataBaseUtils
    {
        private string path = (System.Environment.CurrentDirectory);
        private SqlConnection conn = new SqlConnection();

        public DataBaseUtils()
        {
            path = path.Remove(path.IndexOf("\\bin"), 10) + "\\DB.mdf"; //путь к базе данных
        }

        public void openConnection()
        {
            conn.ConnectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename = {path}\\DB.mdf;Integrated Security=True;Connect Timeout=100;User Instance=False";
            conn.Open();
        }

        public void closeConnection()
        {
            conn.Close();
        }

        private string getFullTableName(string tableName) // возвращает полное имя таблицы типа [Имя] (поля) values (@поля)
        {
            string fullName;
            
            switch(tableName){
                case "Clients":
                    fullName = "[Clients] (Id, Name, Surname, Sex, Date of Registration, Date of Driving Start, Is reliable) values (@Id, @Name, @Surname, @Sex, @Date of Registration, @Date of Driving Start, @Is reliable)";
                    break;
                default:
                    fullName = "";
                    break;
            }
            return fullName;
        }


        public bool insertInDB(string tableName, string dataLine) //для вставки данных в БД
        {
            string fullTableName;
            if ((fullTableName = getFullTableName(tableName)) == "") {
                return false;
            };

            string sql = $"INSERT INTO {fullTableName} values (@Id, @Name)";   //!!!! нужно придумать, как в текст вставлять значения
            SqlCommand cmd_write = new SqlCommand(sql, conn);
            /*cmd_write.Parameters.AddWithValue("@Id", id);
            cmd_write.Parameters.AddWithValue("@Name", name);*/
            cmd_write.ExecuteNonQuery();

            return true;
        }

    }
}
