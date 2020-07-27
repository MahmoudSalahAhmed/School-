using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class StudentEditViewModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "This Field Is Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This Field Is Required")]
        public DateTime BirthDate { get; set; }
        [Required(ErrorMessage = "This Field Is Required")]
        public int GovernateID { get; set; }
        [Required(ErrorMessage = "This Field Is Required")]
        public int NeighborhoodID { get; set; }
        [Required(ErrorMessage = "This Field Is Required")]
        public int FieldID { get; set; }

    }
}
