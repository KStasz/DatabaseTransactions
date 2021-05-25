using DatabaseTransactions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseTransactions.Interfaces
{
    public interface IPeopleRepository
    {
        Task<List<People>> GetPeoples(People filter = null);
        Task<People> GetPeople(People filter);
        Task<bool> UpdatePeople(People item);
        Task<bool> AddPeople(People item);
        Task<bool> RemovePeople(People item);
        Task<bool> UpdateRange(IEnumerable<People> peoples);
        Task<bool> AddRange(IEnumerable<People> peoples);
        Task<bool> RemoveRange(IEnumerable<People> peoples);
    }
}
