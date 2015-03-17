# Pickup Item(s) #

---


## Details ##

Description of packet
  * Packet ID **`[0x07]`**
  * Uses Normal 5 Byte header
  * Is Encrypted

## Packet Breakdown ##
| Index | Datatype | Length | Function |
|:------|:---------|:-------|:---------|
| 1 | Bool | 1 | Pickup All true/false |
| 1 | Null Byte | 1 |  |

## Examples ##
Pickup

00 00

Pickup All

01 00