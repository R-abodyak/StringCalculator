using System;
using System.Collections.Generic;

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
            List<int> NegativeNumbersList = new List<int>();
            string[] numbers = v.Split(delimeter);
            foreach (String sub in numbers)
            {
                string[] SubOfSub = sub.Split("\n");
                foreach (String i in SubOfSub)
                {
                    int Num = int.Parse(i);
                    if (Num < 0)
                    {
                        NegativeNumbersList.Add(Num);
                    }
                    if(Num >= 1000)
                    {
                        Num = 0;
                    }
                     number += Num;
                }
            }
            CheckForNegative(NegativeNumbersList);
            return number;
        }

        private static void CheckForNegative(List<int> NegativeNumbersList)
        {
            if (NegativeNumbersList.Count > 0)
            {
                String message = String.Empty;
                foreach (int i in NegativeNumbersList)
                {
                    message += i + ",";
                }
                message = message.Remove(message.Length - 1);
                throw new ArgumentException
                    ("negatives are not allowed :" + message);


            }
        }
    }
}