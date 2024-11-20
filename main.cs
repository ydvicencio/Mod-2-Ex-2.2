using System;

class Program
    {
        static void Main(string[] args)
        {
          //constants
          const decimal BASE_RATE =200m; //base rate for the first mile in dollars
          const decimal RATE_PER_HOUR = 150m; //rate per hour in dollars
          const decimal RATE_PER_MILE = 2m; //rate per mile in dollars

          //User input
          Console.WriteLine("Enter number of hours for the job: ");
          decimal hours = Convert.ToDecimal(Console.ReadLine());

          Console.WriteLine("Enter number of miles for the move: ");
          decimal miles = Convert.ToDecimal(Console.ReadLine());

          //calculations
          decimal totalCost = BASE_RATE + (RATE_PER_HOUR * hours) + (RATE_PER_MILE * miles);

          //display total estimated rate
          Console.WriteLine("The estimated rate for the move is: $" + totalCost);
        }
    }
  

