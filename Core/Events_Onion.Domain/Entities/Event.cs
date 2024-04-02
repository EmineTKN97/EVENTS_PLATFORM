using Events_Onion.Domain.Common;
using Events_Onion.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Onion.Domain.Entities
{
   public class Event:EntityBase
    {
    
        public string Title { get; set; }    

        public DateTimeOffset Date { get; set; }
        public Location Location { get; set; }

 
    }
}
