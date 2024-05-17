using HouseHunting.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseHunting.BIZ.Services
{
    public interface IHouseHuntingService
    {
        Task<List<House>> GetHouseAsync();
        Task<List<House>> GetHouseAsync(float budget);
    }
}
