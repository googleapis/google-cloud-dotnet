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
using Google.Cloud.Firestore.V1Beta1;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static Google.Cloud.Firestore.V1Beta1.StructuredQuery.Types;
using FieldOp = Google.Cloud.Firestore.V1Beta1.StructuredQuery.Types.FieldFilter.Types.Operator;

namespace Google.Cloud.Firestore
{
    /// <summary>
    /// A query against a collection.
    /// </summary>
    /// <remarks>
    /// <see cref="CollectionReference"/> derives from this class as a "return-all" query against the
    /// collection it refers to.
    /// </remarks>
    public class Query
    {
        /// <summary>
        /// The database this query will search over.
        /// </summary>
        public FirestoreDb Database { get; }

        // Visible for testing
        internal StructuredQuery QueryProto { get; }

        internal CollectionReference Collection { get; }

        // Parent path of this query
        internal string ParentPath => Collection.Parent?.Path ?? Database.DocumentsPath;

        // This would be protected, but that would allow subclasses from other assemblies. The intention is that the only concrete
        // subclass of Query is CollectionReference. If "private protected" ever ends up in C#, this constructor can be changed.
        internal Query(FirestoreDb database, string id)
        {
            Collection = this as CollectionReference;
            GaxPreconditions.CheckState(Collection != null, "Internal Query constructor should only be used from CollectionReference");
            Database = GaxPreconditions.CheckNotNull(database, nameof(database));
            GaxPreconditions.CheckNotNull(id, nameof(id));
            QueryProto = new StructuredQuery { From = { new CollectionSelector { CollectionId = id } } };
        }

        private Query(FirestoreDb database, StructuredQuery query, CollectionReference collection)
        {
            Database = database;
            QueryProto = query;
            Collection = collection;
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
            return Select(ConvertFieldPaths(fieldPaths));
        }

        /// <summary>
        /// Specifies the field paths to return in the results.
        /// </summary>
        /// <remarks>
        /// This call replaces any previously-specified projections in the query.
        /// </remarks>
        /// <param name="fieldPaths">The field paths to select. Must not be null or empty, or contain null elements.</param>
        /// <returns>A new query based on the current one, but with the specified projection applied.</returns>
        public Query Select(params FieldPath[] fieldPaths)
        {
            GaxPreconditions.CheckNotNull(fieldPaths, nameof(fieldPaths));
            GaxPreconditions.CheckArgument(fieldPaths.Length != 0, nameof(fieldPaths), "Projection must specify at least one field");
            GaxPreconditions.CheckArgument(!fieldPaths.Contains(null), nameof(fieldPaths), "Field paths must not contain a null element");
            var query = QueryProto.Clone();
            query.Select = new Projection { Fields = { fieldPaths.Select(fp => fp.ToFieldReference()) } };
            return WithQuery(query);
        }

        // TODO: Choices...
        // - Use an enum instead of strings?
        // - Rename the "op" parameter? (operator is a keyword, but we could make it @operator maybe)
        // - Rename "Where" to "AddFilter"?
        // - Reimplement as individual methods, two per filter operator (accepting string or FieldPath),
        //   e.g. WhereEqual, WhereLess than etc

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
        public Query Where(string fieldPath, QueryOperator op, object value)
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
        /// <param name="value">The value to compare in the filter.</param>
        /// <returns>A new query based on the current one, but with the additional specified filter applied.</returns>
        public Query Where(FieldPath fieldPath, QueryOperator op, object value)
        {
            FieldOp queryOp = GetOperator(op);
            var unaryOperator = GetUnaryOperator(value);
            Filter filter;
            if (unaryOperator != UnaryFilter.Types.Operator.Unspecified)
            {
                if (queryOp == FieldOp.Equal)
                {
                    filter = new Filter { UnaryFilter = new UnaryFilter { Field = fieldPath.ToFieldReference(), Op = unaryOperator } };
                }
                else
                {
                    throw new ArgumentException(nameof(value), "null and NaN values can only be used with the Equal operator");
                }
            }
            else
            {
                var convertedValue = ValueSerializer.Serialize(value);
                filter = new Filter { FieldFilter = new FieldFilter { Field = fieldPath.ToFieldReference(), Op = queryOp, Value = convertedValue } };
            }
            return WithFilter(filter);
        }

