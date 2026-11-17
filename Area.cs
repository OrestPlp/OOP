namespace LAB_1;


class AreaCalculation
{
    public void Run(double perimeter, int[] sides)
    {
        double result = CalculateArea(perimeter, sides);
        PrintResult(result);
    }

    private double CalculateArea(double perimeter, int[] sides)
    {
        perimeter = perimeter / 2;
        return Math.Sqrt(perimeter * (perimeter - sides[0]) * (perimeter - sides[1]) * (perimeter - sides[2]));
    }
    private void PrintResult(double result)
        {
            Console.WriteLine("Area = " + result);    
        }
}