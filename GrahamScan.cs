using System;
using System.Collections.Generic;

public class GrahamScan
{
    static readonly int INF = 10000;

    public static void Main()
    {
        Point[] points = new Point[8];
        points[0] = new Point(0, 3);
        points[1] = new Point(1, 1);
        points[2] = new Point(2, 2);
        points[3] = new Point(4, 4);
        points[4] = new Point(0, 0);
        points[5] = new Point(1, 2);
        points[6] = new Point(3, 1);
        points[7] = new Point(3, 3);

        int n = points.Length;
        ConvexHull(points, n);
    }
static int Orientation(Point p, Point q, Point r)
    {
        int val = (q.Y - p.Y) * (r.X - q.X) - (q.X - p.X) * (r.Y - q.Y);

        if (val == 0) return 0;

        return (val > 0) ? 1 : 2;
    }

    static void ConvexHull(Point[] points, int n)
    {
        if (n < 3) return;

        List<Point> hull = new List<Point>();

        int l = 0;
        for (int i = 1; i < n; i++)
            if (points[i].X < points[l].X)
                l = i;

        int p = l, q;
        do
        {
            hull.Add(points[p]);
            q = (p + 1) % n;

            for (int i = 0; i < n; i++)
            {
                if (Orientation(points[p], points[i], points[q]) == 2)
                {
                    q = i;
                }
            }

            p = q;

        } while (p != l);

        foreach (var point in hull)
        {
            Console.WriteLine($"({point.X}, {point.Y})");
        }
    }
}

class Point
{
    public int X, Y;
    public Point()
    {
        X = 0;
        Y = 0;
    }
    public Point(int a, int b)
    {
        X = a;
        Y = b;
    }
}
