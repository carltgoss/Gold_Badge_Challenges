using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Green_Plan_Repository
{
    public class Cars_Repo
    {
        private List<Cars> _gasCars = new List<Cars>();
        private List<Cars> _hybridCars = new List<Cars>();
        private List<Cars> _electricCars = new List<Cars>();

        public bool AddGasCar(Cars car)
        {
            int startingCount = _gasCars.Count;

            _gasCars.Add(car);

            bool wasAdded = (_gasCars.Count > startingCount) ? true : false;
            return wasAdded;
        }

        public bool AddHybridCar(Cars car)
        {
            int startingCount = _hybridCars.Count;

            _hybridCars.Add(car);

            bool wasAdded = (_hybridCars.Count > startingCount) ? true : false;
            return wasAdded;
        }

        public bool AddElectricCar(Cars car)
        {
            int startingCount = _electricCars.Count;

            _electricCars.Add(car);

            bool wasAdded = (_electricCars.Count > startingCount) ? true : false;
            return wasAdded;
        }

        public List<Cars> GetGasList()
        {
            return _gasCars;
        }

        public List<Cars> GetHybridList()
        {
            return _hybridCars;
        }

        public List<Cars> GetElectricList()
        {
            return _electricCars;
        }

        public Cars GetGasID(int id)
        {
            foreach(Cars car in _gasCars)
            {
                if(car.IdNumber == id)
                {
                    return car;
                }
            }
            return null;
        }

        public Cars GetHybridID(int id)
        {
            foreach (Cars car in _hybridCars)
            {
                if (car.IdNumber == id)
                {
                    return car;
                }
            }
            return null;
        }

        public Cars GetElectricID(int id)
        {
            foreach (Cars car in _electricCars)
            {
                if (car.IdNumber == id)
                {
                    return car;
                }
            }
            return null;
        }

        public bool UpdateGasCar(int originalId, Cars updateCar)
        {
            Cars oldCar = GetGasID(originalId);

            if(oldCar != null)
            {
                oldCar.IdNumber = updateCar.IdNumber;
                oldCar.Make = updateCar.Make;
                oldCar.Model = updateCar.Model;
                oldCar.Year = updateCar.Year;
                oldCar.Color = updateCar.Color;
                oldCar.Type = updateCar.Type;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateHybridCar(int originalId, Cars updateCar)
        {
            Cars oldCar = GetHybridID(originalId);

            if (oldCar != null)
            {
                oldCar.IdNumber = updateCar.IdNumber;
                oldCar.Make = updateCar.Make;
                oldCar.Model = updateCar.Model;
                oldCar.Year = updateCar.Year;
                oldCar.Color = updateCar.Color;
                oldCar.Type = updateCar.Type;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateElectricCar(int originalId, Cars updateCar)
        {
            Cars oldCar = GetElectricID(originalId);

            if (oldCar != null)
            {
                oldCar.IdNumber = updateCar.IdNumber;
                oldCar.Make = updateCar.Make;
                oldCar.Model = updateCar.Model;
                oldCar.Year = updateCar.Year;
                oldCar.Color = updateCar.Color;
                oldCar.Type = updateCar.Type;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
