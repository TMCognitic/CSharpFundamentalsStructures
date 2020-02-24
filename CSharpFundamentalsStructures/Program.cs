using System;

namespace CSharpFundamentalsStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercice 1
            {
                Point?[,] points = new Point?[5, 5];

                for (int i = 0; i < 5; i++)
                {
                    Point point = new Point();
                    point.X = i + 1;
                    point.Y = i + 1;
                    points[i, i] = point;
                }

                for (int i = 0; i < 5; i++)
                {
                    if (points[i, i].HasValue)
                    {
                        Console.Write(new string(' ', 14 * i));
                        Console.WriteLine($"X : {points[i, i].Value.X} - Y : {points[i, i].Value.Y}");
                    }
                }
            }
            #endregion

            #region Exercice 2
            {
                Celsius celsius = new Celsius();
                celsius.Temperature = 30;

                Fahrenheit fahrenheit = new Fahrenheit();
                fahrenheit.Temperature = 86;
            }
            #endregion
        }
    }
}
