﻿using System;
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
            int listLength;
            List<int> list = new List<int>();
            listLength = Utils.AskIntValue();
            for (int i = 0; i < listLength; i++) { 
                list.Add(Utils.AskIntValue());
            }
            Console.WriteLine("\n");
            list = list.Where(x => x % 2 == 0).ToList();
            list.ForEach(x => { Console.WriteLine(x); });
        }
    }
}