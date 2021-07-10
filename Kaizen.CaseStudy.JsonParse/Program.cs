using System;
using System.Linq;
using Kaizen.CaseStudy.JsonParse.Helpers;
using Kaizen.CaseStudy.JsonParse.Models;

namespace Kaizen.CaseStudy.JsonParse
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var data = JsonReaderHelper.ReadJson(@"C:\Users\ahmet\Downloads\response.json");
            if (data != null && data.Any())
            {
                // Get Bigger X coordinate after ordering X's in Edges descending
                int coordinateX = data.First().BoundingPoly.Edges.OrderByDescending(edge => edge.CoordinateX).First().CoordinateX;

                // First Row Of Json has locale property and we don't need this record so we get records which doesn't have locale property
                data = data.FindAll(ocrData => ocrData.Locale == null);

                // Ordering records depends max Y coordinate in edges
                data = data.OrderBy(x => x.BoundingPoly.Edges.Max(y => y.CoordinateY)).ToList();


                string formattedString = "";
                foreach (var ocrData in data)
                {
                    // Get's first bigger X coordinate of ocrData
                    int newCoordinateX = ocrData.BoundingPoly.Edges.OrderByDescending(edge => edge.CoordinateX).First().CoordinateX;

                    // Compare it with previous one if newCoordinate greater than old one we say those 2 words are in same line. Else add \n to end the line.
                    if (newCoordinateX >= coordinateX)
                    {
                        formattedString += " " + ocrData.Description;
                    }
                    else
                    {
                        formattedString += "\n" + ocrData.Description;
                    }

                    coordinateX = newCoordinateX;
                }

                Console.WriteLine(formattedString);
            }
            Console.ReadLine();
        }
    }
}
