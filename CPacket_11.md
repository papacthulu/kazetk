# Change Direction #

---


## Details ##

Description of packet
  * Packet ID **`[0x11]`**
  * Uses Normal 5 Byte header
  * Is Encrypted

## Packet Breakdown ##
| Index | Datatype | Length | Function |
|:------|:---------|:-------|:---------|
| 1 | Byte | 1 | New direction being faced |
| 2 | Null Byte | 1 | Unknown |

### Direction ###
| Up | 0 |
|:---|:--|
| Right | 1 |
| Down | 2 |
| Left | 3 |

## Examples ##
Facing Down

> 02 00

Facing Right

> 01 00