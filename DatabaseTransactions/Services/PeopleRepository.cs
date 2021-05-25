using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatabaseTransactions.Interfaces;
using DatabaseTransactions.Models;
using DatabaseTransactions.Data;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTransactions.Services
{
    public class PeopleRepository : IPeopleRepository
    {
        private readonly ApplicationContext _db;

        public PeopleRepository(ApplicationContext db)
        {
            _db = db;
        }

        public async Task<bool> AddPeople(People item)
        {
            try
            {
                await _db.Database.BeginTransactionAsync();
                _db.Peoples.Add(item);
                await _db.SaveChangesAsync();
                await _db.Database.CommitTransactionAsync();
                return true;
            }
            catch (Exception)
            {
                _db.Database.RollbackTransaction();
                return false;
            }
        }

        public async Task<bool> AddRange(IEnumerable<People> peoples)
        {
            try
            {
                await _db.Database.BeginTransactionAsync();
                await _db.Peoples.AddRangeAsync(peoples);
                await _db.SaveChangesAsync();
                await _db.Database.CommitTransactionAsync();
                return true;
            }
            catch (Exception)
            {
                await _db.Database.RollbackTransactionAsync();
                return false;
            }
        }

        public async Task<People> GetPeople(People filter)
        {
            return await _db.Peoples.FirstOrDefaultAsync(x => x.Id == filter.Id);
        }

        public async Task<List<People>> GetPeoples(People filter = null)
        {
            if (filter != null)
                return await _db.Peoples.Where(x => x.Name == filter.Name
                                                    || x.Surname == filter.Surname
                                                    || x.Town == filter.Town
                                                    || x.PostCode == filter.PostCode)
                                        .ToListAsync();
            else
                return await _db.Peoples.ToListAsync();
        }

        public async Task<bool> RemovePeople(People item)
        {
            try
            {
                await _db.Database.BeginTransactionAsync();
                _db.Peoples.Remove(item);
                await _db.SaveChangesAsync();
                await _db.Database.CommitTransactionAsync();
                return true;
            }
            catch (Exception)
            {
                await _db.Database.RollbackTransactionAsync();
                return false;
            }
        }

        public async Task<bool> RemoveRange(IEnumerable<People> peoples)
        {
            try
            {
                await _db.Database.BeginTransactionAsync();
                _db.Peoples.RemoveRange(peoples);
                await _db.SaveChangesAsync();
                await _db.Database.CommitTransactionAsync();
                return true;
            }
            catch (Exception)
            {
                await _db.Database.RollbackTransactionAsync();
                return false;
            }
        }

        public async Task<bool> UpdatePeople(People item)
        {
            try
            {
                await _db.Database.BeginTransactionAsync();
                _db.Peoples.Update(item);
                await _db.SaveChangesAsync();
                await _db.Database.CommitTransactionAsync();
                return true;
            }
            catch (Exception)
            {
                await _db.Database.RollbackTransactionAsync();
                return false;
            }
        }

        public async Task<bool> UpdateRange(IEnumerable<People> peoples)
        {
            try
            {
                await _db.Database.BeginTransactionAsync();
                _db.Peoples.UpdateRange(peoples);
                await _db.SaveChangesAsync();
                await _db.Database.CommitTransactionAsync();
                return true;
            }
            catch (Exception)
            {
                await _db.Database.RollbackTransactionAsync();
                return false;
            }
        }
    }
}
