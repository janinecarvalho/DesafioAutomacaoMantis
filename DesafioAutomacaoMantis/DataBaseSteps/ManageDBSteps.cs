using System;
using DesafioAutomacaoMantis.Helpers;
using System.Collections.Generic;

namespace DesafioAutomacaoMantis.DataBaseSteps
{
    public class ManageDBSteps
    {

        private static String tableCategoriaProjeto = "mantis_category_table";
        private static String tablePerfilGlobal = "mantis_user_profile_table";
        private static String tableMarcadorProjeto = "mantis_tag_table";
        private static String tableCampoPersonalizadoProjeto = "mantis_custom_field_table";
        private static String tableProjeto = "mantis_project_table";
        private static String tableTarefaProjeto = "mantis_bug_table";
        private static String tableLembrete = "mantis_bugnote_table";
        private static String tableLembreteProjeto = "mantis_bugnote_text_table";
        private static String tableVersaoProjeto = "mantis_project_version_table";

        public static void DeleteUserDB(string user)
        {
            string queryFile = GeneralHelpers.GetProjectPath() + @"Queries/DeleteUser.sql";

            string query = GeneralHelpers.ReplaceValueInFile(queryFile, "{user}", user);

            DataBaseHelpers.ExecuteQueryDB(query);

        }
        public static void InsertUserDB(string user, string password)
        {
            string queryFile = GeneralHelpers.GetProjectPath() + @"Queries/InsertUser.sql";

            string query = GeneralHelpers.ReadValueInFile(queryFile);

            query = GeneralHelpers.ReplaceValuesInFile(query,"{user}",user);

            query = GeneralHelpers.ReplaceValuesInFile(query, "{password}", password);

            DataBaseHelpers.ExecuteQueryDB(query);
        }

        public static bool ValidarInclusaoUsuarioDB(string usuario)
        {
            string queryFile = GeneralHelpers.GetProjectPath() + @"Queries/ValidarInclusaoUser.sql";

            string query = GeneralHelpers.ReplaceValueInFile(queryFile, "{usuario}", usuario);

            return DataBaseHelpers.ExecuteQueryDBWithReturnBool(query);
        }

        private static string GetQueryInsertProjeto()
        {
            string queryFile = GeneralHelpers.GetProjectPath() + @"Queries/queryInsertProjeto.sql";

            string query = GeneralHelpers.ReadValueInFile(queryFile);

            query = GeneralHelpers.ReplaceValuesInFile(query, "{table}", tableProjeto);

            query = GeneralHelpers.ReplaceValuesInFile(query, "{IdTable}", GetLastIdTable(tableProjeto));

            query = GeneralHelpers.ReplaceValuesInFile(query, "{NomeProjeto}", JsonBuilder.GetAppSettings("NOME_PROJETO") + "OLD");

            query = GeneralHelpers.ReplaceValuesInFile(query, "{DescricaoProjeto}", JsonBuilder.GetAppSettings("DESCRICAO_PROJETO"));

            return query;
        }

        private static string GetQueryInsertCategoriaProjeto()
        {
            string queryFile = GeneralHelpers.GetProjectPath() + @"Queries/queryInsertCategoriaProjeto.sql";

            string query = GeneralHelpers.ReadValueInFile(queryFile);

            query = GeneralHelpers.ReplaceValuesInFile(query, "{table}", tableCategoriaProjeto);

            query = GeneralHelpers.ReplaceValuesInFile(query, "{IdTable}", GetLastIdTable(tableCategoriaProjeto));

            return query;
        }

        private static string GetQueryInsertMarcadorProjeto()
        {
            string queryFile = GeneralHelpers.GetProjectPath() + @"Queries/queryInsertMarcadorProjeto.sql";

            string query = GeneralHelpers.ReadValueInFile(queryFile);

            query = GeneralHelpers.ReplaceValuesInFile(query, "{table}", tableMarcadorProjeto);

            query = GeneralHelpers.ReplaceValuesInFile(query, "{IdTable}", GetLastIdTable(tableMarcadorProjeto));

            query = GeneralHelpers.ReplaceValuesInFile(query, "{NOME_MARCADOR}", JsonBuilder.GetAppSettings("NOME_MARCADOR"));

            query = GeneralHelpers.ReplaceValuesInFile(query, "{DESCRICAO_MARCADOR}", JsonBuilder.GetAppSettings("DESCRICAO_MARCADOR"));

            return query;
        }

