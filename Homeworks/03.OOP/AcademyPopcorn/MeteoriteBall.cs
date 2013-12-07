/* 6. Implement a MeteoriteBall. It should inherit the Ball class and should leave a trail of TrailObject objects.
      Each trail objects should last for 3 "turns". Other than that, the Meteorite ball should behave the same way
      as the normal ball. You must NOT edit any existing .cs file. */

namespace AcademyPopcorn
{
    using System.Collections.Generic;

    public class MeteoriteBall : Ball
    {
        private int TailLife = 3;

        public MeteoriteBall(MatrixCoords topLeft, MatrixCoords speed, int tailLife)
            : base(topLeft, speed)
        {
            this.TailLife = tailLife;
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "racket" || otherCollisionGroupString == "block";
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> tails = new List<GameObject>();
            tails.Add(new TrailObject(base.TopLeft, this.TailLife));

            return tails;
        }
    }
}
