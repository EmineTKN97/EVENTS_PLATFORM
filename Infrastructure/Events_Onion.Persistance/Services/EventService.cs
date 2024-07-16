using Events_Onion.Application.Abstractions.Services;
using Events_Onion.Application.DTOs;
using Events_Onion.Application.RequestParameters;
using Events_Onion.Domain.Entities;
using Events_Onion.Persistance.DbContexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Events_Onion.Persistance.Services
{
    public class EventService(EventDbContext _context): IEventService
    {

        public async Task CreateEventAsync(CreateEventDTO createEventDTO)
        {
            if (createEventDTO is not null)
            {
				var newEvent = new Event()
				{
					Title = createEventDTO.Title,
					Date = createEventDTO.Date,
					Location = createEventDTO.Location,
				};
				await _context.Events.AddAsync(newEvent);
                await _context.SaveChangesAsync();

			}
            else { throw new NullReferenceException(); }
        }

        public async Task<IEnumerable<EventDTO>> GetAllEventsAsync(Pagination pagination)
        {
            return await _context.Events.Select(x => new EventDTO()
                { 
                Title = x.Title,
                Date = x.Date,
                Location = x.Location,
                
            }) 
                .Skip(pagination.PageCount *pagination.ItemCount)
                .Take(pagination.ItemCount)
                .ToListAsync();
        }
    }
}
