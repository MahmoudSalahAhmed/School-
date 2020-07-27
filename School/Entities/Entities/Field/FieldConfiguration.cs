using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class FieldConfiguration : EntityTypeConfiguration<Field>
    {
        public FieldConfiguration()
        {
            ToTable("Field");
            Property(i => i.Name).HasMaxLength(40).IsRequired();
            HasMany(i => i.Students).WithRequired(i => i.Field);
            //.WillCascadeOnDelete(false)
        }
    }
}
