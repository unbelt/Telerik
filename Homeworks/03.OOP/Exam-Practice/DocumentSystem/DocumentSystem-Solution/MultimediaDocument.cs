﻿namespace DocumentSystem
{
    using System.Collections.Generic;

    public abstract class MultimediaDocument : BinaryDocument
    {
        public ulong? Length { get; set; }

        public override void LoadProperty(string key, string value)
        {
            if (key == "length")
            {
                this.Length = ulong.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("length", this.Length));
        }
    }
}
