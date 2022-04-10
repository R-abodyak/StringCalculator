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
                string[] items = v.Split("\n");

                if (items[0].Length >= 2 && items[0].Substring(0, 2) == "//" )
                {   
                    return Delimate(v.Substring(items[0].Length+1), items[0].Substring(2));
                }
                return Delimate(v, ",");
            }
        }

        private static int Delimate(string v,string delimeter)
        {
            int number = 0;
            string[] numbers = v.Split(delimeter);
            foreach (String sub in numbers)
            {
                string[] SubOfSub = sub.Split("\n");
                foreach (String i in SubOfSub)
                    number += int.Parse(i);
            }
            return number;
        }
    }
}