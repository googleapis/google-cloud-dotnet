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
using System.Collections;
using System.Linq;
using static Google.Cloud.Firestore.Query;
using FieldOp = Google.Cloud.Firestore.V1.StructuredQuery.Types.FieldFilter.Types.Operator;
using ProtoFilter = Google.Cloud.Firestore.V1.StructuredQuery.Types.Filter;
using UnaryOp = Google.Cloud.Firestore.V1.StructuredQuery.Types.UnaryFilter.Types.Operator;

namespace Google.Cloud.Firestore;

public abstract partial class Filter
{
    internal sealed class UnaryFilter : Filter, IEquatable<UnaryFilter>
    {
        internal FieldPath Field { get; }

        // The integer value of either the UnaryOp or FieldOp, depending on whether Value is null.
        internal int Op { get; }

        // The value for a field (binary) operator, or null for a unary operator
        internal Object Value { get; }

        internal UnaryFilter(FieldPath fieldPath, FieldOp op, Object value)
        {
            Field = fieldPath;
            var unaryOperator = GetUnaryOperator(value, op);
            if (unaryOperator != UnaryOp.Unspecified)
            {
                Op = (int) unaryOperator;
                Value = null;
            }
            else
            {
                Op = (int) op;
                Value = value;
            }
        }

        internal UnaryFilter(string fieldPath, FieldOp op, object value)
            // This expression is long-winded, but we can't easily avoid that. We could create a
            // separate helper method and call that, but it's probably not worth it.
            : this(FieldPath.FromDotSeparatedString(GaxPreconditions.CheckNotNullOrEmpty(fieldPath, nameof(fieldPath))), op, value)
        {
        }

        internal override ProtoFilter ToProto(QueryRoot root)
        {
            var context = root.Database.SerializationContext;
            var convertedValue = Value;
            if (Field.Equals(FieldPath.DocumentId))
            {
                convertedValue = Op switch
                {
                    (int) FieldOp.ArrayContains => throw new ArgumentException($"Invalid query. Document IDs cannot be used with the {Op} operator.", nameof(Op)),
                    (int) FieldOp.ArrayContainsAny => throw new ArgumentException($"Invalid query. Document IDs cannot be used with the {Op} operator.", nameof(Op)),
                    (int) FieldOp.In => ConvertValueToDocumentReferencesForInQuery(),
                    (int) FieldOp.NotIn => ConvertValueToDocumentReferencesForInQuery(),
                    _ => root.ConvertReference(Value, nameof(Value))
                };
            }

            return Value == null
                ? new ProtoFilter { UnaryFilter = new StructuredQuery.Types.UnaryFilter { Field = Field.ToFieldReference(), Op = (UnaryOp) Op } }
                : new ProtoFilter { FieldFilter = new StructuredQuery.Types.FieldFilter { Field = Field.ToFieldReference(), Op = (FieldOp) Op, Value = ValueSerializer.Serialize(context, convertedValue) } };

            object ConvertValueToDocumentReferencesForInQuery()
            {
                var list = (Value as IEnumerable)?.Cast<object>().ToList();
                if (list is null || list.Count == 0)
                {
                    throw new ArgumentException($"Invalid Query. A non-empty array is required for '{Op}' filters.", nameof(Value));
                }
                return list.Select(item => root.ConvertReference(item, nameof(Value))).ToList();
            }
        }

        private static UnaryOp GetUnaryOperator(object value, FieldOp op)
        {
            switch (value)
            {
                case null:
                    return op switch
                    {
                        FieldOp.Equal => UnaryOp.IsNull,
                        FieldOp.NotEqual => UnaryOp.IsNotNull,
                        _ => throw new ArgumentException("Null values can only be used with the Equal/NotEqual operators", nameof(value))
                    };
                case double d when double.IsNaN(d):
                case float f when float.IsNaN(f):
                    return op switch
                    {
                        FieldOp.Equal => UnaryOp.IsNan,
                        FieldOp.NotEqual => UnaryOp.IsNotNan,
                        _ => throw new ArgumentException("Not-a-number values can only be used with the Equal/NotEqual operators", nameof(value))
                    };
                default:
                    return UnaryOp.Unspecified;
            }
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => obj is UnaryFilter other ? Equals(other) : false;

        /// <inheritdoc />
        public bool Equals(UnaryFilter other) =>
            Field.Equals(other.Field) && Op == other.Op && Value.Equals(other.Value);

        /// <inheritdoc />
        public override int GetHashCode() => GaxEqualityHelpers.CombineHashCodes(Field.GetHashCode(), Op, Value?.GetHashCode() ?? -1);

        internal override void ValidateForSentinels(SerializationContext context)
        {
            var convertedValue = ValueSerializer.Serialize(context, Value);
            ValidateNoSentinelsRecursively(convertedValue, "Sentinel values cannot be specified in filters");
        }

        public override bool Equals(Filter other) => other is UnaryFilter && Equals(other as UnaryFilter);
    }
}
