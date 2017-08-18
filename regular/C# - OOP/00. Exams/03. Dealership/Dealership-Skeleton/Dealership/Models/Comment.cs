using Dealership.Common;
using Dealership.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership.Models
{
    public class Comment : IComment
    {
        private string content;

        public Comment(string content)
        {
            this.Content = content;
        }

        public string Author { get; set; }

        public string Content
        {
            get
            {
                return this.content;
            }

            private set
            {
                Validator.ValidateNull(value, "Content can not be null!");
                Validator.ValidateIntRange(
                    value.Length,
                    Constants.MinCommentLength,
                    Constants.MaxCommentLength,
                    string.Format(
                    Constants.StringMustBeBetweenMinAndMax,
                    nameof(this.Content),
                    Constants.MinCommentLength,
                    Constants.MaxCommentLength));
                this.content = value;
            }
        }

        public override string ToString()
        {
            return string.Format(@"----------
    {0}
       User: {1} {2}
----------", this.Content, this.Author);
        }
    }
}
