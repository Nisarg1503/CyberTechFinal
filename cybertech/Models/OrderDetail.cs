namespace cybertech.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderDetail")]
    public partial class OrderDetail
    {
        public virtual int OrderDetailId { get; set; }

        public virtual int OrderId { get; set; }

        public virtual int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public virtual int Quantity { get; set; }

        [Column(TypeName = "numeric")]
        public virtual decimal UnitPrice { get; set; }

    }
}
