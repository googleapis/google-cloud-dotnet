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

namespace Google.Cloud.Metadata.V1
{
    /// <summary>
    /// The type of a disk in a Google Compute Engine VM instance.
    /// </summary>
    /// <seealso cref="DiskMetadata.Type"/>
    public enum DiskType
    {
        /// <summary>
        /// The disk type is unknown.
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// The disk is durable storage that functions like a physical standard hard drive in a server. It is independent from the
        /// VM so the data will persist even after the VM is deleted.
        /// </summary>
        Persistent,

        /// <summary>
        /// The disk is durable storage that functions like a physical solid-state drive in a server. It is independent from the
        /// VM so the data will persist even after the VM is deleted.
        /// </summary>
        PersistentSsd,

        /// <summary>
        /// The disk is a solid-state drive physically attached to the server hosting the VM instance. The data will persist until
        /// VM is stopped or deleted.
        /// </summary>
        LocalSsd,

        /// <summary>
        /// The disk is ephemeral, or temporary, storage.
        /// </summary>
        Ephemeral, // TODO: This seems to not be available anymore. Should we roll this into Deprecated?

        /// <summary>
        /// The disk is a type which is no longer supported.
        /// </summary>
        Deprecated // TODO: Should we have this or just roll it into unknown?
    }
}
