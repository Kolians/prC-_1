using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsProject.models
{
    public class Wheels
    {
        public int WheelsId { get; set; }
        public string WheelRims { get; set; } //диски (Литые диски, Штампованные диски, Кованые диски)
        public int DiskSize { get; set; } // ширина колёс (255, 205, 195)
    }
}
