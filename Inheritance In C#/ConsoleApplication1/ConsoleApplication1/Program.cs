using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    // Its a Base Class
    class Shape
    {
       protected  int width, height;
        public void setWidth(int w)
        {
            width = w;
        }

        public void setHeight(int h)
        {
            height = h;
        }
    }

    // Its a Derived Class
    class Rectangle : Shape  //Inherit the class Shape
    {
        public int getarea()
        {
            return width * height;
        }

        static void Main(string[] args)
        {
            Rectangle obj = new Rectangle();
            obj.setWidth(9);
            obj.setHeight(5);
            obj.getarea();
            Console.WriteLine("Total Area: " + obj.getarea());
            Console.ReadKey();
        }
    }
}
