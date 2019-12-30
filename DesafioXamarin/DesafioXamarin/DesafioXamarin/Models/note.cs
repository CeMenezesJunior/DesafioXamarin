using System;
using SQLite;

namespace Notes.Models
{
    [Table("Estados")]
    public class Note
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public string Capital { get; set; }
        public string Regiao { get; set; }
        public DateTime Date { get; set; }
    }
}