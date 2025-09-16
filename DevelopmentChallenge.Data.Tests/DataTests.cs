using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Enum;
using Xunit;

namespace DevelopmentChallenge.Data.Tests
{
    public class DataTests
    {
        [Fact]
        public void TestShapeReportForEachShape()
        {
            LanguageDictionary.Register(LanguageEnum.EN, new Dictionary<string, string>
            {
                {"ReportHeader", "<h1>Shapes report</h1>"},
                {"EmptyList", "<h1>Empty list of shapes!</h1>"},
                {"Square", "Square"},
                {"Rectangle", "Rectangle"},
                {"Circle", "Circle"},
                {"Triangle", "Triangle"},
                {"Trapezoid", "Trapezoid"},
                {"Pentagon", "Pentagon"},
                {"Area", "Area"},
                {"Perimeter", "Perimeter"},
                {"Total", "TOTAL:"},
                {"Shapes", "shapes"}
            });
            LanguageDictionary.Register(LanguageEnum.ES, new Dictionary<string, string>
            {
                {"ReportHeader", "<h1>Reporte de Formas</h1>"},
                {"EmptyList", "<h1>Lista vacía de formas!</h1>"},
                {"Square", "Cuadrado"},
                {"Rectangle", "Rectángulo"},
                {"Circle", "Círculo"},
                {"Triangle", "Triángulo"},
                {"Trapezoid", "Trapecio"},
                {"Pentagon", "Pentágono"},
                {"Area", "Area"},
                {"Perimeter", "Perimetro"},
                {"Total", "TOTAL:"},
                {"Shapes", "formas"}
            });
            LanguageDictionary.Register(LanguageEnum.IT, new Dictionary<string, string>
            {
                {"ReportHeader", "<h1>Rapporto sulle forme</h1>"},
                {"EmptyList", "<h1>Elenco vuoto di forme!</h1>"},
                {"Square", "Quadrato"},
                {"Rectangle", "Rettangolo"},
                {"Circle", "Cerchio"},
                {"Triangle", "Triangolo"},
                {"Trapezoid", "Trapezio"},
                {"Pentagon", "Pentagono"},
                {"Area", "Area"},
                {"Perimeter", "Perimetro"},
                {"Total", "TOTALE:"},
                {"Shapes", "forme"}
            });
            
            var shapes = new List<Shape> { new Square(5) };
            var reportEn = ShapeReport.PrintReport(shapes, LanguageEnum.EN);
            var reportEs = ShapeReport.PrintReport(shapes, LanguageEnum.ES);
            var reportIt = ShapeReport.PrintReport(shapes, LanguageEnum.IT);
            Assert.Contains("Square", reportEn);
            Assert.Contains("Area 25.00", reportEn);
            Assert.Contains("Perimeter 20.00", reportEn);
            Assert.Contains("Cuadrado", reportEs);
            Assert.Contains("Area 25.00", reportEs);
            Assert.Contains("Perimetro 20.00", reportEs);
            Assert.Contains("Quadrato", reportIt);
            Assert.Contains("Area 25.00", reportIt);
            Assert.Contains("Perimetro 20.00", reportIt);
            
            shapes = new List<Shape> { new Rectangle(8, 3) };
            reportEn = ShapeReport.PrintReport(shapes, LanguageEnum.EN);
            reportEs = ShapeReport.PrintReport(shapes, LanguageEnum.ES);
            reportIt = ShapeReport.PrintReport(shapes, LanguageEnum.IT);
            Assert.Contains("Rectangle", reportEn);
            Assert.Contains("Area 24.00", reportEn);
            Assert.Contains("Perimeter 22.00", reportEn);
            Assert.Contains("Rectángulo", reportEs);
            Assert.Contains("Area 24.00", reportEs);
            Assert.Contains("Perimetro 22.00", reportEs);
            Assert.Contains("Rettangolo", reportIt);
            Assert.Contains("Area 24.00", reportIt);
            Assert.Contains("Perimetro 22.00", reportIt);
            
            shapes = new List<Shape> { new Circle(4) };
            reportEn = ShapeReport.PrintReport(shapes, LanguageEnum.EN);
            reportEs = ShapeReport.PrintReport(shapes, LanguageEnum.ES);
            reportIt = ShapeReport.PrintReport(shapes, LanguageEnum.IT);
            Assert.Contains("Circle", reportEn);
            Assert.Contains("Area 50.27", reportEn);
            Assert.Contains("Perimeter 25.13", reportEn);
            Assert.Contains("Círculo", reportEs);
            Assert.Contains("Area 50.27", reportEs);
            Assert.Contains("Perimetro 25.13", reportEs);
            Assert.Contains("Cerchio", reportIt);
            Assert.Contains("Area 50.27", reportIt);
            Assert.Contains("Perimetro 25.13", reportIt);
            
            shapes = new List<Shape> { new Triangle(6) };
            reportEn = ShapeReport.PrintReport(shapes, LanguageEnum.EN);
            reportEs = ShapeReport.PrintReport(shapes, LanguageEnum.ES);
            reportIt = ShapeReport.PrintReport(shapes, LanguageEnum.IT);
            Assert.Contains("Triangle", reportEn);
            Assert.Contains("Area 15.59", reportEn);
            Assert.Contains("Perimeter 18.00", reportEn);
            Assert.Contains("Triángulo", reportEs);
            Assert.Contains("Area 15.59", reportEs);
            Assert.Contains("Perimetro 18.00", reportEs);
            Assert.Contains("Triangolo", reportIt);
            Assert.Contains("Area 15.59", reportIt);
            Assert.Contains("Perimetro 18.00", reportIt);
            
            shapes = new List<Shape> { new Trapezoid(10, 6, 4, 5, 5) };
            reportEn = ShapeReport.PrintReport(shapes, LanguageEnum.EN);
            reportEs = ShapeReport.PrintReport(shapes, LanguageEnum.ES);
            reportIt = ShapeReport.PrintReport(shapes, LanguageEnum.IT);
            Assert.Contains("Trapezoid", reportEn);
            Assert.Contains("Area 32.00", reportEn);
            Assert.Contains("Perimeter 26.00", reportEn);
            Assert.Contains("Trapecio", reportEs);
            Assert.Contains("Area 32.00", reportEs);
            Assert.Contains("Perimetro 26.00", reportEs);
            Assert.Contains("Trapezio", reportIt);
            Assert.Contains("Area 32.00", reportIt);
            Assert.Contains("Perimetro 26.00", reportIt);
            
            shapes = new List<Shape> { new Pentagon(7) };
            reportEn = ShapeReport.PrintReport(shapes, LanguageEnum.EN);
            reportEs = ShapeReport.PrintReport(shapes, LanguageEnum.ES);
            reportIt = ShapeReport.PrintReport(shapes, LanguageEnum.IT);
            Assert.Contains("Pentagon", reportEn);
            Assert.Contains("Area 84.30", reportEn);
            Assert.Contains("Perimeter 35.00", reportEn);
            Assert.Contains("Pentágono", reportEs);
            Assert.Contains("Area 84.30", reportEs);
            Assert.Contains("Perimetro 35.00", reportEs);
            Assert.Contains("Pentagono", reportIt);
            Assert.Contains("Area 84.30", reportIt);
            Assert.Contains("Perimetro 35.00", reportIt);
        }
        [Fact]
        public void TestShapeReportWithMultipleSquares()
        {
            LanguageDictionary.Register("en", new Dictionary<string, string>
            {
                {"ReportHeader", "<h1>Shapes report</h1>"},
                {"EmptyList", "<h1>Empty list of shapes!</h1>"},
                {"Square", "Square"},
                {"Squares", "Squares"},
                {"Area", "Area"},
                {"Perimeter", "Perimeter"},
                {"Total", "TOTAL:"},
                {"Shapes", "shapes"}
            });
            var shapes = new List<Shape>
            {
                new Square(2),
                new Square(3),
                new Square(4)
            };
            var report = ShapeReport.PrintReport(shapes, LanguageEnum.EN);
            Assert.Contains("3 Squares", report);
            Assert.Contains("Area 29.00", report);
            Assert.Contains("Perimeter 36.00", report);
        }
        [Fact]
        public void TestShapeReportWithMultipleTypes()
        {
            LanguageDictionary.Register(LanguageEnum.EN, new Dictionary<string, string>
            {
                {"ReportHeader", "<h1>Shapes report</h1>"},
                {"EmptyList", "<h1>Empty list of shapes!</h1>"},
                {"Square", "Square"},
                {"Squares", "Squares"},
                {"Circle", "Circle"},
                {"Circles", "Circles"},
                {"Area", "Area"},
                {"Perimeter", "Perimeter"},
                {"Total", "TOTAL:"},
                {"Shapes", "shapes"}
            });
            var shapes = new List<Shape>
            {
                new Square(2),
                new Circle(3)
            };
            var report = ShapeReport.PrintReport(shapes, LanguageEnum.EN);
            Assert.Contains("1 Square", report);
            Assert.Contains("1 Circle", report);
            Assert.Contains("Area 4.00", report);
            Assert.Contains("Area 28.27", report);
        }
        [Fact]
        public void TestShapeReportEmptyList()
        {
            LanguageDictionary.Register(LanguageEnum.EN, new Dictionary<string, string>
            {
                {"ReportHeader", "<h1>Shapes report</h1>"},
                {"EmptyList", "<h1>Empty list of shapes!</h1>"},
                {"Total", "TOTAL:"},
                {"Shapes", "shapes"},
                {"Area", "Area"},
                {"Perimeter", "Perimeter"}
            });
            LanguageDictionary.Register(LanguageEnum.ES, new Dictionary<string, string>
            {
                {"ReportHeader", "<h1>Reporte de Formas</h1>"},
                {"EmptyList", "<h1>Lista vacía de formas!</h1>"},
                {"Total", "TOTAL:"},
                {"Shapes", "formas"},
                {"Area", "Area"},
                {"Perimeter", "Perimetro"}
            });
            LanguageDictionary.Register(LanguageEnum.IT, new Dictionary<string, string>
            {
                {"ReportHeader", "<h1>Rapporto sulle forme</h1>"},
                {"EmptyList", "<h1>Elenco vuoto di forme!</h1>"},
                {"Total", "TOTALE:"},
                {"Shapes", "forme"},
                {"Area", "Area"},
                {"Perimeter", "Perimetro"}
            });
            var shapes = new List<Shape>();
            var reportEn = ShapeReport.PrintReport(shapes, LanguageEnum.EN);
            var reportEs = ShapeReport.PrintReport(shapes, LanguageEnum.ES);
            var reportIt = ShapeReport.PrintReport(shapes, LanguageEnum.IT);
            Assert.Equal("<h1>Empty list of shapes!</h1>", reportEn);
            Assert.Equal("<h1>Lista vacía de formas!</h1>", reportEs);
            Assert.Equal("<h1>Elenco vuoto di forme!</h1>", reportIt);
        }
        [Fact]
        public void TestShapeReport_Simple()
        {
            LanguageDictionary.Register(LanguageEnum.EN, new Dictionary<string, string>
            {
                {"ReportHeader", "<h1>Shapes report</h1>"},
                {"EmptyList", "<h1>Empty list of shapes!</h1>"},
                {"Square", "Square"},
                {"Squares", "Squares"},
                {"Circle", "Circle"},
                {"Circles", "Circles"},
                {"Area", "Area"},
                {"Perimeter", "Perimeter"},
                {"Total", "TOTAL:"},
                {"Shapes", "shapes"}
            });
            LanguageDictionary.Register(LanguageEnum.ES, new Dictionary<string, string>
            {
                {"ReportHeader", "<h1>Reporte de Formas</h1>"},
                {"EmptyList", "<h1>Lista vacía de formas!</h1>"},
                {"Square", "Cuadrado"},
                {"Squares", "Cuadrados"},
                {"Circle", "Círculo"},
                {"Circles", "Círculos"},
                {"Area", "Area"},
                {"Perimeter", "Perimetro"},
                {"Total", "TOTAL:"},
                {"Shapes", "formas"}
            });
            LanguageDictionary.Register(LanguageEnum.IT, new Dictionary<string, string>
            {
                {"ReportHeader", "<h1>Rapporto sulle forme</h1>"},
                {"EmptyList", "<h1>Elenco vuoto di forme!</h1>"},
                {"Square", "Quadrato"},
                {"Squares", "Quadrati"},
                {"Circle", "Cerchio"},
                {"Circles", "Cerchi"},
                {"Area", "Area"},
                {"Perimeter", "Perimetro"},
                {"Total", "TOTALE:"},
                {"Shapes", "forme"}
            });
            var shapes = new List<Shape>
            {
                new Square(5),
                new Circle(3),
                new Square(2)
            };
            var reportEn = ShapeReport.PrintReport(shapes, LanguageEnum.EN);
            var reportEs = ShapeReport.PrintReport(shapes, LanguageEnum.ES);
            var reportIt = ShapeReport.PrintReport(shapes, LanguageEnum.IT);
            Assert.Contains("2 Squares", reportEn);
            Assert.Contains("1 Circle", reportEn);
            Assert.Contains("Area 29.00", reportEn);
            Assert.Contains("Area 28.27", reportEn);
            Assert.Contains("Perimeter 28.00", reportEn);
            Assert.Contains("Perimeter 18.85", reportEn);
            Assert.Contains("3 shapes", reportEn);
            Assert.Contains("TOTAL:", reportEn);
            Assert.Contains("<h1>Shapes report</h1>", reportEn);
            
            Assert.Contains("2 Cuadrados", reportEs);
            Assert.Contains("1 Círculo", reportEs);
            Assert.Contains("Area 29.00", reportEs);
            Assert.Contains("Area 28.27", reportEs);
            Assert.Contains("Perimetro 28.00", reportEs);
            Assert.Contains("Perimetro 18.85", reportEs);
            Assert.Contains("3 formas", reportEs);
            Assert.Contains("TOTAL:", reportEs);
            Assert.Contains("<h1>Reporte de Formas</h1>", reportEs);
            
            Assert.Contains("2 Quadrati", reportIt);
            Assert.Contains("1 Cerchio", reportIt);
            Assert.Contains("Area 29.00", reportIt);
            Assert.Contains("Area 28.27", reportIt);
            Assert.Contains("Perimetro 28.00", reportIt);
            Assert.Contains("Perimetro 18.85", reportIt);
            Assert.Contains("3 forme", reportIt);
            Assert.Contains("TOTALE:", reportIt);
            Assert.Contains("<h1>Rapporto sulle forme</h1>", reportIt);
        }
        [Fact]
        public void TestShapeReportWithAllMainShapes()
        {
            LanguageDictionary.Register(LanguageEnum.ES, new Dictionary<string, string>
            {
                {"ReportHeader", "<h1>Reporte de Formas</h1>"},
                {"EmptyList", "<h1>Lista vacía de formas!</h1>"},
                {"Square", "Cuadrado"},
                {"Squares", "Cuadrados"},
                {"Rectangle", "Rectángulo"},
                {"Rectangles", "Rectángulos"},
                {"Circle", "Círculo"},
                {"Circles", "Círculos"},
                {"Triangle", "Triángulo"},
                {"Triangles", "Triángulos"},
                {"Trapezoid", "Trapecio"},
                {"Trapezoids", "Trapecios"},
                {"Pentagon", "Pentágono"},
                {"Pentagons", "Pentágonos"},
                {"Area", "Area"},
                {"Perimeter", "Perimetro"},
                {"Total", "TOTAL:"},
                {"Shapes", "formas"}
            });
            LanguageDictionary.Register(LanguageEnum.EN, new Dictionary<string, string>
            {
                {"ReportHeader", "<h1>Shapes report</h1>"},
                {"EmptyList", "<h1>Empty list of shapes!</h1>"},
                {"Square", "Square"},
                {"Squares", "Squares"},
                {"Rectangle", "Rectangle"},
                {"Rectangles", "Rectangles"},
                {"Circle", "Circle"},
                {"Circles", "Circles"},
                {"Triangle", "Triangle"},
                {"Triangles", "Triangles"},
                {"Trapezoid", "Trapezoid"},
                {"Trapezoids", "Trapezoids"},
                {"Pentagon", "Pentagon"},
                {"Pentagons", "Pentagons"},
                {"Area", "Area"},
                {"Perimeter", "Perimeter"},
                {"Total", "TOTAL:"},
                {"Shapes", "shapes"}
            });
            LanguageDictionary.Register(LanguageEnum.IT, new Dictionary<string, string>
            {
                {"ReportHeader", "<h1>Rapporto sulle forme</h1>"},
                {"EmptyList", "<h1>Elenco vuoto di forme!</h1>"},
                {"Square", "Quadrato"},
                {"Squares", "Quadrati"},
                {"Rectangle", "Rettangolo"},
                {"Rectangles", "Rettangoli"},
                {"Circle", "Cerchio"},
                {"Circles", "Cerchi"},
                {"Triangle", "Triangolo"},
                {"Triangles", "Triangoli"},
                {"Trapezoid", "Trapezio"},
                {"Trapezoids", "Trapezi"},
                {"Pentagon", "Pentagono"},
                {"Pentagons", "Pentagoni"},
                {"Area", "Area"},
                {"Perimeter", "Perimetro"},
                {"Total", "TOTALE:"},
                {"Shapes", "forme"}
            });
            var shapes = new List<Shape>
            {
                new Square(5),
                new Rectangle(8, 3),
                new Circle(4),
                new Triangle(6),
                new Trapezoid(10, 6, 4, 5, 5),
                new Pentagon(7)
            };
            var reportEn = ShapeReport.PrintReport(shapes, LanguageEnum.EN);
            Assert.Contains("Square", reportEn);
            Assert.Contains("Rectangle", reportEn);
            Assert.Contains("Circle", reportEn);
            Assert.Contains("Triangle", reportEn);
            Assert.Contains("Trapezoid", reportEn);
            Assert.Contains("Pentagon", reportEn);
            Assert.Contains("Area", reportEn);
            Assert.Contains("Perimeter", reportEn);
            Assert.Contains("TOTAL:", reportEn);
            
            var reportEs = ShapeReport.PrintReport(shapes, LanguageEnum.ES);
            Assert.Contains("Cuadrado", reportEs);
            Assert.Contains("Rectángulo", reportEs);
            Assert.Contains("Círculo", reportEs);
            Assert.Contains("Triángulo", reportEs);
            Assert.Contains("Trapecio", reportEs);
            Assert.Contains("Pentágono", reportEs);
            Assert.Contains("Area", reportEs);
            Assert.Contains("Perimetro", reportEs);
            Assert.Contains("TOTAL:", reportEs);
            
            var reportIt = ShapeReport.PrintReport(shapes, LanguageEnum.IT);
            Assert.Contains("Quadrato", reportIt);
            Assert.Contains("Rettangolo", reportIt);
            Assert.Contains("Cerchio", reportIt);
            Assert.Contains("Triangolo", reportIt);
            Assert.Contains("Trapezio", reportIt);
            Assert.Contains("Pentagono", reportIt);
            Assert.Contains("Area", reportIt);
            Assert.Contains("Perimetro", reportIt);
            Assert.Contains("TOTALE:", reportIt);
        }
    }
}
