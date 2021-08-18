﻿using Persistencia.Contexts;
using Modelo.Cadastros;
using System.Linq;
using System.Data.Entity;

namespace Persistencia.DAL.Cadastros
{
    public class FabricanteDAL
    {
        private EFContext context = new EFContext();
        public IQueryable<Fabricante> ObterFabricantesClassificadosPorNome()
        {
            return context.Fabricantes.OrderBy(b => b.Nome);
        }

        public Fabricante ObterFabricantePorId(long id)
        {
            return context.Fabricantes.Where(f => f.FabricanteID == id).First();
        }
        public void GravarFabricante(Fabricante fabricante)
        {
            if (fabricante.FabricanteID == 0)
            {
                context.Fabricantes.Add(fabricante);
            }
            else
            {
                context.Entry(fabricante).State = EntityState.Modified;
            }
            context.SaveChanges();
        }
        public Fabricante EliminarFabricantePorId(long id)
        {
            Fabricante fabricante = ObterFabricantePorId(id);
            context.Fabricantes.Remove(fabricante);
            context.SaveChanges();
            return fabricante;
        }
    }
}