using System;

namespace TestingApp
{

    public class Program
    {
        static void Main(string[] args)
        {

        }

        public static string Something(int tempAgua)
        {
            if (tempAgua >= 100)
            {
                return "Hierve";
            }
            else
            {
                return "No hierve";
            }
        }
    }
}