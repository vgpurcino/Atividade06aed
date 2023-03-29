using System;
using System.Linq;
using System.Collections.Generic;
public class Program
{
    static void Main(string[] args)
    {
        int[] nums = new int[7];

        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine("Digite um número: ");
            nums[i] = int.Parse(Console.ReadLine());
        }

        int[] distinctNums = nums.Distinct().ToArray();
        distinctNums = distinctNums.Where(num => num % 2 != 0).ToArray();
        distinctNums.Reverse();
        foreach(int num in distinctNums)
            {
            Console.WriteLine(num);
        }
    }
}