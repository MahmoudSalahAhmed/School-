﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class StudentTeacherEditViewModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "This Field Is Required")]
        public int TeacherID { get; set; }
        [Required(ErrorMessage = "This Field Is Required")]
        public int StudentID { get; set; }
    }
}
