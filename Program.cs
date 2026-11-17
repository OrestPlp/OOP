namespace LAB_1;
 
class Program
{
    static void Main()
    {
        int[] sides = [4,4,5];

        ExistanceCheck ex = new ExistanceCheck();

        if (!ex.Run(sides)) return;

        PositiveCheck pos = new PositiveCheck();

        if (!pos.Run(sides)) return;

        Perimeter p = new Perimeter();
        double perimeter = p.Run(sides);

        AreaCalculation area = new AreaCalculation();
        area.Run(perimeter, sides);

        Type type = new Type();
        type.Run(sides);




        
        
        
        
    }
}