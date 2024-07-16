using Entities.Models;
using Repositories.Contracts;

namespace Repositories
{
    internal class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext context) : base(context)
        {

        }

        public IQueryable<Product> GetAllProducts(bool trackChanges) => FindAll(trackChanges);

    }
}
