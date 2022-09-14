using System;
using System.Collections.Generic;

namespace CaseStudySolution2._0.Models.DB
{
    public partial class Feature
    {
        public Feature()
        {
            CarFeatures = new HashSet<CarFeature>();
        }

        public int FeatureId { get; set; }
        public string Feature1 { get; set; } = null!;
        public string? Note { get; set; }

        public virtual ICollection<CarFeature> CarFeatures { get; set; }
    }
}
