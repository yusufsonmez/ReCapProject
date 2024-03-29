﻿using ReCapProject.Business.Concrete;
using ReCapProject.DataAccess.Concrete;
using ReCapProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //New car object from InMemoryCarDal()
            CarManager carManager = new CarManager(new InMemoryCarDal());

            //Get all
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("{0} Değerinde {1}", car.DailyPrice, car.Description); //we use this write style because this is less costly for multiple var's to write
            }
            Console.WriteLine("\n");


            //Add new car
            carManager.Add(new Car{ BrandId = 7, ColorId = 5, DailyPrice = 220000, Description = "3 Yıllık Araç -Hasarlı", Id = 6, ModelYear = 2018 });

            //Write the new car
            foreach (var newCar in carManager.GetById(6))
            {
                Console.WriteLine(newCar.Description + " Eklendi\n");
            }



            //Get all - to see defferance
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("{0} Değerinde {1}", car.DailyPrice, car.Description);
            }
            Console.WriteLine("\n");



            //Update a car - add "-Hasarlı" word
            foreach (var carForUpdateTheCars in carManager.GetById(2))
            {
                Car newCarToUpdate = new Car { BrandId = 10, ColorId = 10, DailyPrice = 300000, Description = carForUpdateTheCars.Description+ " -Hasarlı", Id = 2, ModelYear = 2019 };
                carManager.Update(newCarToUpdate);
                Console.WriteLine(carForUpdateTheCars.Id + " id'li araç bilgisi güncellendi\n");
            }

            
            
            //Get all - to see defferance
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("{0} Değerinde {1}", car.DailyPrice, car.Description);
            }
            Console.WriteLine("\n");



            //Delete car
            foreach (var carForDelete in carManager.GetById(3))
            {
                carManager.Delete(carForDelete);
                Console.WriteLine(carForDelete.Id + "id'li araç silindi\n");
            }


            
            //Get all - to see defferance
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("{0} Değerinde {1}", car.DailyPrice, car.Description);
            }

            Console.ReadLine();

        }



    }
}