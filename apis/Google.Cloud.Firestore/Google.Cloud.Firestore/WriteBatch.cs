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
using Google.Cloud.Firestore.V1;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static Google.Cloud.Firestore.V1.DocumentTransform.Types;
using static Google.Cloud.Firestore.V1.DocumentTransform.Types.FieldTransform.Types;

namespace Google.Cloud.Firestore
{
    /// <summary>
    /// A batch of write operations, to be applied in a single commit.
    /// </summary>
    public sealed class WriteBatch
    {
        private static readonly IReadOnlyList<FieldPath> s_emptyFieldPathList = new List<FieldPath>().AsReadOnly();

        private readonly FirestoreDb _db;

        internal bool IsEmpty => Elements.Count == 0;

        // Visible for testing and for this class; should not be used elsewhere in the production code.
        internal List<BatchElement> Elements { get; } = new List<BatchElement>();

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
            var fields = ValueSerializer.SerializeMap(documentReference.Database.SerializationContext, documentData);
            var sentinels = FindSentinels(fields);
            GaxPreconditions.CheckArgument(!sentinels.Any(sf => sf.IsDelete), nameof(documentData), "Delete sentinels cannot appear in Create calls");
            RemoveSentinels(fields, sentinels);
            // Force a write if we've not got any sentinel values. Otherwise, we end up with an empty transform instead,
            // just to specify the precondition.
            AddUpdateWrites(documentReference, fields, s_emptyFieldPathList, Precondition.MustNotExist, sentinels, sentinels.Count == 0, false);
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
            Elements.Add(new BatchElement(write, true)); // No sentinel values to worry about here; always a single write
            return this;
        }

        /// <summary>
        /// Adds an update operation that updates just the specified fields paths in the document, with the corresponding values.
        /// </summary>
        /// <param name="documentReference">A document reference indicating the path of the document to update. Must not be null.</param>
        /// <param name="updates">The updates to perform on the document, keyed by the dot-separated field path to update. Fields not present in this dictionary are not updated. Must not be null or empty.</param>
        /// <param name="precondition">Optional precondition for updating the document. May be null, which is equivalent to <see cref="Precondition.MustExist"/>.</param>
        /// <returns>This batch, for the purposes of method chaining.</returns>
        public WriteBatch Update(DocumentReference documentReference, IDictionary<string, object> updates, Precondition precondition = null)
        {
            GaxPreconditions.CheckNotNull(updates, nameof(updates));
            return Update(documentReference, updates.ToDictionary(pair => FieldPath.FromDotSeparatedString(pair.Key), pair => pair.Value), precondition);
        }

        /// <summary>
        /// Adds an update operation that updates just the specified field in the document, with the corresponding values.
        /// </summary>
        /// <param name="documentReference">A document reference indicating the path of the document to update. Must not be null.</param>
        /// <param name="field">The dot-separated name of the field to update. Must not be null.</param>
        /// <param name="value">The new value for the field. May be null.</param>
        /// <param name="precondition">Optional precondition for updating the document. May be null, which is equivalent to <see cref="Precondition.MustExist"/>.</param>
        /// <returns>This batch, for the purposes of method chaining.</returns>
        public WriteBatch Update(DocumentReference documentReference, string field, object value, Precondition precondition = null)
        {
            GaxPreconditions.CheckNotNull(field, nameof(field));
            return Update(documentReference, new Dictionary<string, object> { { field, value } }, precondition);
        }

