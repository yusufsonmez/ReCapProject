using ReCapProject.Business.Abstract;
using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapProject.Business.Concrete
{

    public class CarManager : ICarService
    {
        ICarDal _icarDal;
        public CarManager(ICarDal iCarDal)
        {
            _icarDal = iCarDal;
        }

        public void Add(Car car)
        {
            _icarDal.Add(car);
        }

        public void Delete(Car car)
        {
            _icarDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _icarDal.GetAll();

        }

        public List<Car> GetById(int id)
        {
            return _icarDal.GetById(id);
        }

        public void Update(Car car)
        {
            _icarDal.Update(car);
        }
    }
}
