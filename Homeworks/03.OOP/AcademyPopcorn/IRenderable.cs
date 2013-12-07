namespace AcademyPopcorn
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public interface IRenderable
    {
        MatrixCoords GetTopLeft();

        char[,] GetImage();
    }
}
