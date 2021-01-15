using Entities;
using System.Collections.Generic;
using DataAccess;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace Bussines
{
    public class B_Storage
    {
        public static List<StorageEntity> StorageList()
        {
            using (var db = new InventaryContext())
            {
                return db.Storages.ToList();
            }
        }

        public static List<StorageEntity> StorageByWarehouseList(string idWarehouse)
        {
            using (var db = new InventaryContext())
            {
                return db.Storages
                    .Include(s => s.Product)
                    .Include(s => s.Warehouse)
                    .Where(c => c.WarehouseId == idWarehouse)
                    .ToList();
            }
        }

        public static void CreateStorage(StorageEntity oStorage)
        {
            using (var db = new InventaryContext())
            {
                db.Storages.Add(oStorage);
                db.SaveChanges();
            }
        }
        public static bool IsStorageInWarehouse(string idStorage)
        {
            using (var db = new InventaryContext())
            {
                var product = db.Storages.ToList().Where(s => s.StorageId == idStorage);
                return product.Any();
            }
        }
        public static void UpdateStorage(StorageEntity oStorage)
        {
            using (var db = new InventaryContext())
            {
                db.Storages.Update(oStorage);
                db.SaveChanges();
            }
        }

        public static StorageEntity StorageById(string Id)
        {
            using (var db = new InventaryContext())
            {
                return db.Storages.ToList().LastOrDefault(p => p.StorageId == Id);
            }
        }
    }
}
