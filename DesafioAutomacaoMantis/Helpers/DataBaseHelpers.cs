using System;
using MySql.Data.MySqlClient;

namespace DesafioAutomacaoMantis.Helpers
{
    public class DataBaseHelpers
    {
            static MySqlConnection connection = null;
            static String connString = $"Server='{JsonBuilder.GetAppSettings("DB_URL")}';" +
                                       $"Database='{JsonBuilder.GetAppSettings("DB_NAME")}';" +
                                       $"Uid='{JsonBuilder.GetAppSettings("DB_USER")}';" +
                                       $"Pwd='{JsonBuilder.GetAppSettings("DB_PASSWORD")}'";
            private static MySqlConnection GetDBConnection()
            {
                try
                {
                    return connection = new MySqlConnection(connString);
                }
                catch (Exception)
                {
                    Console.WriteLine("Sem conexao com banco");
                    throw;
                }
            }

            public static void ExecuteQueryDB(string query)
            {
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, GetDBConnection()))
                    {
                        cmd.CommandTimeout = Int32.Parse(JsonBuilder.GetAppSettings("DB_CONNECTION_TIMEOUT"));
                        cmd.Connection.Open();
                        int number = cmd.ExecuteNonQuery();
                        cmd.Connection.Close();
                        Console.WriteLine(query);
                        Console.WriteLine(number);
                    }
                }

                catch (Exception e)
                {
                    throw new Exception("Erro na execução ou conexão: =>", e);
                }
            }

        public static bool ExecuteQueryDBWithReturnBool(string query)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, GetDBConnection()))
                {
                    cmd.CommandTimeout = Int32.Parse(JsonBuilder.GetAppSettings("DB_CONNECTION_TIMEOUT"));
                    cmd.Connection.Open();
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    Console.WriteLine(query);

                    if (dataReader.HasRows)
                    {
                        cmd.Connection.Close();
                        return true;
                    }

                    else
                    {
                        cmd.Connection.Close();
                        return false;
                    }
                }
            }

            catch (Exception e)
            {
                throw new Exception("Erro na execução ou conexão: =>", e);
            }
        } 
        public static string ExecuteQueryDBWithReturnString(string query)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, GetDBConnection()))
                {
                    cmd.CommandTimeout = Int32.Parse(JsonBuilder.GetAppSettings("DB_CONNECTION_TIMEOUT"));
                    cmd.Connection.Open();
                    int number = cmd.ExecuteNonQuery();

                    var id_table = cmd.ExecuteScalar().ToString();

                    cmd.Connection.Close();
                    Console.WriteLine(query);
                    Console.WriteLine(number);

                    return id_table;
                }
            }

            catch (Exception e)
            {
                throw new Exception("Erro na execução ou conexão: =>", e);
            }
        }
    }
}
