# Chat Message #

---


## Details ##

Description of packet
  * Packet ID **`[0x14]`**
  * Uses Normal 5 Byte header
  * Is Encrypted

## Packet Breakdown ##
| Index | Datatype | Length | Function |
|:------|:---------|:-------|:---------|
| 1 | Byte | 1 | Message Type |
| 2 | Byte | 1 | Message Length |
| 3 | String | Variable | Message |
| 4 | Null Byte | 1 | Unknown |

### Message Type ###
Normal = 0
Shout = 1

## Examples ##
test
0 4 74 65 73 74 0

!TESTOLA
1 7 54 45 53 54 4f 4c 41 0