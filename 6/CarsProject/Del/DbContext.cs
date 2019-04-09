using CarsProject.models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsProject.Del
{
    public class CarContext : DbContext
    {
        public CarContext() :
           base("test2"){ }

        public DbSet<Car> Cars { get; set; }
    }
}
