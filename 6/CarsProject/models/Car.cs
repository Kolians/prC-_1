using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsProject.models
{
    public enum CarType
    {
        SportCar,//NissanSkylineGTRR34
        FamilyCar,//InfinitiQX80
        BuisnessCar //BMWI8

    }

    public class Car 
    {
        public int CarId { get; set; }
        public string Mark { get; set; } //марка (Nissan, Toyota)
        public string Model { get; set; } //модель (skyline r32-r35, Supra)
        public CarType Type { get; set; } //тип машины(модель, марка)
        public Color Color { get; set; } // цвет машины(розовый, красный, синий)
        public Box Box { get; set; } //коробка(Автомат, Механика)
        public Body Body { get; set; } //кузов автомабиля(Кроссовер, Хэтчбек, Седан, Купе)
        public Wheels Wheels { get; set; } //колёса
        public Engine Engine { get; set; } //двигатели
    }

}
