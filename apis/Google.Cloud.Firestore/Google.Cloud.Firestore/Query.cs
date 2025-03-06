// Copyright 2017, Google Inc. All rights reserved.
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
using Google.Api.Gax.Grpc;
using Google.Cloud.Firestore.V1;
using Google.Protobuf;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using static Google.Cloud.Firestore.V1.StructuredQuery.Types;

namespace Google.Cloud.Firestore
{
    /// <summary>
    /// A query against a collection.
    /// </summary>
    /// <remarks>
    /// <see cref="CollectionReference"/> derives from this class as a "return-all" query against the
    /// collection it refers to.
    /// </remarks>
    public class Query : IEquatable<Query>
    {
        // These are all read-only, but may be mutable. They should never be mutated;
        // multiple Query objects may share the same internal references.
        // Any additional fields should be included in equality/hash code checks.
        private readonly int _offset;
        private readonly (int count, LimitType type)? _limit;
        private readonly IReadOnlyList<InternalOrdering> _orderings; // Never null
        private readonly Filter.CompositeFilter _filters; // May be null
        private readonly IReadOnlyList<FieldPath> _projections; // May be null
        private readonly Cursor _startAt;
        private readonly Cursor _endAt;

        // We should never allow a new query to be created for a different root,
        // as that might have different serialization rules.
        private readonly QueryRoot _root;

        private bool IsLimitToLast => _limit?.type == LimitType.Last;

        /// <summary>
        /// The database this query will search over.
        /// </summary>
        public virtual FirestoreDb Database => _root.Database;

        // Parent path of this query
        internal string ParentPath => _root.ParentPath;

        private Query(QueryRoot root)
        {
            _root = root;
            _orderings = new List<InternalOrdering>();
        }

        // private protected = only visible to subclasses within the same assembly.
        private protected Query(FirestoreDb database, DocumentReference parent, string collectionId)
            : this(QueryRoot.ForCollection(database, parent, collectionId))
        {
        }

        // Constructor used for all the fluent interface methods. This contains all the fields, which are copied verbatim with
        // no further cloning: it is the responsibility of each method to ensure it creates a clone for any new data.
        private Query(
            QueryRoot root,
            int offset, (int count, LimitType type)? limit,
            IReadOnlyList<InternalOrdering> orderings, Filter.CompositeFilter filter, IReadOnlyList<FieldPath> projections,
            Cursor startAt, Cursor endAt)
        {
            _root = root;
            _offset = offset;
            _limit = limit;
            _orderings = orderings;
            _projections = projections;
            _startAt = startAt;
            _endAt = endAt;
            _filters = filter;
        }

        internal static Query ForCollectionGroup(FirestoreDb database, string collectionId) =>
            new Query(QueryRoot.ForCollectionGroup(database, collectionId));

        internal StructuredQuery ToStructuredQuery()
        {
            bool limitToLast = IsLimitToLast;
            if (limitToLast && !_orderings.Any())
            {
                throw new InvalidOperationException($"Queries using {nameof(LimitToLast)} must specify at least one ordering.");
            }

            return new StructuredQuery
            {
                From = { new CollectionSelector { AllDescendants = _root.AllDescendants, CollectionId = _root.CollectionId } },
                Limit = _limit?.count,
                Offset = _offset,
                OrderBy = { _orderings.Select(o => o.ToProto(invertDirection: limitToLast)) },
                EndAt = limitToLast ? InvertCursor(_startAt) : _endAt,
                Select = _projections == null ? null : new Projection { Fields = { _projections.Select(fp => fp.ToFieldReference()) } },
                StartAt = limitToLast ? InvertCursor(_endAt) : _startAt,
                Where = _filters == null ? null
                    : _filters.Filters.Count() == 1 ? _filters.Filters.First().ToProto(_root)
                    : _filters.ToProto(_root)
            };

            Cursor InvertCursor(Cursor cursor) =>
                cursor == null ? null : new Cursor { Before = !cursor.Before, Values = { cursor.Values } };
        }

        /// <summary>
        /// Specifies the field paths to return in the results.
        /// </summary>
        /// <remarks>
        /// This call replaces any previously-specified projections in the query.
        /// </remarks>
        /// <param name="fieldPaths">The dot-separated field paths to select. Must not be null or empty, or contain null or empty
        /// elements.</param>
        /// <returns>A new query based on the current one, but with the specified projection applied.</returns>
        public Query Select(params string[] fieldPaths)
        {
            GaxPreconditions.CheckNotNull(fieldPaths, nameof(fieldPaths));
            // Note: if a null or empty element is passed in, we'll currently throw an exception from FieldPath.FromDotSeparatedString.
            // Not sure whether it's worth reimplementing the checks - and we wouldn't want to do *all* validation...
            FieldPath[] convertedFieldPaths = fieldPaths.Select(FieldPath.FromDotSeparatedString).ToArray();
            return Select(convertedFieldPaths);
        }

        /// <summary>
        /// Specifies the field paths to return in the results.
        /// </summary>
        /// <remarks>
        /// This call replaces any previously-specified projections in the query.
        /// </remarks>
        /// <param name="fieldPaths">The field paths to select. Must not be null or contain null elements.
        /// If this is empty, the document ID is implicitly selected.</param>
        /// <returns>A new query based on the current one, but with the specified projection applied.</returns>
        public Query Select(params FieldPath[] fieldPaths)
        {
            GaxPreconditions.CheckNotNull(fieldPaths, nameof(fieldPaths));
            GaxPreconditions.CheckArgument(!fieldPaths.Contains(null), nameof(fieldPaths), "Field paths must not contain a null element");
            if (fieldPaths.Length == 0)
            {
                fieldPaths = new[] { FieldPath.DocumentId };
            }
            return new Query(_root, _offset, _limit, _orderings, _filters, new List<FieldPath>(fieldPaths), _startAt, _endAt);
        }

        /// <summary>
        /// Returns a query with a filter specifying that the value in <paramref name="fieldPath"/> must be
        /// equal to <paramref name="value"/>.
        /// </summary>
        /// <remarks>
        /// This call adds additional filters to any previously-specified ones.
        /// </remarks>
        /// <param name="fieldPath">The dot-separated field path to filter on. Must not be null or empty.</param>
        /// <param name="value">The value to compare in the filter.</param>
        /// <returns>A new query based on the current one, but with the additional specified filter applied.</returns>
        public Query WhereEqualTo(string fieldPath, object value) =>
            Where(Filter.EqualTo(fieldPath, value));

