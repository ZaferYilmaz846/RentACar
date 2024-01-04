using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Model.Entities
{
    public class VehicleBrand
    {
        public VehicleBrand()
        {
            VehicleModels = new HashSet<VehicleModel>();
        }
        public int VehicleBrandID { get; set; }
        public string VehicleBrandName { get; set; }
        public virtual ICollection<VehicleModel> VehicleModels { get; set; }
    }
}
