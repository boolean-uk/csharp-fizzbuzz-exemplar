using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_fizzbuzz.Main
{
    public class Extension
    {
        String[] nums;
        public String[] fizzbuzz(int lower, int higher)
        {
            /* TODO: Implement a function that will create a list of strings containing the numbers from the lower number to the higher number
                Where a number is a multiple of three (3, 6, 9, etc) the array should contain the string "Fizz" instead of a number.
                Where a number is a multiple of five (5, 10, etc) the array should contain the string "Buzz" instead of a number.
                Where a number is a multiple of both five AND three (15, 30, etc) the array should contain the string "Fizzbuzz" instead of a number.
            * */
            this.nums = new String[higher - lower + 1];
            for (int i = lower, index = 0; i <= this.nums.Length; i++, index++)
            {
                if ((i % 15) == 0)
                {
                    this.nums[index] = "Fizzbuzz";
                }
                else if ((i % 3) == 0)
                {
                    this.nums[index] = "Fizz";
                }
                else if ((i % 5) == 0)
                {
                    this.nums[index] = "Buzz";
                }
                else
                {
                    this.nums[index] = i.ToString();
                }
            }
            return this.nums;
        }
    }
}
