using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess {
    public class InventaryContext : DbContext{
        
        //Definimos la creacion de nuestras tablas y como nombre es el como se va a nombrar la tabla en la base de datos
        //Construccion o asociacion a la base de datos
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<InOutEntity> InOuts { get; set; }
        public DbSet<WarehouseEntity> Warehouses { get; set; }
        public DbSet<StorageEntity> Storages { get; set; }

    }
}
