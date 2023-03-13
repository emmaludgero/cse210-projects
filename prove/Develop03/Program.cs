using System;

class Program
{
    static void Main(string[] args)
    {

        Scripture scripture = new Scripture();
        Reference reference = new Reference();
        string rf = reference.DisplayReference();
        scripture.DisplayScripture(rf);
        Word words = new Word("And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        var userInput = ".";
        do {
            
            words.Hide();
            Console.Clear();
            words.DisplayWords(rf);

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine();

        } while (userInput != "quit");
    }
}
