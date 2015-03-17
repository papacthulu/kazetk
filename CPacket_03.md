# Login #

---


## Details ##

Description of packet
  * Packet ID **`[0x03]`**
  * Uses Normal 5 Byte header
  * Is Encrypted

## Packet Breakdown ##
| Index | Datatype | Length | Function |
|:------|:---------|:-------|:---------|
| 1 | Byte | 1 | Length of Username string |
| 2 | String | variable | ASCII string with username |
| 3 | Byte | 1 | Length of Password string |
| 4 | String | variable | ASCII string with password |
| 5 | Unknown | 5 | Unknown |

## Examples ##
tester:test1

6 74 65 73 74 65 72 5 74 65 73 74 31 8a d2 ed 53 0