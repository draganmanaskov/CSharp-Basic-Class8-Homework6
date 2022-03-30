using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class CEO : Employee
    {
        private int _shares { get; set; }

        private double _sharesPrice { get; set; }

        public Manager[] EmployeeManagers { get; set; }

        public Contractor[] EmployeeContractors { get; set; }

        public SalesPerson[] EmplyeeSalesPeople { get; set; }

        public CEO(string firstName, string lastName, int shares, double sharePrice, Manager[] managers, Contractor[] contractors, SalesPerson[] salesPeople)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = 1500;

            //specific for CEO
            _shares = shares;
            _sharesPrice = sharePrice;

            EmployeeManagers = managers;
            EmployeeContractors = contractors;
            EmplyeeSalesPeople = salesPeople;
        }

        public override double GetSalary()
        {
            return Salary + _shares * _sharesPrice;
        }

        public void AddSharesPrice(double shares)
        {
            _sharesPrice = shares;
        }
        public void PrintEmployees()
        {
            Console.WriteLine("Emplyees");
            Console.WriteLine("---------");
            Console.WriteLine("Managers");
            foreach (Manager manager in EmployeeManagers)
            {
                Console.WriteLine($"{manager.FirstName} {manager.LastName}");
            }

            Console.WriteLine("---------");
            Console.WriteLine("Contracors");
            foreach (Contractor contractors in EmployeeContractors)
            {
                Console.WriteLine($"{contractors.FirstName} {contractors.LastName}");
            }

            Console.WriteLine("---------");
            Console.WriteLine("SalesPeople");
            foreach (SalesPerson salesPerson in EmplyeeSalesPeople)
            {
                Console.WriteLine($"{salesPerson.FirstName} {salesPerson.LastName}");
            }
        }
    }
}
