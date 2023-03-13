// Copyright 2023 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at 
//
// https://www.apache.org/licenses/LICENSE-2.0 
//
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and 
// limitations under the License.

using Google.Api.Gax;
using Google.Cloud.Firestore.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using static Google.Cloud.Firestore.Query;
using static Google.Cloud.Firestore.V1.StructuredQuery.Types.CompositeFilter.Types;
using ProtoFilter = Google.Cloud.Firestore.V1.StructuredQuery.Types.Filter;

namespace Google.Cloud.Firestore;

public abstract partial class Filter
{
    internal sealed class CompositeFilter : Filter, IEquatable<CompositeFilter>
    {
        // The list of filters to combine. Must not be null.
        internal IReadOnlyList<Filter> Filters { get; }

        // The operator for combining multiple filters. Must bot be null.
        internal Operator Operator { get; }

        internal CompositeFilter(IEnumerable<Filter> filters, Operator op)
        {
            Filters = new List<Filter>(filters);
            Operator = op;
        }

        internal CompositeFilter WithAdditionalFilter(Filter filter)
        {
            var filters = new List<Filter>(Filters);
            filters.Add(filter);
            return new CompositeFilter(filters, Operator);
        }

        internal override ProtoFilter ToProto(QueryRoot queryRoot) =>
            new ProtoFilter
            {
                CompositeFilter = new StructuredQuery.Types.CompositeFilter
                {
                    Op = Operator,
                    Filters = { Filters.Select(f => f.ToProto(queryRoot)) }
                }
            };

        internal override void ValidateForSentinels(SerializationContext context)
        {
            foreach (var filter in Filters)
            {
                filter.ValidateForSentinels(context);
            }
        }

        /// <inheritdoc />
        public bool Equals(CompositeFilter other) =>
            GaxEqualityHelpers.ListsEqual(Filters, other.Filters) && Operator.Equals(other.Operator);

        /// <inheritdoc />
        public override bool Equals(object obj) => obj is CompositeFilter other ? Equals(other) : false;

        /// <inheritdoc />
        public override int GetHashCode() =>
            GaxEqualityHelpers.CombineHashCodes(GaxEqualityHelpers.GetListHashCode(Filters), Operator.GetHashCode());
        public override bool Equals(Filter other) => other is CompositeFilter filter && Equals(filter as CompositeFilter);
    }
}
