namespace LAB_1;

class PositiveCheck
{
    public bool Run(int[] sides)
    {
        
        bool result = IsPositive(sides);
        PrintResult(result);

        return result;
    }
    private bool IsPositive(int[] sides)
    {
        foreach(int s in sides)
        {
            if(s <= 0)
            {
                return false;
            }
        }
        return true;

    }

    private void PrintResult(bool isPositive)
        {
            if (isPositive) Console.WriteLine("Sides are positive");
            else Console.WriteLine("Some sides are not positive");
        }
}