using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.interfaces
{
    internal interface ISqlFileOperations
    {
        // Wykonaj skrypt SQL z pliku
        void ExecuteSqlScript(string connectionString);

        // Zrób kopię zapasową bazy danych do pliku
        void BackupDatabase(string connectionString, string backupDirectory);

        // Przywróć bazę danych z pliku kopii zapasowej
        void RestoreDatabase(string connectionString, string backupFilePath);

        // Eksportuj wybrane tabele do plików CSV
        void ExportTablesToCsv(string connectionString, List<string> tableNames, string exportDirectory);

        // Importuj dane z pliku CSV do tabeli
        void ImportCsvToTable(string connectionString, string tableName, string csvFilePath);

        // Sprawdź integralność bazy danych
        void CheckDatabaseIntegrity(string connectionString);

        // Zaktualizuj schemat bazy danych na podstawie skryptu
        void UpdateDatabaseSchema(string connectionString, string schemaFilePath);



    }
}
