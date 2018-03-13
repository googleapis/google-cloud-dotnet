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

namespace Infragistics
{
	/// <summary>
	/// Represents the old name of a type which was renamed.
	/// </summary>
	[AttributeUsage(
		AttributeTargets.Class | AttributeTargets.Delegate | AttributeTargets.Interface | AttributeTargets.Struct | AttributeTargets.Enum,
		Inherited = false,
		AllowMultiple = false)]
	internal sealed class TypeRenamedAttribute : Attribute
	{
		private readonly string _oldName;

		/// <summary>
		/// Creates a new <see cref="TypeRenamedAttribute"/> instance.
		/// </summary>
		/// <param name="oldName">The case-sensitive fully qualified name of the old type.</param>
		public TypeRenamedAttribute(string oldName)
		{
			_oldName = oldName;
		}

		/// <summary>
		/// Gets the case-sensitive fully qualified name of the old type.
		/// </summary>
		public string OldName
		{
			get { return _oldName; }
		}
	}
}
