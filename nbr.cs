using System;

namespace SolveQuadraticEquation {
    class Program {
        static void Main(string[] args){
            double a = 1; double b = -1; double c = -1;
          
            double discriminant = b * b - 4 * a * c;

            if (discriminant > 0) {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("Les solutions sont x1 = " + x1 + " et x2 = " + x2);
            }
            else if (discriminant == 0) {
                double x = -b / (2 * a);
                Console.WriteLine("La solution est x = " + x);
            }
            else {
                Console.WriteLine("Il n'y a pas de solution réelle.");
            }
        }
    }
}