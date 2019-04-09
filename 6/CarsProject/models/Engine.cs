using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsProject.models
{
    public enum Type
    {
        DiselEngine,
        GasEngine,
        ElectricEngine
    }
    public class Engine
    {
        public int EngineId { get; set; }
        public Color Color { get; set; }
        public Type Type { get; set; }
    }
}
