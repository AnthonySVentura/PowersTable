Console.WriteLine("Displaying squares and cubes for numbers.");

static int getSquared(int value)
{
    return value * value;
}

static int getCubed(int value)
{
    return value * value * value;
}

while (true)
{
    Console.WriteLine("Please enter a number.");
    int value = int.Parse(Console.ReadLine());

    if (value < 0)
    {
        Console.WriteLine("Enter a valid number");
            continue;
    }

    if (value > 1290)
    {
        Console.WriteLine("This number will not work. Please enter a value thats less than or equal to 1290");
        continue;
    }

    Console.WriteLine(String.Format("{0,15} {1,15} {2,15}", "Number", "Squared", "Cubed"));
    Console.WriteLine(String.Format("{0,15} {1,15} {2,15}", "======", "=======", "====="));

    for (int i = 1; i <= value; i++)
    {
        Console.WriteLine(String.Format("{0,15} {1,15} {2,15}", i, getSquared(i), getCubed(i)));
    }

    Console.WriteLine("Would you like to restart? Enter y to continue, or press any other key to exit");
    string restart = Console.ReadLine().ToUpper();

    if (restart == "y" || restart == "Y")
    {
        continue;
    }
    else
    {
        Console.WriteLine("This is the end of the program");
        break;
    }

}