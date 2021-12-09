using ReCapProject.Entities;
using System.Collections.Generic;


namespace ReCapProject.DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetAll();

        void Add(Car car);

        void Update(Car car);

        void Delete(Car car);

        List<Car> GetById(int id);


    }
}