        private FieldOp GetOperator(QueryOperator op
)
        {
            switch (op)
            {
                case QueryOperator.Equal: return FieldOp.Equal;
                case QueryOperator.LessThan: return FieldOp.LessThan;
                case QueryOperator.LessThanOrEqual: return FieldOp.LessThanOrEqual;
                case QueryOperator.GreaterThan: return FieldOp.GreaterThan;
                case QueryOperator.GreaterThanOrEqual: return FieldOp.GreaterThanOrEqual;
                default:
                    throw new ArgumentException($"No operator for {op}", nameof(op));
            }
        }

        private static UnaryFilter.Types.Operator GetUnaryOperator(object value)
        {
            switch (value)
            {
                case null:
                    return UnaryFilter.Types.Operator.IsNull;
                case double d when double.IsNaN(d):
                case float f when float.IsNaN(f):
                    return UnaryFilter.Types.Operator.IsNan;
                default:
                    return UnaryFilter.Types.Operator.Unspecified;
            }
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
        /// <see cref="StartAt"/>, <see cref="StartAfter(object[])"/>, <see cref="EndAt(object[])"/> or <see cref="EndBefore(object[])"/>.
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
        /// <see cref="StartAt"/>, <see cref="StartAfter(object[])"/>, <see cref="EndAt(object[])"/> or <see cref="EndBefore(object[])"/>.
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
        /// <see cref="StartAt"/>, <see cref="StartAfter(object[])"/>, <see cref="EndAt(object[])"/> or <see cref="EndBefore(object[])"/>.
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
        /// <see cref="StartAt"/>, <see cref="StartAfter(object[])"/>, <see cref="EndAt(object[])"/> or <see cref="EndBefore(object[])"/>.
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
            GaxPreconditions.CheckState(QueryProto.StartAt == null && QueryProto.EndAt == null,
                "All orderings must be specified before StartAt, StartAfter, EndBefore or EndAt are called.");
            var query = QueryProto.Clone();
            query.OrderBy.Add(new Order { Field = fieldPath.ToFieldReference(), Direction = direction });
            return WithQuery(query);
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
            var query = QueryProto.Clone();
            query.Limit = limit;
            return WithQuery(query);
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
            var query = QueryProto.Clone();
            query.Offset = offset;
            return WithQuery(query);
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
        public Query StartAt(params object[] fieldValues)
        {
            var query = QueryProto.Clone();
            query.StartAt = CreateCursor(fieldValues, true);
            return WithQuery(query);
        }

        /// <summary>
        /// Creates and returns a new query that starts after the provided fields relative to the order of the
        /// query. The order of the field values must match the order of the order-by clauses of the query.
        /// </summary>
        /// <remarks>
        /// This call replaces any previously specified start position in the query.
        /// </remarks>
        /// <param name="fieldValues">The field values. Must not be null or empty, or have more values than query has orderings.</param>
        /// <returns>A new query based on the current one, but with the specified start position.</returns>
        public Query StartAfter(params object[] fieldValues)
        {
            var query = QueryProto.Clone();
            query.StartAt = CreateCursor(fieldValues, false);
            return WithQuery(query);
        }

        /// <summary>
        /// Creates and returns a new query that ends before the provided fields relative to the order of the
        /// query. The order of the field values must match the order of the order-by clauses of the query.
        /// </summary>
        /// <remarks>
        /// This call replaces any previously specified end position in the query.
        /// </remarks>
        /// <param name="fieldValues">The field values. Must not be null or empty, or have more values than query has orderings.</param>
        /// <returns>A new query based on the current one, but with the specified end position.</returns>
        public Query EndBefore(params object[] fieldValues)
        {
            var query = QueryProto.Clone();
            query.EndAt = CreateCursor(fieldValues, true);
            return WithQuery(query);
        }

        /// <summary>
        /// Creates and returns a new query that ends at the provided fields relative to the order of the
        /// query. The order of the field values must match the order of the order-by clauses of the query.
        /// </summary>
        /// <remarks>
        /// This call replaces any previously specified end position in the query.
        /// </remarks>
        /// <param name="fieldValues">The field values. Must not be null or empty, or have more values than query has orderings.</param>
        /// <returns>A new query based on the current one, but with the specified end position.</returns>
        public Query EndAt(params object[] fieldValues)
        {
            var query = QueryProto.Clone();
            query.EndAt = CreateCursor(fieldValues, false);
            return WithQuery(query);
        }

        private Cursor CreateCursor(object[] fieldValues, bool before)
        {
            GaxPreconditions.CheckNotNull(fieldValues, nameof(fieldValues));
            GaxPreconditions.CheckArgument(fieldValues.Length != 0, nameof(fieldValues), "Cannot specify an empty set of values for a start/end query cursor.");
            GaxPreconditions.CheckArgument(
                fieldValues.Length <= QueryProto.OrderBy.Count,
                nameof(fieldValues),
                "Too many cursor values specified. The specified values must match the ordering constraints of the query. {0} specified for a query with {1} ordering constraints.",
                fieldValues.Length, QueryProto.OrderBy.Count);

            var cursor = new Cursor { Before = before };
            for (int i = 0; i < fieldValues.Length; i++)
            {
                object value = fieldValues[i];
                // The DocumentId field path is handled differently to other fields. We accept a string (relative path) or
                // a DocumentReference (absolute path that must be a descendant of this collection).
                if (QueryProto.OrderBy[i].Field.FieldPath == FieldPath.DocumentId.EncodedPath)
                {
                    switch (fieldValues[i])
                    {
                        case string relativePath:
                            // Note: this assumes querying over a single collection at the moment.
                            // Convert to a DocumentReference for the cursor
                            PathUtilities.ValidateId(relativePath, nameof(fieldValues));
                            value = Collection.Document(relativePath);
                            break;
                        case DocumentReference absoluteRef:
                            // Just validate that the given document is a direct child of the parent collection.
                            GaxPreconditions.CheckArgument(absoluteRef.Parent.Equals(Collection), nameof(fieldValues),
                                "A DocumentReference cursor value for a document ID must be a descendant of the collection of the query");
                            break;
                        default:
                            throw new ArgumentException($"A cursor value for a document ID must be a string (relative path) or a DocumentReference", nameof(fieldValues));
                    }
                }
                cursor.Values.Add(ValueSerializer.Serialize(value));
            }

            return cursor;
        }

        private static FieldPath[] ConvertFieldPaths(string[] fieldPaths)
        {
            GaxPreconditions.CheckNotNull(fieldPaths, nameof(fieldPaths));
            // Note: if a null or empty element is passed in, we'll currently throw an exception from FieldPath.FromDotSeparatedString.
            // Not sure whether it's worth reimplementing the checks - and we wouldn't want to do *all* validation...
            return fieldPaths.Select(FieldPath.FromDotSeparatedString).ToArray();
        }

        private Query WithFilter(Filter filter)
        {
            var query = QueryProto.Clone();
            if (query.Where == null)
            {
                query.Where = filter;
            }
            else if (query.Where.FilterTypeCase == Filter.FilterTypeOneofCase.CompositeFilter)
            {
                query.Where.CompositeFilter.Filters.Add(filter);
            }
            else
            {
                query.Where = new Filter { CompositeFilter = new CompositeFilter { Op = CompositeFilter.Types.Operator.And, Filters = { query.Where, filter } } };
            }
            return WithQuery(query);
        }

        private Query WithQuery(StructuredQuery query) => new Query(Database, query, Collection);

        /// <summary>
        /// Asynchronously takes a snapshot of all documents matching the query.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>A snapshot of documents matching the query.</returns>
        public Task<QuerySnapshot> SnapshotAsync(CancellationToken cancellationToken = default) => SnapshotAsync(null, cancellationToken);

        internal async Task<QuerySnapshot> SnapshotAsync(ByteString transactionId, CancellationToken cancellationToken)
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

            return new QuerySnapshot(this, snapshots.AsReadOnly(), readTime.Value);
        }

