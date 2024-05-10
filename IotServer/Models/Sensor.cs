using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IotServer.Models
{
    public class Sensor
    {
        public int Id { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Temperature { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Humidity { get; set; }
    }
}