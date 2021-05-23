﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace FloraWarehouseManagement.Classes.Utilities
{
    public class CheckCredentials
    {
        private static readonly string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;

        public CheckCredentials() { }

        public static int CheckUsername(string Username)
        {
            int userExists;
            SQLiteConnection connection = new SQLiteConnection(@"data source=" + projectDirectory + @"\Database\db.db");
            connection.Open();
            string checkIfExistsQuery = "SELECT EXISTS(SELECT 1 FROM User WHERE Username=@Username)";
            SQLiteCommand command = new SQLiteCommand(checkIfExistsQuery, connection);
            command.Parameters.AddWithValue("Username", Username);
            userExists = Convert.ToInt32(command.ExecuteScalar());
            return userExists;
        }

        public static int CheckUsernameAndPassword(string Username, string Password)
        {
            int userExists;
            SQLiteConnection connection = new SQLiteConnection(@"data source=" + projectDirectory + @"\Database\db.db");
            connection.Open();
            string checkIfExistsQuery = "SELECT EXISTS(SELECT 1 FROM User WHERE Username=@Username AND Password=@Password)";
            SQLiteCommand command = new SQLiteCommand(checkIfExistsQuery, connection);
            command.Parameters.AddWithValue("Username", Username);
            command.Parameters.AddWithValue("Password", Password);
            userExists = Convert.ToInt32(command.ExecuteScalar());
            return userExists;
        }
    }
}
