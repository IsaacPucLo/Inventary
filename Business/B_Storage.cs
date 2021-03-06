using System;
using Entities;
using DataAccess;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Business {
    public class B_Storage {//ES UN CRUD

        //LEER DATOS
        public static List<StorageEntity> StorageList() {
            using(var db = new InventaryContext()) {
                return db.Storages.ToList();
            }
        }

        //CREAR DATOS
        public static void CreateStorage (StorageEntity oStorage) {
            using (var db = new InventaryContext()) {
                db.Storages.Add(oStorage);
                db.SaveChanges();
            }
        }

        /* NUEVO MÉTODO */
        public static StorageEntity GetStorageById(string id) {
            using (var db = new InventaryContext()) {
                return db.Storages
                    .Include(s => s.Product)
                    .Include(s => s.Warehouse)
                    .ToList()
                    .LastOrDefault(s => s.StorageId == id);
            }
        }

        /* NUEVO MÉTODO */
        public static bool IsProductInWarehouse(string StorageId) {
            using (var db = new InventaryContext()) {
                var product = db.Storages.ToList()
                    .Where(p => p.StorageId == StorageId);

                return product.Any();
            }
        }

        /* NUEVO MÉTODO */
        public static List<StorageEntity> StorageProductByWarehouse(string idWarehouse) {
            using (var db = new InventaryContext()) {
                return db.Storages
                    .Include(s => s.Product)
                    .Include(s => s.Warehouse)
                    .Where(s => s.WarehouseId == idWarehouse)
                    .ToList();
            }
        }


        //EDITAR DATOS
        public static void UpdateStorage (StorageEntity oStorage) {
            using (var db = new InventaryContext()) {
                db.Storages.Update(oStorage);
                db.SaveChanges();
            }
        }
    }
}