        /// <summary>
        /// Returns a query with a filter specifying that the value in <paramref name="fieldPath"/> must be
        /// equal to <paramref name="value"/>.
        /// </summary>
        /// <remarks>
        /// This call adds additional filters to any previously-specified ones.
        /// </remarks>
        /// <param name="fieldPath">The field path to filter on. Must not be null.</param>
        /// <param name="value">The value to compare in the filter.</param>
        /// <returns>A new query based on the current one, but with the additional specified filter applied.</returns>
        public Query WhereEqualTo(FieldPath fieldPath, object value) =>
            Where(Filter.EqualTo(fieldPath, value));

        /// <summary>
        /// Returns a query with a filter specifying that the value in <paramref name="fieldPath"/> must not be
        /// equal to <paramref name="value"/>.
        /// </summary>
        /// <remarks>
        /// This call adds additional filters to any previously-specified ones.
        /// </remarks>
        /// <param name="fieldPath">The dot-separated field path to filter on. Must not be null or empty.</param>
        /// <param name="value">The value to compare in the filter.</param>
        /// <returns>A new query based on the current one, but with the additional specified filter applied.</returns>
        public Query WhereNotEqualTo(string fieldPath, object value) =>
            Where(Filter.NotEqualTo(fieldPath, value));

        /// <summary>
        /// Returns a query with a filter specifying that the value in <paramref name="fieldPath"/> must not be
        /// equal to <paramref name="value"/>.
        /// </summary>
        /// <remarks>
        /// This call adds additional filters to any previously-specified ones.
        /// </remarks>
        /// <param name="fieldPath">The field path to filter on. Must not be null.</param>
        /// <param name="value">The value to compare in the filter.</param>
        /// <returns>A new query based on the current one, but with the additional specified filter applied.</returns>
        public Query WhereNotEqualTo(FieldPath fieldPath, object value) =>
            Where(Filter.NotEqualTo(fieldPath, value));

        /// <summary>
        /// Returns a query with a filter specifying that the value in <paramref name="fieldPath"/> must be less than
        /// <paramref name="value"/>.
        /// </summary>
        /// <remarks>
        /// This call adds additional filters to any previously-specified ones.
        /// </remarks>
        /// <param name="fieldPath">The dot-separated field path to filter on. Must not be null or empty.</param>
        /// <param name="value">The value to compare in the filter.</param>
        /// <returns>A new query based on the current one, but with the additional specified filter applied.</returns>
        public Query WhereLessThan(string fieldPath, object value) =>
            Where(Filter.LessThan(fieldPath, value));

        /// <summary>
        /// Returns a query with a filter specifying that the value in <paramref name="fieldPath"/> must be less than
        /// <paramref name="value"/>.
        /// </summary>
        /// <remarks>
        /// This call adds additional filters to any previously-specified ones.
        /// </remarks>
        /// <param name="fieldPath">The field path to filter on. Must not be null.</param>
        /// <param name="value">The value to compare in the filter.</param>
        /// <returns>A new query based on the current one, but with the additional specified filter applied.</returns>
        public Query WhereLessThan(FieldPath fieldPath, object value) =>
            Where(Filter.LessThan(fieldPath, value));

        /// <summary>
        /// Returns a query with a filter specifying that the value in <paramref name="fieldPath"/> must be less than or
        /// equal to <paramref name="value"/>.
        /// </summary>
        /// <remarks>
        /// This call adds additional filters to any previously-specified ones.
        /// </remarks>
        /// <param name="fieldPath">The dot-separated field path to filter on. Must not be null or empty.</param>
        /// <param name="value">The value to compare in the filter.</param>
        /// <returns>A new query based on the current one, but with the additional specified filter applied.</returns>
        public Query WhereLessThanOrEqualTo(string fieldPath, object value) =>
            Where(Filter.LessThanOrEqualTo(fieldPath, value));

        /// <summary>
        /// Returns a query with a filter specifying that the value in <paramref name="fieldPath"/> must be less than or
        /// equal to <paramref name="value"/>.
        /// </summary>
        /// <remarks>
        /// This call adds additional filters to any previously-specified ones.
        /// </remarks>
        /// <param name="fieldPath">The field path to filter on. Must not be null.</param>
        /// <param name="value">The value to compare in the filter.</param>
        /// <returns>A new query based on the current one, but with the additional specified filter applied.</returns>
        public Query WhereLessThanOrEqualTo(FieldPath fieldPath, object value) =>
            Where(Filter.LessThanOrEqualTo(fieldPath, value));

        /// <summary>
        /// Returns a query with a filter specifying that the value in <paramref name="fieldPath"/> must be greater than
        /// <paramref name="value"/>.
        /// </summary>
        /// <remarks>
        /// This call adds additional filters to any previously-specified ones.
        /// </remarks>
        /// <param name="fieldPath">The dot-separated field path to filter on. Must not be null or empty.</param>
        /// <param name="value">The value to compare in the filter.</param>
        /// <returns>A new query based on the current one, but with the additional specified filter applied.</returns>
        public Query WhereGreaterThan(string fieldPath, object value) =>
            Where(Filter.GreaterThan(fieldPath, value));

        /// <summary>
        /// Returns a query with a filter specifying that the value in <paramref name="fieldPath"/> must be greater than
        /// <paramref name="value"/>.
        /// </summary>
        /// <remarks>
        /// This call adds additional filters to any previously-specified ones.
        /// </remarks>
        /// <param name="fieldPath">The field path to filter on. Must not be null.</param>
        /// <param name="value">The value to compare in the filter.</param>
        /// <returns>A new query based on the current one, but with the additional specified filter applied.</returns>
        public Query WhereGreaterThan(FieldPath fieldPath, object value) =>
            Where(Filter.GreaterThan(fieldPath, value));

        /// <summary>
        /// Returns a query with a filter specifying that the value in <paramref name="fieldPath"/> must be greater than or
        /// equal to <paramref name="value"/>.
        /// </summary>
        /// <remarks>
        /// This call adds additional filters to any previously-specified ones.
        /// </remarks>
        /// <param name="fieldPath">The dot-separated field path to filter on. Must not be null or empty.</param>
        /// <param name="value">The value to compare in the filter.</param>
        /// <returns>A new query based on the current one, but with the additional specified filter applied.</returns>
        public Query WhereGreaterThanOrEqualTo(string fieldPath, object value) =>
            Where(Filter.GreaterThanOrEqualTo(fieldPath, value));

        /// <summary>
        /// Returns a query with a filter specifying that the value in <paramref name="fieldPath"/> must be greater than or
        /// equal to <paramref name="value"/>.
        /// </summary>
        /// <remarks>
        /// This call adds additional filters to any previously-specified ones.
        /// </remarks>
        /// <param name="fieldPath">The field path to filter on. Must not be null.</param>
        /// <param name="value">The value to compare in the filter.</param>
        /// <returns>A new query based on the current one, but with the additional specified filter applied.</returns>
        public Query WhereGreaterThanOrEqualTo(FieldPath fieldPath, object value) =>
            Where(Filter.GreaterThanOrEqualTo(fieldPath, value));

