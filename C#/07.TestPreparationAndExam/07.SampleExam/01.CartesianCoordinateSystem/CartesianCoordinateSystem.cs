using System;

class CartesianCoordinateSystem
{
    static void Main()
    {
        //Input
        decimal pointX = decimal.Parse(Console.ReadLine());
        decimal pointY = decimal.Parse(Console.ReadLine());

        //Output
        byte position = 0;
        if (pointX == 0 && pointY == 0) { position = 0; }
        else if (pointX > 0 && pointY > 0) {  position = 1; }
        else if (pointX < 0 && pointY > 0) { position = 2; }
        else if (pointX < 0 && pointY < 0) { position = 3; }
        else if (pointX > 0 && pointY < 0) { position = 4; }
        else if (pointX == 0 && pointY != 0) { position = 5; }
        else if (pointX != 0 && pointY == 0) { position = 6; }
        Console.WriteLine(position);
    }
}