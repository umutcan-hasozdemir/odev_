using System;

namespace or259
{
    class Program
    {
        public static void Main(string[] args)
        {
            string s, u = "";
            int a;
            byte c;

            Console.Write("Bir cümle giriniz: ");
            s = Console.ReadLine();

            for (a = 0; a < s.Length; a++)
            {
                c = (byte)s[a];

                if (c >= 65 && c <= 90) 
                {
                    u = u + (char)(c + 32); 
                }
                else
                {
                    u = u + s[a];
                }
            }

            Console.WriteLine(u);
            
           
        }
    }
}