        /// <summary>
        /// Adds an update operation that updates just the specified fields paths in the document, with the corresponding values.
        /// </summary>
        /// <param name="documentReference">A document reference indicating the path of the document to update. Must not be null.</param>
        /// <param name="updates">The updates to perform on the document, keyed by the field path to update. Fields not present in this dictionary are not updated. Must not be null or empty.</param>
        /// <param name="precondition">Optional precondition for updating the document. May be null, which is equivalent to <see cref="Precondition.MustExist"/>.</param>
        /// <returns>This batch, for the purposes of method chaining.</returns>
        public WriteBatch Update(DocumentReference documentReference, IDictionary<FieldPath, object> updates, Precondition precondition = null)
        {
            GaxPreconditions.CheckNotNull(documentReference, nameof(documentReference));
            GaxPreconditions.CheckNotNull(updates, nameof(updates));
            GaxPreconditions.CheckArgument(updates.Count != 0, nameof(updates), "Empty set of updates specified");
            GaxPreconditions.CheckArgument(precondition?.Exists != true, nameof(precondition), "Cannot specify a must-exist precondition for update");

            var serializedUpdates = updates.ToDictionary(pair => pair.Key, pair => ValueSerializer.Serialize(documentReference.Database.SerializationContext, pair.Value));
            var expanded = ExpandObject(serializedUpdates);


            var sentinels = FindSentinels(expanded);

            // This effectively validates that a delete wasn't part of a map. It could still be a multi-segment field path, but it can't be within something else.
            var deletePaths = sentinels.Where(sf => sf.IsDelete).Select(sf => sf.FieldPath);
            GaxPreconditions.CheckArgument(deletePaths.All(fp => updates.ContainsKey(fp)), nameof(updates), "Deletes cannot be nested within update calls");
            RemoveSentinels(expanded, sentinels);

            var nonDeletes = sentinels.Where(sf => !sf.IsDelete).ToList();
            AddUpdateWrites(documentReference, expanded, updates.Keys.ToList(), precondition ?? Precondition.MustExist, nonDeletes, false, false);
            return this;
        }

        /// <summary>
        /// Adds an operation that sets data in a document, either replacing it completely or merging fields.
        /// </summary>
        /// <param name="documentReference">A document reference indicating the path of the document to update. Must not be null.</param>
        /// <param name="documentData">The data to store in the document. Must not be null.</param>
        /// <param name="options">The options to use when setting data in the document. May be null, which is equivalent to <see cref="SetOptions.Overwrite"/>.</param>
        /// <returns>This batch, for the purposes of method chaining.</returns>
        public WriteBatch Set(DocumentReference documentReference, object documentData, SetOptions options = null)
        {
            GaxPreconditions.CheckNotNull(documentReference, nameof(documentReference));
            GaxPreconditions.CheckNotNull(documentData, nameof(documentData));

            var fields = ValueSerializer.SerializeMap(documentReference.Database.SerializationContext, documentData);
            options = options ?? SetOptions.Overwrite;
            var sentinels = FindSentinels(fields);
            var deletes = sentinels.Where(sf => sf.IsDelete).ToList();
            var nonDeletes = sentinels.Where(sf => !sf.IsDelete).ToList();

            bool forceWrite = false;
            IDictionary<FieldPath, Value> updates;
            IReadOnlyList<FieldPath> updatePaths;
            if (options.Merge)
            {
                var mask = options.FieldMask;
                if (mask.Count == 0)
                {
                    // Merge all:
                    // - If the data is empty, we force a write
                    // - Deletes are allowed anywhere
                    // - All timestamps converted to transforms
                    // - Each top-level entry becomes a FieldPath
                    forceWrite = fields.Count == 0;
                    RemoveSentinels(fields, nonDeletes);
                    // Work out the update paths after removing server timestamps but before removing deletes,
                    // so that we correctly perform the deletes.
                    updatePaths = ExtractDocumentMask(fields);
                    RemoveSentinels(fields, deletes);
                    updates = fields.ToDictionary(pair => new FieldPath(pair.Key), pair => pair.Value);
                }
                else
                {
                    // Merge specific:
                    // - Deletes must be in the mask
                    // - Only timestamps in the mask are converted to transforms
                    // - Apply the field mask to get the updates
                    GaxPreconditions.CheckArgument(deletes.All(sf => mask.Contains(sf.FieldPath)), nameof(documentData), "Delete cannot appear in an unmerged field");
                    nonDeletes = nonDeletes.Where(sf => mask.Any(fp => fp.IsPrefixOf(sf.FieldPath))).ToList();
                    RemoveSentinels(fields, deletes);
                    RemoveSentinels(fields, nonDeletes);
                    updates = ApplyFieldMask(fields, mask);
                    // Every field path in the mask must either refer to a now-removed sentinel, or a remaining value.
                    // Sentinels are permitted to be in the mask in a nested fashion rather than directly, e.g. a mask of "parent" with a sentinel of "parent.child.timestamp" is fine.
                    GaxPreconditions.CheckArgument(
                        mask.All(p => updates.ContainsKey(p) ||
                        deletes.Any(sf => p.IsPrefixOf(sf.FieldPath)) ||
                        nonDeletes.Any(sf => p.IsPrefixOf(sf.FieldPath))),
                        nameof(documentData), "All paths specified for merging must appear in the data.");
                    updatePaths = mask;
                }
            }
            else
            {
                // Overwrite:
                // - No deletes allowed
                // - All timestamps converted to transforms
                // - Each top-level entry becomes a FieldPath
                GaxPreconditions.CheckArgument(deletes.Count == 0, nameof(documentData), "Delete cannot appear in document data when overwriting");
                RemoveSentinels(fields, nonDeletes);
                updates = fields.ToDictionary(pair => new FieldPath(pair.Key), pair => pair.Value);
                updatePaths = s_emptyFieldPathList;
                forceWrite = true;
            }

            AddUpdateWrites(documentReference, ExpandObject(updates), updatePaths, null, nonDeletes, forceWrite, options.Merge);
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
            var request = new CommitRequest { Database = _db.RootPath, Writes = { Elements.Select(e => e.Write) }, Transaction = transactionId };
            var response = await _db.Client.CommitAsync(request, CallSettings.FromCancellationToken(cancellationToken)).ConfigureAwait(false);
            return response.WriteResults
                // Only include write results from appropriate elements
                .Where((wr, index) => Elements[index].IncludeInWriteResults)
                .Select(wr => WriteResult.FromProto(wr, response.CommitTime))
                .ToList();
        }

