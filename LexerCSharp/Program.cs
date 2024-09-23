using System;

namespace LexerCSharp
{
    public class Lexer
    {
         string input;
         int Position;
         int ReadPosition;
         char CurrentChar;
        public Lexer(string Input)
        {
            input = Input;
            Position = 0;
            ReadPosition = 0;
            CurrentChar = '\0';
        }

        private void ReadChar()
        {
            while(ReadPosition != input.Length)
            {

            } 
        }

        static void Main(string[] args)
        {
        }
    }
}
