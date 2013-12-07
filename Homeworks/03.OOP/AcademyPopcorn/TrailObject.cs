/* 5. Implement a TrailObject class. It should inherit the GameObject class and should have a constructor
      which takes an additional "lifetime" integer. The TrailObject should disappear after a "lifetime" amount of turns.
      You must NOT edit any existing .cs file. Then test the TrailObject by adding an instance of it in the engine
      through the AcademyPopcornMain.cs file. */

namespace AcademyPopcorn
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class TrailObject : GameObject
    {
        private int Lifetime = 3;

        public TrailObject(MatrixCoords topLeft, int lifetime)
            : base(topLeft, new char[,] { { ':' } })
        {
            this.Lifetime = lifetime;
        }

        public override void Update()
        {
            Lifetime--;

            if (Lifetime == 0)
            {
                this.IsDestroyed = true;
            }
        }
    }
}
