// Task 2 - Edrei Merino

#region 1
using System.Runtime.ConstrainedExecution;
{
    // Read 10 numbers from keyboard and find their sum and average.
    int total = 10;
    int sum = 0;
    int value;
    float average;

    for (int i = 0; i < total; i++)
    {
        // User 10 inputs
        Console.WriteLine("Enter a number: ");
        value = Convert.ToInt32(Console.ReadLine());

        // Solve: Sum of the values
        sum += value;
    }

    // Solve: Average of user input.
    average = (float)sum / total;

    // Display sum and average to user.
    Console.WriteLine("Sum: " + sum + ", Average: " + average);
}
#endregion

#region 2
{
    // Print the following pattern as per user input.
    int starValue;

    Console.WriteLine("Please enter a number: ");
    starValue = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i <= starValue; ++i)
    {
        for (int j = 1; j <= i; ++j)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}
#endregion

#region 3
{
    // Print following pattern as per user input.
    int userInput;

    Console.WriteLine("Please enter a number: ");
    userInput = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i <= userInput; ++i)
    {
        for (int j = 1; j <= i; ++j)
        {
            Console.Write(j);
        }
        Console.WriteLine();
    }
}
#endregion

#region 4
{
    // Print following pattern as per user input.
    int userInput2;
    int k = 1;

    Console.WriteLine("Please enter a number: ");
    userInput2 = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i <= userInput2; i++)
    {
        for (int j = 0; j <= i; j++) 
        {
            Console.Write("{0} ",k++);
        }
        Console.WriteLine();
    }
}
#endregion