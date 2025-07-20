// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! this Operation runs over O(n) because ");


//int[] numbers = { 7, 17, 0, 19, 5 };
int[] numbers = { 2, 0, 5, 0, 20, 30, 56 };
MoveZerosToEnd(numbers);


static int[] MoveZerosToEnd(int[] numbers)
{
    // Your code goes here.
    int zeroCount = 0;
    for (int i = 0, j = 0; i < numbers.Length; i++)
    {
        if (numbers[i] != 0)
        {
            numbers[j++] = numbers[i];
        }
        else
        {
            zeroCount++;
        }
    }
    for (int i = numbers.Length - zeroCount; i < numbers.Length; i++)
    {
        numbers[i] = 0;
    }

    Console.WriteLine("Array: " + string.Join(", ", numbers));



    return numbers;

}