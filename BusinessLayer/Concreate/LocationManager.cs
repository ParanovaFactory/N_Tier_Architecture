using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class LocationManager : ILocationService
    {
        ILocaionDAL _locationDal;
        public LocationManager(ILocaionDAL locationDal)
        {
            _locationDal = locationDal;
        }

        public Location GetById(int id)
        {
            return _locationDal.GetById(id);
        }

        public List<Location> GetList()
        {
            return _locationDal.GetList();
        }

        public void TDelete(Location t)
        {
            _locationDal.Delete(t);
        }

        public void TInsert(Location t)
        {
            _locationDal.Insert(t);
        }

        public void TUpdate(Location t)
        {
            _locationDal.Update(t);
        }
    }
}
