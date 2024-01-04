using RentACar.BusinessLayer.Abstract;
using RentACar.DataAccessLayer.Repositories.Abstract;
using RentACar.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace RentACar.BusinessLayer.Concreate
{
    public class VehicleModelBL : IVehicleModelBL
    {
        IVehicleModelRepository vmr;
        public VehicleModelBL(IVehicleModelRepository _vmr)
        {
            vmr = _vmr;
        }
        public VehicleModel Add(VehicleModel vehicleModel)
        {
            var addedVehicleModel = vmr.Add(vehicleModel);
            return addedVehicleModel;
        }

        public List<VehicleModel> GetVehicleBrandById(int vehicleBrandId)
        {
            var vehicleModels = vmr.GetVehicleBrandById(vehicleBrandId);
            return vehicleModels;
        }

        public VehicleModel GetVehicleModelById(int vehicleModelId, params string[] includeList)
        {
            var vehicleModel = vmr.GetVehicleModelById(vehicleModelId, includeList);
            return vehicleModel;
        }

        public List<VehicleModel> GetVehicleModels(Expression<Func<VehicleModel, bool>> filter = null, params string[] includeList)
        {
            var vehicleModels = vmr.GetVehicleModels(filter, includeList: includeList);
            return vehicleModels;
        }

        public VehicleModel Remove(VehicleModel vehicleModel)
        {
            var deletedVehicleModel = vmr.Remove(vehicleModel);
            return deletedVehicleModel;
        }

        public VehicleModel Updated(VehicleModel vehicleModel)
        {
            var updatedVehicleModel = vmr.Updated(vehicleModel);
            return updatedVehicleModel;
        }
    }
}
