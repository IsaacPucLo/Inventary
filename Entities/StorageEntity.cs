using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities {
    public class StorageEntity {

        [Key]
        [StringLength(50)]
        public string StorageId { get; set; }

        [Required]
        public DateTime LastUpdate { get; set; }
        
        [Required]
        public int PartialQuantity { get; set; }

        //RELACIONES CON OTRAS TABLAS O ENTIDADES
        public string ProductId { get; set; }           //Relacion 1-N con StorageEntity
        public ProductEntity Product { get; set; }

        public int WarehouseId { get; set; }
        public WerehouseEntity Warehouse { get; set; }

        public ICollection<InOutEntity> InOuts { get; set; }
    }
}
