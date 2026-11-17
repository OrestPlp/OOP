namespace LAB_1;

class Perimeter
{
    public double Run(int[] sides)
    {
        double result = CalculatePerimeter(sides);
        PrintResult(result);

        return result;
    }
    
    private double CalculatePerimeter(int[] sides)
    {
        return sides[0] + sides[1] + sides[2];
    }
    private void PrintResult(double result)
        {
            Console.WriteLine("Perimeter = " + result);    
        }
}