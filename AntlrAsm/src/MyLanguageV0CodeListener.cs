//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\Poc and Personal\AntlrAsm\MyLanguageV0Code.g4 by ANTLR 4.8

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
/// <see cref="MyLanguageV0CodeParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public interface IMyLanguageV0CodeListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="MyLanguageV0CodeParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProgram([NotNull] MyLanguageV0CodeParser.ProgramContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyLanguageV0CodeParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProgram([NotNull] MyLanguageV0CodeParser.ProgramContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MyLanguageV0CodeParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclaration([NotNull] MyLanguageV0CodeParser.DeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyLanguageV0CodeParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclaration([NotNull] MyLanguageV0CodeParser.DeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MyLanguageV0CodeParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] MyLanguageV0CodeParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyLanguageV0CodeParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] MyLanguageV0CodeParser.StatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MyLanguageV0CodeParser.ifstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfstmt([NotNull] MyLanguageV0CodeParser.IfstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyLanguageV0CodeParser.ifstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfstmt([NotNull] MyLanguageV0CodeParser.IfstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MyLanguageV0CodeParser.printstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrintstmt([NotNull] MyLanguageV0CodeParser.PrintstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyLanguageV0CodeParser.printstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrintstmt([NotNull] MyLanguageV0CodeParser.PrintstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MyLanguageV0CodeParser.assignstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignstmt([NotNull] MyLanguageV0CodeParser.AssignstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyLanguageV0CodeParser.assignstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignstmt([NotNull] MyLanguageV0CodeParser.AssignstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MyLanguageV0CodeParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] MyLanguageV0CodeParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyLanguageV0CodeParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] MyLanguageV0CodeParser.ExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MyLanguageV0CodeParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTerm([NotNull] MyLanguageV0CodeParser.TermContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyLanguageV0CodeParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTerm([NotNull] MyLanguageV0CodeParser.TermContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MyLanguageV0CodeParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifier([NotNull] MyLanguageV0CodeParser.IdentifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyLanguageV0CodeParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifier([NotNull] MyLanguageV0CodeParser.IdentifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MyLanguageV0CodeParser.integer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInteger([NotNull] MyLanguageV0CodeParser.IntegerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyLanguageV0CodeParser.integer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInteger([NotNull] MyLanguageV0CodeParser.IntegerContext context);
}
