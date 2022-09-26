using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using static System.Net.Mime.MediaTypeNames;


namespace DeviceManagement_WebApp.Repository
{
    public class DeviceRepository : GenericRepository<Device>, IDeviceRepository
    {
        public DeviceRepository(ConnectedOfficeContext context) : base(context)
            {
        }

        public Device GetMostRecentDevice()
        {
            return _context.Device.Include(d => d.Category).Include(d => d.Zone).OrderByDescending(Device=>Device.DateCreated).FirstOrDefault();
        }
        public IEnumerable<Device> GetAllDevices()
        {
            var connectedofficeContext = _context.Device.Include(d => d.Category).Include(d => d.Zone);
            return connectedofficeContext.ToList();
        }
        // Gets device details
        public Device GetDeviceDetails(Guid id)
        {
            var device = _context.Device.Include(d => d.Category).Include(d => d.Zone).FirstOrDefault(m => m.DeviceId == id);
            return device;
        }
       // returns the zone
        public IEnumerable<Zone> GetZone()
        {
            return _context.Zone;
        }

        public IEnumerable<Category> GetCategories()
        {
            return _context.Category;
        }

        public IEnumerable<Device> SortDevices(Expression<Func<Device, string>> expression)
        {
            throw new NotImplementedException();
        }

        public Device FindDevice(Expression<Func<Device, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