        /// <summary>
        /// Returns a query with a filter specifying that the value in <paramref name="fieldPath"/> must be an array containing
        /// <paramref name="value"/>.
        /// </summary>
        /// <remarks>
        /// This call adds additional filters to any previously-specified ones.
        /// </remarks>
        /// <param name="fieldPath">The dot-separated field path to filter on. Must not be null or empty.</param>
        /// <param name="value">The value to check in the filter.</param>
        /// <returns>A new query based on the current one, but with the additional specified filter applied.</returns>
        public Query WhereArrayContains(string fieldPath, object value) =>
            Where(Filter.ArrayContains(fieldPath, value));

        /// <summary>
        /// Returns a query with a filter specifying that the value in <paramref name="fieldPath"/> must be an array containing
        /// <paramref name="value"/>.
        /// </summary>
        /// <remarks>
        /// This call adds additional filters to any previously-specified ones.
        /// </remarks>
        /// <param name="fieldPath">The field path to filter on. Must not be null.</param>
        /// <param name="value">The value to check in the filter.</param>
        /// <returns>A new query based on the current one, but with the additional specified filter applied.</returns>
        public Query WhereArrayContains(FieldPath fieldPath, object value) =>
            Where(Filter.ArrayContains(fieldPath, value));

        /// <summary>
        /// Returns a query with a filter specifying that <paramref name="fieldPath"/> must be
        /// a field present in the document, with a value which is an array containing at least one value in <paramref name="values"/>.
        /// </summary>
        /// <remarks>
        /// This call adds additional filters to any previously-specified ones.
        /// </remarks>
        /// <param name="fieldPath">The dot-separated field path to filter on. Must not be null or empty.</param>
        /// <param name="values">The values to compare in the filter. Must not be null.</param>
        /// <returns>A new query based on the current one, but with the additional specified filter applied.</returns>
        public Query WhereArrayContainsAny(string fieldPath, IEnumerable values) =>
            Where(Filter.ArrayContainsAny(fieldPath, values));

        /// <summary>
        /// Returns a query with a filter specifying that <paramref name="fieldPath"/> must be
        /// a field present in the document, with a value which is an array containing at least one value in <paramref name="values"/>.
        /// </summary>
        /// <remarks>
        /// This call adds additional filters to any previously-specified ones.
        /// </remarks>
        /// <param name="fieldPath">The field path to filter on. Must not be null.</param>
        /// <param name="values">The values to compare in the filter. Must not be null.</param>
        /// <returns>A new query based on the current one, but with the additional specified filter applied.</returns>
        public Query WhereArrayContainsAny(FieldPath fieldPath, IEnumerable values) =>
            Where(Filter.ArrayContainsAny(fieldPath, values));

        /// <summary>
        /// Returns a query with a filter specifying that <paramref name="fieldPath"/> must be
        /// a field present in the document, with a value which is one of the values in <paramref name="values"/>.
        /// </summary>
        /// <remarks>
        /// This call adds additional filters to any previously-specified ones.
        /// </remarks>
        /// <param name="fieldPath">The dot-separated field path to filter on. Must not be null or empty.</param>
        /// <param name="values">The values to compare in the filter. Must not be null.</param>
        /// <returns>A new query based on the current one, but with the additional specified filter applied.</returns>
        public Query WhereIn(string fieldPath, IEnumerable values) =>
            Where(Filter.InArray(fieldPath, values));

        /// <summary>
        /// Returns a query with a filter specifying that <paramref name="fieldPath"/> must be
        /// a field present in the document, with a value which is one of the values in <paramref name="values"/>.
        /// </summary>
        /// <remarks>
        /// This call adds additional filters to any previously-specified ones.
        /// </remarks>
        /// <param name="fieldPath">The field path to filter on. Must not be null.</param>
        /// <param name="values">The values to compare in the filter. Must not be null.</param>
        /// <returns>A new query based on the current one, but with the additional specified filter applied.</returns>
        public Query WhereIn(FieldPath fieldPath, IEnumerable values) =>
            Where(Filter.InArray(fieldPath, values));

        /// <summary>
        /// Returns a query with a filter specifying that <paramref name="fieldPath"/> must be
        /// a field present in the document, with a value which is not one of the values in <paramref name="values"/>.
        /// </summary>
        /// <remarks>
        /// This call adds additional filters to any previously-specified ones.
        /// </remarks>
        /// <param name="fieldPath">The dot-separated field path to filter on. Must not be null or empty.</param>
        /// <param name="values">The values to compare in the filter. Must not be null.</param>
        /// <returns>A new query based on the current one, but with the additional specified filter applied.</returns>
        public Query WhereNotIn(string fieldPath, IEnumerable values) =>
            Where(Filter.NotInArray(fieldPath, values));

        /// <summary>
        /// Returns a query with a filter specifying that <paramref name="fieldPath"/> must be
        /// a field present in the document, with a value which is not one of the values in <paramref name="values"/>.
        /// </summary>
        /// <remarks>
        /// This call adds additional filters to any previously-specified ones.
        /// </remarks>
        /// <param name="fieldPath">The field path to filter on. Must not be null.</param>
        /// <param name="values">The values to compare in the filter. Must not be null.</param>
        /// <returns>A new query based on the current one, but with the additional specified filter applied.</returns>
        public Query WhereNotIn(FieldPath fieldPath, IEnumerable values) =>
            Where(Filter.NotInArray(fieldPath, values));

        /// <summary>
        /// Returns an <see cref="AggregateQuery"/> with count(*) aggregation applied on this query.
        /// </summary>
        /// <returns>An instance of <see cref="AggregateQuery"/> with count(*) aggregation applied.</returns>
        public AggregateQuery Count() =>
            new AggregateQuery(this, new[] { AggregateField.Count() });

        /// <summary>
        /// Calculates the specified aggregations to return the aggregate query. Multiple aggregations can be performed in a single query.
        /// </summary>
        /// <param name="aggregateField">Specifies the <see cref="AggregateField"/> to be calculated. Must not be null.</param>
        /// <param name="aggregateFields">Additional aggregations to be included in the query, if any. Must not be null, but may be empty.</param>
        /// <returns>Returns an <see cref="AggregateQuery" /> that performs aggregations on the documents in the result set of this query.</returns>
        public AggregateQuery Aggregate(AggregateField aggregateField, params AggregateField[] aggregateFields)
        {
            GaxPreconditions.CheckNotNull(aggregateField, nameof(aggregateField));
            GaxPreconditions.CheckNotNull(aggregateFields, nameof(aggregateFields));
            var combined = new List<AggregateField> { aggregateField };
            combined.AddRange(aggregateFields);
            return new AggregateQuery(this, combined);
        }

