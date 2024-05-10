using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IotServer.Models
{
    public class AirConditioner
    {
        public int Id { get; set; }
        public string Mode { get; set; } = string.Empty;
        public string Cool { get; set; } = string.Empty;
        public string Dry { get; set; } = string.Empty;
    }
}