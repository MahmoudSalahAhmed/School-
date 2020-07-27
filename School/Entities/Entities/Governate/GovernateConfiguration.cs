using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class GovernateConfiguration : EntityTypeConfiguration<Governate>
    {
        public GovernateConfiguration()
        {
            ToTable("Governate");
            Property(i => i.Name).HasMaxLength(50).IsRequired();
            HasMany(i => i.Students).WithRequired(i => i.Governate);
            HasMany(i => i.Neighborhoods).WithRequired(i => i.Governate);
        }
    }
}
