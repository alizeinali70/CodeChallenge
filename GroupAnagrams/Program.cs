// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;

Console.WriteLine("Hello, World!");

List<string> words = new List<string> { "eat", "tea", "tan", "ate", "nat", "bat" };
GroupAnagrams(words);

List<List<string>> GroupAnagrams(List<string> words)
{
    Dictionary<string, List<string>> anagramsDict = new Dictionary<string, List<string>>();

    foreach (string word in words)
    {
        var sortedWord=string.Concat(word.OrderBy(x => x));
        if(anagramsDict.ContainsKey(sortedWord))
            anagramsDict[sortedWord].Add(word);
        else
            anagramsDict[sortedWord]= new List<string> {word};
    }


    return new List<List<string>>();
}