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

using System.Collections.Generic;
using System.Linq;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// Represents a collection of database columns associated with a <see cref="SpannerCommand" /> and their
    /// respective mappings to columns in a DataSet.
    /// </summary>
    public sealed class SpannerColumnCollection : SpannerParameterCollection, IEnumerable<SpannerColumn>
    {
        /// <summary>
        /// Creates a new <see cref="SpannerColumnCollection" />
        /// </summary>
        public SpannerColumnCollection() { }

        /// <summary>
        /// Creates a new <see cref="SpannerParameterCollection" />
        /// </summary>
        /// <param name="parameters">The initial collection of parameters</param>
        public SpannerColumnCollection(IEnumerable<SpannerColumn> parameters)
            : base(parameters) { }

        /// <inheritdoc />
        public new IEnumerator<SpannerColumn> GetEnumerator() => InnerList.Cast<SpannerColumn>().GetEnumerator();

        /// <inheritdoc />
        protected override SpannerParameter CreateParameter(
            string parameterName,
            SpannerDbType type,
            object value = null,
            string sourceColumn = null) => new SpannerColumn(parameterName, type)
        {
            Value = value,
            SourceColumn = sourceColumn
        };

        internal static SpannerColumnCollection FromParameterCollection(SpannerParameterCollection source) =>
            new SpannerColumnCollection(source.Select(x => new SpannerColumn(x.ParameterName, x.SpannerDbType)
            {
                Value = x.Value,
                Direction = x.Direction,
                IsNullable =  x.IsNullable,
                Size = x.Size,
                SourceColumn = x.SourceColumn
            }));
    }
}
