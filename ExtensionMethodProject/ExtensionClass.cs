using System;
using System.Text;
namespace ExtensionMethodProject
{
    public static class ExtensionClass
    {
        public static void Test3(this TestClass a)
        {
            Console.WriteLine("Test 3 is A Extension Method Of Test Class");
        }

        public static int Factorial(this int x)
        {
            if (x == 1)
                return 1;
            if (x == 2)
                return 2;
            else
                return x * Factorial(x - 1);
        }

        public static string ToProper(this string str)
        {
            str = str.ToLower();
            string[] strArray = str.Split(" ".ToCharArray());
            StringBuilder final = new StringBuilder();
            foreach(string s in strArray)
            {
                StringBuilder temp = new StringBuilder();
                for (int i = 0; i < s.Length; i++)
                {
                    if (i == 0)
                        temp.Append(s[i].ToString().ToUpper());
                    else
                        temp.Append(s[i]);
                }
                final.Append(temp);
                final.Append(" ");
            }
            final.ToString().TrimEnd(" ".ToCharArray());
            return final.ToString();
        }
    }
}
