using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassicGarage.Models
{
    public class AdvertismentModels
    {
        public int ID { get; set; }

        public int CarId { get; set; }

        public bool Active { get; set; }

        public virtual CarModels Car { get; set; }

    }
}