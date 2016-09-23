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
		: etiqueta? START VAL NL
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
		: BYTE CHAR APOSTROFE VAL APOSTROFE	# DirByteChar
		| BYTE HEX APOSTROFE VAL APOSTROFE	# DirByteHex
		| WORD VAL							# DirWord
		| RESB VAL							# DirResb
		| RESW VAL							# DirResw
		;

etiqueta 
		: VAL
		;

etiquetaFin 
		: VAL
		;

WS		:   ('\r' | '\t') -> skip;
NL		: '\n';
COMA	: ',';
CHAR	: 'C';
HEX		: 'X';
APOSTROFE	: '\'';
START	: 'START';
END		: 'END';
RSUB	: 'RSUB';
BYTE	: 'BYTE';
WORD	: 'WORD';
RESB	: 'RESB';
RESW	: 'RESW';
CODOP	: 'ADD' | 'AND' | 'COMP' | 'DIV' | 'J' | 'JEQ' | 'JGT' | 'JLT' | 'JSUB' | 'LDA' | 'LDCH' | 'LDL' | 'LDX' | 'MUL' | 'OR' | 'RD' | 'STA' | 'STCH' | 'STL' | 'STSW' | 'STX' | 'SUB' | 'TD' | 'TIX' | 'WD';
VAL	: ([\x00-\xFF])+('h' | 'H')?;