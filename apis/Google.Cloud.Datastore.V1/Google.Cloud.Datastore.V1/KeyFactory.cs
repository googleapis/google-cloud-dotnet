// Copyright 2016 Google Inc. All Rights Reserved.
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
using static Google.Cloud.Datastore.V1.Key.Types;

namespace Google.Cloud.Datastore.V1
{
    /// <summary>
    /// Provides a convenient way of producing keys of a specific kind, from a specified parent entity or key,
    /// or for root entities based on a partition ID.
    /// </summary>
    /// <remarks>
    /// If the key factory is constructed with just a partition ID and kind, then the parent key has an empty
    /// path, and all keys created by the factory will be root keys. Otherwise, all keys created by the factory will
    /// be direct children of the parent key, so both the parent key itself and any ancestors of that key will be
    /// ancestors of the child key. Ancestors can be determined in queries using <see cref="Filter.HasAncestor(Key)"/>.
    /// </remarks>
    public sealed class KeyFactory
    {
        private readonly Key _parent;
        private readonly string _kind;

        /// <summary>
        /// Creates a key factory for the root of a partition.
        /// </summary>
        /// <param name="partitionId">The partition ID for the factory. Must not be null.</param>
        /// <param name="kind">The kind of root entity keys to create. Must not be null.</param>
        public KeyFactory(PartitionId partitionId, string kind)
        {
            _parent = new Key { PartitionId = GaxPreconditions.CheckNotNull(partitionId, nameof(partitionId)).Clone() };
            _kind = GaxPreconditions.CheckNotNull(kind, nameof(kind));
        }

        /// <summary>
        /// Creates a key factory for the root of a partition.
        /// </summary>
        /// <param name="projectId">The project ID for the factory. Must not be null.</param>
        /// <param name="namespaceId">The namespace ID for the factory. May be null in which case an empty string is used.</param>
        /// <param name="kind">The kind of root entity keys to create. Must not be null.</param>
        public KeyFactory(string projectId, string namespaceId, string kind)
        {
            GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            _parent = new Key { PartitionId = new PartitionId(projectId, namespaceId ?? "") };
            _kind = GaxPreconditions.CheckNotNull(kind, nameof(kind));
        }

        /// <summary>
        /// Creates a key factory for children of the given key. Keys created by the new
        /// factory will have the same path as this key, but with one extra path element.
        /// </summary>
        /// <remarks>
        /// The key is cloned before being stored, so may be mutated after the factory
        /// is constructed without affecting the factory.
        /// </remarks>
        /// <param name="parent">The "parent" key for keys created by the new factory. Must not be null.</param>
        /// <param name="kind">The kind of child entity keys to create. Must not be null.</param>
        public KeyFactory(Key parent, string kind)
        {
            _parent = GaxPreconditions.CheckNotNull(parent, nameof(parent)).Clone();
            _kind = GaxPreconditions.CheckNotNull(kind, nameof(kind));
        }

        /// <summary>
        /// Creates a key factory for children of the given key. Keys created by the new
        /// factory will have the same path as this key, but with one extra path element.
        /// </summary>
        /// <remarks>
        /// The entity key is cloned before being stored, so may be mutated after the factory
        /// is constructed without affecting the factory.
        /// </remarks>
        /// <param name="parent">The "parent" entity for keys created by the new factory.
        /// Must not be null, and must have a key.</param>
        /// <param name="kind">The kind of child entity keys to create. Must not be null.</param>
        public KeyFactory(Entity parent, string kind)
        {
            GaxPreconditions.CheckNotNull(parent, nameof(parent));
            var key = parent.Key;
            GaxPreconditions.CheckArgument(key != null, nameof(parent), "Parent entity must have a key");
            _parent = key.Clone();
            _kind = GaxPreconditions.CheckNotNull(kind, nameof(kind));
        }

        /// <summary>
        /// Creates a key for the given entity ID.
        /// </summary>
        /// <param name="id">The numeric entity ID.</param>
        /// <returns>A key whose final path element contains the given ID.</returns>
        public Key CreateKey(long id) => _parent.WithElement(new PathElement { Id = id, Kind = _kind });

        /// <summary>
        /// Creates a key for the given entity name.
        /// </summary>
        /// <param name="name">The entity name. Must not be null.</param>
        /// <returns>A key whose final path element contains the given name.</returns>
        public Key CreateKey(string name) =>
            _parent.WithElement(new PathElement { Name = GaxPreconditions.CheckNotNull(name, nameof(name)), Kind = _kind });

        /// <summary>
        /// Creates a key with only the kind specified in the final path element, intended for insertions where
        /// the ID is populated by the server.
        /// </summary>
        /// <returns>A key with no name or ID in the final path element.</returns>
        public Key CreateIncompleteKey() => _parent.WithElement(new PathElement { Kind = _kind });
    }
}
