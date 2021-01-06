using Entities;
using System.Collections.Generic;
using DataAccess;
using System.Linq;

namespace Bussines
{
    public class B_InputOutput
    {
        public static List<InputOutputEntity> InputOutputList()
        {
            using (var db = new InventaryContext())
            {
                return db.InOuts.ToList();
            }
        }

        public static void CreateInputOutput(InputOutputEntity oInputOutput)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Add(oInputOutput);
                db.SaveChanges();
            }
        }

        public static void UpdateInputOutput(InputOutputEntity oInputOutput)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Update(oInputOutput);
                db.SaveChanges();
            }
        }

        public static InputOutputEntity InOutById(string Id)
        {
            using (var db = new InventaryContext())
            {
                return db.InOuts.ToList().LastOrDefault(p => p.InOutId == Id);
            }
        }
    }
}
