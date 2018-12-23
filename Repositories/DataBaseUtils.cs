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
        //private string path = (System.Environment.CurrentDirectory);
        private SqlConnection conn = new SqlConnection();

        public DataBaseUtils()
        {
           // path = path.Remove(path.IndexOf("\\bin"), 10) + "\\DataBase.mdf"; //путь к базе данных
        }

        private void openConnection() //открытие соединения
        {
            conn.ConnectionString = "Data Source = localhost; Initial Catalog = CarRentalDB; Integrated Security = True";
           
            conn.Open();
        }

        private void closeConnection() // закрытие соединения
        {
            conn.Close();
        }

        public bool checkConnection()
        {
            try
            {
                openConnection();
            } catch(Exception ex)
            {
                return false;
            }

            closeConnection();
            return true;

        }

        private string getFullTableName(string tableName) // возвращает полное имя таблицы типа [Имя] (поля) values (@поля)
        {
            string fullName;
            
            switch(tableName){
                case "Clients":
                    //fullName = "[Clients] (Id, Name, Surname, Sex, Date of Registration, Date of Driving Start, Is reliable) values (@Id, @Name, @Surname, @Sex, @Date of Registration, @Date of Driving Start, @Is reliable)";
                    fullName = "[Clients] (Id, Name, Surname, Sex,  Date of Driving Start, Date of Registration, Is Reliable) values ";

                    break;
                case "Users":
                    fullName = "[Users](Id, Name, Surname, Login, Password, IsAdmin) values";
                    break;
                default:
                    fullName = "";
                    break;
            }
            return fullName;
        }

        public bool insertInDB(string tableName, string[] dataStrings) //для вставки данных в БД
        {
            string fullTableName;
            if ((fullTableName = getFullTableName(tableName)) == "") {
                return false;
            };

            string sql = $"INSERT INTO {fullTableName} values ("; //строка-запрос
            for(int i = 0; i < dataStrings.Length; i++) // добавляем данные в строку-запрос
            {
                sql += dataStrings[i] + ", ";
            }
            sql = sql.Remove(sql.Length - 1);//чтобы в конце перед скобкой не было пробела
            sql += ")";

            SqlCommand cmd_write = new SqlCommand(sql, conn);
            cmd_write.ExecuteNonQuery();

            return true;
        }

        public string[] getUsersFromDB( string login ) // поиск пользователя в БД по логину
        {

            openConnection();

            SqlCommand command = new SqlCommand("Select * from [Users] where [Login]=@log", conn); //строка-запрос, ищем по логину
            command.Parameters.AddWithValue("@log", login);

            string[] data = new string[6];
            SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                for (int i = 0; i < 6; i++)
                {
                    data[i] = reader[i].ToString();
                    Console.WriteLine(data[i]);
                }

            reader.Close();
            closeConnection();

            return data;
        }

    }
}
