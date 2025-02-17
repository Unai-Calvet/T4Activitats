using System;
using System.Collections;
using System.Data;
using System.Globalization;
using System.Runtime.InteropServices;
namespace T4Activitats { 
    public class ActT4 {
        public static void Main() {
            // Exercici 1
            //Parella<string, int> parellaStringInt = new Parella<string, int>("text", 1);
            //Parella<double, string> parellaDoubleString = new Parella<double, string>(3.14, "text");

            // Exercici 2
            //const string Message = "Indrodueix un valor: ";
            //int listArrayLenght;

            //ArrayList arrayList = new ArrayList();
            //listArrayLenght = Utils.AskIntValue();
            //for (int i = 0; i < listArrayLenght; i++) {
            //    Console.WriteLine(Message);
            //    arrayList.Add(Console.ReadLine());
            //}
            //Console.Write("\n");
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            // Exercici 3
            //const string AskForNameMessage = "Indrodueix un nom: ";
            //const string AskForAgeMessage = "Introdueix una edat";
            //int dictionaryLenght;
            //string name;
            //int age;

            //Dictionary<string,int> dictionary = new Dictionary<string, int>();
            //dictionaryLenght = Utils.AskIntValue();
            //for (int i = 0; i < dictionaryLenght; i++) {
            //    name = Utils.AskStringValue(AskForNameMessage);
            //    age = Utils.AskNaturalValue(AskForAgeMessage);
            //    dictionary.Add(name,age);
            //}
            //Console.Write("\n");
            //foreach (var item in dictionary) {
            //    Console.WriteLine($"{item.Key}: {item.Value}");
            //}
            // Exercici 4
            //const string AskListLengthMessage = "Introdueix el nombre d'elements de la llista";
            //const string AskNameMessage = "Introdueix un nom";
            //int listLenght;
            //List<string> list = new List<string>();
            //listLenght = Utils.AskIntValue(AskListLengthMessage);
            //for (int i = 0; i < listLenght; i++) {
            //    list.Add(Utils.AskStringValue(AskNameMessage));
            //}
            //List<string> orderedList = new List<string>(list);
            //orderedList.Sort();

            //Console.WriteLine("\n");
            //foreach (var item in list) {
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n");
            //foreach (var item in orderedList) {
            //    Console.WriteLine(item);
            //}
            // Exercici 5
            //int listLength;
            //List<int> list = new List<int>();
            //listLength = Utils.AskIntValue();
            //for (int i = 0; i < listLength; i++) { 
            //    list.Add(Utils.AskIntValue());
            //}
            //Console.WriteLine("\n");
            //list = list.Where(x => x % 2 == 0).ToList();
            //list.ForEach(x => { Console.WriteLine(x); });
            // Exercici 6
            //const string Message = "Falten {0} dies per a la data introduida. ";
            //DateTime nowDate = DateTime.Today;
            //DateTime date;
            //date = Utils.AskFutureDateTime();
            //Console.WriteLine(Message, (date - nowDate).TotalDays);

            // Exercici 7
            //string? stringArrayList = "";
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add("Maria");
            //arrayList.Add("Joan");
            //arrayList.Add("Anna");
            //arrayList.Add(42);
            //arrayList.Add(true);
            //foreach (var item in arrayList) {
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("--------------");
            //arrayList.Remove(42);
            //arrayList.Remove(true);
            //foreach (var item in arrayList) {
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("--------------");
            //arrayList.Insert(1, "Pere");
            //foreach (var item in arrayList) {
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("--------------");
            //Console.WriteLine(arrayList.Contains("Anna"));
            //Console.WriteLine("--------------");
            //foreach (var item in arrayList) {
            //    stringArrayList += Convert.ToString($"{item}\n");
            //}
            //Console.WriteLine(stringArrayList);
            /*
            // Exercici 8
            List<int> list = new List<int> { 5, 10, 15, 20, 25 };
            list.Add(30);
            list.Insert(0, 7);
            list.Remove(15);
            list.OrderDescending();
            List<int> pairList = list.Where(x => x % 2 == 0).ToList();
            pairList.ForEach(x => Console.WriteLine(x));
            */
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


        }
    }
}