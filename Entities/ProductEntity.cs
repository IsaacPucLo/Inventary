using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities {
    public class ProductEntity {
        [Key]
        [StringLength(10)]
        public string ProductId { get; set; }

        [Required]
        [StringLength(100)]
        public string ProductName { get; set; }

        [StringLength(600)]
        public string ProductDescription { get; set; }

        public int TotalQuantity { get; set; }

        //Con estas siguientes dos propiedades defnimos la relación
        //En este caso un producto solo puede pertenecer a una CATEGORÍA
        //(Mirar la otra parte de la relación en la clase CategoryEntity)
        public string CategoryId { get; set; }
        public CategoryEntity Category { get; set; }

        public ICollection<StorageEntity> Storages { get; set; } //Relacion N-1 con StorageEntity
    }
}
