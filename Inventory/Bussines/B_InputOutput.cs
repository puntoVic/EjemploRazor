using Entities;
using System.Collections.Generic;
using DataAccess;
using System.Linq;

namespace Bussines
{
    public class B_InputOutput
    {
        public List<InputOutputEntity> InputOutputList()
        {
            using (var db = new InventaryContext())
            {
                return db.InOuts.ToList();
            }
        }

        public void CreateInputOutput(InputOutputEntity oInputOutput)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Add(oInputOutput);
                db.SaveChanges();
            }
        }

        public void UpdateInputOutput(InputOutputEntity oInputOutput)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Update(oInputOutput);
                db.SaveChanges();
            }
        }
    }
}