        /// <summary>
        /// Calculates the specified aggregations to return the aggregate query. Multiple aggregations can be performed in a single query.
        /// </summary>
        /// <param name="aggregateFields">Aggregations to be included in the query. Must not be null, or empty.</param>
        /// <returns>Returns an <see cref="AggregateQuery" /> that performs aggregations on the documents in the result set of this query.</returns>
        public AggregateQuery Aggregate(IEnumerable<AggregateField> aggregateFields)
        {
            GaxPreconditions.CheckNotNull(aggregateFields, nameof(aggregateFields));
            var list = aggregateFields.ToList();
            GaxPreconditions.CheckArgument(list.Count > 0, nameof(aggregateFields), "At least one aggregatation must be provided");
            return new AggregateQuery(this, list);
        }

        /// <summary>
        /// Add the given filter to this query.
        /// </summary>
        /// <remarks>
        /// This call adds additional filters to any previously-specified ones.
        /// </remarks>
        /// <param name="filter">filter to be applied on query, must not be null.</param>
        /// <returns>A new query based on the current one, but with the additional specified filter applied.</returns>
        public Query Where(Filter filter)
        {
            GaxPreconditions.CheckNotNull(filter, nameof(filter));
            filter.ValidateForSentinels(Database.SerializationContext);
            // Check that serialization doesn't throw an exception.
            filter.ToProto(_root);
            var newFilter = (_filters == null) ? new Filter.CompositeFilter(new List<Filter>(), CompositeFilter.Types.Operator.And)
            .WithAdditionalFilter(filter) : _filters.WithAdditionalFilter(filter);
            return new Query(_root, _offset, _limit, _orderings, newFilter,_projections, _startAt, _endAt);
        }

        /// <summary>
        /// Adds an additional ascending ordering by the specified path.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Unlike LINQ's OrderBy method, this call adds additional subordinate orderings to any
        /// additionally specified. So <c>query.OrderBy("foo").OrderBy("bar")</c> is similar
        /// to a LINQ <c>query.OrderBy(x => x.Foo).ThenBy(x => x.Bar)</c>.
        /// </para>
        /// <para>
        /// This method cannot be called after a start/end cursor has been specified with
        /// <see cref="StartAt(object[])"/>, <see cref="StartAfter(object[])"/>, <see cref="EndAt(object[])"/> or <see cref="EndBefore(object[])"/>.
        /// </para>
        /// </remarks>
        /// <param name="fieldPath">The dot-separated field path to order by. Must not be null or empty.</param>
        /// <returns>A new query based on the current one, but with the additional specified ordering applied.</returns>
        public Query OrderBy(string fieldPath) => OrderBy(fieldPath, Direction.Ascending);

        /// <summary>
        /// Adds an additional descending ordering by the specified path.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Unlike LINQ's OrderBy method, this call adds additional subordinate orderings to any
        /// additionally specified. So <c>query.OrderBy("foo").OrderByDescending("bar")</c> is similar
        /// to a LINQ <c>query.OrderBy(x => x.Foo).ThenByDescending(x => x.Bar)</c>.
        /// </para>
        /// <para>
        /// This method cannot be called after a start/end cursor has been specified with
        /// <see cref="StartAt(object[])"/>, <see cref="StartAfter(object[])"/>, <see cref="EndAt(object[])"/> or <see cref="EndBefore(object[])"/>.
        /// </para>
        /// </remarks>
        /// <param name="fieldPath">The dot-separated field path to order by. Must not be null or empty.</param>
        /// <returns>A new query based on the current one, but with the additional specified ordering applied.</returns>
        public Query OrderByDescending(string fieldPath) => OrderBy(fieldPath, Direction.Descending);

        /// <summary>
        /// Adds an additional ascending ordering by the specified path.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Unlike LINQ's OrderBy method, this call adds additional subordinate orderings to any
        /// additionally specified. So <c>query.OrderBy("foo").OrderBy("bar")</c> is similar
        /// to a LINQ <c>query.OrderBy(x => x.Foo).ThenBy(x => x.Bar)</c>.
        /// </para>
        /// <para>
        /// This method cannot be called after a start/end cursor has been specified with
        /// <see cref="StartAt(object[])"/>, <see cref="StartAfter(object[])"/>, <see cref="EndAt(object[])"/> or <see cref="EndBefore(object[])"/>.
        /// </para>
        /// </remarks>
        /// <param name="fieldPath">The field path to order by. Must not be null.</param>
        /// <returns>A new query based on the current one, but with the additional specified ordering applied.</returns>
        public Query OrderBy(FieldPath fieldPath) => OrderBy(GaxPreconditions.CheckNotNull(fieldPath, nameof(fieldPath)), Direction.Ascending);

        /// <summary>
        /// Adds an additional descending ordering by the specified path.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Unlike LINQ's OrderBy method, this call adds additional subordinate orderings to any
        /// additionally specified. So <c>query.OrderBy("foo").OrderByDescending("bar")</c> is similar
        /// to a LINQ <c>query.OrderBy(x => x.Foo).ThenByDescending(x => x.Bar)</c>.
        /// </para>
        /// <para>
        /// This method cannot be called after a start/end cursor has been specified with
        /// <see cref="StartAt(object[])"/>, <see cref="StartAfter(object[])"/>, <see cref="EndAt(object[])"/> or <see cref="EndBefore(object[])"/>.
        /// </para>
        /// </remarks>
        /// <param name="fieldPath">The field path to order by. Must not be null.</param>
        /// <returns>A new query based on the current one, but with the additional specified ordering applied.</returns>
        public Query OrderByDescending(FieldPath fieldPath) => OrderBy(GaxPreconditions.CheckNotNull(fieldPath, nameof(fieldPath)), Direction.Descending);

        private Query OrderBy(string fieldPath, Direction direction)
        {
            GaxPreconditions.CheckNotNullOrEmpty(fieldPath, nameof(fieldPath));
            return OrderBy(FieldPath.FromDotSeparatedString(fieldPath), direction);
        }

        private Query OrderBy(FieldPath fieldPath, Direction direction)
        {
            GaxPreconditions.CheckState(_startAt == null && _endAt == null,
                "All orderings must be specified before StartAt, StartAfter, EndBefore or EndAt are called.");
            var newOrderings = new List<InternalOrdering>(_orderings) { new InternalOrdering(fieldPath, direction) };
            return new Query(_root, _offset, _limit, newOrderings, _filters, _projections, _startAt, _endAt);
        }

