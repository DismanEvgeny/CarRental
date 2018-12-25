using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Entities;
using IServices;
using IRepositories;
using Repositories;



namespace Services
{
    public class CarsServices : ICarsServices
    {
        private ICarRepository carRepository;
        
        public CarsServices()
        {
            carRepository = new CarRepository();
        }

        public List<Car> getCars()
        {
            uint carCounter = 0;
            List<Car> cars = new List<Car>();
            List<string[]> carStrings = carRepository.getAllCarsFromDB(carCounter);
            foreach (string[] str in carStrings)
            {

                cars.Add(new Car(str[0], str[1], str[2], (FuelType)Enum.Parse(typeof(FuelType), str[3]), short.Parse(str[4]), (str[5]=="True"||str[5]=="1"), (Image) new ImageConverter().ConvertFrom(str[6]))); // насчёт преобразования изображения не уверен
                Console.WriteLine(str[1]);
            }

            return cars;
        }
    }
}
