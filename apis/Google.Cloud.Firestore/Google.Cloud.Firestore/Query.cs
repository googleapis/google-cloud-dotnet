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
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static Google.Cloud.Firestore.V1.StructuredQuery.Types;
using FieldOp = Google.Cloud.Firestore.V1.StructuredQuery.Types.FieldFilter.Types.Operator;
using UnaryOp = Google.Cloud.Firestore.V1.StructuredQuery.Types.UnaryFilter.Types.Operator;

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
        private readonly int? _limit;
        private readonly IReadOnlyList<InternalOrdering> _orderings; // Never null
        private readonly IReadOnlyList<InternalFilter> _filters; // May be null
        private readonly IReadOnlyList<FieldPath> _projections; // May be null
        private readonly Cursor _startAt;
        private readonly Cursor _endAt;
        private readonly QueryRoot _root;

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
            int offset, int? limit,
            IReadOnlyList<InternalOrdering> orderings, IReadOnlyList<InternalFilter> filters, IReadOnlyList<FieldPath> projections,
            Cursor startAt, Cursor endAt)
        {
            _root = root;
            _offset = offset;
            _limit = limit;
            _orderings = orderings;
            _filters = filters;
            _projections = projections;
            _startAt = startAt;
            _endAt = endAt;
        }

        internal static Query ForCollectionGroup(FirestoreDb database, string collectionId) =>
            new Query(QueryRoot.ForCollectionGroup(database, collectionId));

        internal StructuredQuery ToStructuredQuery() =>
            new StructuredQuery
            {
                From = { new CollectionSelector { AllDescendants = _root.AllDescendants, CollectionId = _root.CollectionId } },
                Limit = _limit,
                Offset = _offset,
                OrderBy = { _orderings.Select(o => o.ToProto()) },
                EndAt = _endAt,
                Select = _projections == null ? null : new Projection { Fields = { _projections.Select(fp => fp.ToFieldReference()) } },
                StartAt = _startAt,
                Where = _filters == null ? null
                    : _filters.Count == 1 ? _filters[0].ToProto()
                    : new Filter { CompositeFilter = new CompositeFilter { Op = CompositeFilter.Types.Operator.And, Filters = { _filters.Select(f => f.ToProto()) } } }
            };

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
            Where(fieldPath, FieldOp.Equal, value);

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
            Where(fieldPath, FieldOp.Equal, value);

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
            Where(fieldPath, FieldOp.LessThan, value);

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
            Where(fieldPath, FieldOp.LessThan, value);

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
            Where(fieldPath, FieldOp.LessThanOrEqual, value);

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
            Where(fieldPath, FieldOp.LessThanOrEqual, value);

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
            Where(fieldPath, FieldOp.GreaterThan, value);

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
            Where(fieldPath, FieldOp.GreaterThan, value);

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
            Where(fieldPath, FieldOp.GreaterThanOrEqual, value);

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
            Where(fieldPath, FieldOp.GreaterThanOrEqual, value);

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
            Where(fieldPath, FieldOp.ArrayContains, value);

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
            Where(fieldPath, FieldOp.ArrayContains, value);

        // Note: the two general Where methods were originally public, accepting a public QueryOperator enum.
        // If we ever want to make them public again, we should reinstate the QueryOperator enum to avoid an API
        // dependency on the proto enum.

        /// <summary>
        /// Add a filter for the given field path.
        /// </summary>
        /// <remarks>
        /// This call adds additional filters to any previously-specified ones.
        /// </remarks>
        /// <param name="fieldPath">The dot-separated field path to filter on. Must not be null or empty.</param>
        /// <param name="op">The filter operator. Must not be null.</param>
        /// <param name="value">The value to compare in the filter.</param>
        /// <returns>A new query based on the current one, but with the additional specified filter applied.</returns>
        private Query Where(string fieldPath, FieldOp op, object value)
        {
            GaxPreconditions.CheckNotNullOrEmpty(fieldPath, nameof(fieldPath));
            return Where(FieldPath.FromDotSeparatedString(fieldPath), op, value);
        }

        /// <summary>
        /// Add a filter for the given field path.
        /// </summary>
        /// <remarks>
        /// This call adds additional filters to any previously-specified ones.
        /// </remarks>
        /// <param name="fieldPath">The field path to filter on. Must not be null.</param>
        /// <param name="op">The filter operator.</param>
        /// <param name="value">The value to compare in the filter. Must not be a sentinel value.</param>
        /// <returns>A new query based on the current one, but with the additional specified filter applied.</returns>
        private Query Where(FieldPath fieldPath, FieldOp op, object value)
        {
            InternalFilter filter = InternalFilter.Create(Database.SerializationContext, fieldPath, op, value);
            var newFilters = _filters == null ? new List<InternalFilter>() : new List<InternalFilter>(_filters);
            newFilters.Add(filter);
            return new Query(_root, _offset, _limit, _orderings, newFilters, _projections, _startAt, _endAt);
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
            return new Query(_root, _offset, limit, _orderings, _filters, _projections, _startAt, _endAt);
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

        internal async Task<QuerySnapshot> GetSnapshotAsync(ByteString transactionId, CancellationToken cancellationToken)
        {
            var responses = StreamResponsesAsync(transactionId, cancellationToken);
            Timestamp? readTime = null;
            List<DocumentSnapshot> snapshots = new List<DocumentSnapshot>();
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
            }, cancellationToken).ConfigureAwait(false);

            GaxPreconditions.CheckState(readTime != null, "The stream returned from RunQuery did not provide a read timestamp.");

            return QuerySnapshot.ForDocuments(this, snapshots.AsReadOnly(), readTime.Value);
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
            StreamAsync(transactionId: null, cancellationToken);

        internal IAsyncEnumerable<DocumentSnapshot> StreamAsync(ByteString transactionId, CancellationToken cancellationToken) =>
             StreamResponsesAsync(transactionId, cancellationToken)
                .Where(resp => resp.Document != null)
                .Select(resp => DocumentSnapshot.ForDocument(Database, resp.Document, Timestamp.FromProto(resp.ReadTime)));

        private IAsyncEnumerable<RunQueryResponse> StreamResponsesAsync(ByteString transactionId, CancellationToken cancellationToken)
        {
            var request = new RunQueryRequest { StructuredQuery = ToStructuredQuery(), Parent = ParentPath };
            if (transactionId != null)
            {
                request.Transaction = transactionId;
            }
            var settings = CallSettings.FromCancellationToken(cancellationToken);
            return Database.Client.RunQuery(request, settings).GetResponseStream();
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
                    value = ConvertReference(fieldValues[i], nameof(fieldValues));
                }
                var convertedValue = ValueSerializer.Serialize(Database.SerializationContext, value);
                ValidateNoSentinelsRecursively(convertedValue, "Snapshot ordering contained a sentinel value");
                cursor.Values.Add(convertedValue);
            }

            return cursor;
        }

        private DocumentReference ConvertReference(object fieldValue, string parameterName)
        {
            string basePath = _root.AllDescendants ? ParentPath : $"{ParentPath}/{_root.CollectionId}";
            DocumentReference reference;
            switch (fieldValue)
            {
                case string relativePath:
                    reference = Database.GetDocumentReferenceFromResourceName($"{basePath}/{relativePath}");
                    break;
                case DocumentReference absoluteRef:
                    reference = absoluteRef;
                    break;
                default:
                    throw new ArgumentException($"A cursor value for a document ID must be a string (relative path) or a DocumentReference", parameterName);
            }
            GaxPreconditions.CheckArgument(
                reference.Path.StartsWith(basePath + "/"),
                parameterName,
                "'{0}' is not part of the query result set and cannot be used as a query boundary",
                reference.Path);

            GaxPreconditions.CheckArgument(
                _root.AllDescendants || reference.Parent.Path == basePath,
                parameterName,
                "Only a direct child can be used as a query boundary. Found: '{0}'",
                reference.Path);
            return reference;
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

            if (_orderings.Count == 0 && _filters != null)
            {
                // If no explicit ordering is specified, use the first inequality to define an implicit order.
                foreach (var filter in _filters)
                {
                    if (!filter.IsEqualityFilter())
                    {
                        modifiedOrderings = new List<InternalOrdering>(newOrderings) { new InternalOrdering(filter.Field, Direction.Ascending) };
                        newOrderings = modifiedOrderings;
                    }
                }
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
            if (ReferenceEquals(other, null))
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
                EqualityHelpers.ListsEqual(_orderings, other._orderings) &&
                EqualityHelpers.ListsEqual(_filters, other._filters) &&
                EqualityHelpers.ListsEqual(_projections, other._projections) &&
                Equals(_startAt, other._startAt) &&
                Equals(_endAt, other._endAt);
        }

        /// <inheritdoc />
        public override int GetHashCode() => EqualityHelpers.CombineHashCodes(
            _root.GetHashCode(),
            _offset,
            _limit ?? -1,
            EqualityHelpers.GetListHashCode(_orderings),
            EqualityHelpers.GetListHashCode(_filters),
            EqualityHelpers.GetListHashCode(_projections),
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

        /// <summary>
        /// Convenience method to validate that a serialized value doesn't contain any sentinels.
        /// Throws an ArgumentException with the given message if it does contain a sentinel.
        /// </summary>
        private static void ValidateNoSentinelsRecursively(Value value, string message)
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

        // Structs representing orderings and filters but using FieldPath instead of FieldReference.
        // This allows us to use fields specified in the ordering/filter in this more convenient form.

        private struct InternalOrdering : IEquatable<InternalOrdering>
        {
            internal FieldPath Field { get; }
            internal Direction Direction { get; }
            internal Order ToProto() => new Order { Direction = Direction, Field = Field.ToFieldReference() };

            public override int GetHashCode() => EqualityHelpers.CombineHashCodes(Field.GetHashCode(), (int) Direction);

            internal InternalOrdering(FieldPath field, Direction direction)
            {
                Field = field;
                Direction = direction;
            }

            public override bool Equals(object obj) => obj is InternalOrdering other ? Equals(other) : false;

            public bool Equals(InternalOrdering other) => Field.Equals(other.Field) && Direction == other.Direction;
        }

        private struct InternalFilter : IEquatable<InternalFilter>
        {
            internal FieldPath Field { get; }
            // The integer value of either the UnaryOp or FieldOp, depending on whether _value is null.
            private readonly int _op;
            // The value for a field (binary) operator, or null for a unary operator
            private readonly Value _value;

            internal Filter ToProto() =>
                _value == null
                ? new Filter { UnaryFilter = new UnaryFilter { Field = Field.ToFieldReference(), Op = (UnaryOp) _op } }
                : new Filter { FieldFilter = new FieldFilter { Field = Field.ToFieldReference(), Op = (FieldOp) _op, Value = _value } };

            private InternalFilter(FieldPath field, int op, Value value)
            {
                Field = field;
                _op = op;
                _value = value;
            }

            /// <summary>
            /// Checks whether this is an equality operator. Unary filters are always equality operators, and field filters can be.
            /// </summary>
            internal bool IsEqualityFilter() => _value == null || _op == (int) FieldOp.Equal || _op == (int) FieldOp.ArrayContains;

            internal static InternalFilter Create(SerializationContext context, FieldPath fieldPath, FieldOp op, object value)
            {
                GaxPreconditions.CheckNotNull(fieldPath, nameof(fieldPath));
                var unaryOperator = GetUnaryOperator(value);
                if (unaryOperator != UnaryOp.Unspecified)
                {
                    if (op == FieldOp.Equal)
                    {
                        return new InternalFilter(fieldPath, (int) unaryOperator, null);
                    }
                    else
                    {
                        throw new ArgumentException(nameof(value), "null and NaN values can only be used with the Equal operator");
                    }
                }
                else
                {
                    var convertedValue = ValueSerializer.Serialize(context, value);
                    ValidateNoSentinelsRecursively(convertedValue, "Sentinel values cannot be specified in filters");
                    return new InternalFilter(fieldPath, (int) op, convertedValue);
                }
            }

            private static UnaryOp GetUnaryOperator(object value)
            {
                switch (value)
                {
                    case null:
                        return UnaryOp.IsNull;
                    case double d when double.IsNaN(d):
                    case float f when float.IsNaN(f):
                        return UnaryOp.IsNan;
                    default:
                        return UnaryOp.Unspecified;
                }
            }

            public override bool Equals(object obj) => obj is InternalFilter other ? Equals(other) : false;

            public bool Equals(InternalFilter other) =>
                Field.Equals(other.Field) && _op == other._op && Equals(_value, other._value);

            public override int GetHashCode() =>
                EqualityHelpers.CombineHashCodes(Field.GetHashCode(), _op, _value?.GetHashCode() ?? -1);
        }

        private sealed class DocumentSnapshotComparer : IComparer<DocumentSnapshot>
        {
            private readonly Query _query;

            internal DocumentSnapshotComparer(Query query) => _query = query;

            public int Compare(DocumentSnapshot x, DocumentSnapshot y)
            {
                GaxPreconditions.CheckArgument(x.Exists, nameof(x), "Document snapshot comparer for a query cannot be used with snapshots of missing documents");
                GaxPreconditions.CheckArgument(y.Exists, nameof(y), "Document snapshot comparer for a query cannot be used with snapshots of missing documents");
                var orderings = _query._orderings;

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

        private sealed class QueryRoot : IEquatable<QueryRoot>
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

            public override bool Equals(object obj) => Equals(obj as QueryRoot);

            public bool Equals(QueryRoot other) =>
                other != null &&
                Database.Equals(other.Database) &&
                ParentPath == other.ParentPath &&
                CollectionId == other.CollectionId &&
                AllDescendants == other.AllDescendants;

            public override int GetHashCode() =>
                EqualityHelpers.CombineHashCodes(Database.GetHashCode(), ParentPath.GetHashCode(), CollectionId?.GetHashCode() ?? 0, AllDescendants ? 1 : 0);
        }
    }
}
