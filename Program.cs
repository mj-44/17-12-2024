using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int diameter = 0;
            int arcAngle = 0;
            Console.WriteLine("Enter a diameter: ");
            diameter =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Arc angle");
            arcAngle = Convert.ToInt32(Console.ReadLine());
            circlePropertiesProblem(diameter, arcAngle);

            ballsNeeded();

            fishTankVolume(10, 20, 25);

        }


        static void circlePropertiesProblem(int diameter, int arcAngle)
        {

            double radius = diameter / 2;
            double area = radius * radius * 3.14;
            double circumference = diameter * 3.14;
            double arcLength = circumference * arcAngle / 360;
            Console.WriteLine(diameter);
            Console.WriteLine(arcLength);
            Console.WriteLine(circumference);
            Console.WriteLine(radius);
            Console.WriteLine(area);
            Console.ReadLine();

        }

        static double volumeBallPit(double ballPitRadius, double ballPitHeight)
        {

            double volume = 3.14 * ballPitRadius * ballPitRadius * ballPitHeight;
            return volume;

        }

        static double ballVolume(double ballRadius)
        {

            double ballVolume = 4/3 * 3.14 * ballRadius * ballRadius * ballRadius;
            return ballVolume;

        }


        static void ballsNeeded()
        {
            double radius = 1.0;
            double height = 0.2;
            double balls = 0.05;
            double ballPit = volumeBallPit(radius, height);
            double ball = ballVolume(balls);

            double num = ballPit / ball * 0.75;
            Console.WriteLine(num + " balls are needed");
            Console.ReadLine();

        }

        static void fishTankVolume(int length, int depth, int height)
        {

            double ftVolume = length * depth * height / 1000;
            Console.WriteLine(ftVolume + " litres");
            Console.ReadLine() ;

        }

    }
}
