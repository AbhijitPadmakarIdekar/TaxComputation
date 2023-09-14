using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TaxComputation.Domain.Entities;
using TaxComputation.Domain.Interfaces;
using TaxComputation.DataAccess.Repositories;

namespace TaxComputation.DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public ICompanyRepository? Company { get; private set; }
        public IProductRepository? Product { get; private set; }

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            Company = new CompanyRepository(_context);
            Product = new ProductRepository(_context);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
