using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Yew {
	public class Lexer {
		private readonly TextReader _reader;

		public static Token Lex(TextReader reader) {
			var lex = new Lexer(reader);
			return lex.Next();
		}

		private Lexer(TextReader reader) {
			_reader = reader;
		}

		public Token Next() {
			return null;
		}
	}

}
