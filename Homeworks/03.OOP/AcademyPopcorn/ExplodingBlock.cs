/* 10. Implement an ExplodingBlock. It should destroy all blocks around it when it is destroyed.
       You must NOT edit any existing .cs file. */

namespace AcademyPopcorn
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class ExplodingBlock : Block
    {
        public new const string CollisionGroupString = "explodingBlock";
        public const char Symbol = 'E';

        public ExplodingBlock(MatrixCoords topLeft)
            : base(topLeft)
        {
            this.body[0, 0] = Symbol;
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "ball";
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> splash = new List<GameObject>();

            if (this.IsDestroyed)
            {
                splash.Add(new Explosion(this.topLeft, new char[,] { { '*' } }, new MatrixCoords(-1, 0)));
                splash.Add(new Explosion(this.topLeft, new char[,] { { '*' } }, new MatrixCoords(1, 0)));
                splash.Add(new Explosion(this.topLeft, new char[,] { { '*' } }, new MatrixCoords(0, 1)));
                splash.Add(new Explosion(this.topLeft, new char[,] { { '*' } }, new MatrixCoords(0, -1)));
            }

            return splash;
        }

        public override string GetCollisionGroupString()
        {
            return ExplodingBlock.CollisionGroupString;
        }
    }
}
