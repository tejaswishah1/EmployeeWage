﻿using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Program");
            ////Constants
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            ////Checking attendance
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");

            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
            
            
            //variable
            int empHrs =0;
            int empWage = 0;

            int totalEmpWage = 0;
            int totalHrs = 0;
            int DAYS = 1;


            

            //Computation of wages: 
            empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }

            else
                empHrs = 4; ////Assuming part time hours as 4







            //// switch case to calculate part time wages
            switch (empCheck)
            {
                case 0:
                    empHrs = 4;
                    break;
                case 1:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }





      

            Console.WriteLine("Employee wage = " + empWage);
            //// Salary for 20 days

            empWage = empHrs * EMP_RATE_PER_HOUR * 20;

            Console.WriteLine("Employee wage = " + empWage);

            //// Calculate wages for hours less than 100 and days less than 20
          
            for (DAYS = 1; DAYS <= 20; DAYS += 1)
            {
                while (totalHrs <= 100)
                {
                   
                    empCheck = random.Next(0, 2);
                    if (empCheck == IS_FULL_TIME)
                    {
                        empHrs = 8;
                        totalHrs += empHrs;
                    }
                    else
                    {
                        empHrs = 4;
                        totalHrs += empHrs;
                    }
                }
                empWage = totalHrs * EMP_RATE_PER_HOUR * DAYS;
                totalEmpWage += empWage;
            }
            Console.WriteLine("Total Employee Wage = " + totalEmpWage);



           


            empWage = empHrs * EMP_RATE_PER_HOUR;


            Console.WriteLine("Employee wage = " + empWage);

        }
    }
    }

