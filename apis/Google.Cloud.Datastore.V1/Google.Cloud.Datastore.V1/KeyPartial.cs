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
using System;
using static Google.Cloud.Datastore.V1.Key.Types;

namespace Google.Cloud.Datastore.V1
{
    public partial class Key
    {
        /// <summary>
        /// Creates a new mutation representing a delete of this key.
        /// </summary>
        /// <returns></returns>
        public Mutation ToDelete() => new Mutation { Delete = this };

        /// <summary>
        /// Creates a clone of this key and appends the specified path element to the clone.
        /// </summary>
        /// <param name="pathElement">The path element to append. Must not be null.</param>
        /// <returns>A clone of this key, with the specified path element.</returns>
        public Key WithElement(PathElement pathElement)
        {
            GaxPreconditions.CheckNotNull(pathElement, nameof(pathElement));
            var clone = Clone();
            clone.Path.Add(pathElement);
            return clone;
        }

        /// <summary>
        /// Creates a clone of this key and appends a new path element with the specified kind and name to the clone.
        /// </summary>
        /// <param name="kind">The kind of path element to append. Must not be null.</param>
        /// <param name="name">The name of the path element to append. Must not be null.</param>
        /// <returns>A clone of this key, with the specified path element.</returns>
        public Key WithElement(string kind, string name) => WithElement(new PathElement(kind, name));

        /// <summary>
        /// Creates a clone of this key and appends a new path element with the specified kind and ID to the clone.
        /// </summary>
        /// <param name="kind">The kind of path element to append. Must not be null.</param>
        /// <param name="id">The ID of the path element to append.</param>
        /// <returns>A clone of this key, with the specified path element.</returns>
        public Key WithElement(string kind, long id) => WithElement(new PathElement(kind, id));
        
        /// <summary>
        /// Constructs a clone of this key and removes the final path element.
        /// </summary>
        /// <exception cref="InvalidOperationException">This key is a "root" key with an empty path.</exception>
        /// <returns>The parent key to this key.</returns>
        public Key GetParent()
        {
            var clone = Clone();
            if (clone.IsRoot)
            {
                throw new InvalidOperationException("A root key has no parent");
            }
            clone.Path.RemoveAt(clone.Path.Count - 1);
            return clone;
        }

        /// <summary>
        /// Convenience property to determine whether this key is a root or not. A root key is one
        /// whose <see cref="Path"/> is empty.
        /// </summary>
        public bool IsRoot => Path.Count == 0;

        public static partial class Types
        {
            public partial class PathElement
            {
                /// <summary>
                /// Creates a key path element with the given kind and name.
                /// </summary>
                /// <param name="kind">The kind of path element to create. Must not be null.</param>
                /// <param name="name">The name of the path element to create. Must not be null.</param>
                public PathElement(string kind, string name) : this()
                {
                    Kind = GaxPreconditions.CheckNotNull(kind, nameof(kind));
                    Name = GaxPreconditions.CheckNotNull(name, nameof(name));
                }

                /// <summary>
                /// Creates a key path element with the given kind and ID.
                /// </summary>
                /// <param name="kind">The kind of path element to create. Must not be null.</param>
                /// <param name="id">The ID of the path element to create.</param>
                public PathElement(string kind, long id) : this()
                {
                    Kind = GaxPreconditions.CheckNotNull(kind, nameof(kind));
                    Id = id;
                }
            }
        }

        /// <summary>
        /// Helper method to make sure we can use fully-populated keys.
        /// The Datastore implementation is willing to accept keys without a partition ID,
        /// or with a partition ID including only a namespace - it fills in the project ID itself.
        /// However, keys returned from the service *always* have partition IDs, so any time we need
        /// to match a user-supplied key with a service-supplied key, we should get a normalized version first.
        /// This method never modifies an existing key - it creates a clone if necessary.
        /// </summary>
        /// <returns>Either <c>this</c> if it already contains a project ID, or a clone with the given project ID
        /// otherwise.</returns>
        internal Key NormalizeToProjectId(string projectId)
        {
            return string.IsNullOrEmpty(PartitionId?.ProjectId)
                ? new Key(this) { PartitionId = new PartitionId(projectId, PartitionId?.NamespaceId ?? "") }
                : this;
        }
    }
}
