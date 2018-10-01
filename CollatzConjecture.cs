using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        int steps = 0;
        int num = number;
        if (num < 1)
            throw new ArgumentException();
        while (num > 1)
        {
            if (num % 2 == 0)
                num = num / 2;
            else
                num = num * 3 + 1;
            steps++;
        }
        return steps;
    }
}