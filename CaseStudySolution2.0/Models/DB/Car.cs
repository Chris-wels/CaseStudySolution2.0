using System;
using System.Collections.Generic;

namespace CaseStudySolution2._0.Models.DB
{
    public partial class Car
    {
        public Car()
        {
            CarFeatures = new HashSet<CarFeature>();
            Sales = new HashSet<Sale>();
        }

        public int CarId { get; set; }
        public string Colour { get; set; } = null!;
        public string CurrentMileage { get; set; } = null!;
        public DateTime DateImported { get; set; }
        public int ManufactureYear { get; set; }
        public string Transmission { get; set; } = null!;
        public string Status { get; set; } = null!;
        public string BodyType { get; set; } = null!;
        public int ModelId { get; set; }

        public virtual Model Model { get; set; } = null!;
        public virtual ICollection<CarFeature> CarFeatures { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
