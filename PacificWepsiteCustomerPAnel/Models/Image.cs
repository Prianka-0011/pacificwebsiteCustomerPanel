using System;
using System.Collections.Generic;

namespace PacificWepsiteCustomerPAnel.Models
{
    public partial class Image
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
