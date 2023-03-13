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
using System.Collections;
using System.Collections.Generic;
using static Google.Cloud.Firestore.Query;
using FieldOp = Google.Cloud.Firestore.V1.StructuredQuery.Types.FieldFilter.Types.Operator;
using ProtoFilter = Google.Cloud.Firestore.V1.StructuredQuery.Types.Filter;

namespace Google.Cloud.Firestore;

/// <summary>
/// A holder for any type of filter.
/// </summary>
public abstract partial class Filter : IEquatable<Filter>
{
    // Restrain from sub classing.
    private Filter() { }

    // Convert the filter into its proto equivalent.
    internal abstract ProtoFilter ToProto(QueryRoot queryRoot);
    internal abstract void ValidateForSentinels(SerializationContext context);

    /// <inheritdoc />
    public abstract bool Equals(Filter other);

    /// <summary>
    /// Validates that a value is suitable for a WhereIn or WhereNotIn query. It can't be null or a string.
    /// The reason for highlighting string is that it's an IEnumerable{char}, but users
    /// don't tend to think of it that way; anyone passing a single string to WhereIn is doing so
    /// expecting it to be treated as an array containing just that string, I'm sure. So let's call that out.
    /// </summary>
    /// <param name="values">The value to validate.</param>
    /// <returns>The original value, if it's valid.</returns>
    private static IEnumerable ValidateWhereInValues(IEnumerable values)
    {
        if (values is null)
        {
            throw new ArgumentNullException(nameof(values), "The list of values for a WhereIn or WhereNotIn query must not be null.");
        }
        if (values is string)
        {
            // This is a really long error message, but it's good at saying exactly what's wrong.
            throw new ArgumentException("The list of values for a WhereIn or WhereNotIn query must not be a single string. The code compiles because string implements IEnumerable<char>, but you almost certainly meant to pass a collection of strings, e.g. a string[] or a List<string>",
                nameof(values));
        }
        return values;
    }

    /// <summary>
    /// Convenience method to validate that a serialized value doesn't contain any sentinels.
    /// Throws an ArgumentException with the given message if it does contain a sentinel.
    /// </summary>
    internal static void ValidateNoSentinelsRecursively(Value value, string message)
    {
        if (SentinelValue.GetKind(value) != SentinelKind.None)
        {
            throw new ArgumentException(message);
        }
        if (value.MapValue != null)
        {
            foreach (var mapValue in value.MapValue.Fields.Values)
            {
                ValidateNoSentinelsRecursively(mapValue, message);
            }
        }
        else if (value.ArrayValue != null)
        {
            foreach (var arrayValue in value.ArrayValue.Values)
            {
                ValidateNoSentinelsRecursively(arrayValue, message);
            }
        }
    }

    /// <summary>
    /// Returns the first ordering filter while performing DFS, If there is no ordering filter it will return null.
    /// </summary>
    internal static UnaryFilter GetOrderingFilter(CompositeFilter compositeFilter)
    {
        if (compositeFilter == null)
        {
            return null;
        }
        foreach (var filter in compositeFilter.Filters)
        {
            switch (filter)
            {
                case UnaryFilter unaryFilter:
                    if (IsOrderingFilter(unaryFilter))
                    {
                        return unaryFilter;
                    }
                    break;
                case CompositeFilter nestedCompositeFilter:
                    var recursiveResult = GetOrderingFilter(nestedCompositeFilter);
                    if (recursiveResult is not null)
                    {
                        return recursiveResult;
                    }
                    break;
                default:
                    // This would indicate a library bug.
                    throw new InvalidOperationException($"Unexpected filter type: {filter.GetType()}");
            }
        }
        return null;

        bool IsOrderingFilter(UnaryFilter filter) =>
            filter.Value is object &&
            filter.Op == (int) FieldOp.GreaterThan ||
            filter.Op == (int) FieldOp.GreaterThanOrEqual ||
            filter.Op == (int) FieldOp.LessThan ||
            filter.Op == (int) FieldOp.LessThanOrEqual;
    }

    /// <summary>
    /// Returns a filter specifying that the value in <paramref name="fieldPath"/> must be greater than
    /// <paramref name="value"/>.
    /// </summary>
    public static Filter GreaterThan(string fieldPath, Object value) =>
        new UnaryFilter(fieldPath, FieldOp.GreaterThan, value);

