﻿using AutoMapper;
using eRent.Models;
using eRent.Models.Requests.Rezervacija;
using eRent.Models.Search_Objects;
using eRent.Services.DataDB;

namespace eRent.Services.Rezervacija
{
    public class RezervacijaService : BaseCRUDService<RezervacijaModel, DataDB.Rezervacija, RezervacijaSearchObject, RezervacijaInsertRequest, RezervacijaUpdateRequest>, IRezervacijaService
    {
        public RezervacijaService(ERentContext eRentContext, IMapper mapper) : base(eRentContext, mapper)
        {
        }
        public override IQueryable<DataDB.Rezervacija> AddFilter(IQueryable<DataDB.Rezervacija> query, RezervacijaSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);
            if (search?.NekretninaId != null)
            {
                filteredQuery = filteredQuery.Where(x => x.NekretninaId == search.NekretninaId);
            }
            if (search?.DatumKraja != null)
            {
                filteredQuery = filteredQuery.Where(x => x.DatumKraja.Value <= search.DatumKraja.Value);
            }
            if (search?.DatumPocetka != null)
            {
                filteredQuery = filteredQuery.Where(x => x.DatumPocetka.Value >= search.DatumPocetka.Value);
            }
            if (search?.Odobrena != null)
            {
                filteredQuery = filteredQuery.Where(x=>x.Odobrena == search.Odobrena);
            }
            return filteredQuery;
        }

        public override void BeforeInsert(RezervacijaInsertRequest insert, DataDB.Rezervacija entity)
        {
            entity.Nazivnekretnine =
                Context.Nekretninas.Where(x => x.NekretninaId == insert.NekretninaId).Select(x => x.NazivNekretnine).FirstOrDefault();
            entity.Odobrena = false;
            base.BeforeInsert(insert, entity);
        }
    }
}