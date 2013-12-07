// 4. Inherit the Engine class. Create a method ShootPlayerRacket. Leave it empty for now.

namespace AcademyPopcorn
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class ShootPlayerRacket : Engine
    {
        public ShootPlayerRacket(IRenderer renderer, IUserInterface userInterface, int speed)
            : base(renderer, userInterface, speed)
        {
        }
    }
}