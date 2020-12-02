using System;

namespace ClassSandbox
{
    public class StringUtils
    {
        public static string MakeExciting(string source)
        {
            return $"{source}!!!";
        }

        public static string Capitalize(string source)
        {
            char first = source[0];
            char upperFirst = Char.ToUpper(first);
            string rest = source.Substring(1);
            return $"{upperFirst}{rest}";
        }
    }

    public class Printer
    {
        public void PrintSomeStuff()
        {
            string name = "mae";
            string statement = "I like the smell of scentless candles";

            Console.WriteLine(StringUtils.Capitalize(name));
            Console.WriteLine(StringUtils.MakeExciting(statement));
        }
    }
}