using System;
using System.Collections.Generic;

public class Program{
    public static void Main(string[] args){
        
        string numbers = "0123456789";
        string letters = "abcdefghijklmnopqrstuvwxyz";
        string capital = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string special = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";

        bool hasNumber;
        bool hasLetter;
        bool hasCapital;
        bool hasSpecial;
        bool accepted;

        do{
            Console.WriteLine("Enter a password: ");
            string password = Console.ReadLine().Trim();

            hasNumber = false;
            hasLetter = false;
            hasCapital = false;
            hasSpecial = false;
            foreach(char symbol in password){
                if(numbers.Contains(symbol)){
                    hasNumber = true;
                }
                if(letters.Contains(symbol)){
                    hasLetter = true;
                }
                if(capital.Contains(symbol)){
                    hasCapital = true;
                }
                if(special.Contains(symbol)){
                    hasSpecial = true;
                }
            }

            accepted = true;
            Console.ForegroundColor = ConsoleColor.Red;
            if(password.Length < 8){
                Console.WriteLine("Password needs to be at least 8 characters");
                accepted = false;
            }
            if(!hasNumber){
                Console.WriteLine("Password needs to have a number");
                accepted = false;
            }
            if(!hasLetter){
                Console.WriteLine("Password needs to have a letter");
                accepted = false;
            }
            if(!hasCapital){
                Console.WriteLine("Password needs to have a capital letter");
                accepted = false;
            }
            if(!hasSpecial){
                Console.WriteLine("Password needs to have a special character");
                accepted = false;
            }
            Console.ResetColor();
        }while(!accepted);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Password is strong enough");
        Console.ResetColor();
    }
}