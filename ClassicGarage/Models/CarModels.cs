using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClassicGarage.Models
{
    public class CarModels
    {
        public int ID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        
        public int VIN { get; set; }
        [Required]
        public string Name { get; set; }
        public string Picture { get; set; }
        
        public DateTime PurchaseDate { get; set; }
        public double PurchaseAmount { get; set; }
        public DateTime SalesDate { get; set; }
        public double SalesAmount { get; set; }
        public int OwnerID { get; set; }


        public virtual OwnerModels Owner { get; set; }

        public virtual ICollection<RepairsModels> Repair { get; set; }

        public virtual ICollection<PartsModels> Part { get; set; }

     //   public virtual AdvertismentModels Advertisment { get; set; }


    }
}