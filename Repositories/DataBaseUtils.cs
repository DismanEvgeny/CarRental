﻿using System;
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
                    fullName = "[Clients](Id, Name, Surname, Sex, DateOfRegistration, IsReliable) VALUES ";
                    break;
                case "Users":
                    fullName = "[Users](Id, Name, Surname, Login, Password, IsAdmin) VALUES";
                    break;
                case "Categories":
                    fullName = "[Categories](Id, Name, Tariff, Fine) VALUES";
                    break;
                case "Cars":
                    fullName = "[Cars](Id, Brand, Model, CategoryId, Fuel, YearOfProduction, AutomaticTransmition, Image) VALUES";
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
                sql += "'" + dataStrings[i] + "', ";
            }
            sql = sql.Remove(sql.Length - 2);//чтобы в конце перед скобкой не было пробела c запятой
            sql += ")";

            SqlCommand cmd_write = new SqlCommand(sql, conn);
            Console.WriteLine("COMMAND: " + sql);
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

        public string[] getCarFromDB(string Id)
        {
            openConnection();

            SqlCommand command = new SqlCommand("Select * from [Cars] where [Id]=@id", conn); //строка-запрос, ищем по логину
            command.Parameters.AddWithValue("@id", Id);

            string[] data = new string[8];
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
                for (int i = 0; i < 8; i++)
                {
                    data[i] = reader[i].ToString();
                    Console.WriteLine(data[i]);
                }

            reader.Close();
            closeConnection();

            return data;
        }

        public string[,] getAllUsersFromDB(int userCounter) // поиск пользователя в БД по логину
        {
            string[,] users = new string[userCounter, 3];
            int k = 0;
            int i = 0;
            openConnection();

            SqlCommand command = new SqlCommand("Select ID, Name, Surname from Users", conn); //строка-запрос, ищем по логину


            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
                while (reader.Read())
                { 
                    for (int j = 0; j < 3; j++)
                        users[i, j] = reader[j].ToString();
                    i++;
                }

            reader.Close();
            closeConnection();

            return users;
        }

        public string getUsersAmount() // количество юзеров в таблице
        {

            openConnection();

            SqlCommand command = new SqlCommand("Select count(*) from [Users]", conn);

            string data = "";
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
                data = reader[0].ToString();

            reader.Close();
            closeConnection();

            return data;
        }

        public void deleteUserFromDB(string ID) // удаление юзера из таблицы
        {
            openConnection();

            SqlCommand command = new SqlCommand("DELETE FROM Users WHERE ID=" + ID, conn);
            command.ExecuteNonQuery();

            closeConnection();
        }

        public void deleteCategory(string name) // удаление категории из таблицы
        {
            openConnection();

            SqlCommand newCommand = new SqlCommand("DELETE FROM Categories WHERE Name='" + name + "'", conn); 
            newCommand.ExecuteNonQuery();

            closeConnection();
        }

        public void deleteCar(string ID)
        {
            openConnection();

            SqlCommand newCommand = new SqlCommand("DELETE FROM Cars WHERE Id='" + ID + "'", conn);
            newCommand.ExecuteNonQuery();

            closeConnection();
        }

        public string getsMaxID(string tableName) // поиск максимального id в таблице 
        {

            openConnection();

            SqlCommand command = new SqlCommand($"select * from [{tableName}] where [ID] = (select max(ID) from [{tableName}])", conn); //строка-запрос, ищем по логину

            string data = "";
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
                data = reader[0].ToString();

            reader.Close();
            closeConnection();
            if (data == null || data == "")
            {
                data = "0";
            }
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

        public string[] getCategoryFromDB(string categoryName) // поиск категории по её названию
        {
            openConnection();
            SqlCommand command = new SqlCommand($"Select * from [Categories] WHERE Name='{categoryName}'", conn); //строка-запрос, ищем по логину
            SqlDataReader reader = command.ExecuteReader();
            string[] readString = new string[4];

            if (reader.Read())
            {
                for (int i = 0; i < 4; i++)
                {
                    readString[i] = reader[i].ToString();
                }

            }
            return readString;
        }

        public List<string[]> getCarsFromDB()
        {
            List<string[]> cars = new List<string[]>();
            string[] readStrings = new string[8];
            openConnection();
            SqlCommand command = new SqlCommand("Select * from [Cars]", conn); //строка-запрос, ищем по логину
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < 8; i++)
                {
                    readStrings[i] = reader[i].ToString();
                }
                cars.Add(new string[] { readStrings[0], readStrings[1], readStrings[2], readStrings[3], readStrings[4], readStrings[5], readStrings[6], readStrings[7] });

            }
            closeConnection();

            return cars;
        }

        public List<string[]> getClientsFromDB()
        {
            List<string[]> clients = new List<string[]>();
            string[] readStrings = new string[7];
            openConnection();
            SqlCommand command = new SqlCommand("Select * from [Clients]", conn); //строка-запрос, ищем по логину
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < 7; i++)
                {
                    readStrings[i] = reader[i].ToString();
                }
                clients.Add(new string[] { readStrings[0], readStrings[1], readStrings[2], readStrings[3], readStrings[4], readStrings[5], readStrings[6], readStrings[7] });

            }
            closeConnection();
            return clients;
        }

    }
}
