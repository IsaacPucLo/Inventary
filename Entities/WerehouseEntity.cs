﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities {
    class WerehouseEntity {
        [Key]
        [StringLength(50)]
        public int WarehouseId { get; set; }

        [Required]
        [StringLength(100)]
        public string WarehouseName { get; set; }
        
        [StringLength(150)]
        public string WarehouseAddress { get; set; }
    }
}