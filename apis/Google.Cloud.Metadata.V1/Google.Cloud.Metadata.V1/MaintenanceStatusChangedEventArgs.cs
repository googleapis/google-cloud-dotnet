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
    /// Event args for when the maintenance status metadata changes.
    /// </summary>
    /// <seealso cref="MetadataClient.MaintenanceStatusChanged"/>
    /// <seealso cref="MetadataClient.GetMaintenanceStatus"/>
    /// <seealso cref="MetadataClient.GetMaintenanceStatusAsync"/>
    public sealed class MaintenanceStatusChangedEventArgs : MetadataChangedEventArgs<MaintenanceStatus>
    {
        /// <summary>
        /// Creates a new <see cref="MaintenanceStatusChangedEventArgs"/> instance.
        /// </summary>
        /// <param name="newMaintenanceStatus">The changed <see cref="MaintenanceStatus"/> value.</param>
        public MaintenanceStatusChangedEventArgs(MaintenanceStatus newMaintenanceStatus) : base(newMaintenanceStatus)
        {
        }
    }
}