        /// <summary>
        /// Specifies the maximum number of results to return.
        /// </summary>
        /// <remarks>
        /// This call replaces any previously-specified limit in the query.
        /// </remarks>
        /// <param name="limit">The maximum number of results to return. Must be greater than or equal to 0.</param>
        /// <returns>A new query based on the current one, but with the specified limit applied.</returns>
        public Query Limit(int limit)
        {
            GaxPreconditions.CheckArgumentRange(limit, nameof(limit), 0, int.MaxValue);
            return new Query(_root, _offset, (limit, LimitType.First), _orderings, _filters, _projections, _startAt, _endAt);
        }

        /// <summary>
        /// Creates and returns a new query that only returns the last <paramref name="limit"/> matching documents.
        /// </summary>
        /// <remarks>
        /// <para>
        /// You must specify at least one <see cref="OrderBy(string)"/> clause for limit-to-last queries. Otherwise,
        /// an <see cref="InvalidOperationException"/> is thrown during execution.
        /// </para>
        /// <para>
        /// Results for limit-to-last queries are only available once all documents are received, which means
        /// that these queries cannot be streamed using the <see cref="StreamAsync(CancellationToken)"/> method.
        /// </para>
        /// </remarks>
        /// <param name="limit">The maximum number of results to return. Must be greater than or equal to 0.</param>
        /// <returns>A new query based on the current one, but with the specified limit applied.</returns>
        public Query LimitToLast(int limit)
        {
            GaxPreconditions.CheckArgumentRange(limit, nameof(limit), 0, int.MaxValue);
            return new Query(_root, _offset, (limit, LimitType.Last), _orderings, _filters, _projections, _startAt, _endAt);
        }

        /// <summary>
        /// Specifies a number of results to skip.
        /// </summary>
        /// <remarks>
        /// This call replaces any previously-specified offset in the query.
        /// </remarks>
        /// <param name="offset">The number of results to skip. Must be greater than or equal to 0.</param>
        /// <returns>A new query based on the current one, but with the specified offset applied.</returns>
        public Query Offset(int offset)
        {
            GaxPreconditions.CheckArgumentRange(offset, nameof(offset), 0, int.MaxValue);
            return new Query(_root, offset, _limit, _orderings, _filters, _projections, _startAt, _endAt);
        }

        /// <summary>
        /// Creates and returns a new query that starts at the provided fields relative to the order of the
        /// query. The order of the field values must match the order of the order-by clauses of the query.
        /// </summary>
        /// <remarks>
        /// This call replaces any previously specified start position in the query.
        /// </remarks>
        /// <param name="fieldValues">The field values. Must not be null or empty, or have more values than query has orderings.</param>
        /// <returns>A new query based on the current one, but with the specified start position.</returns>
        public Query StartAt(params object[] fieldValues) => StartAt(fieldValues, true);

        /// <summary>
        /// Creates and returns a new query that starts after the provided fields relative to the order of the
        /// query. The order of the field values must match the order of the order-by clauses of the query.
        /// </summary>
        /// <remarks>
        /// This call replaces any previously specified start position in the query.
        /// </remarks>
        /// <param name="fieldValues">The field values. Must not be null or empty, or have more values than query has orderings.</param>
        /// <returns>A new query based on the current one, but with the specified start position.</returns>
        public Query StartAfter(params object[] fieldValues) => StartAt(fieldValues, false);

        /// <summary>
        /// Creates and returns a new query that ends before the provided fields relative to the order of the
        /// query. The order of the field values must match the order of the order-by clauses of the query.
        /// </summary>
        /// <remarks>
        /// This call replaces any previously specified end position in the query.
        /// </remarks>
        /// <param name="fieldValues">The field values. Must not be null or empty, or have more values than query has orderings.</param>
        /// <returns>A new query based on the current one, but with the specified end position.</returns>
        public Query EndBefore(params object[] fieldValues) => EndAt(fieldValues, true);

        /// <summary>
        /// Creates and returns a new query that ends at the provided fields relative to the order of the
        /// query. The order of the field values must match the order of the order-by clauses of the query.
        /// </summary>
        /// <remarks>
        /// This call replaces any previously specified end position in the query.
        /// </remarks>
        /// <param name="fieldValues">The field values. Must not be null or empty, or have more values than query has orderings.</param>
        /// <returns>A new query based on the current one, but with the specified end position.</returns>
        public Query EndAt(params object[] fieldValues) => EndAt(fieldValues, false);

        /// <summary>
        /// Creates and returns a new query that starts at the document snapshot provided fields relative to the order of the
        /// query.
        /// </summary>
        /// <remarks>
        /// This call replaces any previously specified start position in the query.
        /// </remarks>
        /// <param name="snapshot">The snapshot of the document to start at. Must not be null.</param>
        /// <returns>A new query based on the current one, but with the specified start position.</returns>
        public Query StartAt(DocumentSnapshot snapshot) => StartAtSnapshot(snapshot, true);

        /// <summary>
        /// Creates and returns a new query that starts after the document snapshot provided fields relative to the order of the
        /// query.
        /// </summary>
        /// <remarks>
        /// This call replaces any previously specified start position in the query.
        /// </remarks>
        /// <param name="snapshot">The snapshot of the document to start after. Must not be null.</param>
        /// <returns>A new query based on the current one, but with the specified start position.</returns>
        public Query StartAfter(DocumentSnapshot snapshot) => StartAtSnapshot(snapshot, false);

        /// <summary>
        /// Creates and returns a new query that ends before the document snapshot provided fields relative to the order of the
        /// query.
        /// </summary>
        /// <remarks>
        /// This call replaces any previously specified end position in the query.
        /// </remarks>
        /// <param name="snapshot">The snapshot of the document to end before. Must not be null.</param>
        /// <returns>A new query based on the current one, but with the specified end position.</returns>
        public Query EndBefore(DocumentSnapshot snapshot) => EndAtSnapshot(snapshot, true);

        /// <summary>
        /// Creates and returns a new query that ends at the document snapshot provided fields relative to the order of the
        /// query.
        /// </summary>
        /// <remarks>
        /// This call replaces any previously specified end position in the query.
        /// </remarks>
        /// <param name="snapshot">The snapshot of the document to end at.</param>
        /// <returns>A new query based on the current one, but with the specified end position.</returns>
        public Query EndAt(DocumentSnapshot snapshot) => EndAtSnapshot(snapshot, false);

        /// <summary>
        /// Asynchronously takes a snapshot of all documents matching the query.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>A snapshot of documents matching the query.</returns>
        public Task<QuerySnapshot> GetSnapshotAsync(CancellationToken cancellationToken = default) => GetSnapshotAsync(null, cancellationToken);

