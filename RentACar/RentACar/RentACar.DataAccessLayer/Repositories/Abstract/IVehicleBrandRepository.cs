using RentACar.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace RentACar.DataAccessLayer.Repositories.Abstract
{
    public interface IVehicleBrandRepository
    {
        List<VehicleBrand> GetVehicleBrands(Expression<Func<VehicleBrand, bool>> filter = null, params string[] includeList);
        VehicleBrand GetVehicleBrandById(int vehicleBrandId, params string[] includeList);
        VehicleBrand Add(VehicleBrand vehicleBrand);
    }
}
