using System;

namespace TriangleLibrary
{
    public class TriangleLib
    {
        double sideA = 0;
        double sideB = 0;
        double sideC = 0;
        //Input: sides of triangle (a, b, c)
        //Output: triangle type
        //Description: method used three sides of triagle for find type: right triangle, obtuse triangle or acute-angled triangle.
        //a2+b2=c2 - right, a2+b2>c2 - acute-angled, a2+b2<c2 - obtuse
        public string getTriangleType(double a, double b, double c)
        {
            this.sideA = a;
            this.sideB = b;
            this.sideC = c;
            // step 1. check existence of triangle
            if ((a + b > c) && (b + c > a) && (c + a > b))
            {
                //step 2. Find biggest side
                double max = sideA;
                if (max < sideB)
                    max = sideB;
                if (max < sideC)
                    max = sideC;

                //step 3. a2+b2=c2
                if (max == sideA)
                { // case when side a is the largest
                    if (b * b + c * c > a * a)
                        return "acute-angled triangle"; //остроугольный
                    else if (b * b + c * c == a * a)
                         return "right triangle"; //прямоугольный                    
                    else 
                        return "obtuse triangle"; //тупоугольный

                }
                else if (max == sideB)
                { // case when side a is the largest
                    if (a * a + c * c > b * b)
                        return "acute-angled triangle"; //остроугольный
                    else if (a * a + c * c == b * b)
                        return "right triangle"; //прямоугольный                    
                    else
                        return "obtuse triangle"; //тупоугольный
                }
                else
                {
                    // case when side a is the largest
                    if (b * b + a * a > c * c)
                        return "acute-angled triangle"; //остроугольный
                    else if (b * b + a * a == c * c)
                        return "right triangle"; //прямоугольный                    
                    else
                        return "obtuse triangle"; //тупоугольный
                }
            }
            else            
                return "triangle not exist";           
        }
    }
}
