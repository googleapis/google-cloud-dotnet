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
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using Google.Api.Gax;
using Google.Protobuf.Collections;
using Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// Represents a collection of parameters associated with a <see cref="SpannerCommand" /> and their
    /// respective mappings to columns in a DataSet.
    /// </summary>
    public sealed class SpannerParameterCollection : DbParameterCollection, IEnumerable<SpannerParameter>
    {
        private readonly List<SpannerParameter> _innerList = new List<SpannerParameter>();

        /// <inheritdoc />
        public override int Count => _innerList.Count;

        /// <inheritdoc />
        public override object SyncRoot => _innerList;

        /// <inheritdoc />
        IEnumerator<SpannerParameter> IEnumerable<SpannerParameter>.GetEnumerator() => _innerList.GetEnumerator();

        /// <inheritdoc />
        public override IEnumerator GetEnumerator() => _innerList.GetEnumerator();

        /// <summary>
        /// Adds a new <see cref="SpannerParameter" /> to the <see cref="SpannerParameterCollection" />.
        /// </summary>
        /// <param name="parameterName">
        /// The name of the parameter. For Insert, Update and Delete commands, this name should
        /// be the name of a valid Column in a Spanner table. In Select commands, this name should be the name of a parameter
        /// used in the SQL Query. Must not be null
        /// </param>
        /// <param name="dbType">
        /// One of the <see cref="SpannerDbType" /> values that indicates the type of the parameter.
        /// Must not be null.
        /// </param>
        public void Add(string parameterName, SpannerDbType dbType)
        {
            GaxPreconditions.CheckNotNull(parameterName, nameof(parameterName));
            GaxPreconditions.CheckNotNull(dbType, nameof(dbType));

            _innerList.Add(new SpannerParameter(parameterName, dbType));
        }

        /// <summary>
        /// Adds a new <see cref="SpannerParameter" /> to the <see cref="SpannerParameterCollection" />
        /// </summary>
        /// <param name="parameterName">
        /// The name of the parameter. For Insert, Update and Delete commands, this name should
        /// be the name of a valid Column in a Spanner table. In Select commands, this name should be the name of a parameter
        /// used in the SQL Query. Must not be null.
        /// </param>
        /// <param name="dbType">
        /// One of the <see cref="SpannerDbType" /> values that indicates the type of the parameter.
        /// Must not be null.
        /// </param>
        /// <param name="value">An object that is the value of the SpannerParameter. May be null.</param>
        public void Add(string parameterName, SpannerDbType dbType, object value)
        {
            GaxPreconditions.CheckNotNull(parameterName, nameof(parameterName));
            GaxPreconditions.CheckNotNull(dbType, nameof(dbType));

            var parameter = new SpannerParameter(parameterName, dbType) {Value = value};
            _innerList.Add(parameter);
        }

        /// <inheritdoc />
        public override int Add(object value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            _innerList.Add((SpannerParameter) value);
            return _innerList.Count - 1;
        }

        /// <inheritdoc />
        public override void AddRange(Array values)
        {
            _innerList.AddRange(values.Cast<SpannerParameter>());
        }

        /// <inheritdoc />
        public override void Clear()
        {
            _innerList.Clear();
        }

        /// <inheritdoc />
        public override bool Contains(object value) => _innerList.Contains(value as SpannerParameter);

        /// <inheritdoc />
        public override bool Contains(string value)
        {
            return _innerList.Any(x => x.ParameterName.Equals(value));
        }

        /// <inheritdoc />
        public override void CopyTo(Array array, int index)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }
            if (array.Length < _innerList.Count + index)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(array), "There is not enough space in the array to copy values.");
            }
            foreach (var item in _innerList)
            {
                array.SetValue(item, index);
                index++;
            }
        }

        /// <inheritdoc />
        public override int IndexOf(object value) => _innerList.IndexOf(value as SpannerParameter);

        /// <inheritdoc />
        public override int IndexOf(string parameterName)
        {
            return _innerList.FindIndex(x => x.ParameterName.Equals(parameterName));
        }

        /// <inheritdoc />
        public override void Insert(int index, object value)
        {
            _innerList.Insert(index, (SpannerParameter) value);
        }

        /// <inheritdoc />
        public override void Remove(object value)
        {
            _innerList.Remove((SpannerParameter) value);
        }

        /// <inheritdoc />
        public override void RemoveAt(int index)
        {
            _innerList.RemoveAt(index);
        }

        /// <inheritdoc />
        public override void RemoveAt(string parameterName)
        {
            _innerList.RemoveAt(IndexOf(parameterName));
        }

        /// <inheritdoc />
        protected override DbParameter GetParameter(int index) => _innerList[index];

        /// <inheritdoc />
        protected override DbParameter GetParameter(string parameterName)
        {
            int index = IndexOf(parameterName);
            if (index == -1)
            {
                return null;
            }

            return _innerList[index];
        }

        /// <inheritdoc />
        protected override void SetParameter(int index, DbParameter value)
        {
            _innerList[index] = (SpannerParameter) value;
        }

        /// <inheritdoc />
        protected override void SetParameter(string parameterName, DbParameter value)
        {
            int index = IndexOf(parameterName);
            if (index == -1)
            {
                _innerList.Add((SpannerParameter) value);
            }
            else
            {
                _innerList[index] = (SpannerParameter) value;
            }
        }

        internal void FillSpannerInternalValues(
            MapField<string, Value> valueDictionary,
            MapField<string, V1.Type> requestParamTypes)
        {
            FillSpannerInternalValues(valueDictionary);
            FillSpannerInternalTypes(requestParamTypes);
        }

        private void FillSpannerInternalValues(MapField<string, Value> valueDictionary)
        {
            foreach (var parameter in _innerList)
            {
                valueDictionary[parameter.ParameterName] =
                    ValueConversion.ToValue(parameter.GetValidatedValue(), parameter.SpannerDbType);
            }
        }

        private void FillSpannerInternalTypes(MapField<string, V1.Type> typeDictionary)
        {
            foreach (var parameter in _innerList)
            {
                typeDictionary[parameter.ParameterName] = parameter.SpannerDbType.ToProtobufType();
            }
        }

#if NET45
        /// <inheritdoc />
        public override bool IsFixedSize => false;

        /// <inheritdoc />
        public override bool IsSynchronized => false;

        /// <inheritdoc />
        public override bool IsReadOnly => false;
#endif
    }
}
