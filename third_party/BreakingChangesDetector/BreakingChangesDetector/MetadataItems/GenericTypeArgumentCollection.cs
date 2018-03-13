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

namespace BreakingChangesDetector.MetadataItems
{
	/// <summary>
	/// A collection of <see cref="TypeData"/> instances used as generic type arguments in a constructed generic type.
	/// </summary>
	public class GenericTypeArgumentCollection : IEnumerable<TypeData>
	{
		private readonly TypeData[] _arguments;

		internal GenericTypeArgumentCollection(IEnumerable<TypeData> types)
		{
			_arguments = types.ToArray();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return _arguments.GetEnumerator();
		}

		/// <summary>
		/// Gets an enumerator capable of iterating the generic type arguments.
		/// </summary>
		public IEnumerator<TypeData> GetEnumerator()
		{
			for (int i = 0; i < _arguments.Length; i++)
				yield return _arguments[i];
		}

		/// <summary>
		/// Gets the number of generic type arguments in the collection.
		/// </summary>
		public int Count
		{
			get { return _arguments.Length; }
		}

		/// <summary>
		/// Gets the generic type argument at the specified index in the collection.
		/// </summary>
		public TypeData this[int index]
		{
			get { return _arguments[index]; }
		}

		internal bool DoesMatch(GenericTypeArgumentCollection other)
		{
			if (this.Count != other.Count)
				return false;

			for (int i = 0; i < this.Count; i++)
			{
				if (this[i].DoesMatch(other[i]) == false)
					return false;
			}

			return true;
		}

		internal string GetGenericArgumentListDisplayText(bool includeGenericInfo, int start, int length)
		{
			if (length == 0)
				return string.Empty;

			var sb = new StringBuilder("<");
			sb.Append(this[start].GetDisplayName(fullyQualify: false, includeGenericInfo: includeGenericInfo));
			for (int i = start + 1; i < start + length; i++)
			{
				sb.Append(", ");
				sb.Append(this[i].GetDisplayName(fullyQualify: false, includeGenericInfo: includeGenericInfo));
			}

			sb.Append(">");
			return sb.ToString();
		}
	}
}
