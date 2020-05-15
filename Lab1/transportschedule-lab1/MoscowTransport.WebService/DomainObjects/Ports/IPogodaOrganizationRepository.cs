using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Pogoda.DomainObjects.Ports
{
    public interface IReadOnlyPrognozRepository
    {
        Task<Prognoz> GetPrognoz(long id);

        Task<IEnumerable<Prognoz>> GetAllPrognozs();

        Task<IEnumerable<Prognoz>> QueryPrognozs(ICriteria<Prognoz> criteria);
    }

    public interface IPrognozRepository
    {
        Task AddPrognoz(Prognoz prognoz);

        Task UpdatePrognoz(Prognoz prognoz);

        Task RemovePrognoz(Prognoz prognoz);
    }
}
