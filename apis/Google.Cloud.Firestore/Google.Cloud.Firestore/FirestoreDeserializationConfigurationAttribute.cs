// Copyright 2020, Google LLC
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
using System.Collections.Generic;

namespace Google.Cloud.Firestore
{
    /// <summary>
    /// Provides additional information for how Firestore converters (types implementing <see cref="IFirestoreConverter{T}"/>)
    /// should be called during deserialization.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public sealed class FirestoreDeserializationConfigurationAttribute : Attribute
    {
        /// <summary>
        /// The dictionary key used to specify the document ID when deserializing,
        /// or null if the document ID is not propagated.
        /// </summary>        
        public string DocumentIdKey { get; set; }

        /// <summary>
        /// The dictionary key used to specify the create timestamp when deserializing,
        /// or null if the create timestamp is not propagated.
        /// </summary>
        public string CreateTimestampKey { get; set; }

        /// <summary>
        /// The dictionary key used to specify the update timestamp when deserializing,
        /// or null if the update timestamp is not propagated.
        /// </summary>
        public string UpdateTimestampKey { get; set; }

        /// <summary>
        /// The dictionary key used to specify the read timestamp when deserializing,
        /// or null if the read timestamp is not propagated.
        /// </summary>
        public string ReadTimestampKey { get; set; }

        /// <summary>
        /// Applies the deserialization context properties to the given map.
        /// </summary>
        /// <param name="context">The current deserialization context.</param>
        /// <param name="map">The map to (possibly) update.</param>
        internal void ApplyContext(IDeserializationContext context, Dictionary<string, object> map)
        {
            MaybePopulate(DocumentIdKey, () => context.DocumentReference);
            MaybePopulate(CreateTimestampKey, () => context.CreateTime);
            MaybePopulate(UpdateTimestampKey, () => context.UpdateTime);
            MaybePopulate(ReadTimestampKey, () => context.ReadTime);

            void MaybePopulate(string key, Func<object> valueProvider)
            {
                if (key is object)
                {
                    map[key] = valueProvider();
                }
            }
        }
    }
}
