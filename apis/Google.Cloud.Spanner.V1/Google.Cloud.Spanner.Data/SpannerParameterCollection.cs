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

namespace Google.Cloud.Spanner
{
    /// <summary>
    /// </summary>
    public sealed class SpannerParameterCollection : DbParameterCollection
    {
        private List<SpannerParameter> InnerList { get; } = new List<SpannerParameter>();

        /// <inheritdoc />
        public override int Count => InnerList.Count;

        /// <inheritdoc />
        public override object SyncRoot => InnerList;

        /// <summary>
        /// </summary>
        /// <param name="parameterName"></param>
        /// <param name="dbType"></param>
        public void Add(string parameterName, SpannerDbType dbType)
        {
            InnerList.Add(new SpannerParameter(parameterName, dbType));
        }

        /// <summary>
        /// </summary>
        /// <param name="parameterName"></param>
        /// <param name="value"></param>
        /// <param name="dbType"></param>
        public void Add(string parameterName, object value, SpannerDbType dbType)
        {
            InnerList.Add(new SpannerParameter(parameterName, dbType) { Value = value});
        }

        /// <summary>
        /// </summary>
        /// <param name="parameterName"></param>
        /// <param name="dbType"></param>
        /// <param name="sourceColumn"></param>
        public void Add(string parameterName, SpannerDbType dbType, string sourceColumn)
        {
            InnerList.Add(new SpannerParameter(parameterName, dbType, sourceColumn));
        }

        /// <inheritdoc />
        public override int Add(object value)
        {
            InnerList.Add((SpannerParameter)value);
            return InnerList.Count - 1;
        }

        /// <inheritdoc />
        public override void AddRange(Array values)
        {
            InnerList.AddRange(values.Cast<SpannerParameter>());
        }

        /// <inheritdoc />
        public override void Clear()
        {
            InnerList.Clear();
        }

        /// <inheritdoc />
        public override bool Contains(object value)
        {
            return InnerList.Contains(value as SpannerParameter);
        }

        /// <inheritdoc />
        public override bool Contains(string value)
        {
            return InnerList.Any(x => x.ParameterName.Equals(value));
        }

        /// <inheritdoc />
        public override void CopyTo(Array array, int index)
        {
            foreach (var item in InnerList)
            {
                array?.SetValue(item, index);
                index++;
            }
        }

        /// <inheritdoc />
        public override IEnumerator GetEnumerator()
        {
            return InnerList.GetEnumerator();
        }

        /// <inheritdoc />
        public override int IndexOf(object value)
        {
           return InnerList.IndexOf(value as SpannerParameter);
        }

        /// <inheritdoc />
        public override int IndexOf(string parameterName)
        {
            return InnerList.FindIndex(x => x.ParameterName.Equals(parameterName));
        }

        /// <inheritdoc />
        public override void Insert(int index, object value)
        {
            InnerList.Insert(index, (SpannerParameter)value);
        }

        /// <inheritdoc />
        public override void Remove(object value)
        {
            InnerList.Remove((SpannerParameter)value);
        }

        /// <inheritdoc />
        public override void RemoveAt(int index)
        {
            InnerList.RemoveAt(index);
        }

        /// <inheritdoc />
        public override void RemoveAt(string parameterName)
        {
            InnerList.RemoveAt(IndexOf(parameterName));
        }

        /// <inheritdoc />
        protected override DbParameter GetParameter(int index)
        {
            return InnerList[index];
        }

        /// <inheritdoc />
        protected override DbParameter GetParameter(string parameterName)
        {
            var index = IndexOf(parameterName);
            if (index == -1)
            {
                return null;
            }
            return InnerList[index];
        }

        /// <inheritdoc />
        protected override void SetParameter(int index, DbParameter value)
        {
            InnerList[index] = (SpannerParameter) value;
        }

        /// <inheritdoc />
        protected override void SetParameter(string parameterName, DbParameter value)
        {
            var index = IndexOf(parameterName);
            if (index == -1)
            {
                InnerList.Add((SpannerParameter) value);
            }
            else
            {
                InnerList[index] = (SpannerParameter) value;
            }
        }
    }
}