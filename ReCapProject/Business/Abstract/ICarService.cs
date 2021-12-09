﻿using ReCapProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapProject.Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();

        void Add(Car car);

        List<Car> GetById(int id);

        void Update(Car car);

        void Delete(Car car);
    }
}
