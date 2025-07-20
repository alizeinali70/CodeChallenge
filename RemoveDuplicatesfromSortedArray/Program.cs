// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");

int[] nums = [1, 1, 2];
//int[] nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];
RemoveDuplicates(nums);


int RemoveDuplicates(int[] nums)
{
    //Input://[1,1,2]
    //Output: [1,2]

    int index = 1;
    for (int i = 1; i < nums.Count(); i++)
    {

        if (nums[i - 1] != nums[i])
        {
            nums[index++] = nums[i];

        }
    }
    return index;
}