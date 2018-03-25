/*
    MIT License

    Copyright(c) 2014-2018 Infragistics, Inc.
    Copyright 2018 Google LLC

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

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BreakingChangesDetector.MetadataItems
{
    /// <summary>
    /// A collection of <see cref="GenericTypeParameterData"/> instances used as generic type parameters in a generic type definition.
    /// </summary>
    public sealed class GenericTypeParameterCollection : IEnumerable<GenericTypeParameterData>
    {
        private readonly GenericTypeParameterData[] _parameters;

        internal GenericTypeParameterCollection(IEnumerable<GenericTypeParameterData> parameters = null) =>
            _parameters = parameters?.ToArray() ?? new GenericTypeParameterData[0];

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => _parameters.GetEnumerator();

        /// <summary>
        /// Gets an enumerator capable of iterating the generic type parameters.
        /// </summary>
        public IEnumerator<GenericTypeParameterData> GetEnumerator() =>
            ((IEnumerable<GenericTypeParameterData>)_parameters).GetEnumerator();

        /// <summary>
        /// Gets the number of generic type parameters in the collection.
        /// </summary>
        public int Count => _parameters.Length;

        /// <summary>
        /// Gets the generic type parameter at the specified index in the collection.
        /// </summary>
        public GenericTypeParameterData this[int index] => _parameters[index];

        internal bool DoesMatch(GenericTypeParameterCollection other)
        {
            if (Count != other.Count)
            {
                return false;
            }

            for (int i = 0; i < Count; i++)
            {
                if (this[i].DoesMatch(other[i]) == false)
                {
                    return false;
                }
            }

            return true;
        }

        internal string GetParameterListText(int skipCount = 0)
        {
            var parameters = _parameters.Skip(skipCount).ToList();

            if (parameters.Count == 0)
            {
                return string.Empty;
            }

            var sb = new StringBuilder("<");

            sb.Append(parameters[0].GetParameterListDisplayText());
            for (int i = 1; i < parameters.Count; i++)
            {
                sb.Append(", ");
                sb.Append(parameters[i].GetParameterListDisplayText());
            }

            sb.Append(">");

            return sb.ToString();
        }
    }
}
