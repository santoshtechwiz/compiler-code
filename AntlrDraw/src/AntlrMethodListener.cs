//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\Poc and Personal\AntlrDraw\AntlrMethod.g4 by ANTLR 4.8

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
/// <see cref="AntlrMethodParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public interface IAntlrMethodListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="AntlrMethodParser.eval"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEval([NotNull] AntlrMethodParser.EvalContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AntlrMethodParser.eval"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEval([NotNull] AntlrMethodParser.EvalContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AntlrMethodParser.additionExp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdditionExp([NotNull] AntlrMethodParser.AdditionExpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AntlrMethodParser.additionExp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdditionExp([NotNull] AntlrMethodParser.AdditionExpContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AntlrMethodParser.multiplyExp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiplyExp([NotNull] AntlrMethodParser.MultiplyExpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AntlrMethodParser.multiplyExp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiplyExp([NotNull] AntlrMethodParser.MultiplyExpContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AntlrMethodParser.atomExp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAtomExp([NotNull] AntlrMethodParser.AtomExpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AntlrMethodParser.atomExp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAtomExp([NotNull] AntlrMethodParser.AtomExpContext context);
}
