using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IotServer.DTOs.Sensor;
using IotServer.Models;

namespace IotServer.Mappers
{
    public static class SensorMappers
    {
        public static Sensor ConvertDtoToSensor(this CreateSensorDtoRequest sensorDtoRequest)
        {
            return new Sensor
            {
                Temperature = sensorDtoRequest.Temperature,
                Humidity = sensorDtoRequest.Humidity
            };
        }
    }
}