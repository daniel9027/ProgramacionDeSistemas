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
	/// Visit a parse tree produced by the <c>Multiplication</c>
	/// labeled alternative in <see cref="StdAssemblerParser.multOrDiv"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitMultiplication([NotNull] StdAssemblerParser.MultiplicationContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Division</c>
	/// labeled alternative in <see cref="StdAssemblerParser.multOrDiv"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDivision([NotNull] StdAssemblerParser.DivisionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ToPow</c>
	/// labeled alternative in <see cref="StdAssemblerParser.multOrDiv"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitToPow([NotNull] StdAssemblerParser.ToPowContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ToSetVar</c>
	/// labeled alternative in <see cref="StdAssemblerParser.input"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitToSetVar([NotNull] StdAssemblerParser.ToSetVarContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Calculate</c>
	/// labeled alternative in <see cref="StdAssemblerParser.setVar"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCalculate([NotNull] StdAssemblerParser.CalculateContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>SetVariable</c>
	/// labeled alternative in <see cref="StdAssemblerParser.setVar"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSetVariable([NotNull] StdAssemblerParser.SetVariableContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ToMultOrDiv</c>
	/// labeled alternative in <see cref="StdAssemblerParser.plusOrMinus"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitToMultOrDiv([NotNull] StdAssemblerParser.ToMultOrDivContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Plus</c>
	/// labeled alternative in <see cref="StdAssemblerParser.plusOrMinus"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPlus([NotNull] StdAssemblerParser.PlusContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Minus</c>
	/// labeled alternative in <see cref="StdAssemblerParser.plusOrMinus"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitMinus([NotNull] StdAssemblerParser.MinusContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ChangeSign</c>
	/// labeled alternative in <see cref="StdAssemblerParser.unaryMinus"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitChangeSign([NotNull] StdAssemblerParser.ChangeSignContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ToAtom</c>
	/// labeled alternative in <see cref="StdAssemblerParser.unaryMinus"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitToAtom([NotNull] StdAssemblerParser.ToAtomContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Power</c>
	/// labeled alternative in <see cref="StdAssemblerParser.pow"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPower([NotNull] StdAssemblerParser.PowerContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ConstantPI</c>
	/// labeled alternative in <see cref="StdAssemblerParser.atom"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitConstantPI([NotNull] StdAssemblerParser.ConstantPIContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Variable</c>
	/// labeled alternative in <see cref="StdAssemblerParser.atom"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitVariable([NotNull] StdAssemblerParser.VariableContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Braces</c>
	/// labeled alternative in <see cref="StdAssemblerParser.atom"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitBraces([NotNull] StdAssemblerParser.BracesContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ConstantE</c>
	/// labeled alternative in <see cref="StdAssemblerParser.atom"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitConstantE([NotNull] StdAssemblerParser.ConstantEContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Double</c>
	/// labeled alternative in <see cref="StdAssemblerParser.atom"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDouble([NotNull] StdAssemblerParser.DoubleContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Int</c>
	/// labeled alternative in <see cref="StdAssemblerParser.atom"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitInt([NotNull] StdAssemblerParser.IntContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="StdAssemblerParser.prog"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitProg([NotNull] StdAssemblerParser.ProgContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="StdAssemblerParser.input"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitInput([NotNull] StdAssemblerParser.InputContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="StdAssemblerParser.setVar"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSetVar([NotNull] StdAssemblerParser.SetVarContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="StdAssemblerParser.plusOrMinus"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPlusOrMinus([NotNull] StdAssemblerParser.PlusOrMinusContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="StdAssemblerParser.multOrDiv"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitMultOrDiv([NotNull] StdAssemblerParser.MultOrDivContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="StdAssemblerParser.pow"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPow([NotNull] StdAssemblerParser.PowContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="StdAssemblerParser.unaryMinus"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitUnaryMinus([NotNull] StdAssemblerParser.UnaryMinusContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="StdAssemblerParser.atom"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAtom([NotNull] StdAssemblerParser.AtomContext context) { return VisitChildren(context); }
}
} // namespace SIC_Sim
