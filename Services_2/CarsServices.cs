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

        public void addCarToDB(string[] carStrings)
        {
            
            

           // return carRepository.addToDB(workerString);
        }

        public List<Car> getCars()
        {
            uint carCounter = 0;
            List<Car> cars = new List<Car>();
            List<string[]> carStrings = carRepository.getAllCarsFromDB(carCounter);
            foreach (string[] str in carStrings)
            {
                cars.Add(new Car(int.Parse(str[0]), str[1], str[2], str[3], (FuelType)Enum.Parse(typeof(FuelType), str[4]), short.Parse(str[5]), DateTime.Parse(str[6]), DateTime.Parse(str[7]), (str[8]=="True"||str[8]=="1"), (Image) new ImageConverter().ConvertFrom(str[9]))); // насчёт преобразования изображения не уверен
            }

            return cars;
        }
    }
}
