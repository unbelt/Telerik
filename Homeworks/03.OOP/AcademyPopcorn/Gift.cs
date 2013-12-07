/* 11. Implement a Gift class. It should be a moving object, which always falls down.
       The gift shouldn't collide with any ball, but should collide (and be destroyed) with the racket.
       You must NOT edit any existing .cs file. */

namespace AcademyPopcorn
{
    using System.Collections.Generic;

    public class Gift : MovingObject
    {
        public new const string CollisionGroupString = "gift";

        public Gift(MatrixCoords topLeft, char[,] body, MatrixCoords speed)
            : base(topLeft, body, speed)
        {
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "racket";
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }

        public override string GetCollisionGroupString()
        {
            return Gift.CollisionGroupString;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> produceShootingRacket = new List<GameObject>();

            if (this.IsDestroyed)
            {
                produceShootingRacket.Add(new ShootingRacket(new MatrixCoords(this.topLeft.Row + 1, this.topLeft.Col - 10), 10));
            }

            return produceShootingRacket;
        }
    }
}