        private static string GetQueryInsertCampoPersonalizadoProjeto()
        {
            string queryFile = GeneralHelpers.GetProjectPath() + @"Queries/queryInsertCampoPersonalizadoProjeto.sql";

            string query = GeneralHelpers.ReadValueInFile(queryFile);

            query = GeneralHelpers.ReplaceValuesInFile(query, "{table}", tableCampoPersonalizadoProjeto);

            query = GeneralHelpers.ReplaceValuesInFile(query, "{IdTable}", GetLastIdTable(tableCampoPersonalizadoProjeto));

            return query;
        }

        private static string GetQueryInsertPerfilGlobal()
        {
            string queryFile = GeneralHelpers.GetProjectPath() + @"Queries/queryInsertPerfilGlobal.sql";

            string query = GeneralHelpers.ReadValueInFile(queryFile);

            query = GeneralHelpers.ReplaceValuesInFile(query, "{table}", tablePerfilGlobal);

            query = GeneralHelpers.ReplaceValuesInFile(query, "{IdTable}", GetLastIdTable(tablePerfilGlobal));

            query = GeneralHelpers.ReplaceValuesInFile(query, "{PLATAFORMA}", JsonBuilder.GetAppSettings("PLATAFORMA"));

            query = GeneralHelpers.ReplaceValuesInFile(query, "{OS}", JsonBuilder.GetAppSettings("OS"));

            query = GeneralHelpers.ReplaceValuesInFile(query, "{VERSAO_OS}", JsonBuilder.GetAppSettings("VERSAO_OS"));

            query = GeneralHelpers.ReplaceValuesInFile(query, "{DESCRICAO_PROJETO}", JsonBuilder.GetAppSettings("DESCRICAO_PROJETO"));

            return query;
        }

        private static string GetQueryInsertTableLembrete()
        {
            string queryFile = GeneralHelpers.GetProjectPath() + @"Queries/queryInsertTableLembrete.sql";

            string query = GeneralHelpers.ReadValueInFile(queryFile);

            query = GeneralHelpers.ReplaceValuesInFile(query, "{table}", tableLembrete);

            query = GeneralHelpers.ReplaceValuesInFile(query, "{IdTable}", GetLastIdTable(tableLembrete));

            query = GeneralHelpers.ReplaceValuesInFile(query, "{IdTableTarefaProjeto}", GetLastIdTable(tableTarefaProjeto));

            query = GeneralHelpers.ReplaceValuesInFile(query, "{IdTableLembreteProjeto}", GetLastIdTable(tableLembreteProjeto));

            return query;
        }

        private static string GetQueryInsertTableLembreteProjeto()
        {
            string queryFile = GeneralHelpers.GetProjectPath() + @"Queries/queryInsertTableLembreteProjeto.sql";

            string query = GeneralHelpers.ReadValueInFile(queryFile);

            query = GeneralHelpers.ReplaceValuesInFile(query, "{table}", tableLembreteProjeto);

            query = GeneralHelpers.ReplaceValuesInFile(query, "{IdTable}", GetLastIdTable(tableLembreteProjeto));

            return query;
        }

        private static string GetQueryInsertVersaoProjeto()
        {
            string queryFile = GeneralHelpers.GetProjectPath() + @"Queries/queryInsertVersaoProjeto.sql";

            string query = GeneralHelpers.ReadValueInFile(queryFile);

            query = GeneralHelpers.ReplaceValuesInFile(query, "{table}", tableVersaoProjeto);

            query = GeneralHelpers.ReplaceValuesInFile(query, "{IdTable}", GetLastIdTable(tableVersaoProjeto));

            return query;
        }

