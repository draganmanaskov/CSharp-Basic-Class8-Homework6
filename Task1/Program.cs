using System;

using Domain.Models;
using Domain.Enums;

using System.Collections.Generic;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee()
            //{
            //    FirstName = "Marko",
            //    LastName = "Markovski",
            //    Role = RoleEnum.Other
            //};
            //employee.PrintInfo();

            //SalesPerson salesPerson = new SalesPerson("Bob", "Bobsky");
            //salesPerson.AddSuccessRevenue(7000);
            ////GetSalary from SalesPerson is called
            //Console.WriteLine(salesPerson.GetSalary());

            Manager manager = new Manager("Bill", "Billsky", 700);
            //GetSalary from Manager is called
            //Console.WriteLine(manager.GetSalary());
            manager.AddBonus(200);
            manager.AddBonus(200);
            //GetSalary from Manager is called
            //Console.WriteLine(manager.GetSalary());


            //my code

            Contractor econtractorOne = new Contractor("Dragan", "Manaskov",40, 20, manager);
            //print salary
            Console.WriteLine(econtractorOne.GetSalary());
            //print the department of the manager that is responsible for this Contractor
            Console.WriteLine(econtractorOne.CurrentPosition());

            //Task 2

            Manager[] managerArray = new Manager[]
            {
                new Manager("Bob", "Smith", 600),
                new Manager("Sara", "White", 800)
            };

            Contractor[] contractorsArray = new Contractor[]
            {
                new Contractor("Ana", "Bell",40, 20, managerArray[0]),
                new Contractor("Oliver", "Bush",40, 20, managerArray[1])
            };

            SalesPerson[] salesPersonArray = new SalesPerson[]
            {
                new SalesPerson("Steven", "Hill"),
            };


            CEO ourCEO = new CEO("Jeff", "Jobs", 100, 200, managerArray, contractorsArray, salesPersonArray);

            Console.WriteLine("=====TASK 2=======");
            ourCEO.PrintInfo();
            Console.WriteLine($"Salary of CEO is: {ourCEO.GetSalary()}");
            ourCEO.PrintEmployees();



        }
    }
}
