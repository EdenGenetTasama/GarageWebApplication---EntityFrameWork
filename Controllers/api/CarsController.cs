using GarageWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GarageWebApplication.Controllers.api
{
    public class CarsController : ApiController
    {
        GarageContext CarDB = new GarageContext();
        // GET: api/Cars
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(CarDB.Cars.ToList());
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET: api/Cars/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                Car CarById = CarDB.Cars.First(item => item.Id == id);
                return Ok(CarById);
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST: api/Cars
        public IHttpActionResult Post([FromBody] Car car)
        {
            try
            {
                CarDB.Cars.Add(car);
                CarDB.SaveChanges();
                return Ok("ADDED");
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/Cars/5
        public IHttpActionResult Put(int id, [FromBody] Car car)
        {
            try
            {
                Car catNeededToUpdate = CarDB.Cars.First(item => item.Id == id);
                if (catNeededToUpdate !=null)
                {
                    catNeededToUpdate.OwnerName = car.OwnerName;
                    catNeededToUpdate.CarNum = car.CarNum;
                    catNeededToUpdate.IsFixed=car.IsFixed;
                }
                CarDB.SaveChanges();
                return Ok("Update");
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE: api/Cars/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                Car carToDelte = CarDB.Cars.First(item => item.Id == id);
                CarDB.Cars.Remove(carToDelte);
                CarDB.SaveChanges();
                return Ok("Deleted");
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
