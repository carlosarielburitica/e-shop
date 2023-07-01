using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_store.DataAccess.Repository.IRepository
{
    public interface IWorkUnit : IDisposable
    {
        IWarehouseRepository Warehouse { get; }
        Task Save();
    }
}
