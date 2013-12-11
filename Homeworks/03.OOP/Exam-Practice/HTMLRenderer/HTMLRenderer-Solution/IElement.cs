namespace HTMLRenderer
{
    using System.Collections.Generic;
    using System.Text;

    public interface IElement
    {
        string TextContent { get; set; }

        IEnumerable<IElement> ChildElements { get; }

        string Name { get; }

        void AddElement(IElement element);

        void Render(StringBuilder output);

        string ToString();
    }
}
