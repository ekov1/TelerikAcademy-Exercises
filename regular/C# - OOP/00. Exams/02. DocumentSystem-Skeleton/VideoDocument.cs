using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSystem
{
    public class VideoDocument : MultimediaDocument
    {
        public long? FrameRate { get; protected set; }

        public override void LoadProperty(string key, string value)
        {
            if (key == "faramerate")
            {
                this.FrameRate = long.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }

        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>("faramerate", this.FrameRate));
            base.SaveAllProperties(output);
        }
    }
}
