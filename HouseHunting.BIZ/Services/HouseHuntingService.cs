using HouseHunting.DAL;
using HouseHunting.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseHunting.BIZ.Services
{
    public class HouseHuntingService : IHouseHuntingService
    {
        private readonly IRepository _repository;
        public HouseHuntingService(IRepository repository)
        {

            _repository = repository;

        }
        public async Task<List<House>> GetHouseAsync()
        {
            var result = _repository.GetHouses();
            return await Task.FromResult(result);
        }

        public async Task<List<House>> GetHouseAsync(float budget)
        {
            var result = _repository.GetHouses(budget);
            return await Task.FromResult(result);
        }
    }
}
