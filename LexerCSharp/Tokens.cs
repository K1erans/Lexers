using System;
using System.Collections.Generic;

namespace LexerCSharp
{
       public enum TokenType
    {
        Illegal,
        EOF,
        Identifier,
        Int,
        Assign,
        Plus,
        Comma,
        Semicolon,
        LPAREN,
        RPAREN,
        LBRACE,
        RBRACE,
        Function,
        Let
    }
    public class Tokens
    {
        // creatng Token object to create further tokens with.
        public TokenType TypVariable { get; set; }
        public String LiteralVariable { get; set; }
        public Tokens(TokenType TokType, String Literal)
        {
            TypVariable = TokType;
            LiteralVariable = Literal;
        }
        List<Tokens> PossibleTokenTypes = new List<Tokens>();
        public void PossibleTokens()
        {
            // Adding Tokens that will be used often.
            PossibleTokenTypes.Add(new Tokens(TokenType.Illegal, "ILLEGAL"));
            PossibleTokenTypes.Add(new Tokens(TokenType.EOF, "EOF"));

            // Identifers and Literals
            PossibleTokenTypes.Add(new Tokens(TokenType.Identifier, "Ident"));
            PossibleTokenTypes.Add(new Tokens(TokenType.Int, "int"));

            // Operators
            PossibleTokenTypes.Add(new Tokens(TokenType.Assign, "="));
            PossibleTokenTypes.Add(new Tokens(TokenType.Plus, "+"));

            // Delimters
            PossibleTokenTypes.Add(new Tokens(TokenType.Comma, ","));
            PossibleTokenTypes.Add(new Tokens(TokenType.Semicolon, ";"));

            PossibleTokenTypes.Add(new Tokens(TokenType.LPAREN, "("));
            PossibleTokenTypes.Add(new Tokens(TokenType.RPAREN, ")"));
            PossibleTokenTypes.Add(new Tokens(TokenType.LBRACE, "{"));
            PossibleTokenTypes.Add(new Tokens(TokenType.RBRACE, "}"));


            // Keywords
            PossibleTokenTypes.Add(new Tokens(TokenType.Function, "fn"));
            PossibleTokenTypes.Add(new Tokens(TokenType.Let, "Let"));
        }
    }
}

