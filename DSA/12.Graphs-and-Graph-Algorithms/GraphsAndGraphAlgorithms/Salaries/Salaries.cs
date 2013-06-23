/* Lesson 12 - Graphs and Graph Algorithms
 * Homework 1
 * 
 * Solve these problems from BGCoder:
 * 
 * Task 1.2: Algo Academy February 2013 – Problem 04 – Salaries
 * 
 * http://bgcoder.com/Contest/Practice/130
 * 
 */
namespace Salaries
{
    using System;

    // Used for help this video - http://www.youtube.com/watch?v=bmPvxJOV1p0
    public static class Salaries
    {
        // Number of all employees
        private static int employeesCount;

        // Matrix with all employees and theyr relations
        private static bool[,] structureMatrix;

        // Data with salary of every employee
        private static long[] employeeSalaries;

        public static long CalculateSalary(int employee)
        {
            // Optimization - if salary of this employee is calculated - skip calculations again
            if (employeeSalaries[employee] > 0)
            {
                return employeeSalaries[employee];
            }

            long salary = 0;
            for (int subordinates = 0; subordinates < employeesCount; subordinates++)
            {
                // Check if current employee has subordinates and calculate the salary of that subordinates.
                if (structureMatrix[employee, subordinates])
                {
                    salary += CalculateSalary(subordinates);
                }
            }

            // If employee has no one subordinate - make his salary equal to 1
            if (salary == 0)
            {
                salary = 1;
            }

            // Adding the calculated salary to salary data to skip more calculation ot this employee salary
            employeeSalaries[employee] = salary;

            return salary;
        }

        public static void Main(string[] args)
        {
            // Get value from console for number of employees
            employeesCount = int.Parse(Console.ReadLine());

            // Create matrix for relations between the employees - by default all cell is false - no one has subordinates
            structureMatrix = new bool[employeesCount, employeesCount];

            // Here create needed data size according the number of the employees
            employeeSalaries = new long[employeesCount];

            for (int employee = 0; employee < employeesCount; employee++)
            {
                // Get from console the relations of current employee with others employee.
                string data = Console.ReadLine();
                for (int subordinates = 0; subordinates < employeesCount; subordinates++)
                {
                    // Check if current employee has subordinates and which of other employees are that subordinates 
                    bool hasSubordinates = data[subordinates] == 'Y';

                    // Change the state of relations between curent employee and those that is his subordinates
                    structureMatrix[employee, subordinates] = hasSubordinates;
                }
            }

            long totalSalaries = 0;

            // For each employee calculate the salary to get the total salary
            for (int employee = 0; employee < employeesCount; employee++)
            {
                totalSalaries += CalculateSalary(employee);
            }

            Console.WriteLine(totalSalaries);
        }
    }
}