using System;
using System.Collections.Generic;

namespace T4Activitats {
    public class SalesEmployee : Employee {
        const string MessageDivider = "-----------------------------------------------------------------------------------------------------------------------------------";
        const float DefaultMonthSalary = 1800;
        const int DefaultPayments = 14;
        public float Comission {  get; set; }

        public SalesEmployee(string birthDate, string hireDate, string code, float salary, int payments, float comission, string name, string surname) : base(birthDate, hireDate, code, salary, payments, name, surname) { 
            Comission = comission;
        }
        public SalesEmployee(string birthDate, string hireDate, string code, int payments, float comission, string name, string surname) : this(birthDate, hireDate, code, DefaultMonthSalary, payments, comission, name, surname) { }
        public SalesEmployee(string birthDate, string hireDate, string code, float monthSalary, float comission, string name, string surname) : this(birthDate, hireDate, code, monthSalary, DefaultPayments, comission, name, surname) { }
        public SalesEmployee(string birthDate, string hireDate, string code, float comission, string name, string surname) : this(birthDate, hireDate, code, DefaultMonthSalary, DefaultPayments, comission, name, surname) { }

        public override string TitleToString() {
            return $"{MessageDivider}\nS A L E S E M P L O Y E E\n{MessageDivider}";
        }
        public override string ToString()
        {
            return base.ToString() + $"Commision: {Comission}";
        }
    }
}
