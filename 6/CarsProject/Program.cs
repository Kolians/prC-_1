using CarsProject.Del;
using CarsProject.models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsProject
{
    class Program
    {

        public static void CreateCar(string mark, string model, string transmission, int mechanics, string color, string wheelrims, int Disk, string steel, bool Roof, string CarType, models.Type TypeEngine)
        {
            Car car = new Car();
            car.Body = new Body
            {
                Steel = steel,
                СarRoof = Roof
            };

            car.Mark = mark;
            car.Color = Color.FromName(color);
            car.Model = model;
            car.Box = new Box()
            {
                Transmission = transmission,
                Mechanics = mechanics
            };
            car.Engine = new Engine() { EngineId = 1, Color = Color.FromName(color), Type = TypeEngine };

            car.Wheels = new Wheels() { WheelRims = wheelrims, DiskSize = Disk };


            CarType t = models.CarType.SportCar;
            Enum.TryParse(CarType, out t);
            car.Type = t;
                           
            CarsRepository carsRepo = new CarsRepository();

            carsRepo.Create(0,
                car.Body.Steel,
                car.Body.СarRoof,
                car.Box.Transmission,
                car.Box.Mechanics,
                car.Engine.Color,
                car.Engine.Type,
                car.Wheels.WheelRims,
                car.Wheels.DiskSize,
                car.Mark,
                car.Model);

        }


        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Выберите номер сортировки:\n" +
                "1)Чтобы создать машину нажмите 1;\n" +
                "2)Чтобы удалить машину нажмите 2\r\n" +
                 "3)Чтобы изменить машину нажмите 3\r\n" +
                  "4)Чтобы изменить вывести машину нажмите 4\r\n" +
                   "5)Чтобы изменить вывести машину нажмите 5\r\n");
            int symbol = Convert.ToInt32(Console.ReadLine());
            

            if (symbol == 1)
            { 

            string mark;
            string model;
            string transmission;
            int mechanics;
            string color;
            string wheelrims;
            int Disk;
            string steel;
            bool Roof;
            string CarType;
            string Type;
            Console.WriteLine("Введите марку машины");
            mark = Console.ReadLine();
            Console.WriteLine("Введите модель машины");
            model = Console.ReadLine();
            Console.WriteLine("Введите коробку передач");
            transmission = Console.ReadLine();
            Console.WriteLine("Введите количество передач");
            mechanics = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите цвет машины");
            color = Console.ReadLine();
            Console.WriteLine("Введиnt название дисков");
            wheelrims = Console.ReadLine();
            Console.WriteLine("Введите ширину дисков");
            Disk = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите материал изготовления");
            steel = Console.ReadLine();
            Console.WriteLine("Есть наличие крышы");
            Roof = bool.Parse(Console.ReadLine());

            if (Roof)
            {
                Console.WriteLine("есть");
            }
            else
            {
                Console.WriteLine("нету");
            }

                Console.WriteLine("Введите тип машины");
                CarType = Console.ReadLine();
                Console.WriteLine("Введите тип двигателя");
                Type = Console.ReadLine();
                CarsProject.models.Type c = models.Type.ElectricEngine;
                if (Type == "GasEngine")
                {
                    c = models.Type.GasEngine;
                }
                else if (Type == "ElectricEngine")
                {
                    c = models.Type.ElectricEngine;
                }
                else if (Type == "DiselEngine")
                {
                    c = models.Type.DiselEngine;
                }

                CreateCar(mark, model, transmission, mechanics, color, wheelrims, Disk, steel, Roof, CarType, c);
            }
            else if (symbol == 2)
            {
                Console.WriteLine("Введите id машины которую хотите удалить");
                string number = Console.ReadLine();
                int CarId = int.Parse(number);
                CarsRepository Cars = new CarsRepository();
                Cars.Delete(CarId);
            }else if (symbol == 3)
            {
                string steel;
                bool Roof;
                string transmission;
                int mechanics;
                string color;
                string type;
                string wheelRims;
                int diskSize;
                string mark;
                string model;
                Console.WriteLine("Введите id машины которую хотите машины которую хотите изменить");
                string number = Console.ReadLine();
                int CarId = int.Parse(number);
                Console.WriteLine("Введите номер новой марки машины");
                mark = Console.ReadLine();
                Console.WriteLine("Введите номер новой модель машины");
                model = Console.ReadLine();
                Console.WriteLine("Введите материал изготовления");
                steel = Console.ReadLine();
                Console.WriteLine("Есть наличие крыши");
                Roof = bool.Parse(Console.ReadLine());

                if (Roof)
                {
                    Console.WriteLine("есть");
                }
                else
                {
                    Console.WriteLine("нету");
                }
                Console.WriteLine("Введите коробку передач");
                 transmission = Console.ReadLine();
                Console.WriteLine("Введите количество передач");
                 mechanics = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите цвет машины");
                color = Console.ReadLine();
                Console.WriteLine("Введите тип машины");
                type = Console.ReadLine();
                 CarsProject.models.Type c = models.Type.ElectricEngine;
                if( type == "GasEngine")
                {
                    c = models.Type.GasEngine;
                }else if (type == "ElectricEngine")
                {
                    c = models.Type.ElectricEngine;
                }else if(type == "DiselEngine")
                {
                    c = models.Type.DiselEngine;
                }
                Console.WriteLine("Введите название дисков");
                wheelRims = Console.ReadLine();
                Console.WriteLine("Введите размер дисков");
                diskSize = int.Parse(Console.ReadLine());
                CarsRepository UpdateCar = new CarsRepository();
                UpdateCar.Update(CarId, steel, Roof, transmission,  mechanics,  color, c , wheelRims, diskSize, mark, model );

              }else if (symbol == 4)
              {

                CarsRepository carsRepo = new CarsRepository();
                IEnumerable<Car> cars = carsRepo.Get();
                foreach (var car in cars)
                {
                    Console.WriteLine($"{car.CarId} | {car.Mark} | {car.Model}  | {car.Body.Steel} | {car.Body.СarRoof} | {car.Box.Transmission} | {car.Box.Mechanics} | {car.Engine.Color} | {car.Engine.Type} | {car.Wheels.DiskSize} | {car.Wheels.WheelRims}");
                }

            }

            Console.ReadKey();

            }

    }
}
