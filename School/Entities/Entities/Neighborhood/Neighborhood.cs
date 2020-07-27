using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Neighborhood : BaseModel
    {
        public string Name { get; set; }
        public virtual Governate Governate { get; set; }
        public int GovernateID { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