        private static List<string> listAllQueryInsert()
        {
            List<string> listAllQuery = new List<string>();

            listAllQuery.Add(GetQueryInsertProjeto());
            listAllQuery.Add(GetQueryInsertCategoriaProjeto());
            listAllQuery.Add(GetQueryInsertMarcadorProjeto());
            listAllQuery.Add(GetQueryInsertCampoPersonalizadoProjeto());
            listAllQuery.Add(GetQueryInsertPerfilGlobal());
            listAllQuery.Add(GetQueryInsertTableLembrete());
            listAllQuery.Add(GetQueryInsertTableLembreteProjeto());
            listAllQuery.Add(GetQueryInsertVersaoProjeto());

            return listAllQuery;
        }
        private static List<string> listAllQueryDelete()
        {
            List<string> listQuery = new List<string>();

            listQuery.Add(tableVersaoProjeto);
            listQuery.Add(tableLembreteProjeto);
            listQuery.Add(tableLembrete);
            listQuery.Add(tableTarefaProjeto);
            listQuery.Add(tablePerfilGlobal);
            listQuery.Add(tableCampoPersonalizadoProjeto);
            listQuery.Add(tableMarcadorProjeto);
            listQuery.Add(tableCategoriaProjeto);
            listQuery.Add(tableProjeto);
         
            return listQuery;
        }

        private static string GetLastIdTable(string table)
        {
            string queryFile = GeneralHelpers.GetProjectPath() + @"Queries/GetLastIdTable.sql";

            string query = GeneralHelpers.ReplaceValueInFile(queryFile, "{table}", table);

            return DataBaseHelpers.ExecuteQueryDBWithReturnString(query);
        }        
        
        public static string GetIdMassaTable(string table)
        {
            string queryFile = GeneralHelpers.GetProjectPath() + @"Queries/GetIdMassaTable.sql";

            string query = GeneralHelpers.ReplaceValueInFile(queryFile, "{table}", table);

            return DataBaseHelpers.ExecuteQueryDBWithReturnString(query);
        }

        public static void DeletarMassaDB()
        {
            var listAll = listAllQueryDelete();

            string queryFile = GeneralHelpers.GetProjectPath() + @"Queries/DeleteMassa.sql";

            string query;

            foreach (string table in listAll)
            {
                query = GeneralHelpers.ReplaceValueInFile(queryFile, "{table}", table);

                DataBaseHelpers.ExecuteQueryDB(query);
            }
        }

        public static bool ValidarExclusaoBD(string table, string field, string value)
        {
            string queryFile = GeneralHelpers.GetProjectPath() + @"Queries/ValidarExclusaoValue.sql";

            string query = GeneralHelpers.ReadValueInFile(queryFile);

            query = GeneralHelpers.ReplaceValuesInFile(query, "{table}", table);

            query = GeneralHelpers.ReplaceValuesInFile(query, "{field}", field);

            query = GeneralHelpers.ReplaceValuesInFile(query, "{value}", value);

            if (DataBaseHelpers.ExecuteQueryDBWithReturnBool(query))
                return false;
            else
                return true;
        }        
        public static bool ValidarInclusaoAlteracaoBD(string table, string field, string value)
        {
            string queryFile = GeneralHelpers.GetProjectPath() + @"Queries/ValidarInclusaoAlteracaoValue.sql";

            string query = GeneralHelpers.ReadValueInFile(queryFile);

            query = GeneralHelpers.ReplaceValuesInFile(query, "{table}", table);

            query = GeneralHelpers.ReplaceValuesInFile(query, "{field}", field);

            query = GeneralHelpers.ReplaceValuesInFile(query, "{value}", value);

            return DataBaseHelpers.ExecuteQueryDBWithReturnBool(query);

        }

        public static void InserirMassaDB()
        {
            DeletarMassaDB();

            var listAll = listAllQueryInsert();

            foreach (string query in listAll)
            {
                DataBaseHelpers.ExecuteQueryDB(query);
            }
        }
    }
}
