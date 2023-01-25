using System;
using static System.Console;

Clear();


WriteLine("Введите значения переменных b1, k1, b2, k2 через пробел: ");
double[] myArray = GetArrayFromString(ReadLine());
double X = GetX(myArray);
double Y = GetY(myArray, X);
WriteLine($"Точка пересечения двух прямых имеет координаты --> ({X};{Y})");


double[] GetArrayFromString(string arrayString)
{
    string[] nums = arrayString.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    double[] result = new double[nums.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = Convert.ToInt32(nums[i]);
    }
    return result;
}

double GetX(double[] Array)
{
    double result = (Array[2] - Array[0]) / (Array[1] - Array[3]); // x = (-b2 + b1)/(-k1 + k2)
    return result;
}

double GetY(double[] Array, double X)
{
    double result = (Array[3] * X) + Array[2]; // y = k2 * x + b2 
    return result;
}