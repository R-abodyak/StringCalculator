using System;
namespace StringCalculator.Core
{
    public class StringCalculator
    {
        public int add(string v)
        {
            if (v.Length == 0) return 0;
            else if (v.Length == 1) return int.Parse(v);
            else
            {
                int number = 0; 
                string[] numbers = v.Split(",");
                foreach (String sub in numbers)
                {
                    string[] SubOfSub = sub.Split("\n");
                    foreach (String i in SubOfSub)
                        number += int.Parse(i);
                }
                return number ;
            }
        }
    }
}