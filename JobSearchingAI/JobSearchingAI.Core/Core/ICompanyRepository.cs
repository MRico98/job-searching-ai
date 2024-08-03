using JobSearchingAI.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JobSearchingAI.Core.Core
{
    public interface ICompanyRepository
    {
        Task Add(Company company);
        Task<Company?> GetById(int Id);
        Task<IEnumerable<Company>> GetAll();
        Task<IEnumerable<Company>> Find(Expression<Func<Company, bool>> predicate);
        Task Update(Company company);
        Task Delete(Company company);
    }
}
