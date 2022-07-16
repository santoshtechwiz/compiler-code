//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\Poc and Personal\AntlrDraw\Draw.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="DrawParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public interface IDrawVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="DrawParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProg([NotNull] DrawParser.ProgContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>init</c>
	/// labeled alternative in <see cref="DrawParser.stm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInit([NotNull] DrawParser.InitContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>up</c>
	/// labeled alternative in <see cref="DrawParser.stm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUp([NotNull] DrawParser.UpContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>down</c>
	/// labeled alternative in <see cref="DrawParser.stm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDown([NotNull] DrawParser.DownContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>left</c>
	/// labeled alternative in <see cref="DrawParser.stm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLeft([NotNull] DrawParser.LeftContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>right</c>
	/// labeled alternative in <see cref="DrawParser.stm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRight([NotNull] DrawParser.RightContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>draw</c>
	/// labeled alternative in <see cref="DrawParser.stm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDraw([NotNull] DrawParser.DrawContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>display</c>
	/// labeled alternative in <see cref="DrawParser.stm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDisplay([NotNull] DrawParser.DisplayContext context);
}