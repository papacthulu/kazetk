#region

using System;
using System.IO;
using System.Text.RegularExpressions;

#endregion

namespace IDChanger
{
    internal class IDChanger
    {
        private static void Main(string[] args)
        {
            try
            {
                for (byte i = 0; i < 150; i++)
                {
                    ReplaceInFile("CPacket_" + i.ToString("X2") + ".wiki", @"\* Packet ID \[.*]?",
                                  "* Packet ID *`[0x" + i.ToString("X2") + "]`*");
                    ReplaceInFile("SPacket_" + i.ToString("X2") + ".wiki", @"\* Packet ID \[.*]?",
                                  "* Packet ID *`[0x" + i.ToString("X2") + "]`*");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.ReadKey();
            }
        }

        public static void ReplaceInFile(string filePath, string searchText, string replaceText)
        {
            var reader = new StreamReader(filePath);
            string content = reader.ReadToEnd();
            reader.Close();

            content = Regex.Replace(content, searchText, replaceText);

            var writer = new StreamWriter(filePath);
            writer.Write(content);
            writer.Close();
        }
    }
}