using System;
using System.Collections.Generic;
using System.Text;

namespace BadSuperBowlNamerExercise
{
    public class Converter
    {
        public string ConvertNumberToNumeral(int number)
        {
            if (number < 0 || number > 3999)
                throw new ArgumentException("Value must be in the range 0 - 3,999.");

            int[] values = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] numerals = new string[]
                { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < 13; i++)
            {
                while (number >= values[i])
                {
                    number -= values[i];
                    result.Append(numerals[i]);
                }
            }
            return result.ToString();
        }
    }
}
