# Send Character Details #

---


## Details ##

Description of packet
  * Packet ID **`[0x04]`**
  * Uses Normal 5 Byte header
  * Is Encrypted
  * Sent after the username and password has been sent and confirmation that it is valid is received.

## Packet Breakdown ##
| Index | Datatype | Length | Function |
|:------|:---------|:-------|:---------|
| 1 | Null Bytes | 1 | Unknown (always 0) |
| 2 | Byte | 1 | Face |
| 3 | Byte | 1 | Hair Style |
| 4 | Byte | 1 | Face Color |
| 5 | Byte | 1 | Hair Color |
| 6 | Bool | 1 | Gender |
| 7 | Byte | 1 | Totem Animal |
| 8 | Null Bytes | 2 | Unknown |

### Gender ###
| Male | 0 |
|:-----|:--|
| Female | 1 |

### Totem Animal ###
| Ju-Jak | 0 |
|:-------|:--|
| Baekho | 1 |
| Hyun Moo | 2 |
| Chung Ryong | 3 |


## Examples ##
Female Chung Ryong with last hair and face in list, light purple face and hair.

0 d3 3a 1d 1d 1 0 3 0 0