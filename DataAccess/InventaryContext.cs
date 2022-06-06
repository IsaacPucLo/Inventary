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

        protected override void OnConfiguring(DbContextOptionsBuilder options) {
            if (!options.IsConfigured) {
                //options.UseSqlServer("Server=USER-PC; Database=InventaryDb; User Id=User-PC\\User; Password=");
                
                //Usé esta linea de codigo debido a que mi base de datos no tiene contraseña
                options.UseSqlServer("Server=USER-PC ;Database=InventaryDB; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { CategoryId = "ASH", CategoryName = "Aseo Hogar" },
                new CategoryEntity { CategoryId = "ASP", CategoryName = "Aseo Personal" },
                new CategoryEntity { CategoryId = "HGR", CategoryName = "Hogar" },
                new CategoryEntity { CategoryId = "PRF", CategoryName = "Perfumería" },
                new CategoryEntity { CategoryId = "SLD", CategoryName = "Salud" },
                new CategoryEntity { CategoryId = "VDJ", CategoryName = "Video Juegos" }
            );

            modelBuilder.Entity<WarehouseEntity>().HasData(
                new WarehouseEntity { WarehouseId = new Random().Next(0, 999), WarehouseName = "Bodega Central", WarehouseAddress = "Calle 8 con 23" },
                new WarehouseEntity { WarehouseId = new Random().Next(0,999), WarehouseName = "Bodega Norte", WarehouseAddress = "Calle norte con occidente" }
            );
        }
    }
}
