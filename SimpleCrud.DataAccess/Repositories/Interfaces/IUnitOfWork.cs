using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrud.DataAccess.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        public IProductRepository Products { get; }
        int Commit();
        Task<int> CommitAsync();
    }
}
