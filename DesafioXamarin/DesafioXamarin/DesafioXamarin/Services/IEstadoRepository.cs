using Notes.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioXamarin.Services
{
    public interface IEstadoRepository
    {
        List<Note> GetAllEstadosData();
        void InsertEstado(Note estado);
    }
}
