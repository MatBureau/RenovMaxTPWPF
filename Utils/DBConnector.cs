using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Shapes;

namespace RenovMaxTP.Utils
{
    public class DBConnector
    {
        private string _connectionString;
        public static SqlConnection Connection { get; private set; }

        public DBConnector()
        {
            _connectionString = ReadConnectionStringFromConfig();
            SetCurrentDBConnection();
        }

        private string ReadConnectionStringFromConfig()
        {
            string filePath = "config.ini";
            var configManager = new ConfigManager(filePath);
            var configData = configManager.ReadConfig();
            
            if (!String.IsNullOrWhiteSpace(configData["ConnectionString"]))
            {
                return configData["ConnectionString"];
            }
            
            Console.WriteLine("Erreur : Fichier config.ini introuvable ou string de connexion absente.");
            return null;
        }

        public void SetCurrentDBConnection()
        {
            if (_connectionString != null)
            {
                string cs = _connectionString;
                Connection = new SqlConnection(_connectionString);
            }
            else
            {
                Console.WriteLine("Erreur : Pas de string de connexion dans le fichier.");
            }
        }

        public string ConnectionString => _connectionString;
    }
}