        /// <summary>
        /// Returns an explanation for this query, optionally executing it.
        /// </summary>
        /// <param name="options">The <see cref="ExplainOptions"/> to use. Must not be null.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>A <see cref="PlanSummary"/> for this query.</returns>
        public async Task<ExplainResults<QuerySnapshot>> ExplainAsync(ExplainOptions options, CancellationToken cancellationToken = default)
        {
            GaxPreconditions.CheckNotNull(options, nameof(options));
            return await ExecuteQueryAsync(transactionId: null, options.Proto, cancellationToken).ConfigureAwait(false);
        }

        internal async Task<QuerySnapshot> GetSnapshotAsync(ByteString transactionId, CancellationToken cancellationToken)
        {
            var results = await ExecuteQueryAsync(transactionId, explainOptions: null, cancellationToken).ConfigureAwait(false);
            return results.Snapshot;
        }

        private async Task<ExplainResults<QuerySnapshot>> ExecuteQueryAsync(ByteString transactionId, V1.ExplainOptions explainOptions, CancellationToken cancellationToken)
        {
            var responses = StreamResponsesAsync(transactionId, explainOptions, cancellationToken, allowLimitToLast: true);
            Timestamp? readTime = null;
            List<DocumentSnapshot> snapshots = new List<DocumentSnapshot>();
            ExplainMetrics metrics = null;
            await responses.ForEachAsync(response =>
            {
                if (response.Document != null)
                {
                    snapshots.Add(DocumentSnapshot.ForDocument(Database, response.Document, Timestamp.FromProto(response.ReadTime)));
                }
                if (readTime == null && response.ReadTime != null)
                {
                    readTime = Timestamp.FromProto(response.ReadTime);
                }
                // This will be set on the last response, so we can always just remember "just the last value we saw".
                metrics = response.ExplainMetrics;
            }, cancellationToken).ConfigureAwait(false);

            bool planOnly = explainOptions?.Analyze == false;
            GaxPreconditions.CheckState(readTime is not null || planOnly, "The stream returned from RunQuery did not provide a read timestamp.");
            GaxPreconditions.CheckState(explainOptions is null || metrics is not null, "The stream returned from RunQuery did not provide metrics.");
            if (IsLimitToLast)
            {
                // Reverse in-place. We *could* create an IReadOnlyList<T> which acted as a "reversing view"
                // but that seems like unnecessary work for now.
                snapshots.Reverse();
            }
            var snapshot = planOnly ? null : QuerySnapshot.ForDocuments(this, snapshots.AsReadOnly(), readTime.Value);
            return new ExplainResults<QuerySnapshot>(snapshot, metrics);
        }

        /// <summary>
        /// Creates an <see cref="IComparer{DocumentSnapshot}"/> which will order documents in the same way as the server
        /// does for this query. The returned comparer does *not* handle missing snapshots.
        /// </summary>
        internal IComparer<DocumentSnapshot> CreateDocumentSnapshotComparer() => new DocumentSnapshotComparer(this);

        /// <summary>
        /// Returns an asynchronous sequence of snapshots matching the query.
        /// </summary>
        /// <remarks>
        /// Each time you iterate over the sequence, a new query will be performed.
        /// </remarks>
        /// <param name="cancellationToken">The cancellation token to apply to the streaming operation. Note that even if this is
        /// <see cref="CancellationToken.None"/>, a cancellation token can still be applied when iterating over
        /// the stream, by passing it into <see cref="IAsyncEnumerable{T}.GetAsyncEnumerator(CancellationToken)"/>.
        /// If a cancellation token is passed both to this method and GetAsyncEnumerator,
        /// then cancelling either of the tokens will result in the operation being cancelled.
        /// </param>
        /// <returns>An asynchronous sequence of document snapshots matching the query.</returns>
        public IAsyncEnumerable<DocumentSnapshot> StreamAsync(CancellationToken cancellationToken = default) =>
            StreamAsync(transactionId: null, cancellationToken, false);

        internal IAsyncEnumerable<DocumentSnapshot> StreamAsync(ByteString transactionId, CancellationToken cancellationToken, bool allowLimitToLast) =>
             StreamResponsesAsync(transactionId, null, cancellationToken, allowLimitToLast)
                .Where(resp => resp.Document != null)
                .Select(resp => DocumentSnapshot.ForDocument(Database, resp.Document, Timestamp.FromProto(resp.ReadTime)));

        // Implementation note: this uses an iterator block so that we can dispose of the gRPC call
        // appropriately. The code will only execute when GetEnumerator() is called on the returned value,
        // so the gRPC call *will* be disposed so long as the caller disposes of the iterator (or completes it).
        private async IAsyncEnumerable<RunQueryResponse> StreamResponsesAsync(ByteString transactionId, V1.ExplainOptions explainOptions, [EnumeratorCancellation] CancellationToken cancellationToken, bool allowLimitToLast)
        {
            if (IsLimitToLast && !allowLimitToLast)
            {
                throw new InvalidOperationException($"Cannot stream responses for query using {nameof(LimitToLast)}");
            }
            var request = new RunQueryRequest { StructuredQuery = ToStructuredQuery(), Parent = ParentPath, ExplainOptions = explainOptions };
            if (transactionId != null)
            {
                request.Transaction = transactionId;
            }
            var settings = CallSettings.FromCancellationToken(cancellationToken);
            using var response = Database.Client.RunQuery(request, settings);
            IAsyncEnumerable<RunQueryResponse> stream = response.GetResponseStream();
            await foreach (var result in stream.ConfigureAwait(false))
            {
                yield return result;
            }
        }

        // Helper methods for cursor-related functionality

        internal Query StartAt(object[] fieldValues, bool before) =>
            new Query(_root, _offset, _limit, _orderings, _filters, _projections, CreateCursor(fieldValues, before), _endAt);

        internal Query EndAt(object[] fieldValues, bool before) =>
            new Query(_root, _offset, _limit, _orderings, _filters, _projections, _startAt, CreateCursor(fieldValues, before));

        private Cursor CreateCursor(object[] fieldValues, bool before)
        {
            GaxPreconditions.CheckNotNull(fieldValues, nameof(fieldValues));
            GaxPreconditions.CheckArgument(fieldValues.Length != 0, nameof(fieldValues), "Cannot specify an empty set of values for a start/end query cursor.");
            GaxPreconditions.CheckArgument(
                fieldValues.Length <= _orderings.Count,
                nameof(fieldValues),
                "Too many cursor values specified. The specified values must match the ordering constraints of the query. {0} specified for a query with {1} ordering constraints.",
                fieldValues.Length, _orderings.Count);

            var cursor = new Cursor { Before = before };
            for (int i = 0; i < fieldValues.Length; i++)
            {
                object value = fieldValues[i];
                // The DocumentId field path is handled differently to other fields. We accept a string (relative path) or
                // a DocumentReference (absolute path that must be a descendant of this collection).
                if (Equals(_orderings[i].Field, FieldPath.DocumentId))
                {
                    value = _root.ConvertReference(fieldValues[i], nameof(fieldValues));
                }
                var convertedValue = ValueSerializer.Serialize(Database.SerializationContext, value);
                Filter.ValidateNoSentinelsRecursively(convertedValue, "Snapshot ordering contained a sentinel value");
                cursor.Values.Add(convertedValue);
            }

            return cursor;
        }

