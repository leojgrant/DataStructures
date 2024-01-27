// See https://aka.ms/new-console-template for more information
using DataStructures.Service;

Console.Write("Creating an empty hash map with a size of 3 (in all arrays)...");
HashMap dictionary = new HashMap(3);
Console.WriteLine("Created!");
dictionary.DisplayHashMap();

Console.WriteLine();
Console.WriteLine("Adding values...");
dictionary.AddKeyValuePair("apple", "This ");
dictionary.AddKeyValuePair("banana", "actually ");
dictionary.AddKeyValuePair("orange", "works!");
Console.WriteLine();

Console.Write("The Hash Map now looks like this: ");
dictionary.DisplayHashMap();

Console.WriteLine("\nSelecting each value (from left to right you get):\n");
Console.Write(dictionary.GetValue("apple"));
Console.Write(dictionary.GetValue("banana"));
Console.WriteLine(dictionary.GetValue("orange"));
