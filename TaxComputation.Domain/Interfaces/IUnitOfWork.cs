using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TaxComputation.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        public ICompanyRepository? Company { get; }
        public IProductRepository? Product { get; }
        public Task SaveChangesAsync();
    }
}
