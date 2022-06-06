using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business {
    public class B_InOut {//ES UN CRUD

        //LEER DATOS
        public static List<InOutEntity> InOutList() {
            using (var db = new InventaryContext()) {
                return db.InOuts.ToList();
            }
        }

        //CREAR DATOS
        public static void CreateInOut(InOutEntity oInOut) {
            using (var db = new InventaryContext()) {
                db.InOuts.Add(oInOut);
                db.SaveChanges();
            }
        }

        //EDITAR DATOS
        public static void UpdateInOut(InOutEntity oInOut) {
            using (var db = new InventaryContext()) {
                db.InOuts.Update(oInOut);
                db.SaveChanges();
            }
        }
    }
}