    /// <summary>
    /// Returns a filter specifying that the value in <paramref name="fieldPath"/> must be greater than
    /// <paramref name="value"/>.
    /// </summary>
    public static Filter GreaterThan(FieldPath fieldPath, Object value) =>
        new UnaryFilter(fieldPath, FieldOp.GreaterThan, value);

    /// <summary>
    /// Returns a filter specifying that the value in <paramref name="fieldPath"/> must be greater than or equal to 
    /// <paramref name="value"/>.
    /// </summary>
    public static Filter GreaterThanOrEqualTo(string fieldPath, Object value) =>
        new UnaryFilter(fieldPath, FieldOp.GreaterThanOrEqual, value);

    /// <summary>
    /// Returns a filter specifying that the value in <paramref name="fieldPath"/> must be greater than or equal to 
    /// <paramref name="value"/>.
    /// </summary>
    public static Filter GreaterThanOrEqualTo(FieldPath fieldPath, Object value) =>
        new UnaryFilter(fieldPath, FieldOp.GreaterThanOrEqual, value);

    /// <summary>
    /// Returns a filter specifying that the value in <paramref name="fieldPath"/> must be less than 
    /// <paramref name="value"/>.
    /// </summary>
    public static Filter LessThan(string fieldPath, Object value) =>
        new UnaryFilter(fieldPath, FieldOp.LessThan, value);

    /// <summary>
    /// Returns a filter specifying that the value in <paramref name="fieldPath"/> must be less than 
    /// <paramref name="value"/>.
    /// </summary>
    public static Filter LessThan(FieldPath fieldPath, Object value) =>
        new UnaryFilter(fieldPath, FieldOp.LessThan, value);

    /// <summary>
    /// Returns a filter specifying that the value in <paramref name="fieldPath"/> must be less than or equal to 
    /// <paramref name="value"/>.
    /// </summary>
    public static Filter LessThanOrEqualTo(string fieldPath, Object value) =>
        new UnaryFilter(fieldPath, FieldOp.LessThanOrEqual, value);

    /// <summary>
    /// Returns a filter specifying that the value in <paramref name="fieldPath"/> must be less than or equal to 
    /// <paramref name="value"/>.
    /// </summary>
    public static Filter LessThanOrEqualTo(FieldPath fieldPath, Object value) =>
        new UnaryFilter(fieldPath, FieldOp.LessThanOrEqual, value);

    /// <summary>
    /// Returns a filter specifying that the value in <paramref name="fieldPath"/> must be an array containing
    /// <paramref name="value"/>.
    /// </summary>
    public static Filter ArrayContains(string fieldPath, Object value) =>
        new UnaryFilter(fieldPath, FieldOp.ArrayContains, value);

    /// <summary>
    /// Returns a filter specifying that the value in <paramref name="fieldPath"/> must be an array containing
    /// <paramref name="value"/>.
    /// </summary>
    public static Filter ArrayContains(FieldPath fieldPath, Object value) =>
        new UnaryFilter(fieldPath, FieldOp.ArrayContains, value);

    /// <summary>
    /// Returns a filter specifying that <paramref name="fieldPath"/> must be
    /// a field present in the document, with a value which is an array containing at least one value in <paramref name="values"/>.
    /// </summary>
    public static Filter ArrayContainsAny(FieldPath fieldPath, IEnumerable values) =>
        new UnaryFilter(fieldPath, FieldOp.ArrayContainsAny, values);

    /// <summary>
    /// Returns a filter specifying that <paramref name="fieldPath"/> must be
    /// a field present in the document, with a value which is an array containing at least one value in <paramref name="values"/>.
    /// </summary>
    public static Filter ArrayContainsAny(string fieldPath, IEnumerable values) =>
        new UnaryFilter(fieldPath, FieldOp.ArrayContainsAny, values);

    /// <summary>
    /// Returns a filter specifying that <paramref name="fieldPath"/> must be
    /// a field present in the document, with a value which is one of the values in <paramref name="values"/>.
    /// </summary>
    public static Filter InArray(FieldPath fieldPath, IEnumerable values)
    {
        ValidateWhereInValues(values);
        return new UnaryFilter(fieldPath, FieldOp.In, values);
    }

