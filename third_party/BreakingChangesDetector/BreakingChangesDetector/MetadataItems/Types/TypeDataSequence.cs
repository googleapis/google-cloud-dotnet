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
#if DEBUG
	/// <summary>
	/// An ordered set of <see cref="TypeData"/> instances which can by compared or used as a key in a dictionary.
	/// </summary> 
#endif
	internal class TypeDataSequence :
		IEnumerable<TypeData>,
		IEquatable<TypeDataSequence>
	{
		private readonly TypeData[] _types;

		public TypeDataSequence(params TypeData[] types)
		{
			_types = types;
		}

		public TypeDataSequence(IEnumerable<TypeData> types)
			: this(types.ToArray()) { }

		public override bool Equals(object obj)
		{
			var other = obj as TypeDataSequence;
			return other != null && this.Equals(other);
		}

		public override int GetHashCode()
		{
			int hashCode = 0;
			for (int i = 0; i < _types.Length; i++)
				hashCode ^= (_types[i].GetHashCode() << (i % 16));

			return hashCode;
		}

		public override string ToString()
		{
			return string.Join<TypeData>(", ", _types);
		}

		public bool Equals(TypeDataSequence other)
		{
			if (_types.Length != other._types.Length)
				return false;

			for (int i = 0; i < _types.Length; i++)
			{
				if (_types[i] != other._types[i])
					return false;
			}

			return true;
		}

		public int Count
		{
			get { return _types.Length; }
		}

		public IEnumerator<TypeData> GetEnumerator()
		{
			return ((IEnumerable<TypeData>)_types).GetEnumerator();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return _types.GetEnumerator();
		}
	}
}
