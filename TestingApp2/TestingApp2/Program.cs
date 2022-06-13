using System;

namespace TestingApp2;

public class Program
{
    static void Main(string[] args)
    {

    }

    public static string checkMajorityAge(int age)
    {
        if (age >= 18)
        {

            return "Mayor de edad";

        }
        else
        {

            return "Menor de edad";

        }
    }
}
