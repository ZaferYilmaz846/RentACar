﻿using RentACar.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace RentACar.DataAccessLayer.Repositories.Abstract
{
    public interface IVehicleModelRepository
    {
        List<VehicleModel> GetVehicleModels(Expression<Func<VehicleModel, bool>> filter = null, params string[] includeList);
        List<VehicleModel> GetVehicleBrandById(int vehicleBrandId);
        VehicleModel GetVehicleModelById(int vehicleModelId, params string[] includeList);
        VehicleModel Add(VehicleModel vehicleModel);
        VehicleModel Remove(VehicleModel vehicleModel);
        VehicleModel Updated(VehicleModel vehicleModel);
    }
}