        private Query StartAtSnapshot(DocumentSnapshot snapshot, bool before)
        {
            var cursor = CreateCursorFromSnapshot(snapshot, before, out var newOrderings);
            return new Query(_root, _offset, _limit, newOrderings, _filters, _projections, cursor, _endAt);
        }

        private Query EndAtSnapshot(DocumentSnapshot snapshot, bool before)
        {
            var cursor = CreateCursorFromSnapshot(snapshot, before, out var newOrderings);
            return new Query(_root, _offset, _limit, newOrderings, _filters, _projections, _startAt, cursor);
        }

        private Cursor CreateCursorFromSnapshot(DocumentSnapshot snapshot, bool before, out IReadOnlyList<InternalOrdering> newOrderings)
        {
            // For non-collection-group queries, the snapshot must be in the exact right collection.
            if (!_root.AllDescendants)
            {
                CollectionReference snapshotCollection = snapshot.Reference.Parent;
                GaxPreconditions.CheckArgument(snapshotCollection.Id == _root.CollectionId,
                    nameof(snapshot), "Snapshot was from incorrect collection");
                var snapshotGrandparentPath = snapshotCollection.Parent?.Path ?? _root.Database.DocumentsPath;
                GaxPreconditions.CheckArgument(snapshotGrandparentPath == ParentPath,
                    nameof(snapshot), "Snapshot was from incorrect collection");
            }

            GaxPreconditions.CheckNotNull(snapshot, nameof(snapshot));
            var cursor = new Cursor { Before = before };
            bool hasDocumentId = false;

            // We may or may not need to add some orderings; this is communicated through the out parameter.
            newOrderings = _orderings;
            // Only used when we need to add orderings; set newOrderings to this at the same time.
            List<InternalOrdering> modifiedOrderings = null;
            var orderingFilter = Filter.GetOrderingFilter(_filters);
            if (_orderings.Count == 0 && orderingFilter != null)
            {
                // If no explicit ordering is specified, use the first ordering filter to define an implicit order.
                modifiedOrderings = new List<InternalOrdering>(newOrderings) { new InternalOrdering(orderingFilter.Field, Direction.Ascending) };
                newOrderings = modifiedOrderings;
            }
            else
            {
                hasDocumentId = _orderings.Any(order => Equals(order.Field, FieldPath.DocumentId));
            }

            if (!hasDocumentId)
            {
                // Add implicit sorting by name, using the last specified direction.
                Direction lastDirection = _orderings.Count == 0 ? Direction.Ascending : _orderings.Last().Direction;

                // Clone iff this is the first new ordering.
                if (modifiedOrderings == null)
                {
                    modifiedOrderings = new List<InternalOrdering>(newOrderings);
                    newOrderings = modifiedOrderings;
                }
                modifiedOrderings.Add(new InternalOrdering(FieldPath.DocumentId, lastDirection));
            }

            foreach (var ordering in newOrderings)
            {
                var field = ordering.Field;
                var value = Equals(field, FieldPath.DocumentId) ? ValueSerializer.Serialize(Database.SerializationContext, snapshot.Reference) : snapshot.ExtractValue(field);
                if (value == null)
                {
                    throw new ArgumentException($"Snapshot does not contain field {field}", nameof(snapshot));
                }
                cursor.Values.Add(ValueSerializer.Serialize(Database.SerializationContext, value));
            }
            return cursor;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as Query);

        // Note: these methods should be equivalent to producing the proto representations and checking those for
        // equality, but that would be expensive.

        /// <summary>
        /// Compares this query with another for equality. Every aspect of the query must be equal,
        /// including the collection. A plain Query instance is not equal to a CollectionReference instance,
        /// even if they are logically similar: <c>collection.Offset(0).Equals(collection)</c> will return
        /// <c>false</c>, even though 0 is the default offset.
        /// </summary>
        /// <param name="other">The query to compare this one with</param>
        /// <returns><c>true</c> if this query is equal to <paramref name="other"/>; <c>false</c> otherwise.</returns>
        public bool Equals(Query other)
        {
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (other is null)
            {
                return false;
            }
            if (GetType() != other.GetType())
            {
                return false;
            }
            return _root.Equals(other._root) &&
                _offset == other._offset &&
                _limit == other._limit &&
                GaxEqualityHelpers.ListsEqual(_orderings, other._orderings) &&
                FiltersEqual() &&
                GaxEqualityHelpers.ListsEqual(_projections, other._projections) &&
                Equals(_startAt, other._startAt) &&
                Equals(_endAt, other._endAt);

            bool FiltersEqual()
            {
                if (ReferenceEquals(_filters, other._filters))
                {
                    return true;
                }
                if (_filters is null || other._filters is null)
                {
                    return false;
                }

                // Note: we don't use _filters.Equals as we want to normalize
                // to the serialized form for compatibility.
                return _filters.ToProto(_root).Equals(other._filters.ToProto(other._root));
            }
        }

        /// <inheritdoc />
        public override int GetHashCode() => GaxEqualityHelpers.CombineHashCodes(
            _root.GetHashCode(),
            _offset,
            _limit?.GetHashCode() ?? -1,
            GaxEqualityHelpers.GetListHashCode(_orderings),
            // Note: we don't use _filters.GetHashCode as we want to normalize
            // to the serialized form for compatibility.
            _filters?.ToProto(_root).GetHashCode() ?? -1,
            GaxEqualityHelpers.GetListHashCode(_projections),
            _startAt?.GetHashCode() ?? -1,
            _endAt?.GetHashCode() ?? -1);

        /// <summary>
        /// Listen to this query for changes.
        /// </summary>
        /// <param name="callback">The callback to invoke each time the query results change. Must not be null.</param>
        /// <param name="cancellationToken">Optional cancellation token which may be used to cancel the listening operation.</param>
        /// <returns>A <see cref="FirestoreChangeListener"/> which may be used to monitor the listening operation and stop it gracefully.</returns>
        public FirestoreChangeListener Listen(Func<QuerySnapshot, CancellationToken, Task> callback, CancellationToken cancellationToken = default)
        {
            GaxPreconditions.CheckNotNull(callback, nameof(callback));
            var target = WatchStream.CreateTarget(this);
            var stream = new WatchStream(new WatchState(this, callback), target, Database, cancellationToken);
            return FirestoreChangeListener.Start(stream);
        }

