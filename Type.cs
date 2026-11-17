namespace LAB_1;

class Type
{
    public void Run(int[] sides)
    {
        bool sq = square(sides);
        bool isc = isosceles(sides);
        bool eq = equilateral(sides);
        PrintResult(sq, isc, eq);
    }
    private bool square(int[] sides)
    {
        if ((Math.Pow(sides[0], 2) == Math.Pow(sides[1], 2) + Math.Pow(sides[2], 2)) || 
            (Math.Pow(sides[1], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[2], 2)) ||
            (Math.Pow(sides[2], 2) == Math.Pow(sides[1], 2) + Math.Pow(sides[0], 2)))
        {
            return true;
        }
        else return false;
    }

    private bool isosceles(int[] sides)
    {
        if ((sides[0] == sides[1])|| 
            (sides[1] == sides[2])||
            (sides[2] == sides[0]))
        {
            return true;
        }
        else return false;
    }

    private bool equilateral(int[] sides)
    {
        if((sides[0] == sides[1]) && (sides[0] == sides[2]))
        {
            return true;
        }
        else return false;
    }

    private void PrintResult(bool sq, bool isc, bool eq)
        {
            if(sq && !isc) 
            {
                Console.WriteLine("Triangle is right-angled"); 
                return;
            }
            else if(sq && isc) 
            {
                Console.WriteLine("Triangle is right-angled and isosceles"); 
                return;
            }
            else if(!sq && isc && !eq) 
            {
                Console.WriteLine("Triangle is isosceles");
                return;
            }
            else if(eq) 
            {
                Console.WriteLine("Triangle is equilateral");
                return;
            }
            else Console.WriteLine("Triangle is arbitrary");
        }
}