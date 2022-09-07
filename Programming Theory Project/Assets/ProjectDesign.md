# Project Design
Theory practices mostly appear in debug log. User can slide the temperature then click on PLA or filament button to get more debug log messages.

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
### Overload with many forms
* StickToBed(string plate type)
* StickToBed(int bed temperature)mm

## Encapsulation  
* get cost
* get set bed temp with min max allowable
* get set nozzle temp with min max allowable
* get allowable bed plate type

## Abstraction
* PrintObject()
* RunOut()  

--- 
# Program Flow
1. Player hit "Generate" button to random fill in
    * bed type
    * filament length
    * physical requirement (Sturdy, UV proof, biodegradable)
    * color
2. Player look at various filament on rack, select the one appropriate filament and input nozzle and bed temperature
3. Player hit "Print" button
4. Print status displayed. Then "Success" or "Failure" is displayed.