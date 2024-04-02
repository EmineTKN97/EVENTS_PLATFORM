using Events_Onion.Application.DTOs;
using Events_Onion.Application.RequestParameters;
using Events_Onion.Domain.Entities;
using Events_Onion.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Onion.Application.Abstractions.Services
{
   public interface IEventService
    {
        Task CreateEventAsync(CreateEventDTO createEventDTO);
        Task<IEnumerable<EventDTO>> GetAllEventsAsync(Pagination pagination);
    }
}
