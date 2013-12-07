namespace AcademyPopcorn
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class UnpassableBlock : Block
    {
        public const char Symbol = 'U';
        public new const string CollisionGroupString = "unpassableBlock";

        public UnpassableBlock(MatrixCoords topLeft)
            : base(topLeft)
        {
            this.body[0, 0] = Symbol;
        }

        public override string GetCollisionGroupString()
        {
            return CollisionGroupString;
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
        }
    }
}
