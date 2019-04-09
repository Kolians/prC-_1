using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsProject.models
{
    public class Box
    {
        public int BoxId { get; set; }
        public string Transmission { get; set; } //АПП (Автомат, Механика)
        public int Mechanics { get; set; } //количество передач(1,2,3,4,5)
    }
}
