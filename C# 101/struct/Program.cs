﻿namespace structsample;
class Program
{
    static void Main(string[] args)
    {
        
        
        Rectangle rectangle = new Rectangle();
        rectangle.ShortEdge = 3;
        rectangle.LongEdge = 4;

        Console.WriteLine("Calculate area with class : {0}",rectangle.CalculateArea());

        RectangleStruct rectangleStruck;
        rectangleStruck.LongEdge = 3;
        rectangleStruck.ShortEdge =  4;

        Console.WriteLine("Calculate area with struct : {0}",rectangleStruck.CalculateArea());
        RectangleStructParam rectangleStructParam = new RectangleStructParam(3,4);
        Console.WriteLine("Calculate area with struct parameter : {0}",rectangleStructParam.CalculateArea());
    }
}

class Rectangle
{
    public int ShortEdge;
    public int LongEdge;

    public long CalculateArea()
    {
        return this.ShortEdge * this.LongEdge;
    }
}

struct RectangleStruct
{
    public int ShortEdge;
    public int LongEdge;

    public long CalculateArea()
    {
        return this.ShortEdge * this.LongEdge;
    }

}

struct RectangleStructParam
{

    public RectangleStructParam(int shortEdge, int longEdge)
    {
        ShortEdge = longEdge;
        LongEdge = longEdge;
    }
    public int ShortEdge;
    public int LongEdge;

    public long CalculateArea()
    {
        return this.ShortEdge * this.LongEdge;
    }

}