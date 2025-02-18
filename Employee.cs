using System;
using System.Collections.Generic;
using System.Globalization;

namespace T4Activitats {
    public class Employee {
        const string MessageDivider = "-----------------------------------------------------------------------------------------------------------------------------------";
        const float DefaultMonthSalary = 1800;
        const int DefaultPayments = 14;
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public float MonthSalary { get; set; }
        public int Payments { get; set; }
        public Employee(string birthDate, string hireDate, string code, float monthSalary, int payments, string name, string surname) { 
            BirthDate = DateTime.ParseExact(birthDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            HireDate = DateTime.ParseExact(hireDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Code = code;
            MonthSalary = monthSalary;
            Payments = payments;
            Name = name;
            Surname = surname;
        }
        public Employee(string birthDate, string hireDate, string code, int payments, string name, string surname) : this(birthDate, hireDate, code, DefaultMonthSalary, payments, name, surname){ }
        public Employee(string birthDate, string hireDate, string code, float monthSalary, string name, string surname) : this(birthDate, hireDate, code, monthSalary, DefaultPayments, name, surname) { }
        public Employee(string birthDate, string hireDate, string code, string name, string surname) : this(birthDate, hireDate, code, DefaultMonthSalary, DefaultPayments, name, surname) { }
        public int GetAge(DateTime birthDate) { 
            return Utils.TotalYears(DateTime.Now.Subtract(birthDate));
        }
        public int GetAge() {
            return Utils.TotalYears(DateTime.Now.Subtract(BirthDate));
        }
        public string GetFullName() {
            return $"{Name} {Surname}";
        }
        public string GetFullInversedName() {
            return $"{Surname}{Name}";
        }
        public int GetJobTimeInYears() {
            return Utils.TotalYears(DateTime.Now.Subtract(HireDate));
        }
        public float GetYearSalary() {
            return MonthSalary * Payments;
        }
        public virtual string TitleToString() {
            return $"{MessageDivider}\nE M P L O Y E E\n{MessageDivider}";
        }
        public override string ToString() {
            return $"{TitleToString()}\nCode: {Code}\nFirstname {Name}\nLast name: {Surname}\n" +
                $"Full name: {GetFullName()}\nReverse name: {GetFullInversedName()}\nAge: {GetAge()} years\n" +
                $"Seniority: {GetJobTimeInYears()} years\nAnnual salary {GetYearSalary()}\n";
        }
    }
}