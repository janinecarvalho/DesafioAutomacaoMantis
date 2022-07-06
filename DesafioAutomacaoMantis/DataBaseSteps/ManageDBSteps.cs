using System;
using System.Data;
using MySql.Data.MySqlClient;
using DesafioAutomacaoMantis.Helpers;
using System.Collections.Generic;

namespace DesafioAutomacaoMantis.DataBaseSteps
{
    public class ManageDBSteps
    {
        public static void DeleteUserDB(string user)
        {
            try
            {
                var connString = $"Server='{JsonBuilder.GetAppSettings("DB_URL")}';Database='{JsonBuilder.GetAppSettings("DB_NAME")}';Uid='{JsonBuilder.GetAppSettings("DB_USER")}';Pwd='{JsonBuilder.GetAppSettings("DB_PASSWORD")}'";
                var connection = new MySqlConnection(connString);
                var command = connection.CreateCommand();

                connection.Open();

                command.CommandText = $@"DELETE FROM `mantis_user_table` WHERE `username`='{user}'; ";
                command.ExecuteNonQuery();

                connection.Close();
            }

            catch (Exception e)
            {
                throw new Exception("Erro na execução ou conexão: =>", e);
            }
        }
        public static void InsertUserDB(string user, string password)
        {
            try
            {
                var connString = "Server=localhost;Database=bugtracker;Uid=root;Pwd=root";
                var connection = new MySqlConnection(connString);
                var command = connection.CreateCommand();

                connection.Open();

                command.CommandText = $@"INSERT INTO `mantis_user_table` (`id`, `username`, `realname`, `email`, `password`, `enabled`, `protected`, `access_level`, `login_count`, `lost_password_request_count`, `failed_login_count`, `cookie_string`, `last_visit`, `date_created`) 
                                        VALUES(2, '{user}', '', 'janinelost@hotmail.com', '{password}', 1, 0, 90, 5, 0, 0, 'EvWotLaIN7n_sbUV2p5dNFVj-KfYV-Q0dT0vPpjdk9Wrghe13GvOaq6SxwyBjna9', 1638554263, 1638554138); ";
                command.ExecuteNonQuery();

                connection.Close();
            }

            catch(Exception e)
            {
                throw new Exception("Erro na execução ou conexão: =>", e);
            }
        }

        private static String tableCategoriaProjeto = "mantis_category_table";
        private static String tablePerfilGlobal = "mantis_user_profile_table";
        private static String tableMarcadorProjeto = "mantis_tag_table";
        private static String tableCampoPersonalizadoProjeto = "mantis_custom_field_table";
        private static String tableTarefaProjeto = "mantis_bug_table";
        private static String tableProjeto = "mantis_project_table";

        private static String queryInsertCategoriaProjeto = $"INSERT INTO `{tableCategoriaProjeto}` (`id`, `project_id`, `user_id`, `name`, `status`) VALUES (2, 0, 0, ' BASE_2', 0);";
        private static String queryInsertPerfilGlobal = $"INSERT INTO `{tablePerfilGlobal}` (`id`, `user_id`, `platform`, `os`, `os_build`, `description`) VALUES (2, 0, '{JsonBuilder.GetAppSettings("PLATAFORMA")}', '{JsonBuilder.GetAppSettings("OS")}', '{JsonBuilder.GetAppSettings("VERSAO_OS")}', '{JsonBuilder.GetAppSettings("DESCRICAO_PROJETO")}');";
        private static String queryInsertMarcadorProjeto = $"INSERT INTO `{tableMarcadorProjeto}` (`id`, `user_id`, `name`, `description`, `date_created`, `date_updated`) VALUES (2, 2, '{JsonBuilder.GetAppSettings("NOME_MARCADOR")}', '{JsonBuilder.GetAppSettings("DESCRICAO_MARCADOR")}', 1656971549, 1656971549);";
        private static String queryInsertCampoPersonalizadoProjeto = $"INSERT INTO `{tableCampoPersonalizadoProjeto}` (`id`, `name`, `type`, `possible_values`, `default_value`, `valid_regexp`, `access_level_r`, `access_level_rw`, `length_min`, `length_max`, `require_report`, `require_update`, `display_report`, `display_update`, `require_resolved`, `display_resolved`, `display_closed`, `require_closed`, `filter_by`) VALUES (2, 'PipelinejanineOLD', 0, '', '', '', 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1);";
        private static String queryInsertTarefaProjeto = $"INSERT INTO `{tableTarefaProjeto}` (`id`, `project_id`, `reporter_id`, `handler_id`, `duplicate_id`, `priority`, `severity`, `reproducibility`, `status`, `resolution`, `projection`, `eta`, `bug_text_id`, `os`, `os_build`, `platform`, `version`, `fixed_in_version`, `build`, `profile_id`, `view_state`, `summary`, `sponsorship_total`, `sticky`, `target_version`, `category_id`, `date_submitted`, `due_date`, `last_updated`) VALUES (2, 2, 2, 2, 0, 20, 40, 50, 50, 10, 10, 10, 20, 'Windows', '11-x64', 'Web', '', '', '', 2, 10, 'DesafioB2', 0, 0, '', 2, 1657041097, 1, 1657041097);";
        private static String queryInsertProjeto = $"INSERT INTO `{tableProjeto}` (`id`, `name`, `status`, `enabled`, `view_state`, `access_min`, `file_path`, `description`, `category_id`, `inherit_global`) VALUES (2, '{JsonBuilder.GetAppSettings("NOME_PROJETO") + "OLD"}', 10, 1, 10, 10, '', '{JsonBuilder.GetAppSettings("DESCRICAO_PROJETO")}', 1, 1);";

