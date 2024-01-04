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
    public class VehicleBrandRepository : GenericRepository<VehicleBrand, RentACarContext>, IVehicleBrandRepository
    {
        public VehicleBrand Add(VehicleBrand vehicleBrand)
        {
            return Insert(vehicleBrand);
        }

        public VehicleBrand GetVehicleBrandById(int vehicleBrandId, params string[] includeList)
        {
            return Get(x => x.VehicleBrandID == vehicleBrandId, includeList);
        }

        public List<VehicleBrand> GetVehicleBrands(Expression<Func<VehicleBrand, bool>> filter = null, params string[] includeList)
        {
            return GetAll(filter: null, includeList: includeList);
        }
    }
}
