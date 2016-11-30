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

namespace Google.Cloud.Datastore.V1
{
    /// <summary>
    /// Constants for use in Datastore.
    /// </summary>
    public static class DatastoreConstants
    {
        /// <summary>
        /// The property to use in a query to obtain just the entity key.
        /// </summary>
        public const string KeyProperty = "__key__";

        /// <summary>
        /// The kind used to find all the namespaces used in your application entities.
        /// </summary>
        public const string NamespaceKind = "__namespace__";

        /// <summary>
        /// The kind used to query a specific kind.
        /// </summary>
        public const string KindKind = "__kind__";

        /// <summary>
        /// The kind used to query the properties used in entities.
        /// </summary>
        public const string PropertyKind = "__property__";
    }
}
