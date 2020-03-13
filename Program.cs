using System;

namespace Csharp_Inheritance
{
    class HeavenWithAB
    {
        public void theWidth(int myWidth)
        {
            width = myWidth;
        }
        public void theHeight(int myHeight)
        {
            height = myHeight;
        }
        protected int width;
        protected int height;
    }

    class Square : HeavenWithAB
    // subclass created here
    {
        public int area(){
            return(width*height);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // creating a new instance of square : mySquare
            Square mySquare = new Square();
            // 
            mySquare.theHeight(10);
            mySquare.theWidth(10);
            Console.WriteLine("my square has a value of : {0}", mySquare.area());
            Console.ReadKey();
            Console.WriteLine("Hello World!");
        }
    }
}