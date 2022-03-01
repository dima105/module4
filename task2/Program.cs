using System;
public class Exercise39
{
    public static void Main()
    {
        int i = 200;
        Console.Write("Числа между 200 и 500, которые делятся на 17 : \n");
        while (i < 500) 

        {
            i++;
            if (i % 17 == 0)
            {
                Console.Write("{0} , ", i);
            }
        }
    }
}
