using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using DevelopmentChallenge.Data.Enum;

namespace DevelopmentChallenge.Data.Classes
{
    public static class ShapeReport
    {
        public static string PrintReport(List<Shape> shapes, LanguageEnum language)
        {
            var sb = new StringBuilder();
            if (shapes == null || !shapes.Any())
            {
                sb.Append(LanguageDictionary.Translate(language, "EmptyList"));
                return sb.ToString();
            }
            sb.Append(LanguageDictionary.Translate(language, "ReportHeader"));
            var totalShapes = 0;
            var totalArea = 0m;
            var totalPerimeter = 0m;
            var grouped = shapes.GroupBy(s => s.Type);
            foreach (var group in grouped)
            {
                var count = group.Count();
                var nameKey = count > 1 ? group.Key.ToString() + "s" : group.Key.ToString();
                var shapeName = LanguageDictionary.Translate(language, nameKey);
                var areaLabel = LanguageDictionary.Translate(language, "Area");
                var perimeterLabel = LanguageDictionary.Translate(language, "Perimeter");
                var area = group.Sum(s => s.GetArea());
                var perimeter = group.Sum(s => s.GetPerimeter());
                var areaRounded = Math.Round(area, 2);
                var perimeterRounded = Math.Round(perimeter, 2);
                sb.Append($"{count} {shapeName} | {areaLabel} {areaRounded.ToString("F2", CultureInfo.InvariantCulture)} | {perimeterLabel} {perimeterRounded.ToString("F2", CultureInfo.InvariantCulture)} <br/>");
                totalShapes += count;
                totalArea += area;
                totalPerimeter += perimeter;
            }
            var footer = LanguageDictionary.Translate(language, "Total");
            var shapesLabel = LanguageDictionary.Translate(language, "Shapes");
            var perimeterLabelTotal = LanguageDictionary.Translate(language, "Perimeter");
            var areaLabelTotal = LanguageDictionary.Translate(language, "Area");
            var totalAreaRounded = Math.Round(totalArea, 2);
            var totalPerimeterRounded = Math.Round(totalPerimeter, 2);
            sb.Append($"{footer}<br/>{totalShapes} {shapesLabel} {perimeterLabelTotal} {totalPerimeterRounded.ToString("F2", CultureInfo.InvariantCulture)} {areaLabelTotal} {totalAreaRounded.ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}
