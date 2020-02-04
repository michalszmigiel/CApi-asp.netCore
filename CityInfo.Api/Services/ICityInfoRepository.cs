using CityInfo.Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.Api.Services
{
    public interface ICityInfoRepository
    {
        IEnumerable<City> GetCities();
        City GetCity(int cityId, bool includePointsOfInterest);
        IEnumerable<PointOfInterest> GetPointsOfInterestForCity(int cityId);
        PointOfInterest GetPointOfInterest(int cityId, int pointOfInterestId);
        bool CityExists(int cityId);
        void AddPointOfInterest(int cityId, PointOfInterest pointOfInterest);
        void UpdatePointOfInterest(int city, PointOfInterest pointOfInterest);
        void DeletePointOfInterest(PointOfInterest pointOfInterest);
        bool Save();
    }
}