        /// <summary>
        /// Returns an asynchronous sequence of snapshots matching the query.
        /// </summary>
        /// <remarks>
        /// Each time you iterate over the sequence, a new query will be performed.
        /// </remarks>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>An asynchronous sequence of document snapshots matching the query.</returns>
        public IAsyncEnumerable<DocumentSnapshot> StreamAsync(CancellationToken cancellationToken = default) => StreamAsync(null, cancellationToken);

        internal IAsyncEnumerable<DocumentSnapshot> StreamAsync(ByteString transactionId, CancellationToken cancellationToken) =>
             StreamResponsesAsync(transactionId, cancellationToken)
                .Where(resp => resp.Document != null)
                .Select(resp => DocumentSnapshot.ForDocument(Database, resp.Document, Timestamp.FromProto(resp.ReadTime)));

        private IAsyncEnumerable<RunQueryResponse> StreamResponsesAsync(ByteString transactionId, CancellationToken cancellationToken)
        {
            var request = new RunQueryRequest { StructuredQuery = QueryProto, Parent = ParentPath };
            if (transactionId != null)
            {
                request.Transaction = transactionId;
            }
            var settings = CallSettings.FromCancellationToken(cancellationToken);
            return AsyncEnumerable.CreateEnumerable(() => Database.Client.RunQuery(request, settings).ResponseStream);
        }
    }
}
