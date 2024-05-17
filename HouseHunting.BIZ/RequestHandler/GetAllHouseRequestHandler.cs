using HouseHunting.BIZ.Request;
using HouseHunting.BIZ.Services;
using HouseHunting.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseHunting.BIZ.RequestHandler
{
    public class GetAllHouseRequestHandler : IRequestHandler<GetAllHousesRequest, Response>
    {
        private readonly IHouseHuntingService _service;
        public GetAllHouseRequestHandler(IHouseHuntingService service)
        {
            _service = service;

        }
       /* public async Task<List<House>> Handle(GetAllHousesRequest request, CancellationToken cancellationToken)
        {
            return await _service.GetHouseAsync();
        }
*/
        async Task<Response> IRequestHandler<GetAllHousesRequest, Response>.Handle(GetAllHousesRequest request, CancellationToken cancellationToken)
        {
            var s = await _service.GetHouseAsync();
            return new Response { response="tanya "};
        }
    }
}
