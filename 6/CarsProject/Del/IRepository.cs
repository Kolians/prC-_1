using CarsProject.models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = CarsProject.models.Type;

namespace CarsProject.Del
{
    interface IRepository<T> :  IDisposable where T : class
    {
        IEnumerable<T> Get(); // получение всех объектов

        void Create(int id_car, string Steel, bool СarRoof, string Transmission, int Mechanics, Color Color, Type Type, string WheelRims, int DiskSize, string mark, string model);
        void Update(int id_car, string Steel, bool СarRoof, string Transmission, int Mechanics, string color, Type Type, string WheelRims, int DiskSize, string mark, string model);
        void Delete(int id);
        void Read(int id_car);
        void Read();
    }
}
