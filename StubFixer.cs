using System;
using System.IO;
using System.Text.RegularExpressions;

namespace StubFixer
{
    class StubFixer
    {
        static void Main(string[] args)
        {
            foreach(string arg in args)
            {
                if(arg == "--help" || arg == "-h" || arg == "/?")
                {
                Console.WriteLine("Usage: StubFixer.exe <searchtext> <replacetext>");
                Environment.Exit(0);
                }
                
            }
            try
            {
            for (byte i = 0; i < 150; i++)
			{
            
                ReplaceInFile("CPacket_" + i.ToString("X2") + ".wiki", args[0],args[1]);
                ReplaceInFile("SPacket_" + i.ToString("X2") + ".wiki", args[0],args[1]);
            }
            }
            catch
                {
                    Console.WriteLine("Usage: StubFixer.exe <searchtext> <replacetext>");
                }

        }
                    static public void ReplaceInFile( string filePath, string searchText, string replaceText )
{
    StreamReader reader = new StreamReader( filePath );
    string content = reader.ReadToEnd();
    reader.Close();

    content = Regex.Replace( content, searchText, replaceText );

    StreamWriter writer = new StreamWriter( filePath );
    writer.Write( content );
    writer.Close();
}
    }
}