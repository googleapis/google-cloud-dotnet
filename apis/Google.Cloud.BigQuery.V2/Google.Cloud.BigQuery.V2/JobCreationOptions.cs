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

using System.Collections.Generic;

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

        /// <summary>
        /// If specified, the job will be created in this location. Otherwise, it will be created in the client's
        /// <see cref="BigQueryClient.DefaultLocation">default location</see>.
        /// </summary>
        /// <seealso cref="BigQueryClient.WithDefaultLocation(string)"/>
        public string JobLocation { get; set; }

        /// <summary>
        /// The labels associated with the job to be created.
        /// Labels are key-value pairs.
        /// You can use these to organize and group your jobs.
        /// Label keys and values can be no longer than 63 characters,
        /// can only contain lowercase letters, numeric characters,
        /// underscores and dashes. International characters are allowed.
        /// If a label value is <code>null</code>, it won't be added to the job's labels.
        /// A label value can be <see cref="string.Empty"/>.
        /// Label keys must start with a letter.
        /// </summary>
        public IDictionary<string, string> Labels { get; set; }
    }
}
