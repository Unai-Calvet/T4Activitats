using System;
using System.Collections.Generic;

namespace T4Activitats {
    public class Employee {
        public int GetAge(DateTime birthDate) { 
            return Utils.TotalYears(DateTime.Now.Subtract(birthDate));
        }
    }
}
