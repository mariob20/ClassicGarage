using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassicGarage.Models
{
    public class OwnerModels
    {
        public int ID { get; set; }
        
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int PhoneNo { get; set; }

        public string Email { get; set; }


        public virtual ICollection<CarModels> Cars { get; set; }
    }
}