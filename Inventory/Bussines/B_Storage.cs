using Entities;
using System.Collections.Generic;
using DataAccess;
using System.Linq;


namespace Bussines
{
    public class B_Storage
    {
        public static  List<StorageEntity> StorageList()
        {
            using (var db = new InventaryContext())
            {
                return db.Storages.ToList();
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
