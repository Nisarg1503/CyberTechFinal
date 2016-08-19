namespace cybertech.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cart")]
    public partial class Cart
    {
        [Key]
        public virtual int RecordId { get; set; }

        [Required]
        [StringLength(50)]
        public virtual string CartId { get; set; }

        public virtual int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public virtual int Count { get; set; }

        public virtual DateTime DateCreated { get; set; }
        

    }
}
