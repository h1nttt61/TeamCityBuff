using System;
using System.Security.Claims;

class ProgramBUFF_TC
{
    static bool CheckTriangle(int a, int b, int c, int n)
    {
        if (a <= 0 || b <= 0 || c <= 0)
            return false;

        bool isTriangle = (a + b > c) && (a + c > b) && (b + c > a);
        if (!isTriangle)
            return false;

        int a2 = a * a, b2 = b * b, c2 = c * c;

        bool isRight = (a2 + b2 == c2) || (a2 + c2 == b2) || (b2 + c2 == a2);
        bool isAcute = (a2 + b2 > c2) && (a2 + c2 > b2) && (b2 + c2 > a2);
        bool isObtuse = (a2 + b2 < c2) || (a2 + c2 < b2) || (b2 + c2 < a2);

        switch (n)
        {
            case 1: return isRight;
            case 2: return (a == b) || (a == c) || (b == c);
            case 3:  return (a == b) && (b == c);
            case 4: return isAcute;
            case 5: return isObtuse;
            case 6: return  (a2 + b2 == c2) || (a2 + c2 == b2) || (b2 + c2 == a2);
            case 7:
                double p = (a + b + c) / 2.0;
                double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                return Math.Abs(area - Math.Round(area)) < 0.0001;
            default: return isTriangle;
        }
    }
    static void Main()
    {
        Console.WriteLine(CheckTriangle(3, 4, 5, 1));
        Console.WriteLine(CheckTriangle(1, 2, 3, 0));
    }
}