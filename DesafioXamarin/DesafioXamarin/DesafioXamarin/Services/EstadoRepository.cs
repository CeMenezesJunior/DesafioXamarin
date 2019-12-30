using DesafioXamarin.Helpers;
using Notes.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioXamarin.Services
{
    class EstadoRepository : IEstadoRepository
    {
        DatabaseHelper _databaseHelper;
        public EstadoRepository()
        {
            _databaseHelper = new DatabaseHelper();
        }
        public List<Note> GetAllEstadosData()
        {
           return _databaseHelper.GetAllEstadosData();
        }

        public void InsertEstado(Note estado)
        {
            _databaseHelper.InsertEstado(estado);
        }
    }
}
