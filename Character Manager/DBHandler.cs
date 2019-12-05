using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterManager
{
    public class DBHandler
    {
        static private string databaseFileName = "database.sqlite";
        static private string connectionString = "";
        
        static private bool IsDataBaseExists()
        {
            return File.Exists(databaseFileName);
        }

        static private SQLiteConnection Connect()
        {
            if(IsDataBaseExists())
            {
                var connection = new SQLiteConnection(connectionString);
                return connection;
            }

            throw new Exception("Database not found!");
        } 

        static public DataTable ExecuteQeuryWithDataToReturn(string query)
        {
            try
            {
                using(var connection = Connect())
                {
                    connection.Open();
                    using (var adapter = new SQLiteDataAdapter(query, connection))
                    {
                        var table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
            catch(Exception ex)
            {

                return new DataTable();
            }
        }

        static public void ExecuteQuery(string query)
        {
            try
            {
                using(var connection = Connect())
                {
                    connection.Open();
                    var command = new SQLiteCommand(query, connection);
                    command.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}
