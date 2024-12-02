internal class Program 
{
    public static void Main()
    {
        var mittKjøretøy = new Bil();
        mittKjøretøy.Model = "VW Caddy";
        mittKjøretøy.HasEngine = true;
        mittKjøretøy.AntallHjul = 4;
        mittKjøretøy.Horn();
        var lasteBil = new Lastebil();
        lasteBil.AntallHjul = 8;
        lasteBil.Horn();
        var square = new Square(10);
        Console.WriteLine(square.Height);
        Console.WriteLine(square.Length);
        square.Area();
        int[] myNumbers = [1,2,3,4,5,6,7,8,8,9,];
        var enumerableInterface = myNumbers.Where(n => n < 2).Select(n => n).ToArray();
        ISwimLikeADuck fish = new Fish();
    }
    class Kjøretøy
    {
        public string Model;
        public bool HasEngine;
    }
    class Bil: Kjøretøy
    {
        public int AntallHjul;
        public virtual void Horn()
        {
            Console.WriteLine("Tuut!");
        }
    }
    class Lastebil: Bil
    {
        public string Last;
        public override void Horn()
        {
            Console.WriteLine("Honk!");
        }
    }
    abstract class Shape
    {
        public int Length;
        public int Height;
        abstract public void Area();
    } 
    class Square: Shape
    {
        public Square(int length)
        {
            Length=length;
            Height=length;
        }
        public override void Area()
        {
            Console.WriteLine(Height * Length);
        }
    }
    interface IQuackLikeADuck
    {
        public void Quack();
    }
    interface ISwimLikeADuck
    {
        public void Swim();
    }
    interface ILookLikeADuck
    {
        public void DuckShape();
    }
    class Fish: ISwimLikeADuck
    {
        public int SwimSpeed;
        public void Swim()
        {
            Console.WriteLine("I swim like a duck");
        }
    }
    class Goose: ISwimLikeADuck,ILookLikeADuck
    {
        public void Swim()
        {
            Console.WriteLine("I swim like a duck");
        }
        public void DuckShape()
        {
            Console.WriteLine("I look like a duck");
        }
    }
    class Duck : ISwimLikeADuck, ILookLikeADuck, IQuackLikeADuck
    {
        public void Swim()
        {
            Console.WriteLine("I am a duck");
        }
        public void DuckShape()
        {
            Console.WriteLine("I am a duck");
        }
        public void Quack()
        {
            Console.WriteLine("Quaack!");
        }
    }
}