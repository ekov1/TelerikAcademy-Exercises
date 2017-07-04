using System;
using System.Text;

namespace StringsParseTags
{
    class StringsParseTags
    {
        static void Main()
        {
            string text;  //= Console.ReadLine();
            text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";

            StringBuilder builder = new StringBuilder();

            while (text.IndexOf('<') != -1)
            {
                builder.Append(text.Substring(0, text.IndexOf('<')));

                text = text.Remove(0, text.IndexOf('<') + 1);
                Console.WriteLine(text);
                Console.WriteLine();

                builder.Append(text.Substring(text.IndexOf('>') + 1, (text.IndexOf('<') - text.IndexOf('>') - 1)).ToUpper());

                text = text.Remove(0, text.IndexOf('>') + 1);
                text = text.Remove(0, text.IndexOf('>') + 1);
                Console.WriteLine(text);
                Console.WriteLine();

            }

            builder.Append(text);

            Console.WriteLine(builder.ToString());

        }
    }
}
