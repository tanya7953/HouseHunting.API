using HouseHunting.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseHunting.BIZ.Request
{
    public class GetAllHousesRequest : House, IRequest<Response>
    {

    }
}
