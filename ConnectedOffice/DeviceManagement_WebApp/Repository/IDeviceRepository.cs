using DeviceManagement_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DeviceManagement_WebApp.Repository
{
    public interface IDeviceRepository : IGenericRepository<Device>
    {
        public Device GetMostRecentDevice();

        public IEnumerable<Device> GetAllDevices();

        public Device GetDeviceDetails(Guid id);

        public IEnumerable<Zone> GetZone();

        public IEnumerable<Category> GetCategories();

        public IEnumerable<Device> SortDevices(Expression<Func<Device, String>> expression);

        public Device FindDevice(Expression<Func<Device, bool>> expression);  
    }
}
