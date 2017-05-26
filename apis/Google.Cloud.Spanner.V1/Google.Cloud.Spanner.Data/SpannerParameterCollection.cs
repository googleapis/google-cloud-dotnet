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
using Google.Protobuf.Collections;
using Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// </summary>
    public sealed class SpannerParameterCollection : DbParameterCollection
    {
        /// <inheritdoc />
        public override int Count => _innerList.Count;

        /// <inheritdoc />
        public override object SyncRoot => _innerList;

        private readonly List<SpannerParameter> _innerList = new List<SpannerParameter>();

        /// <summary>
        /// </summary>
        /// <param name="parameterName"></param>
        /// <param name="dbType"></param>
        public void Add(string parameterName, SpannerDbType dbType)
        {
            _innerList.Add(new SpannerParameter(parameterName, dbType));
        }

        /// <summary>
        /// </summary>
        /// <param name="parameterName"></param>
        /// <param name="value"></param>
        /// <param name="dbType"></param>
        public void Add(string parameterName, object value, SpannerDbType dbType)
        {
            _innerList.Add(new SpannerParameter(parameterName, dbType) {Value = value});
        }

        /// <summary>
        /// </summary>
        /// <param name="parameterName"></param>
        /// <param name="dbType"></param>
        /// <param name="sourceColumn"></param>
        public void Add(string parameterName, SpannerDbType dbType, string sourceColumn)
        {
            _innerList.Add(new SpannerParameter(parameterName, dbType, sourceColumn));
        }

        /// <inheritdoc />
        public override int Add(object value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));
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
        public override bool Contains(object value)
        {
            return _innerList.Contains(value as SpannerParameter);
        }

        /// <inheritdoc />
        public override bool Contains(string value)
        {
            return _innerList.Any(x => x.ParameterName.Equals(value));
        }

        /// <inheritdoc />
        public override void CopyTo(Array array, int index)
        {
            if (array == null) {
                throw new ArgumentNullException(nameof(array));
            }
            if (array.Length < _innerList.Count + index) {
                throw new ArgumentOutOfRangeException(nameof(array), "There is not enough space in the array to copy values.");
            }
            foreach (var item in _innerList)
            {
                array.SetValue(item, index);
                index++;
            }
        }

        /// <inheritdoc />
        public override IEnumerator GetEnumerator()
        {
            return _innerList.GetEnumerator();
        }

        /// <inheritdoc />
        public override int IndexOf(object value)
        {
            return _innerList.IndexOf(value as SpannerParameter);
        }

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
        protected override DbParameter GetParameter(int index)
        {
            return _innerList[index];
        }

        /// <inheritdoc />
        protected override DbParameter GetParameter(string parameterName)
        {
            var index = IndexOf(parameterName);
            if (index == -1)
                return null;
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
            var index = IndexOf(parameterName);
            if (index == -1)
                _innerList.Add((SpannerParameter) value);
            else
                _innerList[index] = (SpannerParameter) value;
        }

        internal void FillSpannerInternalValues(MapField<string, Value> valueDictionary, MapField<string, V1.Type> requestParamTypes)
        {
            FillSpannerInternalValues(valueDictionary);
            FillSpannerInternalTypes(requestParamTypes);
        }

        private void FillSpannerInternalValues(MapField<string, Value> valueDictionary)
        {
            foreach (var parameter in _innerList)
            {
                valueDictionary[parameter.ParameterName] = TypeMap.ToValue(parameter.Value, parameter.TypeCode);
            }
        }

        private void FillSpannerInternalTypes(MapField<string, V1.Type> typeDictionary)
        {
            foreach (var parameter in _innerList)
            {
                typeDictionary[parameter.ParameterName] = new V1.Type { Code = parameter.TypeCode };
            }
        }
    }
}