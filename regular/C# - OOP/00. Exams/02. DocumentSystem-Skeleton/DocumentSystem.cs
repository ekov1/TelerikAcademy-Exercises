using System;
using System.Collections.Generic;

namespace DocumentSystem
{
    public class DocumentSystem
    {
        private static IList<IDocument> documentsList = new List<IDocument>();

        static void Main()
        {
            IList<string> allCommands = ReadAllCommands();
            ExecuteCommands(allCommands);
        }

        private static IList<string> ReadAllCommands()
        {
            List<string> commands = new List<string>();
            while (true)
            {
                string commandLine = Console.ReadLine();
                if (commandLine == "")
                {
                    // End of commands
                    break;
                }
                commands.Add(commandLine);
            }
            return commands;
        }

        private static void ExecuteCommands(IList<string> commands)
        {
            foreach (var commandLine in commands)
            {
                int paramsStartIndex = commandLine.IndexOf("[");
                string cmd = commandLine.Substring(0, paramsStartIndex);
                int paramsEndIndex = commandLine.IndexOf("]");
                string parameters = commandLine.Substring(
                    paramsStartIndex + 1, paramsEndIndex - paramsStartIndex - 1);
                ExecuteCommand(cmd, parameters);
            }
        }

        private static void ExecuteCommand(string cmd, string parameters)
        {
            string[] cmdAttributes = parameters.Split(
                new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            if (cmd == "AddTextDocument")
            {
                AddTextDocument(cmdAttributes);
            }
            else if (cmd == "AddPDFDocument")
            {
                AddPdfDocument(cmdAttributes);
            }
            else if (cmd == "AddWordDocument")
            {
                AddWordDocument(cmdAttributes);
            }
            else if (cmd == "AddExcelDocument")
            {
                AddExcelDocument(cmdAttributes);
            }
            else if (cmd == "AddAudioDocument")
            {
                AddAudioDocument(cmdAttributes);
            }
            else if (cmd == "AddVideoDocument")
            {
                AddVideoDocument(cmdAttributes);
            }
            else if (cmd == "ListDocuments")
            {
                ListDocuments();
            }
            else if (cmd == "EncryptDocument")
            {
                EncryptDocument(parameters);
            }
            else if (cmd == "DecryptDocument")
            {
                DecryptDocument(parameters);
            }
            else if (cmd == "EncryptAllDocuments")
            {
                EncryptAllDocuments();
            }
            else if (cmd == "ChangeContent")
            {
                ChangeContent(cmdAttributes[0], cmdAttributes[1]);
            }
            else
            {
                throw new InvalidOperationException("Invalid command: " + cmd);
            }
        }

        private static void AddTextDocument(string[] attributes)
        {
            TextDocument doc = new TextDocument();

            foreach (var attribute in attributes)
            {
                string[] tokens = attribute.Split('=');
                string propName = tokens[0];
                string propValue = tokens[1];

                doc.LoadProperty(propName, propValue);
            }

            if (doc.Name != null)
            {
                documentsList.Add(doc);
                Console.WriteLine("Document added: {0}", doc.Name);
            }
            else
            {
                Console.WriteLine("Document has no name");
            }
        }

        private static void AddPdfDocument(string[] attributes)
        {
            // TODO
        }

        private static void AddWordDocument(string[] attributes)
        {
            // TODO
        }

        private static void AddExcelDocument(string[] attributes)
        {
            // TODO
        }

        private static void AddAudioDocument(string[] attributes)
        {
            // TODO
        }

        private static void AddVideoDocument(string[] attributes)
        {
            // TODO
        }

        private static void ListDocuments()
        {
            if (documentsList.Count == 0)
            {
                Console.WriteLine("No documents found");
            }
            else
            {
                foreach (var document in documentsList)
                {
                    Console.WriteLine(document.ToString());
                }
            }
        }

        private static void EncryptDocument(string name)
        {
            // TODO
        }

        private static void DecryptDocument(string name)
        {
            // TODO
        }

        private static void EncryptAllDocuments()
        {
            // TODO
        }

        private static void ChangeContent(string name, string content)
        {

        }
    }
}
