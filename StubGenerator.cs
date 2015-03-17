using System;
using System.IO;

namespace StubGenerator
{
    class StubGenerator
    {
        static void Main()
        {
            for (byte i = 0; i < 150; i++)
			{
                File.Copy("ClientPacketTemplate.wiki","CPacket_" + i.ToString("X2") + ".wiki");
                File.Copy("ServerPacketTemplate.wiki","SPacket_" + i.ToString("X2") + ".wiki");
			}
        }
    }
}