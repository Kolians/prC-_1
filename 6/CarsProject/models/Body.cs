using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsProject.models
{
    public class Body
    {
        public int BodyId { get; set; }
        public string Steel { get; set; } //материал изготовления (сталь, алюминий, стеклопластика)
        public bool СarRoof { get; set; } //крыша (естьили нет)
    }
}
