using System;

namespace RomanNum
{
    static class MyExtension
    {

        public static string ToRoman(this int number)
        {
            if (number < 0 || number > 3999)
                throw new ArgumentOutOfRangeException("rossz adat");
            if (number < 1)
                return "";
            string value = string.Empty;
            if (number >= 1000)
            {

                return "M" + ToRoman(number - 1000);
            }
            else if (number >= 900)
            {
                return "CM" + ToRoman(number - 900);
            }
            else if (number > 500)
            {

                return "D" + ToRoman(number - 500);
            }
            else if (number >= 400)
            {
                return "CD" + ToRoman(number - 400);
            }
            else if (number >= 100)
            {

                return value += "C" + ToRoman(number - 100);
            }
            else if (number >= 90)
            {
                return value += "XC" + ToRoman(number - 90);
            }
            else if (number >= 50)
            {

                return value += "L" + ToRoman(number - 50);
            }
            else if (number >= 40)
            {
                return value += "XL" + ToRoman(number - 40);
            }
            else if (number >= 10)
            {

                return value += "X" + ToRoman(number - 10);
            }
            else if (number >= 9)
            {

                return value += "IX" + ToRoman(number - 9);
            }
            else if (number >= 5)
            {

                return value += "V" + ToRoman(number - 5);
            }
            else if (number >= 4)
            {

                return value += "IV" + ToRoman(number - 4);
            }
            else if (number >= 1)
            {

                return value += "I" + ToRoman(number - 1);
            }
            throw new ArgumentException("valami nem stimmel");
        }
    }
}
