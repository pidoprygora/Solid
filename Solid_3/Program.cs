using System;

class Rectangle
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }
    public int GetRectangleArea()
    {
        return Width * Height;
    }
}

//квадрат наслідується від прямокутника!!!
class Square : Rectangle
{
    private int side;

    public override int Width
    {
        get { return side; }
        set
        {
            side = value;
            base.Width = value;
            base.Height = value;
        }
    }

    public override int Height
    {
        get { return side; }
        set
        {
            side = value;
            base.Width = value;
            base.Height = value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Square();
            rect.Width = 5;
            rect.Height = 10;

            Console.WriteLine(rect.GetRectangleArea());
            //Відповідь 100? Що не так???
            Console.ReadKey();
        }
    }
}