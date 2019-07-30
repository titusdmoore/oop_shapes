using System;

namespace OOPShapesProject {
    class Program {
        static void Main(string[] args) {

            var newQuad = new Quad(5,7,13,6);

            var perim = newQuad.CalcPerim();

            Console.WriteLine(perim);

            var rect1 = new Rectangle(5, 13);

            perim = rect1.CalcPerim();
            Console.WriteLine(perim);

            var square1 = new Square(5);
            perim = square1.CalcPerim();
            Console.WriteLine(perim);

            int area = rect1.CalcArea();
            Console.WriteLine($"{area} rectangle");

            area = square1.CalcArea();
            Console.WriteLine(area);
            
        }
    }
}
