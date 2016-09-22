//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\MILAN\Documents\Visual Studio 2015\Projects\SIC_SimV2\SIC_Sim\StdAssembler.g4 by ANTLR 4.5.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace SIC_Sim {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System.Collections.Generic;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.3")]
[System.CLSCompliant(false)]
public partial class StdAssemblerParser : Parser {
	public const int
		WS=1, NL=2, COMA=3, CHAR=4, HEX=5, H=6, APOSTROFE=7, START=8, END=9, RSUB=10, 
		BYTE=11, WORD=12, RESB=13, RESW=14, CODOP=15, HEXVAL=16, ASCIIVAL=17;
	public const int
		RULE_linea = 0, RULE_programa = 1, RULE_inicio = 2, RULE_fin = 3, RULE_proposiciones = 4, 
		RULE_proposicion = 5, RULE_instruccion = 6, RULE_directiva = 7, RULE_etiqueta = 8, 
		RULE_etiquetaFin = 9;
	public static readonly string[] ruleNames = {
		"linea", "programa", "inicio", "fin", "proposiciones", "proposicion", 
		"instruccion", "directiva", "etiqueta", "etiquetaFin"
	};

	private static readonly string[] _LiteralNames = {
		null, null, "'\n'", "','", "'C'", "'X'", null, "'''", "'START'", "'END'", 
		"'RSUB'", "'BYTE'", "'WORD'", "'RESB'", "'RESW'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "WS", "NL", "COMA", "CHAR", "HEX", "H", "APOSTROFE", "START", "END", 
		"RSUB", "BYTE", "WORD", "RESB", "RESW", "CODOP", "HEXVAL", "ASCIIVAL"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "StdAssembler.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public StdAssemblerParser(ITokenStream input)
		: base(input)
	{
		_interp = new ParserATNSimulator(this,_ATN);
	}
	public partial class LineaContext : ParserRuleContext {
		public InicioContext inicio() {
			return GetRuleContext<InicioContext>(0);
		}
		public ProposicionesContext proposiciones() {
			return GetRuleContext<ProposicionesContext>(0);
		}
		public FinContext fin() {
			return GetRuleContext<FinContext>(0);
		}
		public ITerminalNode NL() { return GetToken(StdAssemblerParser.NL, 0); }
		public LineaContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_linea; } }
		public override void EnterRule(IParseTreeListener listener) {
			IStdAssemblerListener typedListener = listener as IStdAssemblerListener;
			if (typedListener != null) typedListener.EnterLinea(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IStdAssemblerListener typedListener = listener as IStdAssemblerListener;
			if (typedListener != null) typedListener.ExitLinea(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IStdAssemblerVisitor<TResult> typedVisitor = visitor as IStdAssemblerVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLinea(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public LineaContext linea() {
		LineaContext _localctx = new LineaContext(_ctx, State);
		EnterRule(_localctx, 0, RULE_linea);
		try {
			State = 24;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,0,_ctx) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 20; inicio();
				}
				break;

			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 21; proposiciones(0);
				}
				break;

			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 22; fin();
				}
				break;

			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 23; Match(NL);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ProgramaContext : ParserRuleContext {
		public InicioContext inicio() {
			return GetRuleContext<InicioContext>(0);
		}
		public ProposicionesContext proposiciones() {
			return GetRuleContext<ProposicionesContext>(0);
		}
		public FinContext fin() {
			return GetRuleContext<FinContext>(0);
		}
		public ProgramaContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_programa; } }
		public override void EnterRule(IParseTreeListener listener) {
			IStdAssemblerListener typedListener = listener as IStdAssemblerListener;
			if (typedListener != null) typedListener.EnterPrograma(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IStdAssemblerListener typedListener = listener as IStdAssemblerListener;
			if (typedListener != null) typedListener.ExitPrograma(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IStdAssemblerVisitor<TResult> typedVisitor = visitor as IStdAssemblerVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPrograma(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ProgramaContext programa() {
		ProgramaContext _localctx = new ProgramaContext(_ctx, State);
		EnterRule(_localctx, 2, RULE_programa);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 26; inicio();
			State = 27; proposiciones(0);
			State = 28; fin();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class InicioContext : ParserRuleContext {
		public ITerminalNode START() { return GetToken(StdAssemblerParser.START, 0); }
		public ITerminalNode HEXVAL() { return GetToken(StdAssemblerParser.HEXVAL, 0); }
		public ITerminalNode H() { return GetToken(StdAssemblerParser.H, 0); }
		public ITerminalNode NL() { return GetToken(StdAssemblerParser.NL, 0); }
		public EtiquetaContext etiqueta() {
			return GetRuleContext<EtiquetaContext>(0);
		}
		public InicioContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_inicio; } }
		public override void EnterRule(IParseTreeListener listener) {
			IStdAssemblerListener typedListener = listener as IStdAssemblerListener;
			if (typedListener != null) typedListener.EnterInicio(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IStdAssemblerListener typedListener = listener as IStdAssemblerListener;
			if (typedListener != null) typedListener.ExitInicio(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IStdAssemblerVisitor<TResult> typedVisitor = visitor as IStdAssemblerVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitInicio(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public InicioContext inicio() {
		InicioContext _localctx = new InicioContext(_ctx, State);
		EnterRule(_localctx, 4, RULE_inicio);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 31;
			_la = _input.La(1);
			if (_la==ASCIIVAL) {
				{
				State = 30; etiqueta();
				}
			}

			State = 33; Match(START);
			State = 34; Match(HEXVAL);
			State = 35; Match(H);
			State = 36; Match(NL);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class FinContext : ParserRuleContext {
		public ITerminalNode END() { return GetToken(StdAssemblerParser.END, 0); }
		public ITerminalNode NL() { return GetToken(StdAssemblerParser.NL, 0); }
		public EtiquetaFinContext etiquetaFin() {
			return GetRuleContext<EtiquetaFinContext>(0);
		}
		public FinContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_fin; } }
		public override void EnterRule(IParseTreeListener listener) {
			IStdAssemblerListener typedListener = listener as IStdAssemblerListener;
			if (typedListener != null) typedListener.EnterFin(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IStdAssemblerListener typedListener = listener as IStdAssemblerListener;
			if (typedListener != null) typedListener.ExitFin(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IStdAssemblerVisitor<TResult> typedVisitor = visitor as IStdAssemblerVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFin(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public FinContext fin() {
		FinContext _localctx = new FinContext(_ctx, State);
		EnterRule(_localctx, 6, RULE_fin);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 38; Match(END);
			State = 40;
			_la = _input.La(1);
			if (_la==ASCIIVAL) {
				{
				State = 39; etiquetaFin();
				}
			}

			State = 42; Match(NL);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ProposicionesContext : ParserRuleContext {
		public ProposicionesContext proposiciones() {
			return GetRuleContext<ProposicionesContext>(0);
		}
		public ProposicionContext proposicion() {
			return GetRuleContext<ProposicionContext>(0);
		}
		public ProposicionesContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_proposiciones; } }
		public override void EnterRule(IParseTreeListener listener) {
			IStdAssemblerListener typedListener = listener as IStdAssemblerListener;
			if (typedListener != null) typedListener.EnterProposiciones(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IStdAssemblerListener typedListener = listener as IStdAssemblerListener;
			if (typedListener != null) typedListener.ExitProposiciones(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IStdAssemblerVisitor<TResult> typedVisitor = visitor as IStdAssemblerVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitProposiciones(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ProposicionesContext proposiciones() {
		return proposiciones(0);
	}

	private ProposicionesContext proposiciones(int _p) {
		ParserRuleContext _parentctx = _ctx;
		int _parentState = State;
		ProposicionesContext _localctx = new ProposicionesContext(_ctx, _parentState);
		ProposicionesContext _prevctx = _localctx;
		int _startState = 8;
		EnterRecursionRule(_localctx, 8, RULE_proposiciones, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 45; proposicion();
			}
			_ctx.stop = _input.Lt(-1);
			State = 51;
			_errHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(_input,3,_ctx);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.InvalidAltNumber ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new ProposicionesContext(_parentctx, _parentState);
					PushNewRecursionContext(_localctx, _startState, RULE_proposiciones);
					State = 47;
					if (!(Precpred(_ctx, 2))) throw new FailedPredicateException(this, "Precpred(_ctx, 2)");
					State = 48; proposicion();
					}
					} 
				}
				State = 53;
				_errHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(_input,3,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public partial class ProposicionContext : ParserRuleContext {
		public ProposicionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_proposicion; } }
	 
		public ProposicionContext() { }
		public virtual void CopyFrom(ProposicionContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class PropDirContext : ProposicionContext {
		public DirectivaContext directiva() {
			return GetRuleContext<DirectivaContext>(0);
		}
		public ITerminalNode NL() { return GetToken(StdAssemblerParser.NL, 0); }
		public EtiquetaContext etiqueta() {
			return GetRuleContext<EtiquetaContext>(0);
		}
		public PropDirContext(ProposicionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IStdAssemblerListener typedListener = listener as IStdAssemblerListener;
			if (typedListener != null) typedListener.EnterPropDir(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IStdAssemblerListener typedListener = listener as IStdAssemblerListener;
			if (typedListener != null) typedListener.ExitPropDir(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IStdAssemblerVisitor<TResult> typedVisitor = visitor as IStdAssemblerVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPropDir(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class PropInstrContext : ProposicionContext {
		public InstruccionContext instruccion() {
			return GetRuleContext<InstruccionContext>(0);
		}
		public ITerminalNode NL() { return GetToken(StdAssemblerParser.NL, 0); }
		public EtiquetaContext etiqueta() {
			return GetRuleContext<EtiquetaContext>(0);
		}
		public PropInstrContext(ProposicionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IStdAssemblerListener typedListener = listener as IStdAssemblerListener;
			if (typedListener != null) typedListener.EnterPropInstr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IStdAssemblerListener typedListener = listener as IStdAssemblerListener;
			if (typedListener != null) typedListener.ExitPropInstr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IStdAssemblerVisitor<TResult> typedVisitor = visitor as IStdAssemblerVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPropInstr(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ProposicionContext proposicion() {
		ProposicionContext _localctx = new ProposicionContext(_ctx, State);
		EnterRule(_localctx, 10, RULE_proposicion);
		int _la;
		try {
			State = 66;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,6,_ctx) ) {
			case 1:
				_localctx = new PropInstrContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 55;
				_la = _input.La(1);
				if (_la==ASCIIVAL) {
					{
					State = 54; etiqueta();
					}
				}

				State = 57; instruccion();
				State = 58; Match(NL);
				}
				break;

			case 2:
				_localctx = new PropDirContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 61;
				_la = _input.La(1);
				if (_la==ASCIIVAL) {
					{
					State = 60; etiqueta();
					}
				}

				State = 63; directiva();
				State = 64; Match(NL);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class InstruccionContext : ParserRuleContext {
		public InstruccionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_instruccion; } }
	 
		public InstruccionContext() { }
		public virtual void CopyFrom(InstruccionContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class CodOpContext : InstruccionContext {
		public ITerminalNode CODOP() { return GetToken(StdAssemblerParser.CODOP, 0); }
		public EtiquetaContext etiqueta() {
			return GetRuleContext<EtiquetaContext>(0);
		}
		public ITerminalNode COMA() { return GetToken(StdAssemblerParser.COMA, 0); }
		public ITerminalNode HEX() { return GetToken(StdAssemblerParser.HEX, 0); }
		public CodOpContext(InstruccionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IStdAssemblerListener typedListener = listener as IStdAssemblerListener;
			if (typedListener != null) typedListener.EnterCodOp(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IStdAssemblerListener typedListener = listener as IStdAssemblerListener;
			if (typedListener != null) typedListener.ExitCodOp(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IStdAssemblerVisitor<TResult> typedVisitor = visitor as IStdAssemblerVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitCodOp(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class RSubContext : InstruccionContext {
		public ITerminalNode RSUB() { return GetToken(StdAssemblerParser.RSUB, 0); }
		public RSubContext(InstruccionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IStdAssemblerListener typedListener = listener as IStdAssemblerListener;
			if (typedListener != null) typedListener.EnterRSub(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IStdAssemblerListener typedListener = listener as IStdAssemblerListener;
			if (typedListener != null) typedListener.ExitRSub(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IStdAssemblerVisitor<TResult> typedVisitor = visitor as IStdAssemblerVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitRSub(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public InstruccionContext instruccion() {
		InstruccionContext _localctx = new InstruccionContext(_ctx, State);
		EnterRule(_localctx, 12, RULE_instruccion);
		int _la;
		try {
			State = 75;
			switch (_input.La(1)) {
			case CODOP:
				_localctx = new CodOpContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 68; Match(CODOP);
				State = 69; etiqueta();
				State = 72;
				_la = _input.La(1);
				if (_la==COMA) {
					{
					State = 70; Match(COMA);
					State = 71; Match(HEX);
					}
				}

				}
				break;
			case RSUB:
				_localctx = new RSubContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 74; Match(RSUB);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DirectivaContext : ParserRuleContext {
		public DirectivaContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_directiva; } }
	 
		public DirectivaContext() { }
		public virtual void CopyFrom(DirectivaContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class DirByteCharContext : DirectivaContext {
		public ITerminalNode BYTE() { return GetToken(StdAssemblerParser.BYTE, 0); }
		public ITerminalNode CHAR() { return GetToken(StdAssemblerParser.CHAR, 0); }
		public ITerminalNode[] APOSTROFE() { return GetTokens(StdAssemblerParser.APOSTROFE); }
		public ITerminalNode APOSTROFE(int i) {
			return GetToken(StdAssemblerParser.APOSTROFE, i);
		}
		public ITerminalNode ASCIIVAL() { return GetToken(StdAssemblerParser.ASCIIVAL, 0); }
		public DirByteCharContext(DirectivaContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IStdAssemblerListener typedListener = listener as IStdAssemblerListener;
			if (typedListener != null) typedListener.EnterDirByteChar(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IStdAssemblerListener typedListener = listener as IStdAssemblerListener;
			if (typedListener != null) typedListener.ExitDirByteChar(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IStdAssemblerVisitor<TResult> typedVisitor = visitor as IStdAssemblerVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDirByteChar(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class DirReswContext : DirectivaContext {
		public ITerminalNode RESW() { return GetToken(StdAssemblerParser.RESW, 0); }
		public ITerminalNode HEXVAL() { return GetToken(StdAssemblerParser.HEXVAL, 0); }
		public ITerminalNode H() { return GetToken(StdAssemblerParser.H, 0); }
		public DirReswContext(DirectivaContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IStdAssemblerListener typedListener = listener as IStdAssemblerListener;
			if (typedListener != null) typedListener.EnterDirResw(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IStdAssemblerListener typedListener = listener as IStdAssemblerListener;
			if (typedListener != null) typedListener.ExitDirResw(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IStdAssemblerVisitor<TResult> typedVisitor = visitor as IStdAssemblerVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDirResw(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class DirByteHexContext : DirectivaContext {
		public ITerminalNode BYTE() { return GetToken(StdAssemblerParser.BYTE, 0); }
		public ITerminalNode HEX() { return GetToken(StdAssemblerParser.HEX, 0); }
		public ITerminalNode[] APOSTROFE() { return GetTokens(StdAssemblerParser.APOSTROFE); }
		public ITerminalNode APOSTROFE(int i) {
			return GetToken(StdAssemblerParser.APOSTROFE, i);
		}
		public ITerminalNode HEXVAL() { return GetToken(StdAssemblerParser.HEXVAL, 0); }
		public DirByteHexContext(DirectivaContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IStdAssemblerListener typedListener = listener as IStdAssemblerListener;
			if (typedListener != null) typedListener.EnterDirByteHex(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IStdAssemblerListener typedListener = listener as IStdAssemblerListener;
			if (typedListener != null) typedListener.ExitDirByteHex(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IStdAssemblerVisitor<TResult> typedVisitor = visitor as IStdAssemblerVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDirByteHex(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class DirResbContext : DirectivaContext {
		public ITerminalNode RESB() { return GetToken(StdAssemblerParser.RESB, 0); }
		public ITerminalNode HEXVAL() { return GetToken(StdAssemblerParser.HEXVAL, 0); }
		public ITerminalNode H() { return GetToken(StdAssemblerParser.H, 0); }
		public DirResbContext(DirectivaContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IStdAssemblerListener typedListener = listener as IStdAssemblerListener;
			if (typedListener != null) typedListener.EnterDirResb(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IStdAssemblerListener typedListener = listener as IStdAssemblerListener;
			if (typedListener != null) typedListener.ExitDirResb(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IStdAssemblerVisitor<TResult> typedVisitor = visitor as IStdAssemblerVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDirResb(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class DirWordContext : DirectivaContext {
		public ITerminalNode WORD() { return GetToken(StdAssemblerParser.WORD, 0); }
		public ITerminalNode HEXVAL() { return GetToken(StdAssemblerParser.HEXVAL, 0); }
		public ITerminalNode H() { return GetToken(StdAssemblerParser.H, 0); }
		public DirWordContext(DirectivaContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IStdAssemblerListener typedListener = listener as IStdAssemblerListener;
			if (typedListener != null) typedListener.EnterDirWord(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IStdAssemblerListener typedListener = listener as IStdAssemblerListener;
			if (typedListener != null) typedListener.ExitDirWord(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IStdAssemblerVisitor<TResult> typedVisitor = visitor as IStdAssemblerVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDirWord(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public DirectivaContext directiva() {
		DirectivaContext _localctx = new DirectivaContext(_ctx, State);
		EnterRule(_localctx, 14, RULE_directiva);
		try {
			State = 96;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,9,_ctx) ) {
			case 1:
				_localctx = new DirByteCharContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 77; Match(BYTE);
				State = 78; Match(CHAR);
				State = 79; Match(APOSTROFE);
				State = 80; Match(ASCIIVAL);
				State = 81; Match(APOSTROFE);
				}
				break;

			case 2:
				_localctx = new DirByteHexContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 82; Match(BYTE);
				State = 83; Match(HEX);
				State = 84; Match(APOSTROFE);
				State = 85; Match(HEXVAL);
				State = 86; Match(APOSTROFE);
				}
				break;

			case 3:
				_localctx = new DirWordContext(_localctx);
				EnterOuterAlt(_localctx, 3);
				{
				State = 87; Match(WORD);
				State = 88; Match(HEXVAL);
				State = 89; Match(H);
				}
				break;

			case 4:
				_localctx = new DirResbContext(_localctx);
				EnterOuterAlt(_localctx, 4);
				{
				State = 90; Match(RESB);
				State = 91; Match(HEXVAL);
				State = 92; Match(H);
				}
				break;

			case 5:
				_localctx = new DirReswContext(_localctx);
				EnterOuterAlt(_localctx, 5);
				{
				State = 93; Match(RESW);
				State = 94; Match(HEXVAL);
				State = 95; Match(H);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class EtiquetaContext : ParserRuleContext {
		public ITerminalNode ASCIIVAL() { return GetToken(StdAssemblerParser.ASCIIVAL, 0); }
		public EtiquetaContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_etiqueta; } }
		public override void EnterRule(IParseTreeListener listener) {
			IStdAssemblerListener typedListener = listener as IStdAssemblerListener;
			if (typedListener != null) typedListener.EnterEtiqueta(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IStdAssemblerListener typedListener = listener as IStdAssemblerListener;
			if (typedListener != null) typedListener.ExitEtiqueta(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IStdAssemblerVisitor<TResult> typedVisitor = visitor as IStdAssemblerVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitEtiqueta(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public EtiquetaContext etiqueta() {
		EtiquetaContext _localctx = new EtiquetaContext(_ctx, State);
		EnterRule(_localctx, 16, RULE_etiqueta);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 98; Match(ASCIIVAL);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class EtiquetaFinContext : ParserRuleContext {
		public ITerminalNode ASCIIVAL() { return GetToken(StdAssemblerParser.ASCIIVAL, 0); }
		public EtiquetaFinContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_etiquetaFin; } }
		public override void EnterRule(IParseTreeListener listener) {
			IStdAssemblerListener typedListener = listener as IStdAssemblerListener;
			if (typedListener != null) typedListener.EnterEtiquetaFin(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IStdAssemblerListener typedListener = listener as IStdAssemblerListener;
			if (typedListener != null) typedListener.ExitEtiquetaFin(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IStdAssemblerVisitor<TResult> typedVisitor = visitor as IStdAssemblerVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitEtiquetaFin(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public EtiquetaFinContext etiquetaFin() {
		EtiquetaFinContext _localctx = new EtiquetaFinContext(_ctx, State);
		EnterRule(_localctx, 18, RULE_etiquetaFin);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 100; Match(ASCIIVAL);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 4: return proposiciones_sempred((ProposicionesContext)_localctx, predIndex);
		}
		return true;
	}
	private bool proposiciones_sempred(ProposicionesContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(_ctx, 2);
		}
		return true;
	}

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x3\x13i\x4\x2\t\x2"+
		"\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4\t\t"+
		"\t\x4\n\t\n\x4\v\t\v\x3\x2\x3\x2\x3\x2\x3\x2\x5\x2\x1B\n\x2\x3\x3\x3\x3"+
		"\x3\x3\x3\x3\x3\x4\x5\x4\"\n\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x5\x3"+
		"\x5\x5\x5+\n\x5\x3\x5\x3\x5\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\a\x6\x34\n\x6"+
		"\f\x6\xE\x6\x37\v\x6\x3\a\x5\a:\n\a\x3\a\x3\a\x3\a\x3\a\x5\a@\n\a\x3\a"+
		"\x3\a\x3\a\x5\a\x45\n\a\x3\b\x3\b\x3\b\x3\b\x5\bK\n\b\x3\b\x5\bN\n\b\x3"+
		"\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3"+
		"\t\x3\t\x3\t\x3\t\x3\t\x5\t\x63\n\t\x3\n\x3\n\x3\v\x3\v\x3\v\x2\x2\x3"+
		"\n\f\x2\x2\x4\x2\x6\x2\b\x2\n\x2\f\x2\xE\x2\x10\x2\x12\x2\x14\x2\x2\x2"+
		"m\x2\x1A\x3\x2\x2\x2\x4\x1C\x3\x2\x2\x2\x6!\x3\x2\x2\x2\b(\x3\x2\x2\x2"+
		"\n.\x3\x2\x2\x2\f\x44\x3\x2\x2\x2\xEM\x3\x2\x2\x2\x10\x62\x3\x2\x2\x2"+
		"\x12\x64\x3\x2\x2\x2\x14\x66\x3\x2\x2\x2\x16\x1B\x5\x6\x4\x2\x17\x1B\x5"+
		"\n\x6\x2\x18\x1B\x5\b\x5\x2\x19\x1B\a\x4\x2\x2\x1A\x16\x3\x2\x2\x2\x1A"+
		"\x17\x3\x2\x2\x2\x1A\x18\x3\x2\x2\x2\x1A\x19\x3\x2\x2\x2\x1B\x3\x3\x2"+
		"\x2\x2\x1C\x1D\x5\x6\x4\x2\x1D\x1E\x5\n\x6\x2\x1E\x1F\x5\b\x5\x2\x1F\x5"+
		"\x3\x2\x2\x2 \"\x5\x12\n\x2! \x3\x2\x2\x2!\"\x3\x2\x2\x2\"#\x3\x2\x2\x2"+
		"#$\a\n\x2\x2$%\a\x12\x2\x2%&\a\b\x2\x2&\'\a\x4\x2\x2\'\a\x3\x2\x2\x2("+
		"*\a\v\x2\x2)+\x5\x14\v\x2*)\x3\x2\x2\x2*+\x3\x2\x2\x2+,\x3\x2\x2\x2,-"+
		"\a\x4\x2\x2-\t\x3\x2\x2\x2./\b\x6\x1\x2/\x30\x5\f\a\x2\x30\x35\x3\x2\x2"+
		"\x2\x31\x32\f\x4\x2\x2\x32\x34\x5\f\a\x2\x33\x31\x3\x2\x2\x2\x34\x37\x3"+
		"\x2\x2\x2\x35\x33\x3\x2\x2\x2\x35\x36\x3\x2\x2\x2\x36\v\x3\x2\x2\x2\x37"+
		"\x35\x3\x2\x2\x2\x38:\x5\x12\n\x2\x39\x38\x3\x2\x2\x2\x39:\x3\x2\x2\x2"+
		":;\x3\x2\x2\x2;<\x5\xE\b\x2<=\a\x4\x2\x2=\x45\x3\x2\x2\x2>@\x5\x12\n\x2"+
		"?>\x3\x2\x2\x2?@\x3\x2\x2\x2@\x41\x3\x2\x2\x2\x41\x42\x5\x10\t\x2\x42"+
		"\x43\a\x4\x2\x2\x43\x45\x3\x2\x2\x2\x44\x39\x3\x2\x2\x2\x44?\x3\x2\x2"+
		"\x2\x45\r\x3\x2\x2\x2\x46G\a\x11\x2\x2GJ\x5\x12\n\x2HI\a\x5\x2\x2IK\a"+
		"\a\x2\x2JH\x3\x2\x2\x2JK\x3\x2\x2\x2KN\x3\x2\x2\x2LN\a\f\x2\x2M\x46\x3"+
		"\x2\x2\x2ML\x3\x2\x2\x2N\xF\x3\x2\x2\x2OP\a\r\x2\x2PQ\a\x6\x2\x2QR\a\t"+
		"\x2\x2RS\a\x13\x2\x2S\x63\a\t\x2\x2TU\a\r\x2\x2UV\a\a\x2\x2VW\a\t\x2\x2"+
		"WX\a\x12\x2\x2X\x63\a\t\x2\x2YZ\a\xE\x2\x2Z[\a\x12\x2\x2[\x63\a\b\x2\x2"+
		"\\]\a\xF\x2\x2]^\a\x12\x2\x2^\x63\a\b\x2\x2_`\a\x10\x2\x2`\x61\a\x12\x2"+
		"\x2\x61\x63\a\b\x2\x2\x62O\x3\x2\x2\x2\x62T\x3\x2\x2\x2\x62Y\x3\x2\x2"+
		"\x2\x62\\\x3\x2\x2\x2\x62_\x3\x2\x2\x2\x63\x11\x3\x2\x2\x2\x64\x65\a\x13"+
		"\x2\x2\x65\x13\x3\x2\x2\x2\x66g\a\x13\x2\x2g\x15\x3\x2\x2\x2\f\x1A!*\x35"+
		"\x39?\x44JM\x62";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace SIC_Sim