        private void AddUpdateWrites(
            DocumentReference documentReference,
            IDictionary<string, Value> fields,
            IReadOnlyList<FieldPath> updatePaths,
            Precondition precondition,
            IList<SentinelField> sentinelFields,
            bool forceWrite,
            bool includeEmptyUpdatePath)
        {
            updatePaths = updatePaths.Except(sentinelFields.Select(sf => sf.FieldPath)).ToList();
            bool includeTransformInWriteResults = true;
            if (forceWrite || fields.Count > 0 || updatePaths.Count > 0)
            {
                Elements.Add(new BatchElement(new Write
                {
                    CurrentDocument = precondition?.Proto,
                    Update = new Document
                    {
                        Fields = { fields },
                        Name = documentReference.Path,
                    },
                    UpdateMask = includeEmptyUpdatePath || updatePaths.Count > 0 ? new DocumentMask { FieldPaths = { updatePaths.Select(fp => fp.EncodedPath) } } : null
                }, true));
                includeTransformInWriteResults = false;
                // Don't include the precondition in the Transform write, if there is one.
                precondition = null;
            }
            if (sentinelFields.Count > 0)
            {
                Elements.Add(new BatchElement(new Write
                {
                    CurrentDocument = precondition?.Proto,
                    Transform = new DocumentTransform
                    {
                        Document = documentReference.Path,
                        FieldTransforms = { sentinelFields.Select(p => p.ToFieldTransform()) }
                    }
                }, includeTransformInWriteResults));
            }
        }

        /// <summary>
        /// Finds all the sentinel values in a field map.
        /// Additionally, this validates that no sentinels exist in arrays (even nested).
        /// </summary>
        /// <param name="fields">The field map to find sentinels within.</param>
        /// <returns>The sentinel fields in the field map: both the value and the corresponding field path.</returns>
        private static List<SentinelField> FindSentinels(IDictionary<string, Value> fields)
        {
            List<SentinelField> result = new List<SentinelField>();
            FindSentinelsRecursively(fields, FieldPath.Empty);
            return result;

            void FindSentinelsRecursively(IDictionary<string, Value> currentFields, FieldPath currentParentPath)
            {
                foreach (var pair in currentFields)
                {
                    Value value = pair.Value;
                    string key = pair.Key;
                    SentinelKind sentinelKind = SentinelValue.GetKind(value);
                    if (sentinelKind != SentinelKind.None)
                    {
                        result.Add(new SentinelField(currentParentPath.Append(key), value));
                    }
                    else if (value.MapValue != null)
                    {
                        FindSentinelsRecursively(value.MapValue.Fields, currentParentPath.Append(pair.Key));
                    }
                    else if (value.ArrayValue != null)
                    {
                        ValidateNoSentinelValues(value.ArrayValue.Values);
                    }
                }
            }

            void ValidateNoSentinelValues(IEnumerable<Value> values)
            {
                foreach (var value in values)
                {
                    if (SentinelValue.GetKind(value) != SentinelKind.None)
                    {
                        // We don't know what parameter name to use here
                        throw new ArgumentException("Sentinel values must not appear directly or indirectly within array values");
                    }
                    else if (value.MapValue != null)
                    {
                        ValidateNoSentinelValues(value.MapValue.Fields.Values);
                    }
                    else if (value.ArrayValue != null)
                    {
                        ValidateNoSentinelValues(value.ArrayValue.Values);
                    }
                }
            }
        }

