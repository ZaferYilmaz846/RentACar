using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Update.Internal;
using RentACar.BusinessLayer.Abstract;
using RentACar.Model.Dtos.VehicleBrand;
using RentACar.Model.Dtos.VehicleModel;
using RentACar.Model.Entities;
using System.Collections.Generic;

namespace RentACar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleModelController : ControllerBase
    {
        private readonly IVehicleModelBL modelBL;
        private readonly IMapper mapper;
        public VehicleModelController(IVehicleModelBL _modelBL, IMapper _mapper)
        {
            modelBL = _modelBL;
            mapper = _mapper;
        }

        [HttpGet("getall")]
        public ActionResult<List<VehicleModelGetDto>> GetVehicleModels()
        {
            try
            {
                var vehicleModels = modelBL.GetVehicleModels(null, "VehicleBrand");
                var dto = mapper.Map<List<VehicleModelGetDto>>(vehicleModels);
                return Ok(dto);
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }



        [ProducesResponseType(typeof(VehicleModel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("getvehiclemodelbyid")]
        public ActionResult<VehicleModelGetDto> GetVehicleModelById([FromQuery] int modelId)
        {
            try
            {
                if (modelId <= 0)
                {
                    return BadRequest();
                }
                var vehicleModels = modelBL.GetVehicleModelById(modelId);

                if (vehicleModels == null)
                {
                    return NotFound();
                }
                var dto = mapper.Map<VehicleModelGetDto>(vehicleModels);
                return Ok(dto);
            }

            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }


        [HttpPost("add")]
        public ActionResult<VehicleModel> AddVehicleModel([FromBody] VehicleModelForCreation adto)
        {
            var vehicleModel = new VehicleModel
            {
                VehicleBrandID = adto.BrandID,
                VehicleModelName = adto.ModelName,
                VehicleYear = adto.Year,
                VehicleFuelOil = adto.FuelOil,
                VehicleTransmission = adto.Transmission,
                PerDayPrice = adto.PerDayPrice
            };

            return Ok(modelBL.Add(vehicleModel));
        }


        [HttpPost("delete")]
        public ActionResult<VehicleModel> DeleteVehicleModel([FromBody] VehicleModelDeleteDto ddto)
        {
            try
            {
                if (ddto == null)
                {
                    return NotFound();
                }
                var vehicleModel = new VehicleModel
                {
                    VehicleModelID = ddto.ModelID
                };

                return Ok(modelBL.Remove(vehicleModel));
            }
            catch (System.Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }


        [HttpPost("update")]
        public ActionResult<VehicleModel> UpdateVehicleModel([FromBody] VehicleModelUpdateDto udto)
        {
            var updatedVehicleModel = new VehicleModel
            {
                VehicleModelID = udto.ModelID,
                VehicleBrandID = udto.BrandID,
                VehicleModelName = udto.ModelName,
                VehicleYear = udto.Year,
                VehicleFuelOil = udto.FuelOil,
                VehicleTransmission = udto.Transmission,
                PerDayPrice = udto.PerDayPrice
            };
            return Ok(modelBL.Updated(updatedVehicleModel));

        }
    }
}
