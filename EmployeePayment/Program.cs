using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using EmployeePayment.Entities;
using System.Globalization;

namespace EmployeePayment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.WriteLine("Enter the number of Employees");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i<=n; i++)
            {
                Console.WriteLine($"Employee number #{i} data: ");

                Console.WriteLine("Outsourced (y/n)? ");
                char sn = char.Parse(Console.ReadLine());

                Console.WriteLine("Name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Hours ");
                int hours = int.Parse(Console.ReadLine());

                Console.WriteLine("Value per hour ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(sn == 'y')
                {
                    Console.WriteLine("Addtional Charge: ");
                    double addtionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new OutsourcedEmployee(addtionalCharge, name, hours, valuePerHour));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));

                }

                

            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS: ");
            foreach (Employee emp in list)
            {

                Console.WriteLine(emp.Name + " - $" + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));

            }
        }
    }
}
