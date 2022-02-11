/* 
Name: Rachel Pittman
Date: 2/10/22
Comments: This C# Console App demonstrates the use of iterative statements

*/

using System;


 
    double conversion;
    double USD;
//have user input CAD number 
    Console.Write ("Please enter a CAD increment value: ");
//catch block to verify input
try
{
    string input = Console.ReadLine();
    //interative statement
    int CAD_val = int.Parse(input);
    //if number is between 5 and 25, loop
    if ((CAD_val >= 5) && (CAD_val <= 25))
    {
        //conversion rate
        conversion = 0.792367;
        Console.WriteLine("CAD Increment value = " + input + "\n");

        Console.WriteLine("CAD" + "\t" + "USD"); //headers of values

        for (int i = 0; i <= 200; i = i + CAD_val) //loop
        {
            USD = i * conversion;

            string mg = i.ToString() + "\t" + USD;
            Console.WriteLine(mg);
        }

    }
    else
    {
        //error message displayed if user doesn't input correct value 5-25
        Console.WriteLine(" Please enter CAD value between 5 & 25 ");
        Console.WriteLine("Enter any key to exit");
        Console.ReadKey(true);

    }
}
catch
{
   //error
    Console.WriteLine(" Please enter CAD value between 5 & 25 ");
    Console.WriteLine("Enter any key to exit");
    Console.ReadKey(true);

}