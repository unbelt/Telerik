namespace AcademyPopcorn
{
    using System.Collections.Generic;

    public class GiftBlock : Block
    {
        public new const string CollisionGroupString = "giftBlock";

        public GiftBlock(MatrixCoords topLeft)
            : base(topLeft)
        {
            this.body[0, 0] = 'G';
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }

        public override System.Collections.Generic.IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> fallingGifts = new List<GameObject>();

            if (this.IsDestroyed)
            {
                fallingGifts.Add(new Gift(this.topLeft, new char[,] { { 's' } }, new MatrixCoords(1, 0)));
            }

            return fallingGifts;
        }

        public override string GetCollisionGroupString()
        {
            return GiftBlock.CollisionGroupString;
        }
    }
}