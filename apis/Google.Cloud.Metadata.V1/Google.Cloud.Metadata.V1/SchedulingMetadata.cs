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
    /// Gets the metadata describing the scheduling options for the Google Compute Engine VM instance.
    /// </summary>
    /// <seealso cref="InstanceMetadata.Scheduling"/>
    public sealed class SchedulingMetadata
    {
        /// <summary>
        /// Gets the value indicating whether the instance is preemptible. 
        /// </summary>
        public bool IsPreemptible { get; }

        /// <summary>
        /// Gets the value indicating how the instance will act during an infrastructure maintenance event.
        /// </summary>
        public MaintenanceEventBehavior MaintenanceEventBehavior { get; }

        /// <summary>
        /// Gets the value indicating whether the instance should restart if it is terminated automatically (not by a user).
        /// </summary>
        /// <remarks>
        /// Preemptible instances cannot be automatically restarted.
        /// </remarks>
        /// <seealso cref="IsPreemptible"/>
        public bool ShouldRestartAutomatically { get; }
    }
}
