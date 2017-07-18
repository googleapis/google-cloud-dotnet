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

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// Base class for options for operations that create jobs.
    /// </summary>
    public abstract class JobCreationOptions
    {
        /// <summary>
        /// The ID of the project in which to create the job. If this is not set,
        /// it defaults to the project ID of the client.
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// If specified, use this prefix when generating a job ID. (Job IDs are always generated client-side
        /// by this library, to allow insertion to be retried where necessary.) It is an error to set both this
        /// property and <see cref="JobId"/>.
        /// </summary>
        public string JobIdPrefix { get; set; }

        /// <summary>
        /// If specified, this ID will be used to create the job. It is an error to set both this property
        /// and <see cref="JobIdPrefix"/>.
        /// </summary>
        public string JobId { get; set; }
    }
}
