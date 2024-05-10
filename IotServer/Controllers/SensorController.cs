using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IotServer.Data;
using IotServer.DTOs.Sensor;
using IotServer.Mappers;
using IotServer.Models;
using Microsoft.AspNetCore.Mvc;

namespace IotServer.Controllers
{
    [Route("api/sensor")]
    [ApiController]
    public class SensorController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public SensorController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll() {
            var sensor = _context.Sensors.ToList();
            return Ok(sensor);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var sensor = _context.Sensors.Find(id);
            if(sensor == null) {
                return NotFound();
            }
            return Ok(sensor);
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateSensorDtoRequest sensorDtoRequest)
        {
            Sensor sensor = sensorDtoRequest.ConvertDtoToSensor();
            _context.Sensors.Add(sensor);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new {id = sensor.Id}, sensor);
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] UpdateSensorDtoRequest sensorUpdate)
        {
            var val = _context.Sensors.FirstOrDefault(x => x.Id == id);
            if(val == null) {
                return NotFound();
            }
            val.Temperature = sensorUpdate.Temperature;
            val.Humidity = sensorUpdate.Humidity;
            _context.SaveChanges();
            return Ok(val);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var sensor = _context.Sensors.FirstOrDefault(x => x.Id == id);
            if(sensor == null) {
                return NotFound();
            }
            _context.Sensors.Remove(sensor);
            _context.SaveChanges();
            return NoContent();
        }
    }
}