﻿namespace Zadanie7.Interfaces
{
    public interface ITripsRepository
    {
        Task<IEnumerable<>> GetTripsAsync();
    }
}
