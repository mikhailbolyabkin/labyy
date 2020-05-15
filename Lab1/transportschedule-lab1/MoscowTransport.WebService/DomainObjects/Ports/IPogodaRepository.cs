using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Pogoda.DomainObjects.Ports
{
    public interface IReadOnlyPogodaRepository
    {
        Task<Pogoda> GetPogoda(long id);

        Task<IEnumerable<Pogoda>> GetAllPogoda();

        Task<IEnumerable<Pogoda>> QueryPogoda(ICriteria<Pogoda> criteria);

    }

    public interface IPogodaRepository
    {
        Task AddPogoda(Pogoda pogoda);

        Task RemovePogoda(Pogoda pogoda);

        Task UpdatePogoda(Pogoda pogoda);
    }
}
