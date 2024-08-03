using JobSearchingAI.Core.Core;
using JobSearchingAI.Core.Entities;
using JobSearchingAI.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JobSearchingAI.Infraestructure.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly ApplicationDbContext _context;

        public CompanyRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        async Task ICompanyRepository.Add(Company company)
        {
            await _context.Companies.AddAsync(company);
            await _context.SaveChangesAsync();
        }

        async Task ICompanyRepository.Delete(Company company)
        {
            _context.Companies.Remove(company);
            await _context.SaveChangesAsync();
        }

        async Task<IEnumerable<Company>> ICompanyRepository.Find(Expression<Func<Company, bool>> predicate)
        {
            return await _context.Companies.Where(predicate).ToListAsync();
        }

        async Task<IEnumerable<Company>> ICompanyRepository.GetAll()
        {
            return await _context.Companies.ToListAsync();
        }

        async Task<Company?> ICompanyRepository.GetById(int Id)
        {
            return await _context.Companies.FindAsync(Id);
        }

        Task ICompanyRepository.Update(Company company)
        {
            throw new NotImplementedException();
        }
    }
}
