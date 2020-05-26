﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManagement.Models
{
    public class EmployeesModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Designation { get; set; }
        public double BasicPay { get; set; }
        public string EmployeeType { get; set; }
        public double Salary { get; set; }
        public double HRA { get; set; }
        
    }
}
