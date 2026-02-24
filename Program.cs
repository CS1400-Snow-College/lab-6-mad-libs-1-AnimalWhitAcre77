//Name: Ammon, 2/23/26, Lab 6: Madlibs

using System.IO.Pipes;

Console.Clear();
Console.WriteLine(@"Welcome to MadLibs!

Please enter the provided literary devices, and
you'll get a wacky story out of it!");

char[] vowels = ['a', 'e', 'i', 'o', 'u'];

string originalStory = "I've been known to tell a tall tale, but when it comes to (plural_noun), you gotta believe me! I was just going down to (place) when a big (adjective) (noun) blocked my way. I used a (noun) to get around, but I tripped on (plant). When I woke up, I found myself in (place) looking (direction) at some ninjas. After the (plural_noun), I woke up here.";

string[] storyWords = originalStory.Split(' ');

string newStory = "";
foreach (string word in storyWords)
{
    if (word[0] == '(')
    {
        //Prompt with an/a recognition, and parenthesis correction
        Console.Write($"Please give me {(vowels.Contains(word[1]) ? "an" : "a")} {word[1..^1].Replace('_', ' ').Trim(")")}: ");

        //Add the response to the story with a period if one was present before
        newStory += $"{Console.ReadLine()}{((word[^1] == '.') ? '.' : "")} ";
    }
    else
        newStory += $"{word} ";
}

Console.WriteLine(newStory);