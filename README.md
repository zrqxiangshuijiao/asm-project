# AssemblerProject
Project in CAO1, 3rd Semester. Counter project is made for counting, detecting movement of people passing through certain way.
Project is made using Adeept Mega 2560 Arduino microcontroller.
## Problem statement
What can be done to detect movement of people passing through certain way?
## Design
![State machine](https://github.com/zrqxiangshuijiao/asm-project/blob/master/diagrams/diagram.png) 
  
There are 2 possible states for the program  
* LightOn - state where LED is on.
* LightOff - state where LED is off.

[//]: # (Description of state)
When there is movement in front of PIR Movement sensor program goes to LightOn state, after 3 seconds it goes back to LightOff state.
## Testing
PIR Movement sensor test and LED:
Purpose for the test is to test PIR Movement sensor and LED
Excepted result:
When there is movement in front of PIR Movement sensor the LED lights up.

![Test](https://github.com/zrqxiangshuijiao/asm-project/blob/master/diagrams/diagram2.png)


## Project diagram  

Things used:
* 6 Wires
* 1 PIR Movement sensor
* 1 Adeept mega 2560 microcontroller board
* 1 Breadboard
* 1 LEDs
* 1 220Ω resistors


[//]: # (Description of connections)
PIR Movement sensor is connected to 3 wires, one is connected to ground to microcontroller, one is connected to 5V power to microcontroller and the other wire is connected to pin 3. Pin 2 from microcontroller is connected to breadboard where is connection to the LEDs. The resistor is connected to negative leg of LEDs.
![Project diagram](https://github.com/zrqxiangshuijiao/asm-project/blob/master/diagrams/diagram2.png)  

