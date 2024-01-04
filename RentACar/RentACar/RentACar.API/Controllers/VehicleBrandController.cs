using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentACar.BusinessLayer.Abstract;
using RentACar.Model.Dtos.VehicleBrand;
using System.Collections.Generic;

namespace RentACar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleBrandController : ControllerBase
    {
        IVehicleBrandBL brandBL;
        IMapper mapper;
        public VehicleBrandController(IVehicleBrandBL _brandBL, IMapper _mapper)
        {
            brandBL = _brandBL;
            mapper = _mapper;
        }


        [HttpGet("getall")]
        public ActionResult<List<VehicleBrandGetDto>> GetVehicleBrands()
        {
            try
            {
                var vehicleBrands = brandBL.GetVehicleBrands(null);
                var dto = mapper.Map<List<VehicleBrandGetDto>>(vehicleBrands);
                return Ok(dto);
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
