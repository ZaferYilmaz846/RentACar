using RentACar.BusinessLayer.Abstract;
using RentACar.DataAccessLayer.Repositories.Abstract;
using RentACar.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace RentACar.BusinessLayer.Concreate
{
    public class VehicleBrandBL : IVehicleBrandBL
    {
        IVehicleBrandRepository vbr;
        public VehicleBrandBL(IVehicleBrandRepository _vbr)
        {
            vbr = _vbr;
        }
        public VehicleBrand Add(VehicleBrand vehicleBrand)
        {
            var addedVehicleModel = vbr.Add(vehicleBrand);
            return addedVehicleModel;
        }

        public VehicleBrand GetVehicleBrandById(int vehicleBrandId, params string[] includeList)
        {
            var vehicleBrand = vbr.GetVehicleBrandById(vehicleBrandId, includeList);
            return vehicleBrand;
        }

        public List<VehicleBrand> GetVehicleBrands(Expression<Func<VehicleBrand, bool>> filter = null, params string[] includeList)
        {
            var vehicleBrands = vbr.GetVehicleBrands(filter, includeList: includeList);
            return vehicleBrands;
        }
    }
}
