﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class FieldEditViewModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Name Is Required")]
        public string Name { get; set; }
        
    }
}
