﻿using System;
using Entities;
using DataAccess;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business {
    public class B_Storage {//ES UN CRUD

        //LEER DATOS
        public List<StorageEntity> StorageList() {
            using(var db = new InventaryContext()) {
                return db.Storages.ToList();
            }
        }

        //CREAR DATOS
        public void CreateStorage (StorageEntity oStorage) {
            using (var db = new InventaryContext()) {
                db.Storages.Add(oStorage);
                db.SaveChanges();
            }
        }

        //EDITAR DATOS
        public void UpdateStorage (StorageEntity oStorage) {
            using (var db = new InventaryContext()) {
                db.Storages.Update(oStorage);
                db.SaveChanges();
            }
        }
    }
}