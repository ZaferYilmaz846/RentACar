using Generic_Infrastructure.DataAccess.Concreate;
using RentACar.DataAccessLayer.Context;
using RentACar.DataAccessLayer.Repositories.Abstract;
using RentACar.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace RentACar.DataAccessLayer.Repositories.Concreate.EntityFrameworkCore
{
    public class VehicleModelRepository : GenericRepository<VehicleModel, RentACarContext>, IVehicleModelRepository
    {
        public VehicleModel Add(VehicleModel vehicleModel)
        {
            return Insert(vehicleModel);
        }

        public VehicleModel Remove(VehicleModel vehicleModel)
        {
            return Delete(vehicleModel);
        }

        public List<VehicleModel> GetVehicleBrandById(int vehicleBrandId)
        {
            return GetAll(x => x.VehicleBrandID == vehicleBrandId);
        }

        public VehicleModel GetVehicleModelById(int vehicleModelId, params string[] includeList)
        {
            return Get(x => x.VehicleModelID == vehicleModelId, includeList);
        }

        public List<VehicleModel> GetVehicleModels(Expression<Func<VehicleModel, bool>> filter = null, params string[] includeList)
        {
            return GetAll(filter: null, includeList: includeList);
        }

        public VehicleModel Updated(VehicleModel vehicleModel)
        {
            return Update(vehicleModel);
        }
    }
}
