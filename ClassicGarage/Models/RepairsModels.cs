using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassicGarage.Models
{
    public class RepairsModels
    {
        public int ID { get; set; }

        public int CarId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double RepairPrice { get; set; }

        public virtual CarModels Car { get; set; }


    }
}