        /// <summary>
        /// Removes the specified sentinel paths from the given field map. Any maps which were non-empty but become empty due to this are
        /// removed along the way.
        /// </summary>
        /// <returns>true iff the map was non-empty before, but is now empty (i.e. removing the sentinels has removed all data)</returns>
        private static bool RemoveSentinels(IDictionary<string, Value> fields, IEnumerable<SentinelField> sentinelFields)
        {
            // Keep track of whether the set of paths was empty of not while only iterating once.
            bool anyPaths = false;

            foreach (var sentinelField in sentinelFields)
            {
                anyPaths = true;
                RemoveSentinel(fields, sentinelField.FieldPath, 0);
            }
            // If we don't have any fields left and we removed anything, we must have removed
            // everything.
            return fields.Count == 0 && anyPaths;

            bool RemoveSentinel(IDictionary<string, Value> currentFields, FieldPath path, int segmentIndex)
            {
                string segment = path.Segments[segmentIndex];
                // We can remove this segment if either it's the leaf (the sentinel itself) or
                // the recursive call indicates that we've removed all the descendants.
                var removeSegment = segmentIndex == path.Segments.Length - 1 ||
                    RemoveSentinel(currentFields[segment].MapValue.Fields, path, segmentIndex + 1);
                if (removeSegment)
                {
                    currentFields.Remove(segment);
                }
                return currentFields.Count == 0;
            }
        }        

