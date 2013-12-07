namespace AcademyPopcorn
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public interface IObjectProducer
    {
        IEnumerable<GameObject> ProduceObjects();
    }
}
