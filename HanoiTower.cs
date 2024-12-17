using System;

public class HanoiTower
{
    public static void Main(string[] args)
    {
        int N = 3;

        TowerOfHanoi(N, 'A', 'C', 'B');
    }

    static void TowerOfHanoi(int n, char fromPeg, char toPeg, char auxPeg)
    {
        if (n == 0)
        {
            return;
        }

        TowerOfHanoi(n - 1, fromPeg, auxPeg, toPeg);
        Console.WriteLine("Move disk " + n + " from rod " + fromPeg + " to rod " + toPeg);
        TowerOfHanoi(n - 1, auxPeg, toPeg, fromPeg);
    }
}
