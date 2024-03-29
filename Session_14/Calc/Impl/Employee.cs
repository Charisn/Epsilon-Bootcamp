﻿using PetShopLib.Enums;
using PetShopLib.Impl.Model;
using PetShopLib.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopLib.Impl;

public class Employee : BaseEntity, IEmployee
{
    [Required]
    public decimal SalaryPerMonth { get; set; }
    public EmployeeTypeEnum EmployeeType { get; set; }
    public string Name { get; set; }
    public string SurName { get; set; }
    public Guid ID { get; set; }

    public Employee()
    {
        ID = Guid.NewGuid();            
    }
    public Employee(string name, string surname, decimal salary) : this()
    {
        SalaryPerMonth = salary;
        Name = name;
        SurName = surname;
    }
}
