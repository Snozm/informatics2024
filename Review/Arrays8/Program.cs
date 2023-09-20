using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter height:");
        int height = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter width:");
        int width = int.Parse(Console.ReadLine());
        List<Word> words = new List<Word>();

        for(int i = 0; i < height; i++){
            Console.WriteLine($"Enter row {i+1}");
            string row = Console.ReadLine();
            string[] rowItems = row.Split(" ");
            for(int j = 0; j < width; j++){
                words.Add(new Word(rowItems[j]));
            }
        }
        
        int maxChain = 0;
        string answer = "";
        int counter = 0;
        foreach(Word word in words){
            int chain = word.search(words, counter / width, counter % width, height, width);
            if(chain >= maxChain){
                maxChain = chain;
                answer = word.getWord();
            }
            counter++;
        }
        
        Console.WriteLine(answer + " " + maxChain);

        /*for(int i = 0; i < height; i++){
            for(int j = 0; j < width; j++){
                Console.Write(words[i * width + j].getWord() + " ");
            }
            Console.WriteLine();
        }*/
    }
}

class Word{
    private string word;
    private bool visited;
    public Word(string word){
        this.word = word;
        visited = false;
    }
    //I'm sorry I couldn't figure out a way to remove width and height from here
    public int search(List<Word> words, int i, int j, int height, int width){
        return searchH(words, i, j, height, width, this.word);
    }
    private int searchH(List<Word> words, int i, int j, int height, int width, string word){

        if(i < 0 || i >= height || j < 0 || j >= width){
            return 0;
        }
        
        Word current = words[i * width + j];

        if(current.isVisited()){
            return 0;
        }
        
        if(current.getWord() != word){
            return 0;
        }

        current.Visit();
        
        return 1 + searchH(words, i+1, j, height, width, word) + searchH(words, i-1, j, height, width, word) + searchH(words, i, j+1, height, width, word) + searchH(words, i, j-1, height, width, word);
        
    }
    public string getWord(){
        return this.word;
    }
    public void Visit(){
        visited = true;
    }
    public bool isVisited(){
        return visited;
    }
}