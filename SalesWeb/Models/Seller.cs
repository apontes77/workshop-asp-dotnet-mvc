﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWeb.Models
{
    public class Seller
    {
       

        public int Id { get; set; }

        [Required(ErrorMessage = "{0} Required")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} size should be between {2} and {1}")]
        public string Name { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "{0} Required")]
        public string  email { get; set; }

        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "{0} Required")]
        public DateTime birthDate { get; set; }

        [Display(Name = "Base Salary")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Required(ErrorMessage = "{0} Required")]
        public double baseSalary { get; set; }
        public int DepartmentId { get; set; }

        public Department department { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            this.email = email;
            this.birthDate = birthDate;
            this.baseSalary = baseSalary;
            this.department = department;
        }

        public void addSales (SalesRecord sr) 
        {
            Sales.Add(sr);
        }

       public void removeSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double totalSales (DateTime initial, DateTime final)
        {
            return Sales
                        .Where(sr => sr.Date >= initial && sr.Date <= final)
                        .Sum(sr => sr.Amount);
        }
    }
}
