using System;
using System.Collections.Generic;

namespace CaseStudySolution2._0.Models.DB
{
    public partial class Customer
    {
        public Customer()
        {
            Sales = new HashSet<Sale>();
        }

        public int CustomerId { get; set; }
        public string LicenceNumber { get; set; } = null!;
        public int Age { get; set; }
        public DateTime LicenceExpiryDate { get; set; }

        public virtual Person CustomerNavigation { get; set; } = null!;
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
