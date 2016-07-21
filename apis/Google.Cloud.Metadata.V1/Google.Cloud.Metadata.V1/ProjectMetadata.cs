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
    /// Metadata describing the project of the Google Compute Engine VM instance currently running this code.
    /// </summary>
    /// <seealso cref="MetadataClient.GetProjectMetadata"/>
    /// <seealso cref="MetadataClient.GetProjectMetadataAsync"/>
    public sealed class ProjectMetadata
    {
        /// <summary>
        /// Gets the custom metadata values associated with the project.
        /// </summary>
        /// <remarks>
        /// Custom metadata are simply opaque key/value pairs which allow for custom configuration parameters, scripts, or other
        /// relatively small pieces of data to be associated with the project.
        /// </remarks>
        /// <seealso cref="MetadataClient.GetCustomProjectMetadata"/>
        /// <seealso cref="MetadataClient.GetCustomProjectMetadataAsync"/>
        /// <seealso cref="MetadataClient.RemoveCustomProjectMetadata"/>
        /// <seealso cref="MetadataClient.RemoveCustomProjectMetadataAsync"/>
        /// <seealso cref="MetadataClient.SetCustomProjectMetadata(string, string)"/>
        /// <seealso cref="MetadataClient.SetCustomProjectMetadata(IDictionary{string, string})"/>
        /// <seealso cref="MetadataClient.SetCustomProjectMetadataAsync(string, string, System.Threading.CancellationToken)"/>
        /// <seealso cref="MetadataClient.SetCustomProjectMetadataAsync(IDictionary{string, string}, System.Threading.CancellationToken)"/>
        public IReadOnlyDictionary<string, string> CustomMetadata { get; }
        
        /// <summary>
        /// Gets the numeric ID associated with this project.
        /// </summary>
        public long NumericProjectId { get; }

        /// <summary>
        /// Gets the ID associated with this project.
        /// </summary>
        public string ProjectId { get; }

        // TODO: Should we try to parse these and expose a collection of a custom value type here? (Same for instance metadata).
        /// <summary>
        /// Gets the SSH keys that can connect to instances in the project.
        /// </summary>
        public IReadOnlyList<string> SshKeys { get; }
    }
}
