using e_store.DataAccess.Data;
using e_store.DataAccess.Repository.IRepository;
using e_store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_store.DataAccess.Repository
{
    public class WarehouseRepository : Repository<Warehouse>, IWarehouseRepository
    {
        private readonly ApplicationDbContext _db;
        public WarehouseRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Warehouse warehouse)
        {
            var warehouseDB = _db.Warehouses.FirstOrDefault(b => b.Id == warehouse.Id);
            if (warehouseDB != null) 
            { 
                warehouseDB.Name = warehouse.Description;
                warehouseDB.Description =  warehouse.Name;
                warehouseDB.Status = warehouse.Status;
                _db.SaveChanges();
            }
        }
    }
}
