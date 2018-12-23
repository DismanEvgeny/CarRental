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
                    fullName = "[Clients] (Id, Name, Surname, Sex,  Date of Driving Start, Date of Registration, Is Reliable) VALUES ";
                    break;
                case "Users":
                    fullName = "[Users](Id, Name, Surname, Login, Password, IsAdmin) VALUES";
                    break;
                case "Categories":
                    fullName = "[Categories](Id, Name, Tariff, Fine) VALUES";
                    break;
                default:
                    fullName = "";
                    break;
            }
            return fullName;
        }

        public bool insertInDB(string tableName, string[] dataStrings) //для вставки данных в БД
        {
            openConnection();
            string fullTableName;
            if ((fullTableName = getFullTableName(tableName)) == "") {
                return false;
            };

            string sql = $"INSERT INTO {fullTableName}("; //строка-запрос
            for(int i = 0; i < dataStrings.Length; i++) // добавляем данные в строку-запрос
            {
                sql += "\'" + dataStrings[i] + "\', ";
            }
            sql = sql.Remove(sql.Length - 2);//чтобы в конце перед скобкой не было пробела c запятой
            sql += ")";

            SqlCommand cmd_write = new SqlCommand(sql, conn);
            cmd_write.ExecuteNonQuery();
            closeConnection();
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

        public List<string[]> getCategoriesFromDB()
        {
            List<string[]> categories = new List<string[]>();
            string[] readStrings = new string[4];
            openConnection();
            SqlCommand command = new SqlCommand("Select * from [Categories]", conn); //строка-запрос, ищем по логину
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < 4; i++)
                {
                    readStrings[i] = reader[i].ToString();
                }
                categories.Add(new string[] { readStrings[0], readStrings[1], readStrings[2], readStrings[3] });
            }

            return categories;
        }

    }
}
