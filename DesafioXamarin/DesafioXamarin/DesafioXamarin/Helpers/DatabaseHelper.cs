using PCLExt.FileStorage;
using PCLExt.FileStorage.Folders;
using DesafioXamarin.Models;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using Notes.Models;

namespace DesafioXamarin.Helpers
{
    class DatabaseHelper
    {
        //defina uma conexao e o  nome do banco de dados
        static SQLiteConnection sqliteconnection;
        public const string DbFileName = "PedidosDB.db";
        public DatabaseHelper()
        {
            //cria uma pasta base local para o dispositivo
            var pasta = new LocalRootFolder();
            //cria o arquivo
            var arquivo = pasta.CreateFile(DbFileName, CreationCollisionOption.OpenIfExists);
            //abre o BD
            sqliteconnection = new SQLiteConnection(arquivo.Path);
            //cria a tabela no BD
            sqliteconnection.CreateTable<Note>();
        }
        //Pegar todos os dados  
        public List<Note> GetAllEstadosData()
        {
            return (from data in sqliteconnection.Table<Note>()
                    select data).ToList();
        }
       
        // Inserir dados
        public void InsertEstado(Note estado)
        {
            sqliteconnection.Insert(estado);
        }
        public void DeleteAllEstados()
        {
            sqliteconnection.DeleteAll<Note>();
        }
        

    }
}
    