using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtomatYonetimSistemi.Entities
{
    public class Machines
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string? Name { get; set; }
        public string? Location { get; set; }
        public string? BarcodeNumber { get; set; }
        public byte Capacity { get; set; }
    }
}
