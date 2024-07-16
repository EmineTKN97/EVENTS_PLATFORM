using Events_Onion.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Onion.Application.Abstractions.Services
{
	public interface ITextService
	{
		string FormatTextForEvent(IEnumerable<EventDTO> eventItems);
	}
}
