namespace DocumentSystem
{
    using System.Collections.Generic;

    public class WordDocument : OfficeDocument, IEditable
    {
        public string NumberOfCharacters
        {
            get;
            set;
        }

        public override void LoadProperty(string key, string value)
        {
            if (key == "chars")
            {
                this.NumberOfCharacters = value;
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("chars", this.NumberOfCharacters));
        }

        public void ChangeContent(string newContent)
        {
            this.Content = newContent;
        }
    }
}
