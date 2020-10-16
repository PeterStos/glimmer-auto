using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GlimmerAuto.Models.ViewModel
{
    public class CarServiceViewModel
    {
        public Car Car { get; set; }
        public ServiceHeader ServiceHeader { get; set; }
        public ServiceDetails ServiceDetails { get; set; }

        public List<ServiceType> ServiceTypesList { get; set; }
        public List<ServiceShoppingCart> ServiceShoppingCart { get; set; }

    }
}
