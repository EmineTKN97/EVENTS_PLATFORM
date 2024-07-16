using Events_Onion.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Onion.Application.Abstractions.Services.Concrete
{
    public class ExportService(ITextService _textService, IFileService _fileService)
	{
		public async Task ExportEventAsync(IEnumerable<EventDTO> eventItems, string path)
		{ 
			var formatedText = _textService.FormatTextForEvent(eventItems);
			await	_fileService.SaveTextAsync(formatedText, path);
		
		}
	}
}
