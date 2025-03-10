﻿using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Globalization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace T4Activitats {
    public class ActT4 {
        public static void Main() {
            /*
            // Exercici 1
            Parella<string, int> parellaStringInt = new Parella<string, int>("text", 1);
            Parella<double, string> parellaDoubleString = new Parella<double, string>(3.14, "text");

            // Exercici 2
            const string Message = "Indrodueix un valor: ";
            int listArrayLenght;

            ArrayList arrayList = new ArrayList();
            listArrayLenght = Utils.AskIntValue();
            for (int i = 0; i < listArrayLenght; i++) {
                Console.WriteLine(Message);
                arrayList.Add(Console.ReadLine());
            }
            Console.Write("\n");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            // Exercici 3
            const string AskForNameMessage = "Indrodueix un nom: ";
            const string AskForAgeMessage = "Introdueix una edat";
            int dictionaryLenght;
            string name;
            int age;

            Dictionary<string,int> dictionary = new Dictionary<string, int>();
            dictionaryLenght = Utils.AskIntValue();
            for (int i = 0; i < dictionaryLenght; i++) {
                name = Utils.AskStringValue(AskForNameMessage);
                age = Utils.AskNaturalValue(AskForAgeMessage);
                dictionary.Add(name,age);
            }
            Console.Write("\n");
            foreach (var item in dictionary) {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
             //Exercici 4
            const string AskListLengthMessage = "Introdueix el nombre d'elements de la llista";
            const string AskNameMessage = "Introdueix un nom";
            int listLenght;
            List<string> list = new List<string>();
            listLenght = Utils.AskIntValue(AskListLengthMessage);
            for (int i = 0; i < listLenght; i++) {
                list.Add(Utils.AskStringValue(AskNameMessage));
            }
            List<string> orderedList = new List<string>(list);
            orderedList.Sort();

            Console.WriteLine("\n");
            foreach (var item in list) {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
            foreach (var item in orderedList) {
                Console.WriteLine(item);
            }
             //Exercici 5
            int listLength;
            List<int> list = new List<int>();
            listLength = Utils.AskIntValue();
            for (int i = 0; i < listLength; i++) { 
                list.Add(Utils.AskIntValue());
            }
            Console.WriteLine("\n");
            list = list.Where(x => x % 2 == 0).ToList();
            list.ForEach(x => { Console.WriteLine(x); });
             //Exercici 6
            const string Message = "Falten {0} dies per a la data introduida. ";
            DateTime nowDate = DateTime.Today;
            DateTime date;
            date = Utils.AskFutureDateTime();
            Console.WriteLine(Message, (date - nowDate).TotalDays);

             // Exercici 7
            string? stringArrayList = "";
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Maria");
            arrayList.Add("Joan");
            arrayList.Add("Anna");
            arrayList.Add(42);
            arrayList.Add(true);
            foreach (var item in arrayList) {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------");
            arrayList.Remove(42);
            arrayList.Remove(true);
            foreach (var item in arrayList) {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------");
            arrayList.Insert(1, "Pere");
            foreach (var item in arrayList) {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------");
            Console.WriteLine(arrayList.Contains("Anna"));
            Console.WriteLine("--------------");
            foreach (var item in arrayList) {
                stringArrayList += Convert.ToString($"{item}\n");
            }
            Console.WriteLine(stringArrayList);
            /*
            // Exercici 8
            List<int> list = new List<int> { 5, 10, 15, 20, 25 };
            list.Add(30);
            list.Insert(0, 7);
            list.Remove(15);
            list.OrderDescending();
            List<int> pairList = list.Where(x => x % 2 == 0).ToList();
            pairList.ForEach(x => Console.WriteLine(x));

            // Exercici 9
            const string WriteDictionaryMessage = "Nom: {0}, Edat: {1}";
            const string AskAName = "Introdueix un nom: ";
            int age;
            string name;
            Dictionary<string,int> dictionary = new Dictionary<string,int>();
            dictionary.Add("Marc", 21);
            dictionary.Add("Laura", 19);
            dictionary.Add("Pau", 22);
            foreach (var item in dictionary) {
                Console.WriteLine(WriteDictionaryMessage, item.Key, item.Value);
            }
            Console.WriteLine("\n");
            name = Utils.AskStringValue(AskAName);
            Console.WriteLine(dictionary.TryGetValue(name, out age) ? $"L'estudiant indicat existeix, i la seva edat és: {age}." : "L'estudiant indicat no existeix. ");
            dictionary.Remove("Laura");
            foreach (var item in dictionary) {
                Console.WriteLine(WriteDictionaryMessage, item.Key, item.Value);
            }

            // Exercici 10
            Utils.AskTwoDatesAndCompare();

            // Exercici 11
            Console.WriteLine(Utils.GetNowWeekDay());

            // Exercici 12
            Employee employee = new Employee();
            DateTime birth = new DateTime(2006, 11, 14);
            Console.WriteLine($"{employee.GetAge(birth)} anys");

            // Exercici 13
            List<Employee> employeesList = new List<Employee>();
            List<SalesEmployee> salesEmployeesList = new List<SalesEmployee>();

            employeesList.Add(new Employee("16/11/1982", "14/11/2006", "123456789A", 2100, 10, "Pepe", "García"));
            employeesList.Add(new Employee("10/04/1981", "23/09/2008", "385639547H", 10, "Joana", "Fernàndez"));
            employeesList.Add(new Employee("16/11/1982", "14/11/2016", "482593759B", 1900, "Alex", "Porta"));
            employeesList.Add(new Employee("20/02/0023", "04/12/0034", "574659574K", "Leto", "Atreides"));
            employeesList.Add(new Employee("13/12/1938", "04/04/1954", "836463746T", 450000, 52, "Shadam", "Corrino"));
            employeesList = employeesList.OrderByDescending(n => n.GetJobTimeInYears()).ToList();
            employeesList.ForEach(n => Console.WriteLine(n.ToString()));

            salesEmployeesList.Add(new SalesEmployee("12/09/1957", "01/01/2021", "987654321D", 700, 50, 1.9f, "Hans", "Zimmer"));
            salesEmployeesList.Add(new SalesEmployee("10/04/1981", "23/09/2008", "385639547H", 10, 1.1f, "Joana", "Fernàndez"));
            salesEmployeesList.Add(new SalesEmployee("16/11/1982", "14/11/2006", "482593759B", 1900, 1.6f, "Alex", "Porta"));
            salesEmployeesList.Add(new SalesEmployee("16/11/1982", "14/11/2016", "123456789A", 1.8f, "Pepe", "García"));
            salesEmployeesList.Add(new SalesEmployee("13/07/1940", "04/12/1987", "000001701D", 1f, "Jean-Luc", "Picard"));
            salesEmployeesList = salesEmployeesList.OrderByDescending(n => n.GetJobTimeInYears()).ToList();
            salesEmployeesList.ForEach(n => Console.WriteLine(n.ToString()));

            //Exercici 14
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Console.WriteLine(list.Sum());

            // Exercici 15
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            var even = list.Where(x => x%2 == 0);
            Console.WriteLine(string.Join(", ", even));

            // Exercici 16
            List<string> list = new List<string>();
            string[] array = { "a", "string", "array", "to", "<stirng>", "list" };
            list = array.ToList();
            list.ForEach(x => Console.WriteLine(x));

            // Exercici 17
            Dictionary<string, int> dictionaryEmployeesSalary = new Dictionary<string, int>();

            dictionaryEmployeesSalary.Add("person 1", 1000);
            dictionaryEmployeesSalary.Add("person 2", 1200);
            dictionaryEmployeesSalary.Add("person 3", 800);

            foreach (var person in dictionaryEmployeesSalary) {
                Console.WriteLine($"Name: {person.Key}, Salary: {person.Value}");
            }

            // Exercici 18
            const string AskListLengthMessage = "Introdueix la qunatitat de números de la llista: ";
            const string AskFilterNumberMessage = "S'eliminaran els valors majors a: ";
            List<int> list = new List<int>();
            int length = Utils.AskIntValue(AskListLengthMessage);
            int maxNumList;
            for (int i = 0; i < length; i++) { 
                list.Add(Utils.AskIntValue());
            }
            maxNumList = Utils.AskIntValue(AskFilterNumberMessage);
            list.RemoveAll(x => x > maxNumList);
            list.ForEach(x => Console.WriteLine(x));

                // Exercici 19
                Delegates.Operacio mult = Delegates.Multiplicar;
                Delegates.Operacio div = Delegates.Dividir;

                Console.WriteLine(mult(10,5));
                Console.WriteLine(div(10,5));

            // Exercici 20
            Console.WriteLine(Delegates.ExecutarOperacio(10, 5, Utils.Multiplicar));
            Console.WriteLine(Delegates.ExecutarOperacio(10, 5, Utils.Dividir));

            // Exercici 21
            const string Message = "Aquest es el missatge";
            Delegates.Notificacio notificacio;
            notificacio = Delegates.MostrarMissatgeConsola;
            notificacio += Delegates.MostrarMissatgeAmbEstreles;
            notificacio(Message);

            // Exercici 22
            Func<int, int, int> funcMultiplicar = (x, y) => x * y;
            Action<int, int> actMultiplicar = (x, y) => Console.WriteLine(x * y);
            Console.WriteLine(Delegates.ExecutarOperacio(funcMultiplicar, 2, 5));
            Delegates.ExecutarOperacio(actMultiplicar, 2, 5);

            // Exercici 23
            Delegates.Operacio operacio = (int x, int y) => (int)Math.Pow(x, y);
            Console.WriteLine(operacio(5,2)); 

            //Exercici 24
            const string mesg = "1";
            Delegates.ExecutarAmbMetodeAnonim(delegate () { Console.WriteLine(mesg); });
            Delegates.ExecutarAmbMetodeAnonim(delegate () { Console.WriteLine(mesg); });

            // Exercici 25 
            Func<int, int, int> suma = (x,y) => x + y;
            Console.WriteLine(suma(2, 2));

            // Exercici 26
            Console.WriteLine(Utils.IsValidEmail("usuari@gmail.com")); 
            Console.WriteLine(Utils.IsValidEmail("usuari@gmail"));

            // Exercici 27
            Console.WriteLine(Utils.IsValidPhoneNumber("+34 600 123 456"));
            Console.WriteLine(Utils.IsValidPhoneNumber("+34600123456"));
            Console.WriteLine(Utils.IsValidPhoneNumber("600123456"));
            Console.WriteLine(Utils.IsValidPhoneNumber("60012345"));

            // Exercici 28
            Console.WriteLine(Utils.ExtractNumbers("Avui és el dia 12 del mes 02 de l'any 2024"));

            // Exercici 29
            Console.WriteLine(Utils.IsValidPassword("Hola1234!"));
            Console.WriteLine(Utils.IsValidPassword("hola1234"));

            // Exercici 30
            Console.WriteLine(Utils.IsValidPostalCode("08001"));
            Console.WriteLine(Utils.IsValidPostalCode("60000"));

            // Exercici 31
            List<int> list = new List<int>();
            list.Add(-65);
            list.Add(-4);
            list.Add(2);
            list.Add(3);
            list.Add(5);
            list.Add(2);
            list.Add(5);
            list.Add(80);
            list.Add(23);
            list.Add(54);

            List<int> modifiedList = list.Where(x => x % 2 == 0).ToList();
            modifiedList.ForEach(x => Console.WriteLine(x));

            modifiedList = list.Where(x => x > 0).ToList();
            modifiedList.ForEach((x) => Console.WriteLine(x));

            modifiedList = list.Where(x => x > 20).ToList();
            modifiedList.ForEach((x) => Console.WriteLine($"{x}, {x*x}"));
            
            // Exercici 32
            string line;
            string path = Path.GetFullPath(@"..\..\..\Files\notes.txt");
            using (StreamWriter sw = new StreamWriter(path)) {
                sw.WriteLine("nom1 cognom1: 5,7\nnom2 cognom2: 7,8\nnom3 cognom3: 5\nnom4 cognom4: 4,9\nnom5 cognom5: 5,7");
            }
            using (StreamReader sr = new StreamReader(path)) {
                while ((line = sr.ReadLine()) != null) {
                    Console.WriteLine(line);
                }
            }
            
            // Exercici 33
            List<Alumne> alumnes = new List<Alumne> {
                new Alumne("Joan", 30, "Barcelona"),
                new Alumne("Maria", 25, "Madrid"),
                new Alumne("Pepa", 19, "Barcelona"),
                new Alumne("Pepe", 53, "Madrid"),
                new Alumne()
            };
            string path = Path.GetFullPath(@"..\..\..\Files\alumnes.csv");
            using (var writer = new StreamWriter(path))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture)) { 
                csv.WriteRecords(alumnes);
            }

            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture)) { 
                var registres = csv.GetRecords<Alumne>();
                foreach (var alumne in registres) {
                    Console.WriteLine($"Nom: {alumne.Name}, Edat: {alumne.Age}, Ciutat: {alumne.City}");
                }
            }
            
            // Exercici 34
            string path = Path.GetFullPath(@"..\..\..\Files\llibres.xml");
            XDocument documetxml = new XDocument(
                new XElement("llibres",
                    new XElement("llibre", 
                        new XElement("titol", "Dune"),
                        new XElement("autor", "Frank Herbert"),
                        new XElement("any", "1965")
                    ),
                    new XElement("llibre",
                        new XElement("titol", "Ubik"),
                        new XElement("autor", "Philip K. Dick"),
                        new XElement("any", "1969")
                    )
                )
            );
            documetxml.Save(path);

            XDocument documetXml = XDocument.Load(path);
            var llibres = from llibre in documetXml.Descendants("llibre")
                                 select new {
                                     Title = llibre.Element("titol").Value,
                                     Autor = llibre.Element("autor").Value,
                                     Year = llibre.Element("any").Value
                                 };
            foreach (var llibre in llibres) {
                Console.WriteLine($"Titol: {llibre.Title}, Autor: {llibre.Autor}, Any: {llibre.Year}");
            }
            */
            // Exercci 35
            string path = Path.GetFullPath(@"..\..\..\Files\llibres.json");
            List<Book> llibres = new List<Book> { 
                new Book("Ubik",  "Philip K. Dick", 1969),
                new Book("Dune",  "Frank Herbert", 1965)
            };
            string jsoncontent = JsonConvert.SerializeObject(llibres, Formatting.Indented);
            File.WriteAllText(path, jsoncontent);

            List<Book> llistaLlibres = JsonConvert.DeserializeObject<List<Book>>(File.ReadAllText(path));
            foreach (var llibre in llistaLlibres) {
                Console.WriteLine($"Nom: {llibre.Title}, Autor: {llibre.Autor}, Any: {llibre.Year}");
            }
        }
    }
}