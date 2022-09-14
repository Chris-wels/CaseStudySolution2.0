using System;
using System.Collections.Generic;

namespace CaseStudySolution2._0.Models.DB
{
    public partial class CarFeature
    {
        public int CarFeatureId { get; set; }
        public int CarId { get; set; }
        public int FeatureId { get; set; }

        public virtual Car Car { get; set; } = null!;
        public virtual Feature Feature { get; set; } = null!;
    }
}
