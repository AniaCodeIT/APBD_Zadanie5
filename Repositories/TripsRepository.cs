using System.Runtime.CompilerServices;
using Zadanie7.DTOs;
using Zadanie7.Interfaces;
using Zadanie7.Models;
using Zadanie7.Models.DTO;

namespace Zadanie7.Repositories
{
    public class TripsRepositories : ITripsRepository
    {
        private readonly S25630Context _context;
        public TripsRepositories(S25630Context _context)
        {
            this._context = _context;
        }

        public async Task<IEnumerable<TripDTO>> GetTripsAsync()
        {
            var result = _context
                .Trips
                .Select(e =>
                new TripDTO
                {
                    Name = e.Name,
                    Description = e.Description
                    DateFrom = DateOnly.FromDateTime(e.DateFrom),
                    DateTo = DateOnly.FromDateTimee(e.DateTo),
                    MaxPeople = e.MaxPeople,
                    Countries = e.IdCountries
                    .Select(e => new CountryDTO { Name = e.Name }),
                    Clients = e.Clients

                })


        }
    }
}