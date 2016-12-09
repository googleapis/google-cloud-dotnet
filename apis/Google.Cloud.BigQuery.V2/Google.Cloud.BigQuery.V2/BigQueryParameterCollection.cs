// Copyright 2016 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using System.Collections;
using System.Collections.Generic;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// A collection of <see cref="BigQueryParameter"/> elements, as part of a <see cref="BigQueryCommand"/>.
    /// </summary>
    public sealed class BigQueryParameterCollection : IReadOnlyList<BigQueryParameter>
    {
        private readonly List<BigQueryParameter> _parameters = new List<BigQueryParameter>();

        // Note: no Add(string) or Add(BigQueryDbType) overloads,
        // as that makes it too easy to accidentally add two or three parameters
        // with a collection initializer when we only want one.

        /// <summary>
        /// Adds a new parameter to the collection, with no name, type or value.
        /// </summary>
        /// <returns>The parameter added.</returns>
        public BigQueryParameter Add() => Add(new BigQueryParameter());

        /// <summary>
        /// Adds a new parameter to the collection with the given name and type, but no initial value.
        /// </summary>
        /// <param name="name">The initial name of the parameter.</param>
        /// <param name="type">The initial type of the parameter.</param>
        /// <returns>The parameter added.</returns>
        public BigQueryParameter Add(string name, BigQueryDbType? type)
            => Add(new BigQueryParameter(name, type));

        /// <summary>
        /// Adds a new parameter to the collection with the given name, type and value.
        /// </summary>
        /// <param name="name">The initial name of the parameter.</param>
        /// <param name="type">The initial type of the parameter.</param>
        /// <param name="value">The initial value of the parameter.</param>
        /// <returns>The parameter added.</returns>
        public BigQueryParameter Add(string name, BigQueryDbType? type, object value)
            => Add(new BigQueryParameter(name, type, value));

        /// <summary>
        /// Adds a new parameter to the collection with the given type and value, but no name.
        /// </summary>
        /// <param name="type">The initial type of the parameter.</param>
        /// <param name="value">The initial value of the parameter.</param>
        public BigQueryParameter Add(BigQueryDbType? type, object value)
            => Add(new BigQueryParameter(type, value));

        /// <summary>
        /// Adds the specified parameter to the collection.
        /// </summary>
        /// <param name="parameter">The parameter to add. Must not be null.</param>
        /// <returns>The parameter added, i.e. <paramref name="parameter"/>.</returns>
        public BigQueryParameter Add(BigQueryParameter parameter)
        {
            GaxPreconditions.CheckNotNull(parameter, nameof(parameter));
            _parameters.Add(parameter);
            return parameter;
        }

        /// <inheritdoc />
        public void Clear() => _parameters.Clear();

        /// <inheritdoc />
        public int Count => _parameters.Count;

        /// <inheritdoc />
        public BigQueryParameter this[int index] => _parameters[index];

        /// <inheritdoc />
        public IEnumerator<BigQueryParameter> GetEnumerator() => _parameters.GetEnumerator();

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
