namespace AcademyPopcorn
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class IndestructibleBlock : Block
    {
        public new const string CollisionGroupString = "indestructibleBlock";

        public char Symbol { get; private set; }

        public IndestructibleBlock(MatrixCoords upperLeft, char symbol = '|')
            : base(upperLeft)
        {
            this.body[0, 0] = symbol;
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
        }

        public override string GetCollisionGroupString()
        {
            return CollisionGroupString;
        }
    }
}
