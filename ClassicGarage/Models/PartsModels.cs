using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassicGarage.Models
{
    public class PartsModels
    {
        public int ID { get; set; }

        public int CarId { get; set; }

        public string Name { get; set; }

        public int CatalogNo { get; set; }

        public double PurchaseAmount { get; set; }

        public double SalesAmount { get; set; }

        public DateTime PurchaseDate { get; set; }

        public DateTime SalesDate { get; set; }


        public virtual CarModels Car { get; set; }

    }
}