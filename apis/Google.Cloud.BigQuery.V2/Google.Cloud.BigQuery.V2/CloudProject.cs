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

using Google.Apis.Bigquery.v2.Data;
using static Google.Apis.Bigquery.v2.Data.ProjectList;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// A project within Google Cloud Platform.
    /// </summary>
    public sealed class CloudProject
    {
        private readonly BigQueryClient _client;

        /// <summary>
        /// The underlying REST-ful resource for the table.
        /// </summary>
        public ProjectsData Resource { get; }

        /// <summary>
        /// The project ID, obtained from the <see cref="Reference"/>.
        /// </summary>
        public string ProjectId => Resource.ProjectReference.ProjectId;

        /// <summary>
        /// The fully-qualified identifier for the project, as an object which can be used for other operations
        /// within this API.
        /// </summary>
        public ProjectReference Reference => Resource.ProjectReference;

        /// <summary>
        /// The friendly name of the project, if any.
        /// </summary>
        public string FriendlyName => Resource.FriendlyName;

        internal CloudProject(BigQueryClient _client, ProjectsData resource)
        {
            this._client = _client;
            Resource = resource;
        }

        /// <summary>
        /// Creates a new client for the specified project, using the same credentials
        /// as the one used to create this object.
        /// </summary>
        /// <returns>A client for this project.</returns>
        public BigQueryClient CreateClient() => new BigQueryClientImpl(Reference, _client.Service);
    }
}
