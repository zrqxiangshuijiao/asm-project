LDI R21, (1 << PE5)
	OUT DDRE,R21
	LDI R22,0xFF
	OUT DDRB,R22
hel:
	IN R20,PINE
	ANDI R20, (1 << PE4)
	CPI R20,0
	BRNE on
	LDI R17,0
	OUT PORTE,R17
	JMP hel
on:
	LDI R17, (1 << PE5)
	OUT PORTE,R17
	JMP hel


