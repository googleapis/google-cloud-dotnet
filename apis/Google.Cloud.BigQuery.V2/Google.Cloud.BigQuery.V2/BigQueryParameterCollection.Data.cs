// Copyright 2017 Google Inc. All Rights Reserved.
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

using System;
using System.Collections;
using System.Data.Common;
using System.Linq;
using Google.Api.Gax;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// </summary>
    public sealed partial class BigQueryParameterCollection : DbParameterCollection
    {
        /// <inheritdoc />
        public override int Add(object value)
        {
            var bigQueryParameter = value as BigQueryParameter;
            GaxPreconditions.CheckArgument(bigQueryParameter != null, nameof(value),
                "The argument must not be null and be of type {0}", nameof(BigQueryParameter));
            _parameters.Add(bigQueryParameter);
            return _parameters.Count - 1;
        }

        /// <inheritdoc />
        public override bool Contains(object value) => _parameters.Contains(value as BigQueryParameter);

        /// <inheritdoc />
        public override bool Contains(string value) => _parameters.Any(x => x.ParameterName.Equals(value));

        /// <inheritdoc />
        public override int IndexOf(string parameterName) => _parameters.FindIndex(x => x.ParameterName.Equals(parameterName));

        /// <inheritdoc />
        public override void RemoveAt(string parameterName) => _parameters.RemoveAt(IndexOf(parameterName));

        /// <inheritdoc />
        protected override void SetParameter(int index, DbParameter value)
            => _parameters[index] = (BigQueryParameter)value;

        /// <inheritdoc />
        protected override void SetParameter(string parameterName, DbParameter value)
        {
            int index = IndexOf(parameterName);
            if (index == -1)
            {
                _parameters.Add((BigQueryParameter)value);
            }
            else
            {
                _parameters[index] = (BigQueryParameter)value;
            }
        }

#if NET45
        /// <inheritdoc />
        public override bool IsFixedSize => false;
        /// <inheritdoc />
        public override bool IsReadOnly => false;
        /// <inheritdoc />
        public override bool IsSynchronized => false;
#endif
        /// <inheritdoc />
        public override object SyncRoot => _parameters;

        /// <inheritdoc />
        public override void Insert(int index, object value)
            => _parameters.Insert(index, (BigQueryParameter)value);

        /// <inheritdoc />
        public override void Remove(object value)
            => _parameters.Remove((BigQueryParameter)value);

        /// <inheritdoc />
        public override void RemoveAt(int index) => _parameters.RemoveAt(index);

        /// <inheritdoc />
        public override void CopyTo(Array array, int index)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }
            if (array.Length < _parameters.Count + index)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(array), "There is not enough space in the array to copy values.");
            }
            foreach (var item in _parameters)
            {
                array.SetValue(item, index);
                index++;
            }
        }

        /// <inheritdoc />
        public override IEnumerator GetEnumerator() => _parameters.GetEnumerator();

        /// <inheritdoc />
        protected override DbParameter GetParameter(int index)
            => _parameters[index];

        /// <inheritdoc />
        protected override DbParameter GetParameter(string parameterName)
        {
            int index = IndexOf(parameterName);
            if (index == -1)
            {
                return null;
            }

            return _parameters[index];
        }

        /// <inheritdoc />
        public override int IndexOf(object value)
            => _parameters.IndexOf(value as BigQueryParameter);

        /// <inheritdoc />
        public override void AddRange(Array values)
            => _parameters.AddRange(values.Cast<BigQueryParameter>());
    }
}
