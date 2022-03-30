using System;
using System.Collections.Generic;
using System.Text;

using Domain.Enums;

namespace Domain.Models
{
    public class Contractor : Employee
    {

        public double WorkHours { get; set; }

        public int PayPerHour { get; set; }

        public Manager Responsible { get; set; }

        public Contractor(string firstName, string lastName, double workHours, int payPerHours, Manager manager)
        {
            FirstName = firstName;
            LastName = lastName;
            //specific for Contractor
            Role = RoleEnum.Contractor;
            WorkHours = workHours;
            PayPerHour = payPerHours;
            Responsible = manager;

            Salary = GetSalary();
        }

        public override double GetSalary()
        {
            return WorkHours * PayPerHour;
        }

        public RoleEnum CurrentPosition()
        {
            return Responsible.Role;
        }
    }
}
