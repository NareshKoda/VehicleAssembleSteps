using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleAssembleSteps
{
    public class VehicleAssembleModel
    {
        public string VehicleProjectCode { get; set; }
        public string Variant { get; set; }
        public int TirePressure { get; set; }
        public string Region { get; set; }
        public string TransmissionType { get; set; }
        public string AssemblyProcess { get; set; }
        public string ColorCode { get; set; }
    }
}
