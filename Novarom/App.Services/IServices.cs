using System.Collections.Generic;
using App.Domain.Entities;


namespace App.Services
{
    public interface IServices
    {
        IEnumerable<Abogados> GetAllAbogados();
        bool DeleteAbogados(int id );
        bool ActualizarAbogados(Abogados data);
        int GuardaAbogados(Abogados data);
    }
}