using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities {
    public class CategoryEntity {       //Agruegar public sino aparece en un principio
        
        [Key]
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
