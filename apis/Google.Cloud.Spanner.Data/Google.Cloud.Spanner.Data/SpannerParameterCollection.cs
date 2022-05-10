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

using Google.Api.Gax;
using Google.Protobuf.Collections;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// Represents a collection of parameters associated with a <see cref="SpannerCommand" /> and their
    /// respective mappings to columns in a DataSet.
    /// </summary>
    public sealed class SpannerParameterCollection : DbParameterCollection, IEnumerable<SpannerParameter>
    {
        /// <summary>
        /// Initializes a new SpannerParameterCollection with the given set of optional <see cref="SpannerParameter"/>
        /// objects.
        /// </summary>
        /// <param name="initialParameters">The initial parameters to include in the collection.</param>
        public SpannerParameterCollection(IEnumerable<SpannerParameter> initialParameters = null)
        {
            if (initialParameters != null)
            {
                _innerList.AddRange(initialParameters);
            }
        }

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
        /// <returns>The parameter which has been added.</returns>
        public SpannerParameter Add(string parameterName, SpannerDbType dbType)
        {
            GaxPreconditions.CheckNotNull(parameterName, nameof(parameterName));
            GaxPreconditions.CheckNotNull(dbType, nameof(dbType));

            var parameter = new SpannerParameter(parameterName, dbType);
            _innerList.Add(parameter);
            return parameter;
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
        /// <returns>The parameter which has been added.</returns>
        public SpannerParameter Add(string parameterName, SpannerDbType dbType, object value)
        {
            var parameter = Add(parameterName, dbType);
            parameter.Value = value;
            return parameter;
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

        internal void FillSpannerCommandParams(out Struct parameters, MapField<string, V1.Type> paramTypes, SpannerConversionOptions options)
        {
            if (Count == 0)
            {
                parameters = null;
            }
            else
            {
                parameters = new Struct();
                FillSpannerInternalValues(parameters.Fields, paramTypes, options);
            }
        }

        internal void FillSpannerInternalValues(
            MapField<string, Value> valueDictionary,
            MapField<string, V1.Type> requestParamTypes,
            SpannerConversionOptions options)
        {
            FillSpannerInternalValues(valueDictionary, options);
            FillSpannerInternalTypes(requestParamTypes, options);
        }

        /// <summary>
        /// This helper removes the leading '@' in case the developer accidentally used
        /// it in his parameter name.
        /// </summary>
        private string GetCorrectedParameterName(string parameterName) 
            => parameterName?.StartsWith("@") ?? false ? parameterName.Substring(1) : parameterName;

        private void FillSpannerInternalValues(MapField<string, Value> valueDictionary, SpannerConversionOptions options)
        {
            foreach (var parameter in _innerList)
            {
                valueDictionary[GetCorrectedParameterName(parameter.ParameterName)]
                    = parameter.GetConfiguredSpannerDbType(options).ToProtobufValue(parameter.GetValidatedValue(), options);
            }
        }

        private void FillSpannerInternalTypes(MapField<string, V1.Type> typeDictionary, SpannerConversionOptions options)
        {
            foreach (var parameter in _innerList)
            {
                typeDictionary[GetCorrectedParameterName(parameter.ParameterName)]
                    = parameter.GetConfiguredSpannerDbType(options).ToProtobufType();
            }
        }

        /// <inheritdoc />
        public override bool IsFixedSize => false;

        /// <inheritdoc />
        public override bool IsSynchronized => false;

        /// <inheritdoc />
        public override bool IsReadOnly => false;

        /// <summary>
        /// Clones the collection.
        /// </summary>
        /// <returns>A cloned copy of this instance.</returns>
        public SpannerParameterCollection Clone() =>
            new SpannerParameterCollection(_innerList.Select(p => (SpannerParameter) p.Clone()));
    }
}
