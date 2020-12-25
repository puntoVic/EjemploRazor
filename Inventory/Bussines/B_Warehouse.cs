using Entities;
using System.Collections.Generic;
using DataAccess;
using System.Linq;


namespace Bussines
{
    public class B_Warehouse
    {
        public List<WarehouseEntity> WarehouseList()
        {
            using (var db = new InventaryContext())
            {
                return db.Warehouses.ToList();
            }
        }

        public void CreateWarehouse(WarehouseEntity oWarehouse)
        {
            using (var db = new InventaryContext())
            {
                db.Warehouses.Add(oWarehouse);
                db.SaveChanges();
            }
        }

        public void UpdateWarehouse(WarehouseEntity oWarehouse)
        {
            using (var db = new InventaryContext())
            {
                db.Warehouses.Update(oWarehouse);
                db.SaveChanges();
            }
        }
    }
}
