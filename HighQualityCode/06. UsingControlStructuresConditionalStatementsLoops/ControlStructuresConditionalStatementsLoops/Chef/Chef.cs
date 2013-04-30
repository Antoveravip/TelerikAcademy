namespace Chef
{
    using System;
    // For this task I thing than must only reorganize the methods.
    // Thats why do not create classes and rewrite method structure.
    public class Chef
    {
        public void Cook()
        {
            Bowl bowl = GetBowl();

            Potato potato = GetPotato();
            Peel(potato);
            Cut(potato);
            bowl.Add(potato);

            Carrot carrot = GetCarrot();
            Peel(carrot);
            Cut(carrot);
            bowl.Add(carrot);
        }

        private Bowl GetBowl()
        {
            //...
        }

        private Carrot GetCarrot()
        {
            //...
        }

        private Potato GetPotato()
        {
            //...
        }

        private void Cut(Vegetable vegetable)
        {
            //...
        }

        private void Peel(Vegetable vegetable)
        {
            //...
        }
    }
}