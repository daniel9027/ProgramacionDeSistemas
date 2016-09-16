grammar StdAssembler;

programa  
		: inicio proposiciones fin 
		;

inicio
		: etiqueta? START DIR nl 
		; 

fin 
		: etiqueta? END etiqueta? nl
		;

propociciones
		: proposiciones proposicion
		| proposicion
		;

proposicion
		: etiqueta? instruccion 
		| etiqueta? directiva
		;

instruccion
		: CODOP DIR (COMA HEX)? nl
		;

directiva
		: BYTE CHAR APOSTROFE ASCIIVAL APOSTROFE
		| BYTE HEX APOSTROFE HEXVAL APOSTROFE
		| WORD NUM
		| WORD HEXVAL H
		| RESB NUM
		| RESB HEXVAL H
		| RESW NUM
		| RESW HEXVAL H
		;
