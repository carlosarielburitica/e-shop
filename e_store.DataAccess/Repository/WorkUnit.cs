using e_store.DataAccess.Data;
using e_store.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_store.DataAccess.Repository
{
    public class WorkUnit : IWorkUnit
    {
        private readonly ApplicationDbContext _db;
        public IWarehouseRepository Warehouse { get; private set; }
        public WorkUnit(ApplicationDbContext db)
        {
            _db = db;
            Warehouse = new WarehouseRepository(_db);
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public async Task Save()
        {
            await _db.SaveChangesAsync();
        }
    }
}
