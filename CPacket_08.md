# Drop Item #

---


## Details ##

Description of packet
  * Packet ID **`[0x08]`**
  * Uses Normal 5 Byte header
  * Is Encrypted

## Packet Breakdown ##
| Index | Datatype | Length | Function |
|:------|:---------|:-------|:---------|
| 1 | Byte | 1 | Location in Inventory of Item to Drop |
| 1 | Bool | 1 | Drop All |
| 1 | Null Byte | 1 |

### Location of Item ###
| Slot A | 1 |
|:-------|:--|
| Slot B | 2 |
| Slot Z | 26 |
etc..

## Examples ##

Drop All Slot B

02 01 00