// Copyright 2019, Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;

namespace Google.Cloud.Firestore;

/// <summary>
/// Provides context for deserialization operations, used to obtain appropriate converters
/// and populate data in custom types decorated with attributes such as
/// <see cref="FirestoreDocumentCreateTimestampAttribute"/>.
/// </summary>
/// <remarks>
/// This is primarily used for deserializing document snapshots (or parts of them), but
/// may be used in non-document situations, such as deserializing aspects of an
/// <see cref="AggregateQuerySnapshot"/>. Properties which make no sense in a particular context
/// (e.g. <see cref="UpdateTime"/> for an aggregate snapshot) should throw
/// <see cref="InvalidOperationException"/> to indicate that deserialization has been misconfigured.
/// </remarks>
internal interface IDeserializationContext
{
    /// <summary>
    /// The database containing the document being deserialized. This is never null.
    /// </summary>
    FirestoreDb Database { get; }

    /// <summary>
    /// The document being deserialized. This is never null.
    /// </summary>
    /// <exception cref="InvalidOperationException">This context is not document-oriented.</exception>
    DocumentReference DocumentReference { get; }

    /// <summary>
    /// The time at which the document was created, if the document exists.
    /// </summary>
    /// <exception cref="InvalidOperationException">This context is not document-oriented.</exception>
    Timestamp? CreateTime { get; }

    /// <summary>
    /// The time at which the document was last updated, if the document exists.
    /// </summary>
    /// <exception cref="InvalidOperationException">This context is not document-oriented.</exception>
    Timestamp? UpdateTime { get; }

    /// <summary>
    /// The read time of the context (whether of a document or a query).
    /// </summary>
    Timestamp ReadTime { get; }
}
