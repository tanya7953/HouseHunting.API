using HouseHunting.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseHunting.DAL
{
    public interface IRepository
    {
        List<House> GetHouses(float budget);
        List<House> GetHouses();
    }
}
