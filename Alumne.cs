using System;

namespace T4Activitats {
    public class Alumne {
        const string DefaultName = "Unknown";
        const int DefaultAge = 20;
        const string DefaultCity = "Unknown";
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public Alumne(string name, int age, string city) {
            Name = name;
            Age = age;
            City = city;
        }
        public Alumne() : this(DefaultName, DefaultAge, DefaultCity) { }
    }
}
