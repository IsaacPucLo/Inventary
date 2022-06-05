using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities {
    public class CategoryEntity {       //Agruegar public sino aparece en un principio
        
        [Key]
        [StringLength(50)]
        public string CategoryId { get; set; }

        [Required]
        [StringLength(100)]
        public string CategoryName { get; set; }

        //Se establece la relacion de uno a muchos
        //Esta entidad puede contener muchos PRODUCTOS
        //(Mirar la relación en la clase ProductEntity)
        public ICollection<ProductEntity> Products { get; set; }

    }
}
