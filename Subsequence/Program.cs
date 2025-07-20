// See https://aka.ms/new-console-template for more information

//Given a string s and an array of strings words, return the number of words[i] that is a subsequence of s.
//A subsequence of a string is a new string generated from the original string with some characters (can be none)
//deleted without changing the relative order of the remaining characters.
//For example, "ace" is a subsequence of "abcde".

//Example 1:

//Input: s="abcde", words = ["a","bb","acd","ace"]
//Output: 3
//Explanation: There are three strings in words that are a subsequnce of s: "a", "acd", "ace"

//Example 2:
//Input s= "dsahjpjauf", words=["ahjpjau","ja","ahnwzgqnuk","tbnlanowax"]
//Output: 2


// brute Solution -> so calculate all possible substring then compare with word list -> 2^n where n is size of s
// another solution -> pre compute location of letter to index

Console.WriteLine("Hello, World!");

string s = "abcde";
string[] words = {"a", "bb", "acd", "ace"};

GenerateSubstring(s,words);

void GenerateSubstring(string s, string[] words)
{

    List<string> listsub = new List<string>();
    List<char> chars = new List<char>();


    int count = s.Length;

    for (int i = 0; i < count; i++)
    {
        chars.Add(s[i]);
        for (int j = i + 1; j < count - 1; j++)
        {
            listsub.Add(chars[i].ToString() + chars[j].ToString());
        }
    }

    for (int i = 0; i < count; i++)
    {
        for (int j = 1; j < count; j++)
        {
            listsub.Add(chars[i].ToString() + chars[j]);
        }

    }
    
}