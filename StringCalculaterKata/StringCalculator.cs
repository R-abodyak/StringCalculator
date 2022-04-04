using System;
namespace StringCalculator.Core
{
    public class StringCalculator
    {
        public int add(string v)
        {
            if (v.Length == 0) return 0;
            if (v.Length == 1) return int.Parse(v);
            string[] numbers = v.Split(",");
            int number1 = int.Parse(numbers[0]);
            int number2 = int.Parse(numbers[1]);
            return number1 + number2;
          
        }
    }
}