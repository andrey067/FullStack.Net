﻿using Microsoft.EntityFrameworkCore;
using ProEventos.Domain.Entities;
using ProEventos.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEventos.Persistence.Repository
{
    public class EventoRepository : BaseRepository<Evento>, IEventoRepository
    {
        private readonly DataContext _context;
        private readonly DbSet<Evento> _eventoContext;
        public EventoRepository(DataContext context) : base(context)
        {
            _context = context;
            _eventoContext = context.Set<Evento>();
        }

        public void Add(Evento evento)
        {
            _eventoContext.Add(evento);
        }

        public void Delete(Evento evento)
        {
            _eventoContext.Remove(evento);
        }

        public async Task<Evento[]> GetAllEventosAsync(string tema, bool includePalestrante = false)
        {
            IQueryable<Evento> query = _eventoContext
                                    .Include(e => e.Lotes)
                                    .Include(e => e.RedeSociais);

            if (includePalestrante)
            {
                query = query
                .Include(e => e.PalestrantesEventos)
                .ThenInclude(pe => pe.Palestrante);
            }

            query = query.OrderBy(e => e.Id)
                         .Where(ev => ev.Tema.ToLower().Contains(tema.ToLower()));

            return await query.ToArrayAsync();
        }

        public async Task<Evento> GetAllEventosByIdAsync(int EventoId, bool includePalestrante)
        {
            IQueryable<Evento> query = _eventoContext
                                    .Include(e => e.Lotes)
                                    .Include(e => e.RedeSociais);

            if (includePalestrante)
            {
                query = query
                .Include(e => e.PalestrantesEventos)
                .ThenInclude(pe => pe.Palestrante);
            }

            query = query.OrderBy(e => e.Id)
                         .Where(ev => ev.Id == EventoId);

            return await query.FirstOrDefaultAsync();
        }

        public Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrante)
        {
            throw new NotImplementedException();
        }

        public void Update(Evento evento)
        {
            _eventoContext.Update(evento);
        }
    }
}
