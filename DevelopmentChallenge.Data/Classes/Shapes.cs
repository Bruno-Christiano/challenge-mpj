using System;
using System.Collections.Generic;
using DevelopmentChallenge.Data.Enum;

namespace DevelopmentChallenge.Data.Classes
{
    
    public abstract class Shape
    {
        public ShapeTypeEnum Type { get; }
        public abstract decimal GetArea();
        public abstract decimal GetPerimeter();
        public abstract Dictionary<string, decimal> GetParameters();

        protected Shape(ShapeTypeEnum type)
        {
            Type = type;
        }
    }

    public class Square : Shape
    {
        public decimal Side { get; }
        public Square(decimal side) : base(ShapeTypeEnum.Square)
        {
            Side = side;
        }
        public override decimal GetArea() => Side * Side;
        public override decimal GetPerimeter() => 4 * Side;
        public override Dictionary<string, decimal> GetParameters() => new() { { "side", Side } };
    }

    public class Circle : Shape
    {
        public decimal Radius { get; }
        public Circle(decimal radius) : base(ShapeTypeEnum.Circle)
        {
            Radius = radius;
        }
        public override decimal GetArea() => (decimal)Math.PI * Radius * Radius;
        public override decimal GetPerimeter() => 2 * (decimal)Math.PI * Radius;
        public override Dictionary<string, decimal> GetParameters() => new() { { "radius", Radius } };
    }

    public class Triangle : Shape
    {
        public decimal Side { get; }
        public Triangle(decimal side) : base(ShapeTypeEnum.Triangle)
        {
            Side = side;
        }
        public override decimal GetArea() => (decimal)(Math.Sqrt(3) / 4) * Side * Side;
        public override decimal GetPerimeter() => 3 * Side;
        public override Dictionary<string, decimal> GetParameters() => new() { { "side", Side } };
    }

    public class Rectangle : Shape
    {
        public decimal Width { get; }
        public decimal Height { get; }
        public Rectangle(decimal width, decimal height) : base(ShapeTypeEnum.Rectangle)
        {
            Width = width;
            Height = height;
        }
        public override decimal GetArea() => Width * Height;
        public override decimal GetPerimeter() => 2 * (Width + Height);
        public override Dictionary<string, decimal> GetParameters() => new() { { "width", Width }, { "height", Height } };
    }

    public class Trapezoid : Shape
    {
        public decimal Base1 { get; }
        public decimal Base2 { get; }
        public decimal Height { get; }
        public decimal Side1 { get; }
        public decimal Side2 { get; }
        public Trapezoid(decimal base1, decimal base2, decimal height, decimal side1, decimal side2) : base(ShapeTypeEnum.Trapezoid)
        {
            Base1 = base1;
            Base2 = base2;
            Height = height;
            Side1 = side1;
            Side2 = side2;
        }
        public override decimal GetArea() => ((Base1 + Base2) * Height) / 2;
        public override decimal GetPerimeter() => Base1 + Base2 + Side1 + Side2;
        public override Dictionary<string, decimal> GetParameters() => new() { { "base1", Base1 }, { "base2", Base2 }, { "height", Height }, { "side1", Side1 }, { "side2", Side2 } };
    }

    public class Pentagon : Shape
    {
        public decimal Side { get; }
        public Pentagon(decimal side) : base(ShapeTypeEnum.Pentagon)
        {
            Side = side;
        }
        public override decimal GetArea() => (5 * Side * Side) / (4 * (decimal)Math.Tan(Math.PI / 5));
        public override decimal GetPerimeter() => 5 * Side;
        public override Dictionary<string, decimal> GetParameters() => new() { { "side", Side } };
    }

    public class Hexagon : Shape
    {
        public decimal Side { get; }
        public Hexagon(decimal side) : base(ShapeTypeEnum.Hexagon)
        {
            Side = side;
        }
        public override decimal GetArea() => (3 * (decimal)Math.Sqrt(3) / 2) * Side * Side;
        public override decimal GetPerimeter() => 6 * Side;
        public override Dictionary<string, decimal> GetParameters() => new() { { "side", Side } };
    }
}
