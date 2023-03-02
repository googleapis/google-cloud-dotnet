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


using Google.Cloud.Firestore.V1;
using System;
using System.Collections.Generic;
using FieldOp = Google.Cloud.Firestore.V1.StructuredQuery.Types.FieldFilter.Types.Operator;
using UnaryOp = Google.Cloud.Firestore.V1.StructuredQuery.Types.UnaryFilter.Types.Operator;
using ProtoFilter = Google.Cloud.Firestore.V1.StructuredQuery.Types.Filter;
using static Google.Cloud.Firestore.V1.StructuredQuery.Types.CompositeFilter.Types;
using System.Linq;
using Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Firestore;


/// <summary>
/// 
/// </summary>
public abstract class Filter
{
    private Filter() { }

    internal abstract ProtoFilter ToProto(SerializationContext context);

    /// <summary>
    /// 
    /// </summary>
    internal class UnaryFilter : Filter, IEquatable<UnaryFilter>
    {
        public FieldPath Field { get; }

        // The integer value of either the UnaryOp or FieldOp, depending on whether _value is null.
        public int Op { get; }

        // The value for a field (binary) operator, or null for a unary operator
        public Object Value { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldPath"></param>
        /// <param name="op"></param>
        /// <param name="value"></param>
        public UnaryFilter(FieldPath fieldPath, FieldOp op, Object value)
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

        internal override ProtoFilter ToProto(SerializationContext context)
        {
            
            return Value == null
                ? new ProtoFilter { UnaryFilter = new StructuredQuery.Types.UnaryFilter { Field = Field.ToFieldReference(), Op = (UnaryOp) Op } }
                : new ProtoFilter { FieldFilter = new StructuredQuery.Types.FieldFilter { Field = Field.ToFieldReference(), Op = (FieldOp) Op, Value = ValueSerializer.Serialize(context, Value) } };
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

        public bool Equals(UnaryFilter other) => throw new NotImplementedException();
    }

    /// <summary>
    /// 
    /// </summary>
    internal class CompositeFilter : Filter, IEquatable<CompositeFilter>
    {
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<Filter> Filters { get; }

        /// <summary>
        /// 
        /// </summary>
        public Operator Operator { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filters"></param>
        /// <param name="op"></param>
        public CompositeFilter(IEnumerable<Filter> filters, Operator op)
        {
            Filters = new List<Filter>(filters);
            Operator = op;
        }

        public CompositeFilter WithAdditionalFilter(Filter filter)
        {
            var filters = new List<Filter>(Filters);
            filters.Add(filter);
            return new CompositeFilter(filters, Operator);
        }

        internal override ProtoFilter ToProto(SerializationContext context) =>
            new ProtoFilter { CompositeFilter = new StructuredQuery.Types.CompositeFilter { Op = Operator, Filters = { Filters.Select(f => f.ToProto(context)) } } };

        

        public bool Equals(CompositeFilter other) => throw new NotImplementedException();
    }

    internal static bool IsOrderingFilter(UnaryFilter filter) =>
        filter.Value is object &&
        filter.Op == (int) FieldOp.GreaterThan ||
        filter.Op == (int) FieldOp.GreaterThanOrEqual ||
        filter.Op == (int) FieldOp.LessThan ||
        filter.Op == (int) FieldOp.LessThanOrEqual;

    internal static UnaryFilter GetOrderingFilter(CompositeFilter compositeFilter)
    {
        foreach (var filter in compositeFilter.Filters)
        {
            if (filter.GetType() == typeof(Filter.UnaryFilter))
            {
                if (IsOrderingFilter((UnaryFilter) filter))
                {
                    return (UnaryFilter) filter;
                }
            }
            else
            {
                var res = GetOrderingFilter((CompositeFilter)filter);
                if (res != null)
                {
                    return res;
                }
            }
        }
        return null;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public static Filter GreaterThan(string fieldPath, Object value)
    {
        return new UnaryFilter(FieldPath.FromDotSeparatedString(fieldPath), FieldOp.GreaterThan, value);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public static Filter Equal(string fieldPath, Object value)
    {
        return new UnaryFilter(FieldPath.FromDotSeparatedString(fieldPath), FieldOp.Equal, value);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public static Filter LessThan(string fieldPath, Object value)
    {
        return new UnaryFilter(FieldPath.FromDotSeparatedString(fieldPath), FieldOp.LessThan, value);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="filters"></param>
    /// <returns></returns>
    public static Filter And(IEnumerable<Filter> filters)
    {
        return new CompositeFilter(filters, StructuredQuery.Types.CompositeFilter.Types.Operator.And);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="filters"></param>
    /// <returns></returns>
    public static Filter And(params Filter[] filters) => And((IEnumerable<Filter>) filters);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="filters"></param>
    /// <returns></returns>
    public static Filter Or(IEnumerable<Filter> filters)
    {
        return new CompositeFilter(filters, StructuredQuery.Types.CompositeFilter.Types.Operator.Or);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="filters"></param>
    /// <returns></returns>
    public static Filter Or(params Filter[] filters) => Or((IEnumerable<Filter>) filters);

}
