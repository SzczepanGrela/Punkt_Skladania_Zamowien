using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.interfaces;

namespace WindowsFormsApp1.classes.FileOperations
{
    internal class SqlFileOperations : BasicFileOperations, ISqlFileOperations
    {
        public SqlFileOperations()
        {

        }

        public SqlFileOperations(string filePath) : base(filePath, "sql")
        {

        }

        public void ExecuteSqlScript(string connectionString)
        {

        }

        public void BackupDatabase(string connectionString, string backupDirectory)
        {

        }

        public void RestoreDatabase(string connectionString, string backupFilePath)
        {

        }

        public void ExportTablesToCsv(string connectionString, List<string> tableNames, string exportDirectory)
        {

        }

        public void ImportCsvToTable(string connectionString, string tableName, string csvFilePath)
        {

        }

        public void CheckDatabaseIntegrity(string connectionString)
        {

        }

        public void UpdateDatabaseSchema(string connectionString, string schemaFilePath)
        { 

        }


    }


}

