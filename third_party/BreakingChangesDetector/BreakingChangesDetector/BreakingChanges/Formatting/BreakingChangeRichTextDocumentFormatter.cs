/*
    MIT License

    Copyright(c) 2014-2018 Infragistics, Inc.

    Permission is hereby granted, free of charge, to any person obtaining a copy
    of this software and associated documentation files (the "Software"), to deal
    in the Software without restriction, including without limitation the rights
    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the Software is
    furnished to do so, subject to the following conditions:

    The above copyright notice and this permission notice shall be included in all
    copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
    SOFTWARE.
*/

using Infragistics.Documents.RichText;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingChangesDetector.BreakingChanges.Formatting
{
	/// <summary>
	/// A class capable of formatting breaking changes messages into a RichTextDocument.
	/// </summary>
	public class BreakingChangeRichTextDocumentFormatter : IBreakingChangeFormatter
	{
		#region Constants

		private const string ListId = "List";
		private const string ListStyleId = "Decimal";

		#endregion // Constants

		#region Member Variables

		private readonly CharacterSettings _defaultCharacterSettings;
		private readonly RichTextDocument _document;
		private readonly StringBuilder _runText;

		#endregion // Member Variables

		#region Constructor

		/// <summary>
		/// Creates a new <see cref="BreakingChangeRichTextDocumentFormatter"/> instance.
		/// </summary>
		public BreakingChangeRichTextDocumentFormatter()
		{
			_defaultCharacterSettings = new CharacterSettings { Bold = false, Italics = false };
			_document = new RichTextDocument();
			_runText = new StringBuilder();

			_document.RootNode.Styles.Add((RichTextStyleBase)_document.AvailableStyles[ListStyleId].Clone());
			_document.RootNode.Lists.Add(new RichTextList
			{
				Id = ListId,
				ListStyleId = ListStyleId,
			});

			this.AppendLine();
		}

		#endregion // Constructor

		#region Methods

		#region Public Methods

		#region AppendFormat

		/// <summary>
		/// Appends the text to the document using the specified format and formatting arguments.
		/// </summary>
		/// <param name="format">The format string used to append the text.</param>
		/// <param name="arguments">The arguments to use in the format string.</param>
		public void AppendFormat(string format, params FormatItem[] arguments)
		{
			_runText.Clear();

			for (int i = 0; i < format.Length; i++)
			{
				var c = format[i];

				switch (c)
				{
					case '{':
						{
							if (i < format.Length - 1 && format[i + 1] == '{')
							{
								_runText.Append('{');
								i++;
								continue;
							}

							var closeBraceIndex = format.IndexOf('}', i + 1);
							if (closeBraceIndex < 0)
								throw new FormatException("Invalid format string");

							var indexText = format.Substring(i + 1, closeBraceIndex - i - 1);
							int index;
							if (int.TryParse(indexText, out index) == false)
								throw new FormatException("Invalid format string");

							if (index < 0 || arguments.Length <= index)
								throw new FormatException("Format index out of range");

							this.AppendCurrentRunText();
							this.AppendFormatItem(arguments[index]);

							i = closeBraceIndex;
						}
						break;

					case '}':
						if (i < format.Length - 1 && format[i + 1] == '}')
						{
							_runText.Append('}');
							i++;
							continue;
						}

						throw new FormatException("Invalid format string");

					default:
						_runText.Append(c);
						break;
				}
			}

			this.AppendCurrentRunText();
		}

		#endregion // AppendFormat

		#region AppendLine

		/// <summary>
		/// Appends a new line to the formatted text.
		/// </summary>
		public void AppendLine()
		{
			_document.RootNode.Body.ChildNodes.Add(new ParagraphNode
			{
				Settings = new ParagraphSettings { ListId = ListId, ContextualSpacing = true }
			});
		}

		#endregion // AppendLine

		#region OnDocumentComplete

		/// <summary>
		/// Called when the full document has been created and can be finalized.
		/// </summary>
		public void OnDocumentComplete()
		{
			_document.RootNode.Body.ChildNodes.RemoveAt(_document.RootNode.Body.ChildNodes.Count - 1);
		}

		#endregion // OnDocumentComplete

		#endregion // Public Methods

		#region Private Methods

		#region AppendCurrentRunText

		private void AppendCurrentRunText()
		{
			if (_runText.Length == 0)
				return;

			string error;
			_document.AppendText(_runText.ToString(), out error, characterSettings: _defaultCharacterSettings);
			_runText.Clear();
		}

		#endregion // AppendCurrentRunText

		#region AppendFormatItem

		private void AppendFormatItem(FormatItem formatItem)
		{
			var characterSettings = new CharacterSettings
			{
				Bold = formatItem.Style.HasFlag(StyleFlags.Bold),
				Italics = formatItem.Style.HasFlag(StyleFlags.Italics),
			};

			string error;
			_document.AppendText(formatItem.Text, out error, characterSettings: characterSettings);
		}

		#endregion // AppendFormatItem

		#endregion // Private Methods

		#endregion // Methods

		#region Properties

		/// <summary>
		/// Gets the document created by the formatter.
		/// </summary>
		public RichTextDocument Document { get { return _document; } }

		#endregion // Properties
	}
}
