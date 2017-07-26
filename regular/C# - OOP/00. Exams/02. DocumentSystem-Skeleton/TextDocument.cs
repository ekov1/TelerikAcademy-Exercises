using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSystem
{
    class TextDocument : Document
    {
        public string Charset { get; protected set; }

        public void LoadProperty(string key, string value)
        {
            if (key == "charset")
            {
                this.Name = value;
            }
            else
            {
                base.LoadProperty(key, value);
            }

        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>("charset", this.Charset));
            base.SaveAllProperties(output);
        }
    }
}
