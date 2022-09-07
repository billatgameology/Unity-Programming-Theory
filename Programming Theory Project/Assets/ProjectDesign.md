# Project Design
Text based library of 3D printing material. Player is given an object that is needed to be printed with specification. Player then browse through the material library and select a material to use. Based on the selection, the project may pass or fail based on the material selected.

## Inheritance
Filament Properties:  
  * diameter
  * cost
  * nozzle temp
  * bed temp
  * color

Filament -> PLA  
Filament -> PETG  
Filament -> ASA  
Filament -> Soluable  

## Polymorphy
### same function different capability
* Melt()
* String()  
### Overload with many forms
* StickToBed(string plate type)
* StickToBed(int bed temperature)

## Abstraction


## Encapsulation