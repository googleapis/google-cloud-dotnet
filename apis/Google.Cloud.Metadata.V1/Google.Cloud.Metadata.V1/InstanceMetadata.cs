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

using System.Collections.Generic;

namespace Google.Cloud.Metadata.V1
{
    /// <summary>
    /// Metadata describing the Google Compute Engine VM instance currently running this code.
    /// </summary>
    /// <seealso cref="MetadataClient.GetInstanceMetadata"/>
    /// <seealso cref="MetadataClient.GetInstanceMetadataAsync"/>
    public sealed class InstanceMetadata
    {
        /// <summary>
        /// Gets the CPU platform used by the instance.
        /// </summary>
        public CpuPlatform CpuPlatform { get; }

        /// <summary>
        /// Gets the custom metadata values associated with the instance.
        /// </summary>
        /// <remarks>
        /// Custom metadata are just opaque key/value pairs which allow for custom configuration parameters, scripts, or other
        /// relatively small pieces of data to be associated with the instance.
        /// </remarks>
        /// <seealso cref="MetadataClient.GetCustomInstanceMetadata"/>
        /// <seealso cref="MetadataClient.GetCustomInstanceMetadataAsync"/>
        /// <seealso cref="MetadataClient.RemoveCustomInstanceMetadata"/>
        /// <seealso cref="MetadataClient.RemoveCustomInstanceMetadataAsync"/>
        /// <seealso cref="MetadataClient.SetCustomInstanceMetadata(string, string)"/>
        /// <seealso cref="MetadataClient.SetCustomInstanceMetadata(IDictionary{string, string})"/>
        /// <seealso cref="MetadataClient.SetCustomInstanceMetadataAsync(string, string, System.Threading.CancellationToken)"/>
        /// <seealso cref="MetadataClient.SetCustomInstanceMetadataAsync(IDictionary{string, string}, System.Threading.CancellationToken)"/>
        public IReadOnlyDictionary<string, string> CustomMetadata { get; }

        /// <summary>
        /// Gets the description of the instance which was user-supplied when created.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Gets the metadata describing each disk attached to the instance.
        /// </summary>
        public IReadOnlyList<DiskMetadata> Disks { get; }

        /// <summary>
        /// Gets the fully qualified host name of the instance.
        /// </summary>
        public string HostName { get; }

        /// <summary>
        /// Gets the unique ID of the instance.
        /// </summary>
        public long Id { get; }
        
        // TODO: Look into why ImagePath was returning an empty string and see if it can be added back in.

        /// <summary>
        /// Gets the collection of license ids this instance is billed for.
        /// </summary>
        public IReadOnlyList<string> LicenseIds { get; }

        /// <summary>
        /// Gets the partial URL of the machine type resource used to create the instance.
        /// </summary>
        /// <remarks>
        /// The partial URLs are relative to https://www.googleapis.com/compute/v1/.
        /// Examples of machine type resource paths might be "zones/us-central1-f/machineTypes/n1-standard-1" or "projects/12345/machineTypes/n1-highmem-2".
        /// </remarks>
        public string MachineTypePath { get; }

        /// <summary>
        /// Gets the metadata for all network interfaces in the instance.
        /// </summary>
        public IReadOnlyList<NetworkInterfaceMetadata> NetworkInterfaces { get; }

        /// <summary>
        /// Gets the metadata related to scheduling of the instance.
        /// </summary>
        public SchedulingMetadata Scheduling { get; }

        /// <summary>
        /// Gets the SSH keys that can connect to the instance.
        /// </summary>
        public IReadOnlyList<string> SshKeys { get; }

        /// <summary>
        /// Gets the service accounts associated with the instance.
        /// </summary>
        public IReadOnlyList<ServiceAccountMetadata> ServiceAccounts { get; }

        /// <summary>
        /// Gets the tags associated with the instance.
        /// </summary>
        public IReadOnlyList<string> Tags { get; }

        /// <summary>
        /// Gets the partial URL of the zone where this instance is located.
        /// </summary>
        /// <remarks>
        /// The partial URLs are relative to https://www.googleapis.com/compute/v1/.
        /// An example of a zone path is "projects/12345/zones/us-central1-f".
        /// </remarks>
        public string ZonePath { get; }
    }
}
