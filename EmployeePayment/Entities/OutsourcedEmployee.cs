using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePayment.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AddtionalCharge { get; set; }

        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(double addtionalCharge, string name, int hours, double valuePerHour)
            : base(name, hours, valuePerHour)
        {
            AddtionalCharge = addtionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AddtionalCharge;
        }
    }

   
}
