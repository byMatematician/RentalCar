using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal

    {

        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{ColorId = 1, BrandId = 1,  Id = 1, Dailyprice = 30, Description = "Small Cars", ModelYear = "2020"},
                new Car{ColorId = 2, BrandId = 2,  Id = 1, Dailyprice = 40, Description = "Medium Cars", ModelYear = "2021" },
                new Car{ColorId = 3, BrandId = 3,  Id = 3, Dailyprice = 45, Description = "Estate cars", ModelYear = "2019"  },
                new Car{ColorId = 1, BrandId = 4,  Id = 2, Dailyprice = 45, Description = "Premium cars", ModelYear = "2020"  },
                new Car{ColorId = 2, BrandId = 5,  Id = 2, Dailyprice = 38, Description = "Suvs", ModelYear = "2019"  },
                new Car{ColorId = 3, BrandId = 6,  Id = 2, Dailyprice = 65, Description = "People carriers", ModelYear = "2019"  }

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {

            Car carToDelete = _cars.SingleOrDefault(c => c.Id == c.Id);
            _cars.Remove(carToDelete);
        }
        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == c.Id);

            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.Dailyprice = car.Dailyprice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