        // Visible for testing
        /// <summary>
        /// Turns a field map that contains field paths into a nested map, such that each key in the response only has a single segment.
        /// For example, { "a.b": "c" } is converted into { "a": { "b": "c" } }
        /// ... assuming that a.b is a field path with two segments "a" and "b", rather than a single segment of "a.b".
        /// </summary>
        /// <remarks>
        /// Precondition (checked in method): dictionary keys do not contain any mutual prefixes.
        /// </remarks>
        internal static IDictionary<string, Value> ExpandObject(IDictionary<FieldPath, Value> data)
        {
            ValidateNoPrefixes(data.Keys);
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
                        currentMap[segments[i]] = value;
                    }
                    else
                    {
                        // Anything *not* at the end of the path needs to be a map. Create one if we haven't already got
                        // an entry for this path, or use the existing one. The precondition on mutual prefixes ensures
                        // that we'll never see a non-map value here.
                        if (!currentMap.TryGetValue(segments[i], out var newMap))
                        {
                            newMap = new Value { MapValue = new MapValue() };
                            currentMap[segments[i]] = newMap;
                        }
                        currentMap = newMap.MapValue.Fields;
                    }
                }
            }

            return result;            
        }

        // Visible for testing
        /// <summary>
        /// Applies a field mask to the specified dictionary of values, returning a set of fields limited to the given field mask.
        /// </summary>
        /// <param name="fields">The field/value map.</param>
        /// <param name="fieldMask">The field mask to apply.</param>
        /// <returns>A filtered view of fields.</returns>
        internal static Dictionary<FieldPath, Value> ApplyFieldMask(IDictionary<string, Value> fields, IEnumerable<FieldPath> fieldMask)
        {
            var result = new Dictionary<FieldPath, Value>();
            var fieldPathSet = new HashSet<FieldPath>(fieldMask);
            ApplyFieldMaskImpl(fields, FieldPath.Empty);
            return result;

            void ApplyFieldMaskImpl(IDictionary<string, Value> currentFields, FieldPath parentPath)
            {
                foreach (var pair in currentFields)
                {
                    FieldPath childPath = parentPath.Append(pair.Key);
                    if (fieldPathSet.Contains(childPath))
                    {
                        result[childPath] = pair.Value;
                    }
                    else if (pair.Value.MapValue != null)
                    {
                        // Even if the whole field isn't in the mask, a nested field might be. Recurse, populating the same result dictionary.
                        ApplyFieldMaskImpl(pair.Value.MapValue.Fields, childPath);                        
                    }
                }
            }
        }

        // Visible for testing
        /// <summary>
        /// Returns all a list of all the field paths to non-map values within a set of values.
        /// An empty map value does not create any entries.
        /// </summary>
        internal static IReadOnlyList<FieldPath> ExtractDocumentMask(IDictionary<string, Value> fields)
        {
            var result = new List<FieldPath>();
            AppendDocumentMask(fields, FieldPath.Empty);
            return result;

            void AppendDocumentMask(IDictionary<string, Value> currentFields, FieldPath parentPath)
            {
                foreach (var pair in currentFields)
                {
                    var childPath = parentPath.Append(pair.Key);
                    if (pair.Value.MapValue != null)
                    {
                        AppendDocumentMask(pair.Value.MapValue.Fields, childPath);
                    }
                    else
                    {
                        result.Add(childPath);
                    }
                }
            }
        }

        // Visible for testing
        /// <summary>
        /// Validates that the given set of paths contains no paths p1, p2 such that p1.IsPrefixOf(p2) is true.
        /// </summary>
        internal static void ValidateNoPrefixes(IEnumerable<FieldPath> paths)
        {
            // It's very convenient that the escaping rules and character ordering means that
            // performing a lexicographic sort by encoded path means we only need to check adjacent values.
            var ordered = paths.OrderBy(p => p.EncodedPath, StringComparer.Ordinal).ToList();
            for (int i = 0; i < ordered.Count - 1; i++)
            {
                FieldPath current = ordered[i];
                FieldPath next = ordered[i + 1];
                if (current.IsPrefixOf(next))
                {
                    throw new ArgumentException($"{current} is a prefix of {next}. Prefixes must not be specified in updates.");
                }
            }
        }

        // Part of the batch: the write, and whether or not the corresponding WriteResult
        // should be returned from CommitAsync.
        internal struct BatchElement
        {
            internal Write Write { get; }
            internal bool IncludeInWriteResults { get; }

            internal BatchElement(Write write, bool includeInWriteResults)
            {
                Write = write;
                IncludeInWriteResults = includeInWriteResults;
            }
        }

        /// <summary>
        /// A sentinel field value detected within a document.
        /// </summary>
        internal struct SentinelField
        {
            internal FieldPath FieldPath { get; }
            internal Value Value { get; }
            internal SentinelKind Kind => SentinelValue.GetKind(Value);
            internal bool IsDelete => Kind == SentinelKind.Delete;

            internal SentinelField(FieldPath fieldPath, Value value)
            {
                FieldPath = fieldPath;
                Value = value;
            }

            internal FieldTransform ToFieldTransform()
            {
                var transform = new FieldTransform { FieldPath = FieldPath.EncodedPath };
                switch (Kind)
                {
                    case SentinelKind.ServerTimestamp:
                        transform.SetToServerValue = ServerValue.RequestTime;
                        break;
                    case SentinelKind.ArrayRemove:
                        transform.RemoveAllFromArray = SentinelValue.GetArrayValue(Value);
                        break;
                    case SentinelKind.ArrayUnion:
                        transform.AppendMissingElements = SentinelValue.GetArrayValue(Value);
                        break;
                    case SentinelKind.NumericIncrement:
                        transform.Increment = SentinelValue.GetIncrement(Value);
                        break;
                    default:
                        throw new InvalidOperationException($"Cannot convert sentinel value of kind {Kind} to field transform");
                }
                return transform;
            }
        }
    }
}
