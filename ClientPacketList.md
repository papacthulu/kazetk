# Introduction #

Packets sent by the client come in three flavours, encrypted, unencrypted, and header-less.

### Adding New Packets ###
Please see the ClientPacketTemplate before adding or changing packet packet Wiki pages.

# Packets #
## Without Header ##

| **ID** | **`[WikiPage`]** | **Function** |
|:-------|:-----------------|:-------------|
| 0x00 | [CPacket\_00](CPacket_00.md) | Unknown |
| 0x62 | [CPacket\_62](CPacket_62.md) | Seems to send the ASCII string BARAM |

## With Header ##

| **ID** | **`[WikiPage]`** | **Function** |
|:-------|:-----------------|:-------------|
| 0x02 | [CPacket\_02](CPacket_02.md) | Sends Username and password to server and waits for response on whether they are valid or not. |
| 0x03 | [CPacket\_03](CPacket_03.md) | Login |
| 0x04 | [CPacket\_04](CPacket_04.md) | Sends character data for creation (Hair, Color, Totem). |
| 0x05 | [CPacket\_05](CPacket_05.md) | Seems to tell the server where the "camera" center is. |
| 0x06 | [CPacket\_06](CPacket_06.md) | Probably involves something with map updates. |
| 0x07 | [CPacket\_07](CPacket_07.md) | Used when picking up items. |
| 0x08 | [CPacket\_08](CPacket_08.md) | Used when dropping items. |
| 0x0A | [CPacket\_0A](CPacket_0A.md) | Used when Rick Clicking? |
| 0x0E | [CPacket\_0E](CPacket_0E.md) | Chat Message (Normal and Shout) |
| 0x11 | [CPacket\_11](CPacket_11.md) | Send when character changes direction (facing). |
| 0x13 | [CPacket\_13](CPacket_13.md) | Attacking |
| 0x19 | [CPacket\_19](CPacket_19.md) | Whispering |
| 0x1B | [CPacket\_1B](CPacket_1B.md) | Used when toggling some client options (wisdom, etc), some F1-12 options, and when trying to mount using r.|
| 0x1C | [CPacket\_1C](CPacket_1C.md) | Equiping Items |
| 0x1D | [CPacket\_1D](CPacket_1D.md) | Emoticons |
| 0x2D | [CPacket\_2D](CPacket_2D.md) | Something involving group and status tabs, probably requesting information from server.|
| 0x32 | [CPacket\_32](CPacket_32.md) | Move |
| 0x38 | [CPacket\_38](CPacket_38.md) | Refresh screen/map data |
| 0x39 | [CPacket\_39](CPacket_39.md) | Selecting items on menu |
| 0x3A | [CPacket\_3A](CPacket_3A.md) | Navigating menus |
| 0x3B | [CPacket\_3B](CPacket_3B.md) | Opening board/mail |
| 0x43 | [CPacket\_43](CPacket_43.md) | Is sent when you click on an object/NPC which (presumably) calls a script. |
| 0x69 | [CPacket\_69](CPacket_69.md) | Client sends this packet when you try to move in a direction which is currently (according to the client) occupied by NPC. |