using System;
using System.Collections.Generic;
using System.Text;

using TaxComputation.Domain.Entities;

namespace TaxComputation.Domain.Interfaces
{
    public interface IProductRepository : IGenericRepository<Product>
    {
    }
}