    /// <summary>
    /// Returns a filter specifying that <paramref name="fieldPath"/> must be
    /// a field present in the document, with a value which is one of the values in <paramref name="values"/>.
    /// </summary>
    public static Filter InArray(string fieldPath, IEnumerable values)
    {
        ValidateWhereInValues(values);
        return new UnaryFilter(fieldPath, FieldOp.In, values);
    }

    /// <summary>
    /// Returns a filter specifying that <paramref name="fieldPath"/> must be
    /// a field present in the document, with a value which is not one of the values in <paramref name="values"/>.
    /// </summary>
    public static Filter NotInArray(FieldPath fieldPath, IEnumerable values)
    {
        ValidateWhereInValues(values);
        return new UnaryFilter(fieldPath, FieldOp.NotIn, values);
    }

    /// <summary>
    /// Returns a filter specifying that <paramref name="fieldPath"/> must be
    /// a field present in the document, with a value which is not one of the values in <paramref name="values"/>.
    /// </summary>
    public static Filter NotInArray(string fieldPath, IEnumerable values)
    {
        ValidateWhereInValues(values);
        return new UnaryFilter(fieldPath, FieldOp.NotIn, values);
    }

    /// <summary>
    /// Returns a filter specifying that the value in <paramref name="fieldPath"/> must be
    /// equal to <paramref name="value"/>.
    /// </summary>
    public static Filter EqualTo(string fieldPath, Object value) =>
        new UnaryFilter(fieldPath, FieldOp.Equal, value);

    /// <summary>
    /// Returns a filter specifying that the value in <paramref name="fieldPath"/> must be
    /// equal to <paramref name="value"/>.
    /// </summary>
    public static Filter EqualTo(FieldPath fieldPath, Object value) =>
        new UnaryFilter(fieldPath, FieldOp.Equal, value);

    /// <summary>
    /// Returns a filter specifying that the value in <paramref name="fieldPath"/> must not be
    /// equal to <paramref name="value"/>.
    /// </summary>
    public static Filter NotEqualTo(string fieldPath, Object value) =>
        new UnaryFilter(fieldPath, FieldOp.NotEqual, value);

    /// <summary>
    /// Returns a filter specifying that the value in <paramref name="fieldPath"/> must not be
    /// equal to <paramref name="value"/>.
    /// </summary>
    public static Filter NotEqualTo(FieldPath fieldPath, Object value) =>
        new UnaryFilter(fieldPath, FieldOp.NotEqual, value);

    /// <summary>
    /// Creates a composite filter which is the logical "AND" of all the specified filters.
    /// </summary>
    /// <param name="filters">Set of filters to combine. Must not be null or empty, or contain null references.</param>
    /// <returns>A filter representing the logical "AND" of all the elements in <paramref name="filters"/>.</returns>
    public static Filter And(IEnumerable<Filter> filters) =>
        new CompositeFilter(filters, StructuredQuery.Types.CompositeFilter.Types.Operator.And);

    /// <summary>
    /// Creates a composite filter which is the logical "AND" of all the specified filters.
    /// </summary>
    /// <param name="filters">Set of filters to combine. Must not be null or empty, or contain null references.</param>
    /// <returns>A filter representing the logical "AND" of all the elements in <paramref name="filters"/>.</returns>
    public static Filter And(params Filter[] filters) => And((IEnumerable<Filter>) filters);

    /// <summary>
    /// Creates a composite filter which is the logical "OR" of all the specified filters.
    /// </summary>
    /// <param name="filters">Set of filters to combine. Must not be null or empty, or contain null references.</param>
    /// <returns>A filter representing the logical "OR" of all the elements in <paramref name="filters"/>.</returns>
    public static Filter Or(IEnumerable<Filter> filters) =>
        new CompositeFilter(filters, StructuredQuery.Types.CompositeFilter.Types.Operator.Or);

    /// <summary>
    /// Creates a composite filter which is the logical "OR" of all the specified filters.
    /// </summary>
    /// <param name="filters">Set of filters to combine. Must not be null or empty, or contain null references.</param>
    /// <returns>A filter representing the logical "OR" of all the elements in <paramref name="filters"/>.</returns>
    public static Filter Or(params Filter[] filters) => Or((IEnumerable<Filter>) filters);
}
