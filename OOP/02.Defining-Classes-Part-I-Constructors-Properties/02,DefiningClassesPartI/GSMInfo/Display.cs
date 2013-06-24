using System;

namespace GSM
{
    public class Display
    {
        // --- FIELDS --- //
        // Characteristics fields - homework tasks 1
        private double size;
        private int colors;

        // --- CONSTRUCTORS --- //
        //Constructors - Homework Task 2  
        public Display()
            : this(0, 0) // Reuse the constructor
        {
        }
        //Constructor with the full information for the class
        public Display(double size = 0, int colors = 0)
        {
            this.size = size;
            this.colors = colors;
        }

        // --- PROPERTIES --- //
        //Properties - Homework Tasks 5
        public double Size
        {
            get { return size; }
            set
            {
                if (value <= 1)
                {
                    throw new ArgumentOutOfRangeException("The size should be correct!");
                }
                else
                {
                    size = value;
                }
            }
        }

        public int Colors
        {
            get { return colors; }
            set
            {
                if (value <= 2)
                {
                    throw new ArgumentOutOfRangeException("The colors should be at least 2!");
                }
                else
                {
                    colors = value;
                }
            }
        }
    }
}