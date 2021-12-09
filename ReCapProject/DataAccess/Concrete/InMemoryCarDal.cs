using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapProject.DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=2,DailyPrice=200000,Description="0 Kilometre Araç",ModelYear=2021},
                new Car{Id=2,BrandId=6,ColorId=3,DailyPrice=340000,Description="2 Yıllık Araç",ModelYear=2019},
                new Car{Id=3,BrandId=2,ColorId=12,DailyPrice=120000,Description="2 Yıllık Araç",ModelYear=2019},
                new Car{Id=4,BrandId=3,ColorId=3,DailyPrice=110000,Description="5 Yıllık Araç",ModelYear=2016},
                new Car{Id=5,BrandId=4,ColorId=6,DailyPrice=100000,Description="1 Yıllık Araç",ModelYear=2020},
            };

            
        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;

            //Find the car which have id that i send
            carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            //Remove the car
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

            carToUpdate.Id = car.Id;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
        }
    }
}