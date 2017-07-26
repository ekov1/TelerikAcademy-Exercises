using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSystem
{
    public abstract class Document : IDocument
    {
        public string Content { get; protected set; }
        public string Name { get; protected set; }

        public virtual void LoadProperty(string key, string value)
        {
            if (key == "name")
            {
                this.Name = value;
            }
            if (key == "content")
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
            StringBuilder sb = new StringBuilder();

            sb.Append(this.GetType().Name);
            sb.Append('[');

            IList<KeyValuePair<string, object>> atributes = new List<KeyValuePair<string, object>>();
            SaveAllProperties(atributes);
            var sortedAttributes = atributes.OrderBy(item => item.Key);

            foreach (var attribute in sortedAttributes)
            {
                if (attribute.Value != null )
                {
                    sb.Append(attribute.Key);
                    sb.Append('=');
                    sb.Append(attribute.Value);
                    sb.Append(';');
                }
            }
            sb.Length--;
            sb.Append(']');

            return sb.ToString();
        }
    }
}
