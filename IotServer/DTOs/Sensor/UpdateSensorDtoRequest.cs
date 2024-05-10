using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IotServer.DTOs.Sensor
{
    public class UpdateSensorDtoRequest
    {
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Temperature { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Humidity { get; set; }
    }
}