        /// <summary>
        /// Listen to this query for changes. This method is a convenience method over <see cref="Listen(Func{QuerySnapshot, CancellationToken, Task}, CancellationToken)"/>,
        /// wrapping a synchronous callback to create an asynchronous one.
        /// </summary>
        /// <param name="callback">The callback to invoke each time the query results change. Must not be null.</param>
        /// <param name="cancellationToken">Optional cancellation token which may be used to cancel the listening operation.</param>
        /// <returns>A <see cref="FirestoreChangeListener"/> which may be used to monitor the listening operation and stop it gracefully.</returns>
        public FirestoreChangeListener Listen(Action<QuerySnapshot> callback, CancellationToken cancellationToken = default)
        {
            GaxPreconditions.CheckNotNull(callback, nameof(callback));
            return Listen((snapshot, _) => { callback(snapshot); return Task.FromResult(0); }, cancellationToken);
        }

        // Structs representing orderings and filters but using FieldPath instead of FieldReference.
        // This allows us to use fields specified in the ordering/filter in this more convenient form.

        private struct InternalOrdering : IEquatable<InternalOrdering>
        {
            internal FieldPath Field { get; }
            internal Direction Direction { get; }
            internal Direction InverseDirection =>
                Direction switch
                {
                    Direction.Ascending  => Direction.Descending,
                    Direction.Descending => Direction.Ascending,
                    _ => throw new InvalidOperationException($"Can't invert direction {Direction}")
                };

            internal Order ToProto(bool invertDirection) => new Order { Direction = invertDirection ? InverseDirection : Direction, Field = Field.ToFieldReference() };

            public override int GetHashCode() => GaxEqualityHelpers.CombineHashCodes(Field.GetHashCode(), (int) Direction);

            internal InternalOrdering(FieldPath field, Direction direction)
            {
                Field = field;
                Direction = direction;
            }

            public override bool Equals(object obj) => obj is InternalOrdering other ? Equals(other) : false;

            public bool Equals(InternalOrdering other) => Field.Equals(other.Field) && Direction == other.Direction;
        }


        private sealed class DocumentSnapshotComparer : IComparer<DocumentSnapshot>
        {
            private readonly Query _query;

            internal DocumentSnapshotComparer(Query query) => _query = query;

            public int Compare(DocumentSnapshot x, DocumentSnapshot y)
            {
                GaxPreconditions.CheckArgument(x.Exists, nameof(x), "Document snapshot comparer for a query cannot be used with snapshots of missing documents");
                GaxPreconditions.CheckArgument(y.Exists, nameof(y), "Document snapshot comparer for a query cannot be used with snapshots of missing documents");

                Direction lastDirection = Direction.Ascending;
                foreach (var ordering in _query._orderings)
                {
                    lastDirection = ordering.Direction;
                    int fieldResult;
                    if (Equals(ordering.Field, FieldPath.DocumentId))
                    {
                        fieldResult = x.Reference.CompareTo(y.Reference);
                    }
                    else
                    {
                        var xValue = x.ExtractValue(ordering.Field);
                        var yValue = y.ExtractValue(ordering.Field);
                        if (xValue == null || yValue == null)
                        {
                            throw new InvalidOperationException("Can only compare fields that exist in the DocumentSnapshot."
                                + " Please include the fields you are ordering on in your Select() call.");
                        }
                        fieldResult = ValueComparer.Instance.Compare(xValue, yValue);
                    }
                    if (fieldResult != 0)
                    {
                        return lastDirection == Direction.Ascending ? fieldResult : -Math.Sign(fieldResult);
                    }
                }

                // Everything is equal in the specified orderings.
                // Compare by name, using the last-specified ordering, defaulting to ascending.
                int result = x.Reference.CompareTo(y.Reference);
                if (lastDirection == Direction.Descending)
                {
                    result = -Math.Sign(result);
                }
                return result;
            }
        }

        internal sealed class QueryRoot : IEquatable<QueryRoot>
        {
            internal FirestoreDb Database { get; }
            internal string ParentPath { get; }
            internal string CollectionId { get; }
            internal bool AllDescendants { get; }

            private QueryRoot(FirestoreDb database, string parentPath, string collectionId, bool allDescendants)
            {
                Database = GaxPreconditions.CheckNotNull(database, nameof(database));
                ParentPath = parentPath;
                CollectionId = GaxPreconditions.CheckNotNull(collectionId, nameof(collectionId));
                AllDescendants = allDescendants;
            }

            internal static QueryRoot ForCollection(FirestoreDb database, DocumentReference parent, string collectionId) =>
                new QueryRoot(database, parent?.Path ?? database?.DocumentsPath, collectionId, false);

            internal static QueryRoot ForCollectionGroup(FirestoreDb database, string collectionId) =>
                new QueryRoot(database, database?.DocumentsPath, collectionId, true);

            internal DocumentReference ConvertReference(object fieldValue, string parameterName)
            {
                string basePath = AllDescendants ? ParentPath : $"{ParentPath}/{CollectionId}";
                var reference = fieldValue switch
                {
                    string relativePath => Database.GetDocumentReferenceFromResourceName($"{basePath}/{relativePath}"),
                    DocumentReference absoluteRef => absoluteRef,
                    _ => throw new ArgumentException($"The corresponding value for a document ID must be a string (relative path) or a DocumentReference", parameterName),
                };
                GaxPreconditions.CheckArgument(
                    reference.Path.StartsWith(basePath + "/"),
                    parameterName,
                    "'{0}' is not part of the query result set and cannot be used as a query boundary",
                    reference.Path);

                GaxPreconditions.CheckArgument(
                    AllDescendants || reference.Parent.Path == basePath,
                    parameterName,
                    "Only a direct child can be used as a query boundary. Found: '{0}'",
                    reference.Path);
                return reference;
            }

            public override bool Equals(object obj) => Equals(obj as QueryRoot);

            public bool Equals(QueryRoot other) =>
                other != null &&
                Database.Equals(other.Database) &&
                ParentPath == other.ParentPath &&
                CollectionId == other.CollectionId &&
                AllDescendants == other.AllDescendants;

            public override int GetHashCode() =>
                GaxEqualityHelpers.CombineHashCodes(Database.GetHashCode(), ParentPath.GetHashCode(), CollectionId?.GetHashCode() ?? 0, AllDescendants ? 1 : 0);
        }

        private enum LimitType
        {
            First,
            Last
        }
    }
}
