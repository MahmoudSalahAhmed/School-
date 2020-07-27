using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class NeighborhoodConfiguration : EntityTypeConfiguration<Neighborhood>
    {
        public NeighborhoodConfiguration()
        {
            ToTable("Neighborhood");
            Property(i => i.Name).IsRequired();
            HasRequired(i => i.Governate).WithMany(i => i.Neighborhoods).
                   HasForeignKey(i => i.GovernateID);
            HasMany(i => i.Students).WithRequired(i => i.Neighborhood).WillCascadeOnDelete(false);
        }
    }
}
