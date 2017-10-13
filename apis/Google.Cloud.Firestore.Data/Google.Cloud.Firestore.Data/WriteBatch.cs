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
// limitations under the License.using System;

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Cloud.Firestore.V1Beta1;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Firestore.Data
{
    // TODO: Sentinel fields on all operations

    /// <summary>
    /// A batch of write operations, to be applied in a single commit.
    /// </summary>
    public sealed class WriteBatch
    {
        private readonly FirestoreDb _db;

        internal bool IsEmpty => Writes.Count == 0;

        // Visible for testing; should not be used elsewhere in the production code.
        internal List<Write> Writes = new List<Write>();

        internal WriteBatch(FirestoreDb firestoreDb)
        {
            _db = firestoreDb;
        }

        /// <summary>
        /// Adds a write operation which will create the specified document with a precondition
        /// that it doesn't exist already.
        /// </summary>
        /// <param name="documentReference">A document reference indicating the path of the document to create. Must not be null.</param>
        /// <param name="documentData">The data for the document. Must not be null.</param>
        /// <returns>This batch, for the purpose of method chaining</returns>
        public WriteBatch Create(DocumentReference documentReference, object documentData)
        {
            GaxPreconditions.CheckNotNull(documentReference, nameof(documentReference));
            GaxPreconditions.CheckNotNull(documentData, nameof(documentData));
            var write = new Write
            {
                CurrentDocument = Precondition.MustNotExist.Proto,
                Update = new Document
                {
                    Fields = { ValueSerializer.SerializeMap(documentData) },
                    Name = documentReference.Path
                }
            };
            Writes.Add(write);

            return this;
        }

        /// <summary>
        /// Adds a write operation that deletes the specified document, with an optional precondition.
        /// </summary>
        /// <param name="documentReference">A document reference indicating the path of the document to delete. Must not be null.</param>
        /// <param name="precondition">Optional precondition for deletion. May be null, in which case the deletion is unconditional.</param>
        /// <returns>This batch, for the purposes of method chaining.</returns>
        public WriteBatch Delete(DocumentReference documentReference, Precondition precondition = null)
        {
            GaxPreconditions.CheckNotNull(documentReference, nameof(documentReference));
            var write = new Write
            {
                CurrentDocument = precondition?.Proto,
                Delete = documentReference.Path
            };
            Writes.Add(write);
            return this;
        }

        /// <summary>
        /// Adds an update operation that updates just the specified fields paths in the document, with the corresponding values.
        /// </summary>
        /// <param name="documentReference">A document reference indicating the path of the document to update. Must not be null.</param>
        /// <param name="updates">The updates to perform on the document, keyed by the field path to update. Fields not present in this dictionary are not updated. Must not be null.</param>
        /// <param name="precondition">Optional precondition for updating the document. May be null, which is equivalent to <see cref="Precondition.MustExist"/>.</param>
        /// <returns>This batch, for the purposes of method chaining.</returns>
        public WriteBatch Update(DocumentReference documentReference, IDictionary<FieldPath, object> updates, Precondition precondition = null)
        {
            var serializedUpdates = updates.ToDictionary(pair => pair.Key, pair => ValueSerializer.Serialize(pair.Value));
            var deconstructed = ExpandObject(serializedUpdates);

            // TODO: Validate that the precondition is reasonable (i.e. not "MustNotExist")?
            var write = new Write
            {
                CurrentDocument = (precondition ?? Precondition.MustExist).Proto,
                Update = new Document
                {
                    Fields = { deconstructed },
                    Name = documentReference.Path,
                },
                UpdateMask = new DocumentMask { FieldPaths = { serializedUpdates.Keys.Select(fp => fp.EncodedPath) } }
            };
            Writes.Add(write);

            return this;
        }

        /// <summary>
        /// Commits the batch on the server.
        /// </summary>
        /// <returns>The write results from the commit.</returns>
        public Task<IList<WriteResult>> CommitAsync(CancellationToken cancellationToken = default) =>
            CommitAsync(ByteString.Empty, cancellationToken);

        internal async Task<IList<WriteResult>> CommitAsync(ByteString transactionId, CancellationToken cancellationToken)
        {
            var request = new CommitRequest { Database = _db.RootPath, Writes = { Writes }, Transaction = transactionId };
            var response = await _db.Client.CommitAsync(request, CallSettings.FromCancellationToken(cancellationToken)).ConfigureAwait(false);
            return response.WriteResults.Select(wr => WriteResult.FromProto(wr, response.CommitTime)).ToList();
        }

        // Visible for testing
        /// <summary>
        /// Turns a field map that contains field paths into a nested map, such that each key in the response only has a single segment.
        /// For example, { "a.b": "c" } is converted into { "a": { "b": "c" } }
        /// ... assuming that a.b is a field path with two segments "a" and "b", rather than a single segment of "a.b".
        /// </summary>
        internal static IDictionary<string, Value> ExpandObject(IDictionary<FieldPath, Value> data)
        {
            var result = new Dictionary<string, Value>();
            foreach (var pair in data)
            {
                var segments = pair.Key.Segments;
                var value = pair.Value;

                IDictionary<string, Value> currentMap = result;
                for (int i = 0; i < segments.Length; i++)
                {
                    // The end of any path is just a value. However, if it's a map, we might be modifying it with another value,
                    // so we need to clone it - we don't want to modify the original data. (In fact it *may* be okay to do so,
                    // but it's harder to reason about.)
                    if (i == segments.Length - 1)
                    {                        
                        if (value.MapValue != null)
                        {
                            value = value.Clone();
                        }
                        if (currentMap.TryGetValue(segments[i], out var currentValue))
                        {
                            GaxPreconditions.CheckState(currentValue.MapValue != null && value.MapValue != null,
                                "Attempt to merge values where at least one is not a map; path={0} (segment {1})", pair.Key, segments[i]);
                            MergeMaps(value.MapValue, currentValue.MapValue);
                        }
                        else
                        {
                            currentMap[segments[i]] = value;
                        }
                    }
                    else
                    {
                        // Anything *not* at the end of the path needs to be a map. Create one if we haven't already got
                        // an entry for this path, or use the existing one.
                        if (!currentMap.TryGetValue(segments[i], out var newMap))
                        {
                            newMap = new Value { MapValue = new MapValue() };
                            currentMap[segments[i]] = newMap;
                        }
                        else
                        {
                            GaxPreconditions.CheckState(newMap.MapValue != null, "Non-map value exists in path {0} (segment {1})", pair.Key, segments[i]);
                        }
                        currentMap = newMap.MapValue.Fields;
                    }
                }
            }

            return result;

            void MergeMaps(MapValue source, MapValue destination)
            {
                foreach (var pair in source.Fields)
                {
                    if (destination.Fields.TryGetValue(pair.Key, out var currentValue))
                    {
                        // Merge further map fields, but nothing else.
                        GaxPreconditions.CheckState(pair.Value.MapValue != null && currentValue.MapValue != null,
                            "Cannot merge map elements which aren't further maps");
                        MergeMaps(pair.Value.MapValue, currentValue.MapValue);
                    }
                    else
                    {
                        destination.Fields.Add(pair.Key, pair.Value);
                    }
                }
            }
        }
    }
}
