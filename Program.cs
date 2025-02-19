using System;
using System.Collections;

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
            */
            // Exercici 22
            Func<int, int, int> funcMultiplicar = (x, y) => x * y;
            Action<int, int> actMultiplicar = (x, y) => Console.WriteLine(x * y);
            Console.WriteLine(Delegates.ExecutarOperacio(funcMultiplicar, 2, 5));
            Delegates.ExecutarOperacio(actMultiplicar, 2, 5);
        }
    }
}