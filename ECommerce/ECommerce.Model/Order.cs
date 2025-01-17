﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Model
{
    [Table("Order", Schema = "dbo")]
    public class Order
    {
        public int Id { get; set; }
        public string EcommerceAdminUserId { get; set; }
        public virtual ECommerceAdminUser ECommerceAdminUser { get; set; }
        public int? Total { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }

    }

}
