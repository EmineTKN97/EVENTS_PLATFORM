using Events_Onion.Application.Abstractions.Services;
using Events_Onion.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Onion.Infrastructure.Services
{
	public class TextService : ITextService
	{
		public string FormatTextForEvent(IEnumerable<EventDTO> eventItems)
		{
			if (eventItems is null)
				throw new ArgumentNullException(nameof(eventItems));

			StringBuilder stringBuilder = new StringBuilder();
			foreach (var item in eventItems)
			{
				stringBuilder.AppendLine($"Event: {item.Title} - Location: {item.Location} - Date: {item.Date.ToString("HH:mm - dd/MM/yyyy")}");
			}
			return stringBuilder.ToString().TrimEnd();
		}
	}
}
