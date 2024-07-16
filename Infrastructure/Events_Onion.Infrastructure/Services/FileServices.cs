using Events_Onion.Application.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Onion.Infrastructure.Services
{
	public class FileServices : IFileService
	{
		public async Task SaveTextAsync(string text, string path)
		{
			try
			{
				if (string.IsNullOrWhiteSpace(path))
				{
					throw new ArgumentNullException(nameof(path));
				}

				await File.WriteAllTextAsync(text, path);
			}
			catch (Exception ex) 
			{
				Console.WriteLine($"An error occured while saving the text to file :{ex.Message}");
			}
		}
	}
}
