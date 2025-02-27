using System;


partial class Program
    {
        static string Reverse(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return s;
            }
            return Reverse(s.Substring(1)) + s[0].ToString();
        }
    }
