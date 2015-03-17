# Whisper #

---


## Details ##

Description of packet
  * Packet ID **`[0x19]`**
  * Uses Normal 5 Byte header
  * Is Encrypted

## Packet Breakdown ##
| Index | Datatype | Length | Function |
|:------|:---------|:-------|:---------|
| 1 | Byte | 1 | Length of Character name |
| 2 | String | Variable | Character name in ASCII |
| 3 | Byte | Length of Message | Length of Message string |
| 4 | String | Variable | Message in ASCII |
| 5 | Null Byte | 1 |  |


## Examples ##

Testifer: TEST!

9 54 65 73 74 69 66 69 65 72 5 54 45 53 54 21 0