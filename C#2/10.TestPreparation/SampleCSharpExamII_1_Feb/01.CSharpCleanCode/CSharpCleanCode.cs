using System;
using System.IO;
using System.Text;

class CSharpCleanCode
{
    static void Main()
    {
        StringBuilder inputCode = new StringBuilder();
        int linesCount = int.Parse(Console.ReadLine());

        bool inMultiLineComment = false;
        bool inString = false;
        bool inMultilineString = false;
        bool inSingleQuotedString = false;

        for (int i = 1; i <= linesCount; i++)
        {
            string line = Console.ReadLine();

            for (int j = 0; j < line.Length; j++)
            {
                if (inMultilineString)
                {
                    if (line[j] == '\"' && j + 1 < line.Length && line[j + 1] == '\"')
                    {
                        inputCode.Append("\"\"");
                        j++;
                        continue;
                    }
                }
                if (inString)
                {
                    if (line[j] == '\\' && j + 1 < line.Length && line[j + 1] == '\"')
                    {
                        inputCode.Append("\\\"");
                        j++;
                        continue;
                    }
                    if (line[j] == '\\' && j + 1 < line.Length && line[j + 1] == '\'')
                    {
                        inputCode.Append("\\\'");
                        j++;
                        continue;
                    }
                    if (line[j] == '\"' && !inSingleQuotedString)
                    {
                        inString = false;
                        inMultilineString = false;
                        inputCode.Append('\"');
                        continue;
                    }
                    if (line[j] == '\'' && inSingleQuotedString)
                    {
                        inString = false;
                        inSingleQuotedString = false;
                        inputCode.Append('\'');
                        continue;
                    }
                    inputCode.Append(line[j]);
                    continue;
                }

                // Multiline comments
                if (!inMultiLineComment && j + 1 < line.Length && line[j] == '/' && line[j + 1] == '*')
                {
                    inMultiLineComment = true;
                    j++;
                    continue;
                }
                if (inMultiLineComment && j + 1 < line.Length && line[j] == '*' && line[j + 1] == '/')
                {
                    inMultiLineComment = false;
                    j++;
                    continue;
                }
                if (inMultiLineComment)
                {
                    continue;
                }

                // One line comment
                if (line[j] == '/' && j + 1 < line.Length && line[j + 1] == '/')
                {
                    if (j + 2 >= line.Length || line[j + 2] != '/')
                    {
                        break;
                    }
                    else
                    {
                        // Inline documentation (///)
                        inputCode.Append("///");
                        j += 2;
                        continue;
                    }
                }

                if (line[j] == '@' && j + 1 < line.Length && line[j + 1] == '\"')
                {
                    inString = true;
                    inMultilineString = true;
                    j++;
                    inputCode.Append("@\"");
                    continue;
                }

                if (line[j] == '\"')
                {
                    inString = true;
                }

                if (line[j] == '\'')
                {
                    inString = true;
                    inSingleQuotedString = true;
                }


                inputCode.Append(line[j]);
            }

            if (!inMultiLineComment) inputCode.AppendLine();
        }

        StringReader sr = new StringReader(inputCode.ToString());
        string lineToPrint = null;
        while ((lineToPrint = sr.ReadLine()) != null)
        {
            if (!string.IsNullOrWhiteSpace(lineToPrint))
            {
                Console.WriteLine(lineToPrint);
            }
        }
    }
}