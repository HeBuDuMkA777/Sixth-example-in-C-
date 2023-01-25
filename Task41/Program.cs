using System;
using static System.Console;

Clear();

WriteLine("Введи числа через пробел: ");
int[] myArray = GetArrayFromString(ReadLine());
WriteLine($"В массиве {count(myArray)} чисел больше 0!");




int[] GetArrayFromString(string arrayString)
{
    string[] nums = arrayString.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[nums.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = Convert.ToInt32(nums[i]);
    }
    return result;
}



int count(int[] Array)
{
    int result = 0;
    foreach (var item in Array)
    {
        if (item > 0) result++;
    }
    return result;
}