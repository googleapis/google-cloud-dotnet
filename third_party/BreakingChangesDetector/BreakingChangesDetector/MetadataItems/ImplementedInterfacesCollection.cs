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

namespace BreakingChangesDetector.MetadataItems
{
    /// <summary>
    /// A collection of <see cref="DeclaringTypeData"/> instances representing interfaces
    /// </summary>
    public sealed class ImplementedInterfacesCollection : IEnumerable<DeclaringTypeData>
    {
        private readonly DeclaringTypeData[] _implementedInterfaces;

        internal ImplementedInterfacesCollection(IEnumerable<DeclaringTypeData> types) =>
            _implementedInterfaces = types.ToArray();

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() =>
            _implementedInterfaces.GetEnumerator();

        /// <summary>
        /// Gets an enumerator capable of iterating the interfaces
        /// </summary>
        public IEnumerator<DeclaringTypeData> GetEnumerator() =>
            ((IEnumerable<DeclaringTypeData>)_implementedInterfaces).GetEnumerator();

        /// <summary>
        /// Gets the number of implemented interfaces in the collection.
        /// </summary>
        public int Count => _implementedInterfaces.Length;

        /// <summary>
        /// Gets the implemented interface at the specified index in the collection.
        /// </summary>
        public DeclaringTypeData this[int index] => _implementedInterfaces[index];

        internal ImplementedInterfacesCollection ReplaceGenericTypeParameters(GenericTypeParameterCollection genericParameters, GenericTypeArgumentCollection genericArguments) =>
            new ImplementedInterfacesCollection(this.Select(im => (DeclaringTypeData)im.ReplaceGenericTypeParameters(genericParameters, genericArguments)));
    }
}