        private static List<string> listAllQueryInsert()
        {
            List<string> listQuery = new List<string>();

            listQuery.Add(queryInsertProjeto);
            listQuery.Add(queryInsertCategoriaProjeto);
            listQuery.Add(queryInsertPerfilGlobal);
            listQuery.Add(queryInsertMarcadorProjeto);
            listQuery.Add(queryInsertTarefaProjeto);
            listQuery.Add(queryInsertCampoPersonalizadoProjeto);
            
            return listQuery;
        }
        private static List<string> listAllQueryDelete()
        {
            List<string> listQuery = new List<string>();

            listQuery.Add(tableCategoriaProjeto);
            listQuery.Add(tablePerfilGlobal);
            listQuery.Add(tableMarcadorProjeto);
            listQuery.Add(tableCampoPersonalizadoProjeto);
            listQuery.Add(tableTarefaProjeto);
            listQuery.Add(tableProjeto);
            
            return listQuery;
        }
        private static void DeletarMassaDB()
        {
            var listAll = listAllQueryDelete();

            try
            {
                var connString = "Server=localhost;Database=bugtracker;Uid=root;Pwd=root";
                var connection = new MySqlConnection(connString);
                var command = connection.CreateCommand();

                connection.Open();

                foreach (string table in listAll)
                {
                    command.CommandText = $@"DELETE FROM `{table}` WHERE `id`>'1'; "; ;
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
            catch(Exception e)
            {
                throw new Exception("Erro na execução ou conexão: =>", e);
            }
        }

        public static void InserirMassaDB()
        {
            DeletarMassaDB();

            var listAll = listAllQueryInsert();

            try
            {
                var connString = "Server=localhost;Database=bugtracker;Uid=root;Pwd=root";
                var connection = new MySqlConnection(connString);
                var command = connection.CreateCommand();

                connection.Open();

                foreach(string query in listAll)
                {
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Erro na execução ou conexão: =>", e);
            }
        }

        public static bool ValidarExclusaoBD(string table, string field, string value)
        {
            var query = $@"SELECT * FROM {table} WHERE {field} = '{value}'";

            try
            {
                var connString = "Server=localhost;Database=bugtracker;Uid=root;Pwd=root";
                var connection = new MySqlConnection(connString);
                var command = connection.CreateCommand();

                connection.Open();

                command.CommandText = query;

                MySqlDataReader dataReader = command.ExecuteReader();

                connection.Close();

                if (dataReader.HasRows)
                {
                    connection.Close();
                    return false;
                }

                else
                {
                    connection.Close();
                    return true;
                }
            }
            catch(Exception e)
            {
                throw new Exception("Erro na execução ou conexão: =>", e);
            }
        }        
        public static bool ValidarInclusaoAlteracaoBD(string table, string field, string value)
        {
            var query = $@"SELECT * FROM {table} WHERE {field} = '{value}'";

            try
            {
                var connString = "Server=localhost;Database=bugtracker;Uid=root;Pwd=root";
                var connection = new MySqlConnection(connString);
                var command = connection.CreateCommand();

                connection.Open();

                command.CommandText = query;

                MySqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    connection.Close();
                    return true;
                }

                else
                {
                    connection.Close();
                    return false;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro na execução ou conexão: =>", e);
            }
        }
    }
}
