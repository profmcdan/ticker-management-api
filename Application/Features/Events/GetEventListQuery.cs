using System.Collections.Generic;
using MediatR;

namespace Application.Features.Events
{
    public class GetEventListQuery : IRequest<List<EventListViewModel>>
    {
        
    }
}