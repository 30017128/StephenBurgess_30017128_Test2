//Stephen Burgess
//Payroll Application 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{//Main Program Class
    class Program
    {
        static void Main(string[] args)
        {

            //creates the double annual salary
            double annualsalary = 80000;
            //creates the double hourlyRate
            double hourlyRate = 33.72;

            //Creates an Salary object using annualsalary as a double
            Salary p1 = new Salary(annualsalary);

            Console.WriteLine("Welcome to the staff payroll system");
            Console.WriteLine("enter 1. to display Salary");
            Console.WriteLine("enter 2. to display wages");
            Console.Write("Enter option: ");
            double num = double.Parse(Console.ReadLine());

            //If the user enters 1 they will see their salary
            if (num == 1)
            {
                //Shows the user their annual salary and their weekly salary
                Console.WriteLine($"\nYour salary is set at ${p1.Annualsalary} per year\nYour salary per week is ${p1.Weeklysalary()}.00\n\n ");
               
                Console.ReadLine();

            }
            //If they enter 2 they will see their wages
            else if (num == 2)
            {
                Console.WriteLine("\nI will calculate your wages");
                Console.Write("Enter the number of hours worked: ");
                //allows the user to enter how many hours they work
                double numHours = double.Parse(Console.ReadLine());
                //Creates a Wages Object combining the doubles hourlyRate and numHours
                Wages w1 = new Wages(hourlyRate, numHours);
                //Shows the user their weekly wages
                Console.WriteLine($"Your wages per week is ${w1.WeeklyWages()} ");
                Console.ReadLine();

            }
            //If they enter the wrong number they will be told to restart the program and enter 1 or 2
            else
            {
                Console.WriteLine("Please Restart the program and enter 1 or 2");
                Console.ReadLine();
              }
        }
            

            

               
                   
            


            

           
           


        }

        class Salary
        {
            //getters and setters
            public double Annualsalary { get; set; }

            //Constructor
            public Salary(double _annualsalary)
            {
                Annualsalary = _annualsalary;//accesses the annualsalary setter


            }

            //Method WeeklySalary divides AnnualSalary by 52.1429 so it can be displayed back to the user
            public double Weeklysalary()
            {

                return Math.Round (Annualsalary / 52.1429);

            }




        }
        class Wages
        {
            //getters and setters 
            public double HourlyRate { get; set; }
            public double NumHours { get; set; }

            //Constructor allows the main method to access the properties
            public Wages(double _hourlyRate, double _numHours)
            {
                HourlyRate = _hourlyRate;
                NumHours = _numHours;


            }
            //Method NumHours times HourlyRate to get WeeklyWages
            public double WeeklyWages()
            {

                return NumHours * HourlyRate;



            }

        }
    }
    

        
    



