//-----------------------------------------------------------------------
// <copyright file="Statistics.cs" company="crypted info">
//  Copyright (c) crypted info. All rights reserved.
// </copyright>
// <author>for academy reason - crypted info</author>
//-----------------------------------------------------------------------
namespace RefBestPractices
{
    using System;
    using System.Globalization;
    using System.Threading;

    /// <summary>
    /// Calculate and print min, max and average value of double statistics data
    /// </summary>
    public class Statistics
    {
        #region Constants
        /// <summary>
        /// Maximal value of type double
        /// </summary>
        private const double MaxValue = double.MaxValue;

        /// <summary>
        /// Minimal value of type double
        /// </summary>
        private const double MinValue = double.MinValue;
        #endregion

        #region Fields
        /// <summary>
        /// Array with statistics data
        /// </summary>
        private double[] statisticsData;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Statistics"/> class.
        /// </summary>
        /// <param name="statisticsData">Contains the statistics data value</param>
        public Statistics(double[] statisticsData)
        {
            this.StatisticsData = statisticsData;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets statistics data
        /// </summary>
        /// <value> 
        /// Can not be null or empty.
        /// </value> 
        public double[] StatisticsData
        {
            get
            {
                return this.statisticsData;
            }

            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Must provide statistics data. Data can't be empty!");
                }

                this.statisticsData = value;
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Print minimal, maximal and average value of statistics data
        /// </summary>
        /// <param name="data">Statistics data array</param>
        public static void PrintStatistics(double[] data)
        {
            double min = FindMin(data);
            Console.WriteLine("Min value: {0:f}", min);

            double max = FindMax(data);
            Console.WriteLine("Max value: {0:f}", max);

            double average = FindAverage(data);
            Console.WriteLine("Average:   {0:f}", average);
        }   

        /// <summary>
        /// Find maximal value from statistics data array
        /// </summary>
        /// <param name="data">Statistics data array</param>
        /// <returns>Maximal value</returns>
        public static double FindMax(double[] data)
        {
            double maxValue = MinValue;
            int length = data.Length;

            for (int index = 0; index < length; index++)
            {
                if (data[index] > maxValue)
                {
                    maxValue = data[index];
                }
            }

            return maxValue;
        }

        /// <summary>
        /// Find minimal value from statistics data array
        /// </summary>
        /// <param name="data">Statistics data array</param>
        /// <returns>Minimal value</returns>
        public static double FindMin(double[] data)
        {
            double minValue = MaxValue;
            int length = data.Length;

            for (int index = 0; index < length; index++)
            {
                if (data[index] < minValue)
                {
                    minValue = data[index];
                }
            }

            return minValue;
        }

        /// <summary>
        /// Find average value from statistics data array
        /// </summary>
        /// <param name="data">Statistics data array</param>
        /// <returns>Average value</returns>
        public static double FindAverage(double[] data)
        {
            int length = data.Length;
            double sum = 0;            

            for (int index = 0; index < length; index++)
            {
                sum += data[index];
            }

            double average = sum / length;

            return average;
        }

        /// <summary>
        /// Test method <see cref="PrintStatistics"/>.
        /// </summary>
        public static void Main()
        { 
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            // First type of test
            double[] studentsScore = new double[] { 6.00, 2.00, 3.50, 5.00, 4.00, 5.50, 4.00, 2.50, 6.00, 4.50, 5.50, 5.00, 4.00, 3.00, 2.00, 6.00 };

            Console.WriteLine("Students Score:" + Environment.NewLine + new string('-', 20));
            PrintStatistics(studentsScore);

            Console.WriteLine();

            // Second type of test
            double[] storeIncome = new double[] { 126.50, 2.20, 0.50, 999.99, 99.99, 5.50, 33.33, 8.90, 4.20, 3.48, 6.50, 11.26, 25.48, 16.12, 8.65, 34.12 };

            Console.WriteLine("Store Income:" + Environment.NewLine + new string('-', 20));
            PrintStatistics(storeIncome);
        }
         #endregion
    }
}