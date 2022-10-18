using System;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GetAllCarsTest();

            //GetAllBrandsTest();

            //GetAllColorsTest();

            //AddColorTest();

            //GetCarDetailsTest();

            //AddUserTest();

        }

        private static void AddUserTest()
        {
            IUserDal userDal = new EfUserDal();
            IUserService userService = new UserManager(userDal);

            //User user = new User { UserId = 1, FirstName = "Muhammet", LastName = "ÇAKIR", Email = "muhammetcakir@gmail.com", Password = "12345" };

            //userService.Add(user);

            foreach (var u in userService.GetAll().Data)
            {
                Console.WriteLine(u.UserId + " " + u.FirstName + " " + u.LastName + " " + u.Email + " " + u.Password);
            }
        }

        private static void GetCarDetailsTest()
        {
            ICarDal carDal = new EfCarDal();
            ICarService carService = new CarManager(carDal);

            var result = carService.GetCarDetails().Data;

            foreach (var car in result)
            {
                Console.WriteLine(car.CarId + " " + car.BrandName + " " + car.ColorName + " " + car.ModelYear);
            }
        }

        private static void AddColorTest()
        {
            IColorDal colorDal = new EfColorDal();
            IColorService colorService = new ColorManager(colorDal);

            colorService.Add(new Color { ColorId = 8, ColorName = "Turuncu" });
        }

        private static void GetAllColorsTest()
        {
            IColorDal colorDal = new EfColorDal();
            IColorService colorService = new ColorManager(colorDal);

            var result = colorService.GetAll().Data;

            foreach (var color in result)
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void GetAllBrandsTest()
        {
            IBrandDal brandDal = new EfBrandDal();
            IBrandService brandService = new BrandManager(brandDal);

            var result = brandService.GetAll().Data;

            foreach (var brand in result)
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void GetAllCarsTest()
        {
            ICarDal carDal = new EfCarDal();
            ICarService carManager = new CarManager(carDal);

            var result = carManager.GetAll().Data;

            foreach (var car in result)
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
