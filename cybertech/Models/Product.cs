namespace cybertech.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public int ProductID { get; set; }

        public int AssecID { get; set; }

        [Required]
        [StringLength(150)]
        public string ProductName { get; set; }

        [Required]
        [StringLength(500)]
        public string ProductDesc { get; set; }

        public decimal Price { get; set; }

        public virtual CompAssec CompAssec { get; set; }
    }
}
