// Copyright 2017 Google Inc. All Rights Reserved.
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

using Google.Apis.Storage.v1.Data;

namespace Google.Cloud.Storage.V1
{
    /// <summary>
    /// String constants for the names of the storage classes, as used in <see cref="Bucket.StorageClass"/>
    /// and <see cref="Object.StorageClass"/>. See https://cloud.google.com/storage/docs/storage-classes for details.
    /// </summary>
    public static class StorageClasses
    {
        /// <summary>
        /// Name for the Multi-Regional storage class.
        /// </summary>
        public const string MultiRegional = "MULTI_REGIONAL";

        /// <summary>
        /// Name for the Regional storage class.
        /// </summary>
        public const string Regional = "REGIONAL";

        /// <summary>
        /// Name for the Nearline storage class.
        /// </summary>
        public const string Nearline = "NEARLINE";

        /// <summary>
        /// Name for the Coldline storage class.
        /// </summary>
        public const string Coldline = "COLDLINE";

        /// <summary>
        /// Name of the Standard storage class, which is equivalent to
        /// Multi-Regional or Regional depending on the location.
        /// </summary>
        public const string Standard = "STANDARD";

        /// <summary>
        /// Name of the Durable Reduced Availability (DRA) storage class.
        /// Use of this storage class is not recommended; Regional storage has
        /// lower pricing for some operations but otherwise the same pricing structure,
        /// and better performance/availability.
        /// </summary>
        public const string DurableReducedAvailability = "DURABLE_REDUCED_AVAILABILITY";
    }
}
