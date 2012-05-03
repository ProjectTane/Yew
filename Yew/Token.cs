using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Yew {

	public enum TokenType {
		Name,
		Number,
		String,
		Comment,
		Separator,
		Operator,
	}

	[DebuggerDisplay("{Value}")]
	public sealed class Token {
		public readonly TokenType Type;
		public readonly String Value;
		private Lexer _lexer;

		private Token _next = null;
		public Token Next {
			get {
				if (_lexer != null) {
					_next = _lexer.Next();
					_lexer = null;
				}
				return _next;
			}
		}

		public Token(TokenType type, string value, Lexer lex) {
			this.Type = type;
			this.Value = value;
			this._lexer = lex;
		}
	}

}
