namespace AcademyPopcorn
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class MovingObject : GameObject
    {    
        public MatrixCoords Speed { get; protected set; }

        public MovingObject(MatrixCoords topLeft, char[,] body, MatrixCoords speed)
            : base(topLeft, body)
        {
            this.Speed = speed;
        }

        protected virtual void UpdatePosition()
        {
            this.TopLeft += this.Speed;
        }

        public override void Update()
        {
        }


    }
}
