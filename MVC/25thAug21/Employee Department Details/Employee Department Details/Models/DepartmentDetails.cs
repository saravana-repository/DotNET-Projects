﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Department_Details.Models
{
    public class DepartmentDetails
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Department Name is required")]
        [StringLength(25, ErrorMessage = "Department Name can not exceed 25 characters")]
        public string DepartmentName { get; set; }

    }
}
