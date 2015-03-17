# Menu Navigation #

---


## Details ##

Description of packet
  * Packet ID **`[0x39]`**
  * Uses Normal 5 Byte header
  * Is Encrypted

## Packet Breakdown ##
| Index | Datatype | Length | Function |
|:------|:---------|:-------|:---------|

## Examples ##

Next
```
1 0 0 23 26 0 0 0 2 0 
1 0 0 23 4a 0 0 0 2 0
1 0 0 24 35 0 0 0 2 0
1 0 0 24 1f 0 0 0 2 0
1 0 0 24 1e 0 0 0 2 0
1 0 0 24 2c 0 0 0 2 0
```
Previous
```
1 0 0 23 26 0 0 0 0 0 
```
Close
```
1 0 0 23 26 0 0 0 1 0 
1 0 0 23 4a 0 0 0 1 0 
```
Ok (Item Selection)
```
1st
1 0 0 23 26 0 0 0 2 1 1 0
1 0 0 24 1e 0 0 0 2 1 1 0  
2nd
1 0 0 23 26 0 0 0 2 1 2 0 
1 0 0 24 35 0 0 0 2 1 2 0
1 0 0 24 1e 0 0 0 2 1 2 0
3rd
1 0 0 24 1e 0 0 0 2 1 3 0
```