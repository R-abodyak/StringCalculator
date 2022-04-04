using System;
namespace StringCalculator.Core
{
    public class StringCalculator
    {
        public int add(string v)
        {
            if (v.Length == 0) return 0;
            if (v.Length == 1) return int.Parse(v);
            throw new NotImplementedException();
        }
    }
}