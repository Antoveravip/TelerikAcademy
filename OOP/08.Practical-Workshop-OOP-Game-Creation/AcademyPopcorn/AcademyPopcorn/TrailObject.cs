using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Task 5: Implement a TrailObject class. It should inherit the GameObject
 * class and should have a constructor which takes an additional "lifetime"
 * integer. The TrailObject should disappear after a "lifetime" amount of 
 * turns. You must NOT edit any existing .cs file. Then test the TrailObject
 * by adding an instance of it in the engine through the AcademyPopcornMain.cs
 * file.
 */

namespace AcademyPopcorn
{
    public class TrailObject : GameObject
    {
        private int lifeTime;

        public int LifeTime
        {
            get { return this.lifeTime; }
            set { this.lifeTime = value; }
        }

        public TrailObject(MatrixCoords topLeft, char[,] body, int lifetime)
            : base(topLeft, body)
        {
            this.lifeTime = lifetime;
        }
        public override void Update()
        {
            lifeTime--;
            if (lifeTime <= 0)
            {
                this.IsDestroyed = true;
            }
        }
    }
}