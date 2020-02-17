using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

namespace Design_patterns___Singleton__Quête_1
{
    public sealed class DatabaseSingleton
    {
        private SqlConnection Connection { get; set; }
        private static DatabaseSingleton instance = null;

        private DatabaseSingleton()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.ConnectionString = @"Data Source=DESKTOP-ODBJ5B8\SQLEXPRESS;Initial Catalog=Hackathon1;Integrated Security=True";
            Connection = new SqlConnection(builder.ConnectionString);
            Connection.Open();
        }

        public static DatabaseSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DatabaseSingleton();
                }
                return instance;
            }
        }
    }
}

