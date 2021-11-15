using System;

namespace Open_Lab_04._07
{
    public class StringTools
    {
        public string Reverse(string original)
        {
            char[] char_Array = original.ToCharArray();
            Array.Reverse(char_Array);
            return new string(char_Array);
        }
    }
}
