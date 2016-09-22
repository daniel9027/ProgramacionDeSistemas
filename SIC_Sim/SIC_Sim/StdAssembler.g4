grammar StdAssembler;

linea	
		: inicio
		| proposiciones
		| fin
		| NL
		;

programa  
		: inicio proposiciones fin 
		;

inicio
		: etiqueta? START HEXVAL H NL
		; 

fin 
		: END etiquetaFin? NL
		;

proposiciones
		: proposiciones proposicion
		| proposicion
		;

proposicion
		: etiqueta? instruccion NL	# PropInstr
		| etiqueta? directiva NL	# PropDir
		;

instruccion
		: CODOP etiqueta (COMA HEX)?	# CodOp
		| RSUB	# RSub 
		;

directiva
		: BYTE CHAR APOSTROFE ASCIIVAL APOSTROFE	# DirByteChar
		| BYTE HEX APOSTROFE HEXVAL APOSTROFE		# DirByteHex
		| WORD HEXVAL H								# DirWord
		| RESB HEXVAL H								# DirResb
		| RESW HEXVAL H								# DirResw
		;

etiqueta 
		: ASCIIVAL
		;

etiquetaFin 
		: ASCIIVAL
		;


WS		:   (' ' | '\r' | '\t') -> skip;
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
HEXVAL	: ([A-F0-9])+;
ASCIIVAL	: ([A-Z])+;