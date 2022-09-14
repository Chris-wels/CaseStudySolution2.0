using System;
using System.Collections.Generic;

namespace CaseStudySolution2._0.Models.DB
{
    public partial class Sale
    {
        public int SaleId { get; set; }
        public int? CustomerId { get; set; }
        public int? CarId { get; set; }
        public DateTime? Date { get; set; }

        public virtual Car? Car { get; set; }
        public virtual Customer? Customer { get; set; }
    }
}
