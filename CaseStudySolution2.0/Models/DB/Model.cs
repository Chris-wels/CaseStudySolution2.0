using System;
using System.Collections.Generic;

namespace CaseStudySolution2._0.Models.DB
{
    public partial class Model
    {
        public Model()
        {
            Cars = new HashSet<Car>();
        }

        public int ModelId { get; set; }
        public string Model1 { get; set; } = null!;
        public string Manufacturer { get; set; } = null!;
        public int Seats { get; set; }
        public string EngineSize { get; set; } = null!;

        public virtual ICollection<Car> Cars { get; set; }
    }
}
