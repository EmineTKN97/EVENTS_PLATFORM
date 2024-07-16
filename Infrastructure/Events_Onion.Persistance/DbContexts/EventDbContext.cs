using Events_Onion.Domain.Common;
using Events_Onion.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Onion.Persistance.DbContexts
{
   public class EventDbContext:DbContext
    {
        public DbSet<Event> Events { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("EventDB");
        }
		public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
		{
            var data = ChangeTracker.Entries<EntityBase>();
            foreach (var entry in data)
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreatedDate = DateTime.UtcNow;
                }
                else if (entry.State == EntityState.Modified)
                { 
                    entry.Entity.UpdatedDate = DateTime.UtcNow; 
                }
          
            }
			return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
		}
	}
}
