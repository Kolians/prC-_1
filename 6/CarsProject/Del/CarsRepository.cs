using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarsProject.models; 
using System.Data.SqlClient;
using System.Drawing;

namespace CarsProject.Del
{

    class CarsRepository : IRepository<Car>
    {
        CarContext db;
        public CarsRepository()
        {
            db = new CarContext();
        }

        public void Create(int id_car, string Steel, bool СarRoof, string Transmission, int Mechanics, Color Color, models.Type Type, string WheelRims, int DiskSize, string mark, string model)
        {

            Car creatingCar = new Car
            {
                CarId = id_car,
                Mark = mark,
                Model = model,
            };

            creatingCar.Body = new Body
            {
                Steel = Steel,
                СarRoof = СarRoof,

            };
            creatingCar.Box = new Box
            {
                Mechanics = Mechanics,
                Transmission = Transmission,

            };
            creatingCar.Engine = new Engine
            {
                Type = Type,
                Color = Color,
            };
            creatingCar.Wheels = new Wheels
            {
                WheelRims = WheelRims,
                DiskSize = DiskSize,
            };
            db.Cars.Add(creatingCar);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            Car deletingCar = db.Cars.Where(g => g.CarId == id).FirstOrDefault();
            db.Cars.Remove(deletingCar);
            db.SaveChanges();
        }

        public void Update(int id_car, string Steel, bool СarRoof, string Transmission, int Mechanics, string color, models.Type Type, string WheelRims, int DiskSize, string mark, string model)
        {
            Car updatingCar = db.Cars.Where(g => g.CarId == id_car).FirstOrDefault();
            updatingCar.Mark = mark;
            updatingCar.Model = model;
            updatingCar.Body.Steel = Steel;
            updatingCar.Body.СarRoof = СarRoof;
            updatingCar.Box.Transmission = Transmission;
            updatingCar.Box.Mechanics = Mechanics;
            updatingCar.Engine.Color = Color.FromName(color);
            updatingCar.Engine.Type = Type;
            updatingCar.Wheels.WheelRims = WheelRims;
            updatingCar.Wheels.DiskSize = DiskSize;
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public IEnumerable<Car> Get()
        {
            return db.Cars; 
        }

        public void Read(int id_car)
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            throw new NotImplementedException();
        }

    }
}