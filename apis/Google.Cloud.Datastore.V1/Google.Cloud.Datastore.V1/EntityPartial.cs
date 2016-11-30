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

namespace Google.Cloud.Datastore.V1
{
    // Additional helper members.
    public partial class Entity
    {
        /// <summary>
        /// Indexer presenting a null-friendly view of the entity properties.
        /// </summary>
        /// <remarks>
        /// <para>
        /// When using the getter of this indexer, if the key is not present in
        /// this entity's set of properties, <c>null</c> is returned.
        /// </para>
        /// <para>
        /// When using the setter of the indexer, setting a null value removes the
        /// property if it is present. To explicitly set a null value, use <see cref="Value.ForNull"/>.
        /// </para>
        /// </remarks>
        /// <param name="name">Property name to access. The name itself must not be null.</param>
        /// <returns>The property value associated with the key.</returns>
        public Value this[string name]
        {
            get
            {
                GaxPreconditions.CheckNotNull(name, nameof(name));
                Value value;
                Properties.TryGetValue(name, out value);
                return value;
            }
            set
            {
                GaxPreconditions.CheckNotNull(name, nameof(name));
                if (value == null)
                {
                    Properties.Remove(name);
                }
                else
                {
                    Properties[name] = value;
                }
            }
        }

        /// <summary>
        /// Creates a mutation representating an update of this entity.
        /// </summary>
        /// <exception cref="InvalidOperationException">The entity does not have a key.</exception>
        public Mutation ToUpdate()
        {
            GaxPreconditions.CheckState(Key != null, "Key property must be present to create a mutation");
            return new Mutation { Update = this };
        }

        /// <summary>
        /// Creates a mutation representating an insert of this entity.
        /// </summary>
        /// <exception cref="InvalidOperationException">The entity does not have a key.</exception>
        public Mutation ToInsert()
        {
            GaxPreconditions.CheckState(Key != null, "Key property must be present to create a mutation");
            return new Mutation { Insert = this };
        }

        /// <summary>
        /// Creates a mutation representating an upsert of this entity.
        /// </summary>
        /// <exception cref="InvalidOperationException">The entity does not have a key.</exception>
        public Mutation ToUpsert()
        {
            GaxPreconditions.CheckState(Key != null, "Key property must be present to create a mutation");
            return new Mutation { Upsert = this };
        }

        /// <summary>
        /// Creates a mutation representating a delete of this entity, via its <see cref="Key"/> property.
        /// </summary>
        /// <exception cref="InvalidOperationException">The entity does not have a key.</exception>
        public Mutation ToDelete()
        {
            GaxPreconditions.CheckState(Key != null, "Key property must be present to create a mutation");
            return new Mutation { Delete = Key };
        }
    }
}
