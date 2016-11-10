//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\becarios\Documents\GitHub\ProgramacionDeSistemas\SIC_Sim\SIC_Sim\StdAssembler.g4 by ANTLR 4.5.3

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

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="StdAssemblerParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.3")]
[System.CLSCompliant(false)]
public interface IStdAssemblerVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by the <c>DirByteChar</c>
	/// labeled alternative in <see cref="StdAssemblerParser.directiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDirByteChar([NotNull] StdAssemblerParser.DirByteCharContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>DirWord</c>
	/// labeled alternative in <see cref="StdAssemblerParser.directiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDirWord([NotNull] StdAssemblerParser.DirWordContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>DirResw</c>
	/// labeled alternative in <see cref="StdAssemblerParser.directiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDirResw([NotNull] StdAssemblerParser.DirReswContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>DirByteHex</c>
	/// labeled alternative in <see cref="StdAssemblerParser.directiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDirByteHex([NotNull] StdAssemblerParser.DirByteHexContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>DirResb</c>
	/// labeled alternative in <see cref="StdAssemblerParser.directiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDirResb([NotNull] StdAssemblerParser.DirResbContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>PropDir</c>
	/// labeled alternative in <see cref="StdAssemblerParser.proposicion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPropDir([NotNull] StdAssemblerParser.PropDirContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>PropInstr</c>
	/// labeled alternative in <see cref="StdAssemblerParser.proposicion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPropInstr([NotNull] StdAssemblerParser.PropInstrContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>RSub</c>
	/// labeled alternative in <see cref="StdAssemblerParser.instruccion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRSub([NotNull] StdAssemblerParser.RSubContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>CodOp</c>
	/// labeled alternative in <see cref="StdAssemblerParser.instruccion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCodOp([NotNull] StdAssemblerParser.CodOpContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="StdAssemblerParser.linea"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLinea([NotNull] StdAssemblerParser.LineaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="StdAssemblerParser.programa"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrograma([NotNull] StdAssemblerParser.ProgramaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="StdAssemblerParser.inicio"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInicio([NotNull] StdAssemblerParser.InicioContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="StdAssemblerParser.fin"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFin([NotNull] StdAssemblerParser.FinContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="StdAssemblerParser.proposiciones"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProposiciones([NotNull] StdAssemblerParser.ProposicionesContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="StdAssemblerParser.proposicion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProposicion([NotNull] StdAssemblerParser.ProposicionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="StdAssemblerParser.instruccion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInstruccion([NotNull] StdAssemblerParser.InstruccionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="StdAssemblerParser.directiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDirectiva([NotNull] StdAssemblerParser.DirectivaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="StdAssemblerParser.etiqueta"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEtiqueta([NotNull] StdAssemblerParser.EtiquetaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="StdAssemblerParser.etiquetaFin"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEtiquetaFin([NotNull] StdAssemblerParser.EtiquetaFinContext context);
}
} // namespace SIC_Sim
