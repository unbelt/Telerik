namespace DocumentSystem
{
    using System.Collections.Generic;
    using System.Text;

    public abstract class Document : IDocument
    {
        public string Name
        {
            get;
            protected set;
        }

        public string Content
        {
            get;
            protected set;
        }

        public virtual void LoadProperty(string key, string value)
        {
            if (key == "name")
            {
                this.Name = value;
            }
            else if (key == "content")
            {
                this.Content = value;
            }
        }

        public virtual void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>("name", this.Name));
            output.Add(new KeyValuePair<string, object>("content", this.Content));
        }

        public override string ToString()
        {
            List<KeyValuePair<string, object>> properties = new List<KeyValuePair<string, object>>();
            this.SaveAllProperties(properties);

            properties.Sort((a, b) => a.Key.CompareTo(b.Key));

            var print = new StringBuilder();

            print.AppendFormat("{0}[", this.GetType().Name);

            foreach (var prop in properties)
            {
                if (prop.Value != null)
                {
                    print.AppendFormat("{0}={1};", prop.Key, prop.Value);
                }
            }

            print.Length--;
            print.Append(']');

            return print.ToString();
        }
    }
}