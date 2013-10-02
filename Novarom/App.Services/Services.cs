using System;
using System.Collections.Generic;
using System.Linq;
using App.DataAccess.Model;
using App.Domain.Entities;

namespace App.Services
{
    public class Services : IServices, IDisposable
    {
        private readonly ModelEntitiesContainer context;

        public Services()
        {
            context = new ModelEntitiesContainer();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<Abogados> GetAllAbogados()
        {
            var list = new List<Abogados>();

            list = context.Abogados.ToList();

            return list;
        }

        public bool DeleteAbogados(int id)
        {
            Abogados abogados = (from a in context.Abogados where a.IdAbogado == id select a).FirstOrDefault();
            context.Abogados.Remove(abogados);
            context.SaveChanges();

            return true;
        }

        public bool ActualizarAbogados(Abogados data)
        {
            Abogados abogados =
                (from a in context.Abogados where a.IdAbogado == data.IdAbogado select a).FirstOrDefault();
            context.Abogados.Add(abogados);
            context.SaveChanges();

            return true;
        }

        public int GuardaAbogados(Abogados data)
        {
            using (var container = new ModelEntitiesContainer())
            {
                container.Abogados.Add(data);
                container.SaveChanges();
            }
            return data.IdAbogado;
        }
    }
}