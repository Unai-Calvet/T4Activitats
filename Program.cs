using System;
using System.Collections;
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
            //Utils.WriteArrayList(arrayList);

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
        }
    }
}