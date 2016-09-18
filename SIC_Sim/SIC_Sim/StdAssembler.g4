grammar StdAssembler;

programa  
		: inicio proposiciones fin 
		;

inicio
		: etiqueta? START DIR H NL
		; 

fin 
		: etiqueta? END etiqueta? NL
		;

proposiciones
		: proposiciones proposicion
		| proposicion
		;

proposicion
		: etiqueta? instruccion NL
		| etiqueta? directiva NL
		;

instruccion
		: CODOP etiqueta (COMA HEX)? 
		| RSUB
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

etiqueta 
		: ASCIIVAL
		;


WS     : [ \t\r]+ -> skip;
NL		: '\n';
COMA	: ',';
CHAR	: 'C';
HEX		: 'X';
H		: ('h' | 'H');
APOSTROFE	: '\'';
START	: 'START';
END		: 'END';
RSUB	: 'RSUB';
BYTE	: 'BYTE';
WORD	: 'WORD';
RESB	: 'RESB';
RESW	: 'RESW';
CODOP	: 'ADD' | 'AND' | 'COMP' | 'DIV' | 'J' | 'JEQ' | 'JGT' | 'JLT' | 'JSUB' | 'LDA' | 'LDCH' | 'LDL' | 'LDX' | 'MUL' | 'OR' | 'RD' | 'STA' | 'STCH' | 'STL' | 'STSW' | 'STX' | 'SUB' | 'TD' | 'TIX' | 'WD';
DIR		: [A-F0-9][A-F0-9][A-F0-9][A-F0-9];
HEXVAL	: [A-F0-9]+;
ASCIIVAL	: [A-F0-9]+;
NUM		: [0-9]+;
