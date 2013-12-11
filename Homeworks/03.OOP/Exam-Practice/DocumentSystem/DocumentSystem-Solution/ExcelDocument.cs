namespace DocumentSystem
{
    using System.Collections.Generic;

    public class ExcelDocument : OfficeDocument
    {
        public ulong? NumberOfRows
        {
            get;
            set;
        }

        public ulong? NumberOfColumns { get; set; }

        public override void LoadProperty(string key, string value)
        {
            if (key == "rows")
            {
                this.NumberOfRows = ulong.Parse(value);
            }
            else if (key == "cols")
            {
                this.NumberOfColumns = ulong.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("rows", this.NumberOfRows));
            output.Add(new KeyValuePair<string, object>("cols", this.NumberOfColumns));
        }
    }
}