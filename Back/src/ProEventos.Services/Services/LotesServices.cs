using AutoMapper;
using ProEventos.Domain.Entities;
using ProEventos.Domain.Interfaces.Repositories;
using ProEventos.Services.Dtos;
using ProEventos.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProEventos.Services.Services
{
    public class LotesServices : ILotesService
    {
        private readonly IMapper _mapper;
        private readonly ILotesRepository _lotesRepository;

        public LotesServices(IMapper mapper, ILotesRepository lotesRepository)
        {
            _mapper = mapper;
            _lotesRepository = lotesRepository;
        }

        public async Task AddLote(int eventoId, LoteDto model)
        {
            try
            {
                var lote = _mapper.Map<Lote>(model);
                lote.Evento.Id = eventoId;

                await _lotesRepository.InsertAsync(lote);

                await _lotesRepository.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> DeleteLote(int eventoId, int loteId)
        {
            try
            {
                var lote = await _lotesRepository.GetLoteByIdsAsync(eventoId, loteId);
                if (lote == null) throw new Exception("Lote para delete não encontrado.");

                await _lotesRepository.DeleteAsync(lote.Id);
                return await _lotesRepository.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<LoteDto> GetLoteByIdsAsync(int eventoId, int loteId)
        {
            try
            {
                var lote = await _lotesRepository.GetLoteByIdsAsync(eventoId, loteId);
                if (lote == null) return null;

                var resultado = _mapper.Map<LoteDto>(lote);

                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<LoteDto>> GetLotesByEventoIdAsync(int eventoId)
        {
            try
            {
                var lotes = await _lotesRepository.GetLotesByEventoIdAsync(eventoId);
                if (lotes == null) return null;

                var resultado = _mapper.Map<List<LoteDto>>(lotes);

                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<LoteDto>> SaveLotes(int eventoId, List<LoteDto> models)
        {
            try
            {
                var lotes = await _lotesRepository.GetLotesByEventoIdAsync(eventoId);
                if (lotes == null) return null;

                foreach (var model in models)
                {
                    if (model.Id == 0)
                    {
                        await AddLote(eventoId, model);
                    }
                    else
                    {
                        var lote = lotes.FirstOrDefault(lote => lote.Id == model.Id);
                        model.EventoId = eventoId;

                        _mapper.Map(model, lote);

                        await _lotesRepository.UpdateAsync(lote);

                        await _lotesRepository.SaveChangesAsync();
                    }
                }

                var loteRetorno = await _lotesRepository.GetLotesByEventoIdAsync(eventoId);

                return _mapper.Map<List<LoteDto>>(loteRetorno);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
