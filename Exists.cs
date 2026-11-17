namespace LAB_1;

class ExistanceCheck
{
    public bool Run(int[] sides)
    {
        bool result = Exists(sides);
        PrintResult(result);

        return result;

    }
    private bool Exists(int[] sides)
    {
        if(sides[0] + sides[1] > sides[2] && sides[0] + sides[2] > sides[1] && sides[1] + sides[2] > sides[0])
        {
            return true;
        }
        else return false;
    }

    private void PrintResult(bool Exists)
        {
            if (Exists)
            {
                Console.WriteLine("Triangle exists");
            }
            else
            {
                Console.WriteLine("Triangle doesn`t exist");
            }

        }
}