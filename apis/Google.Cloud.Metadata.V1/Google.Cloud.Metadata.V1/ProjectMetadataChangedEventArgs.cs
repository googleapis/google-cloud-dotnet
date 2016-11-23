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

using Google.Apis.Compute.v1.Data;

namespace Google.Cloud.Metadata.V1
{
    /// <summary>
    /// Event args for when project level metadata changes.
    /// </summary>
    /// <seealso cref="MetadataClient.ProjectMetadataChanged"/>
    /// <seealso cref="MetadataClient.GetProjectMetadata"/>
    /// <seealso cref="MetadataClient.GetProjectMetadataAsync"/>
    public sealed class ProjectMetadataChangedEventArgs : MetadataChangedEventArgs<Project>
    {
        /// <summary>
        /// Creates a new <see cref="ProjectMetadataChangedEventArgs"/> instance.
        /// </summary>
        /// <param name="newProjectMetadata">The changed <see cref="Project"/> metadata.</param>
        public ProjectMetadataChangedEventArgs(Project newProjectMetadata) : base(newProjectMetadata)
        {
        }
    }
}
