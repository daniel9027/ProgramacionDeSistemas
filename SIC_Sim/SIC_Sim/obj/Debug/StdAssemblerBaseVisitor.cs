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
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IStdAssemblerVisitor{Result}"/>,
/// which can be extended to create a visitor which only needs to handle a subset
/// of the available methods.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.3")]
[System.CLSCompliant(false)]
public partial class StdAssemblerBaseVisitor<Result> : AbstractParseTreeVisitor<Result>, IStdAssemblerVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by the <c>CodOp</c>
	/// labeled alternative in <see cref="StdAssemblerParser.instruccion"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCodOp([NotNull] StdAssemblerParser.CodOpContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>RSub</c>
	/// labeled alternative in <see cref="StdAssemblerParser.instruccion"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitRSub([NotNull] StdAssemblerParser.RSubContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>PropDir</c>
	/// labeled alternative in <see cref="StdAssemblerParser.proposicion"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPropDir([NotNull] StdAssemblerParser.PropDirContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>PropInstr</c>
	/// labeled alternative in <see cref="StdAssemblerParser.proposicion"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPropInstr([NotNull] StdAssemblerParser.PropInstrContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>DirByteChar</c>
	/// labeled alternative in <see cref="StdAssemblerParser.directiva"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDirByteChar([NotNull] StdAssemblerParser.DirByteCharContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>DirResw</c>
	/// labeled alternative in <see cref="StdAssemblerParser.directiva"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDirResw([NotNull] StdAssemblerParser.DirReswContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>DirByteHex</c>
	/// labeled alternative in <see cref="StdAssemblerParser.directiva"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDirByteHex([NotNull] StdAssemblerParser.DirByteHexContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>DirResb</c>
	/// labeled alternative in <see cref="StdAssemblerParser.directiva"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDirResb([NotNull] StdAssemblerParser.DirResbContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>DirWord</c>
	/// labeled alternative in <see cref="StdAssemblerParser.directiva"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDirWord([NotNull] StdAssemblerParser.DirWordContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="StdAssemblerParser.linea"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitLinea([NotNull] StdAssemblerParser.LineaContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="StdAssemblerParser.programa"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPrograma([NotNull] StdAssemblerParser.ProgramaContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="StdAssemblerParser.inicio"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitInicio([NotNull] StdAssemblerParser.InicioContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="StdAssemblerParser.fin"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFin([NotNull] StdAssemblerParser.FinContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="StdAssemblerParser.proposiciones"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitProposiciones([NotNull] StdAssemblerParser.ProposicionesContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="StdAssemblerParser.proposicion"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitProposicion([NotNull] StdAssemblerParser.ProposicionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="StdAssemblerParser.instruccion"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitInstruccion([NotNull] StdAssemblerParser.InstruccionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="StdAssemblerParser.directiva"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDirectiva([NotNull] StdAssemblerParser.DirectivaContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="StdAssemblerParser.etiqueta"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitEtiqueta([NotNull] StdAssemblerParser.EtiquetaContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="StdAssemblerParser.etiquetaFin"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitEtiquetaFin([NotNull] StdAssemblerParser.EtiquetaFinContext context) { return VisitChildren(context); }
}
} // namespace SIC_Sim
