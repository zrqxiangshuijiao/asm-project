LDI R21, (1 << PE4)          ;set the register
	OUT DDRE,R21         ;set port E to output
	
hel:
	IN R20,PINE          ;set the register
	ANDI R20, (1 << PE5) ;do and
	CPI R20,0            ;compare R20 and 0
	BRNE on              ;if not,go to on
	LDI R17,0
	OUT PORTE,R17
	JMP hel
on:
	LDI R17, (1 << PE4)  ;set the register
	OUT PORTE,R17
	JMP hel



