# Check Valid Login #

---


## Details ##

Description of packet
  * Packet ID **`[0x02]`**
  * Uses Normal 5 Byte header
  * Is Encrypted
  * Is sent before sending the rest of the character data during character creation. If username and password check out, proceeds to send the rest (0x04)

## Packet Breakdown ##
| Index | Datatype | Length | Name |
|:------|:---------|:-------|:-----|
| 1 | Byte | 1 | Username Length |
| 2 | string | variable | Username |
| 3 | Byte | 1 | Password Length |
| 4 | string | variable | Password |
| 5 | null | 3 | Null or Unknown (delimiter) |

## Examples ##
testertest1

6 74 65 73 74 65 72 5 74 65 73 74 31 0 0 0