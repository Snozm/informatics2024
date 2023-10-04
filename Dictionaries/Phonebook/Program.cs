using System;
using System.Collections.Generic;

public class Program{
    public static void Main(string[] args){
        Dictionary<string, string> contacts = new Dictionary<string, string>();
        
        Console.WriteLine("Select action:");
        Console.WriteLine("1. Add contact");
        Console.WriteLine("2. Search contact");
        Console.WriteLine("3. Delete contact");
        Console.WriteLine("Or anything else to quit");
        string choice = Console.ReadLine();
        
        while(choice == "1" || choice == "2" || choice == "3"){
            switch(choice){
                case "1":
                    Console.WriteLine("Enter name to add:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter phone number:");
                    string phone = Console.ReadLine();
                    contacts.Add(name, phone);
                    break;
                case "2":
                    Console.WriteLine("Enter name to search:");
                    name = Console.ReadLine();
                    bool found = false;
                    foreach (KeyValuePair<string,string> contact in contacts){
                        if(contact.Key == name){
                            Console.WriteLine($"Number of {name} is: {contact.Value}");
                            found = true;
                        }
                    }
                    if(!found){
                        Console.WriteLine("Contact not found.");
                    }
                    break;
                case "3":
                    Console.WriteLine("Enter name to delete:");
                    name = Console.ReadLine();
                    contacts.Remove(name);
                    break;
            }
            Console.WriteLine("Enter new choice:");
            choice = Console.ReadLine();
        }
    }
}