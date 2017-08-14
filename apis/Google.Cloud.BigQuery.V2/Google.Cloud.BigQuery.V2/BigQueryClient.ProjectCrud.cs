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

using Google.Api.Gax;
using Google.Apis.Bigquery.v2.Data;
using System;

namespace Google.Cloud.BigQuery.V2
{
    public abstract partial class BigQueryClient
    {
        #region ListProjects
        /// <summary>
        /// Lists the cloud projects available using the current credentials.
        /// </summary>
        /// <remarks>
        /// The project associated with this client is irrelevant for this operation.
        /// </remarks>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A sequence of projects the user has access to.</returns>
        public virtual PagedEnumerable<ProjectList, CloudProject> ListProjects(ListProjectsOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously lists the cloud projects available using the current credentials.
        /// </summary>
        /// <remarks>
        /// The project associated with this client is irrelevant for this operation.
        /// </remarks>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>An asynchronous sequence of projects the user has access to.</returns>
        public virtual PagedAsyncEnumerable<ProjectList, CloudProject> ListProjectsAsync(ListProjectsOptions options = null)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
