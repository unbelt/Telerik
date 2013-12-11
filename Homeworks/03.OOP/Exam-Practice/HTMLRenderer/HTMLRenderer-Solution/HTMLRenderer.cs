namespace HTMLRenderer
{
    using System.Collections.Generic;
    using System.Text;

    public class HTMLElement : IElement
    {
        private IEnumerable<IElement> childElements;

        public HTMLElement(string name)
        {
            this.Name = name;
            this.childElements = new List<IElement>();
        }

        public HTMLElement(string name, string textContent)
            : this(name)
        {
            this.TextContent = textContent;
        }

        public string Name
        {
            get;
            private set;
        }

        public string TextContent
        {
            get;
            set;
        }

        public IEnumerable<IElement> ChildElements
        {
            get
            {
                return this.childElements;
            }

            private set
            {
                this.childElements = value;
            }
        }

        public virtual void Render(StringBuilder output)
        {
            if (!string.IsNullOrWhiteSpace(this.Name))
            {
                output.AppendFormat("<{0}>", this.Name);
            }

            foreach (var element in this.childElements)
            {
                element.Render(output);
            }

            if (!string.IsNullOrWhiteSpace(this.TextContent))
            {
                this.EscapeSpecialChars(output);
            }

            if (!string.IsNullOrWhiteSpace(this.Name))
            {
                output.AppendFormat("</{0}>", this.Name);
            }
        }

        public void AddElement(IElement element)
        {
            ((IList<IElement>)this.childElements).Add(element);
        }

        public override string ToString()
        {
            var output = new StringBuilder();

            this.Render(output);

            return output.ToString();
        }

        private void EscapeSpecialChars(StringBuilder output)
        {
            for (int symbol = 0; symbol < this.TextContent.Length; symbol++)
            {
                var currentChar = this.TextContent[symbol];

                switch (currentChar)
                {
                    case '<': output.Append("$lt");
                        break;
                    case '>': output.Append("$gt");
                        break;
                    case '&': output.Append("$amp");
                        break;
                    default: output.Append(currentChar);
                        break;
                }
            }
        }
    }
}