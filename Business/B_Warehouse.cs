using Entities;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Business {
    public class B_Warehouse { //ES UN CRUD

        //LEER DATOS
        public static List<WarehouseEntity> WarehouseList() {
            using (var db = new InventaryContext()) {
                return db.Warehouses.ToList();
            }
        }

        //CREAR DATOS
        public static void CreateWarehouse(WarehouseEntity oWarehouse) {
            using (var db = new InventaryContext()) {
                db.Warehouses.Add(oWarehouse);
                db.SaveChanges();
            }
        }

        //EDITAR DATOS
        public static void UpdateWarehouse(WarehouseEntity oWarehouse) {
            using (var db = new InventaryContext()) {
                db.Warehouses.Update(oWarehouse);
                db.SaveChanges();
            }
        }
    }
}
