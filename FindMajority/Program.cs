// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("Hello, World! FindMajority ");


//List<int> numbers = new List<int> { 2, 2, 1, 1, 1, 2, 2 };
List<int> numbers = new List<int> { 3, 3, 4, 2, 4, 4, 2, 4, 4 };
FindMajority(numbers);


static int FindMajority(List<int> numbers)
{
    if (numbers.Count == 0) return -1;

    int candidate = numbers[0];
    int count = 1;

    List<int> dist = numbers.Distinct().ToList();


    for (int i = 1; i < numbers.Count; i++)
    {
        if (numbers[i] == candidate)
        {
            //Matched
            count++;
        }
        else
        {
            count--;
            if (count == 0)
            {
                candidate = numbers[i];
                count = 1;
            }
        }
    }

    count = numbers.Count(n => n == candidate);
    return count > numbers.Count / 2 ? candidate : -1;

}


