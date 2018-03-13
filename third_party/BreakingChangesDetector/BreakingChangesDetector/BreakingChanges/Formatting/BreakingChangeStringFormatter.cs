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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingChangesDetector.BreakingChanges.Formatting
{
	/// <summary>
	/// A class capable of formatting breaking changes messages into a string.
	/// </summary>
	public class BreakingChangeStringFormatter : IBreakingChangeFormatter
	{
		#region Constructor

		/// <summary>
		/// Creates a new <see cref="BreakingChangeStringFormatter"/> instance.
		/// </summary>
		public BreakingChangeStringFormatter()
		{
			this.Builder = new StringBuilder();
		}

		#endregion // Constructor

		#region Methods

		/// <summary>
		/// Appends the text to the document using the specified format and formatting arguments.
		/// </summary>
		/// <param name="text">The format string used to append the text.</param>
		/// <param name="arguments">The arguments to use in the format string.</param>
		public void AppendFormat(string text, params FormatItem[] arguments)
		{
			this.Builder.AppendFormat(text, arguments);
		}

		/// <summary>
		/// Appends a new line to the formatted text.
		/// </summary>
		public void AppendLine()
		{
			this.Builder.AppendLine();
		}

		#endregion // Methods

		#region Properties

		/// <summary>
		/// Gets the StringBuilder containing the currently formatted string.
		/// </summary>
		public StringBuilder Builder { get; private set; }

		#endregion // Properties
	}
}
