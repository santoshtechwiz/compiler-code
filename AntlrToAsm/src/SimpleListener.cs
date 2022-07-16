//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\Poc and Personal\AntlrToAsm\Simple.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="SimpleParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public interface ISimpleListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProg([NotNull] SimpleParser.ProgContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProg([NotNull] SimpleParser.ProgContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>assign</c>
	/// labeled alternative in <see cref="SimpleParser.stm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssign([NotNull] SimpleParser.AssignContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>assign</c>
	/// labeled alternative in <see cref="SimpleParser.stm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssign([NotNull] SimpleParser.AssignContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>print</c>
	/// labeled alternative in <see cref="SimpleParser.stm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrint([NotNull] SimpleParser.PrintContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>print</c>
	/// labeled alternative in <see cref="SimpleParser.stm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrint([NotNull] SimpleParser.PrintContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ifthen</c>
	/// labeled alternative in <see cref="SimpleParser.stm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfthen([NotNull] SimpleParser.IfthenContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ifthen</c>
	/// labeled alternative in <see cref="SimpleParser.stm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfthen([NotNull] SimpleParser.IfthenContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>whiledo</c>
	/// labeled alternative in <see cref="SimpleParser.stm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhiledo([NotNull] SimpleParser.WhiledoContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>whiledo</c>
	/// labeled alternative in <see cref="SimpleParser.stm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhiledo([NotNull] SimpleParser.WhiledoContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>beginend</c>
	/// labeled alternative in <see cref="SimpleParser.stm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBeginend([NotNull] SimpleParser.BeginendContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>beginend</c>
	/// labeled alternative in <see cref="SimpleParser.stm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBeginend([NotNull] SimpleParser.BeginendContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.opt_stmts"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_stmts([NotNull] SimpleParser.Opt_stmtsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.opt_stmts"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_stmts([NotNull] SimpleParser.Opt_stmtsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.stmt_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStmt_list([NotNull] SimpleParser.Stmt_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.stmt_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStmt_list([NotNull] SimpleParser.Stmt_listContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>div</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDiv([NotNull] SimpleParser.DivContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>div</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDiv([NotNull] SimpleParser.DivContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>add</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdd([NotNull] SimpleParser.AddContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>add</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdd([NotNull] SimpleParser.AddContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>sub</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSub([NotNull] SimpleParser.SubContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>sub</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSub([NotNull] SimpleParser.SubContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>parens</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParens([NotNull] SimpleParser.ParensContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>parens</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParens([NotNull] SimpleParser.ParensContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>mod</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMod([NotNull] SimpleParser.ModContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>mod</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMod([NotNull] SimpleParser.ModContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>mul</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMul([NotNull] SimpleParser.MulContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>mul</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMul([NotNull] SimpleParser.MulContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>id</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterId([NotNull] SimpleParser.IdContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>id</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitId([NotNull] SimpleParser.IdContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>int</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInt([NotNull] SimpleParser.IntContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>int</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInt([NotNull] SimpleParser.IntContext context);
}