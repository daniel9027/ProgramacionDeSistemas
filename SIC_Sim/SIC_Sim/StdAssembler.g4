grammar StdAssembler;

linea	
		: inicio
		| proposiciones
		| fin
		;

programa  
		: inicio proposiciones fin 
		;

inicio
		: etiqueta? START DIR H NL
		; 

fin 
		: etiqueta? END etiqueta? NL?
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
		| WORD NUM									# DirWordInt
		| WORD HEXVAL H								# DirWordHex
		| RESB NUM									# DirResbInt
		| RESB HEXVAL H								# DirResbHex
		| RESW NUM									# DirReswInt
		| RESW HEXVAL H								# DirReswHex
		;

etiqueta 
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
DIR		: ([A-F0-9][A-F0-9][A-F0-9][A-F0-9]);
HEXVAL	: [A-F0-9]+;
NUM		: [0-9]+;
ASCIIVAL	: ([A-Z])+;