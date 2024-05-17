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
    /*public class GetHouseByBudgetRequestHandler : IRequestHandler<GetHousesByBudgetRequest, Response>
    {
        private readonly IHouseHuntingService _service;
        public GetHouseByBudgetRequestHandler(IHouseHuntingService service)
        {
            _service = service;
        }*/
        /*public async Task<List<House>> Handle(GetHousesByBudgetRequest request, CancellationToken cancellationToken)
        {
            GetHousesByBudgetRequest ss = request;
            

            return await _service.GetHouseAsync(request.budget);
        }*/

       /* async Task<Response> IRequestHandler<GetHousesByBudgetRequest, Response>.Handle(GetHousesByBudgetRequest request, CancellationToken cancellationToken)
        {
           var s =  await _service.GetHouseAsync(request.budget);
        }*/
 //7   }
}
