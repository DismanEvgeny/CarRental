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
        private DataBaseUtils dataBaseUtils;
        
        public CarsServices()
        {
            carRepository = new CarRepository();
            dataBaseUtils = new DataBaseUtils();
        }

        public int addCarToDB(string[] carStrings)
        {
            //получение ID категории, исходя из её имени
            //carStrings[2] = dataBaseUtils.getCategoryFromDB(carStrings[2])[0];
            //Console.WriteLine("Замена: "+ carStrings[2]);

            Image img = Image.FromFile(carStrings[6]);
            
            return carRepository.insertCarInDB(carStrings, img);
        }
        public Car getCar(string Id)
        {
            string[] str = carRepository.getCarFromDB(Id);
            Car car = new Car(int.Parse(str[0]), str[1], str[2], str[3], (FuelType)Enum.Parse(typeof(FuelType), str[4]), short.Parse(str[5]),
                    (str[6] == "True" || str[6] == "1"), Image.FromFile(str[7]), (str[8] == "True" || str[8] == "1"));
            return car;
        }

        public List<Car> getCars()
        {
            uint carCounter = 0;

            List<Car> cars = new List<Car>();
            List<string[]> carStrings = carRepository.getAllCarsFromDB(carCounter);
            foreach (string[] str in carStrings)
            {
                cars.Add(new Car(int.Parse(str[0]), str[1], str[2], str[3], (FuelType)Enum.Parse(typeof(FuelType), str[4]), short.Parse(str[5]),
                    (str[6] == "True" || str[6] == "1"), Image.FromFile(str[7]), (str[8] == "True" || str[8] == "1")));       
            }

            return cars;
        }

        public List<Car> getCars(string categoryId)
        {
            //uint carCounter = 0;

            List<Car> cars = new List<Car>();
            List<string[]> carStrings = carRepository.getCarsFromDB(categoryId);
            foreach (string[] str in carStrings)
            {
                cars.Add(new Car(int.Parse(str[0]), str[1], str[2], str[3], (FuelType)Enum.Parse(typeof(FuelType), str[4]), short.Parse(str[5]),
                    (str[6] == "True" || str[6] == "1"), Image.FromFile(str[7]), (str[8] == "True" || str[8] == "1")));
            }

            return cars;
        }

        public void deleteCar(string carId)
        {
            carRepository.deleteCarFromDB(carId);
        }

        public void setOccupied(string carId)
        {
            carRepository.setOccupied(carId);
        }

        public uint carsInUse()
        {
            return carRepository.carsInUse();
        }

        public List<Car> getCarsOccupied(bool isOccupied)
        {
            List<Car> cars = new List<Car>();
            List<string[]> carsStrings = carRepository.getCarsOccupied(isOccupied);

            foreach (string[] str in carsStrings)
            {
                cars.Add(new Car(int.Parse(str[0]), str[1], str[2], str[3], (FuelType)Enum.Parse(typeof(FuelType), str[4]), short.Parse(str[5]),
                    (str[6] == "True" || str[6] == "1"), Image.FromFile(str[7]), (str[8] == "True" || str[8] == "1")));
            }
            return cars;
        }
    }
}
