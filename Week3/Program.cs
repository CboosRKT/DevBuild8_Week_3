static void PrintHead()
{
    Console.Clear();
    Console.WriteLine("\n****************************************************************");
    Console.WriteLine("************  Welcome to DevBuild 8 Circle-o-matic  ************");
    Console.WriteLine("****************************************************************\n");
}
static void Buff()
{
   

    string buff = "*";
   
        for (int i = 0; i < 60; i++)
        {
            Console.WriteLine(buff);
            Thread.Sleep(10);
            buff = "*" + buff;
            int top = Console.CursorTop;
            Console.SetCursorPosition(0, top - 1);
        }
   
    
}


double uRad = -1.00d;
bool goAgain = true;
int cirCount = 0;
while (goAgain)
{

    bool uValid = false;

    while (!uValid)
    {
        PrintHead();
        Console.WriteLine("Enter a Radius: ");

        if (double.TryParse(Console.ReadLine(), out uRad))
        {

            if (uRad > 0 && uRad < 999999999)
            {
                uValid = true;
            }
            else
            {
                Console.WriteLine("please enter positive a number less than 9,999,999,999");
                Thread.Sleep(250);
                Buff();
                uValid = false;
            }

        }
        else
        {
            Console.WriteLine("please enter positive a number less than 9,999,999,999");
            Thread.Sleep(250);
            Buff();
            uValid = false;
        }
    }
   
   Circle uCirc = new Circle(uRad);
     Buff();
    PrintHead();

    Console.WriteLine("Circumference: " + uCirc.circ);
    Console.WriteLine("Area: \t" + uCirc.area);
    cirCount++;

    bool validContIn = false;
    while (!validContIn)
    {   
        Console.WriteLine("Continue? (y/n)");
        string uCont  = Console.ReadLine().Trim().ToLower();
        if (uCont[0] != 'y' && uCont[0] != 'n')
        {
            validContIn = false;
            Console.WriteLine("Invalid Response!");
            Buff();
            PrintHead();
            
        }else if(uCont[0] == 'y')
        {
            validContIn = true;
            goAgain = true;
        }
        else
        {
            validContIn = true;
            goAgain = false;
        }
    }

}
//end of main loop
PrintHead();
Buff();
PrintHead();
Console.WriteLine($"\nGoodbye. You created {cirCount} Circle object(s).");
Thread.Sleep(500);
//goodbye with count





class Circle
{

   public double radius;
   public double area;
   public double circ;
    public Circle(double radius)
    {
        this.radius = radius;
        this.area = CalculateArea(radius);
        this.circ = CalculateCircumference(radius);
    }

    public double CalculateCircumference(double x)
    {
        double solv = 2 * (Math.PI) * x;
        return solv;
    }

    public double CalculateArea(double rad)
    {
        double solv = (Math.PI * (Math.Pow(rad, 2)));
        return solv;
    }
}

