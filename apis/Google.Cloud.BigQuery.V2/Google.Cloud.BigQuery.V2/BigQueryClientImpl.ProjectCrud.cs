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
using Google.Api.Gax.Rest;
using Google.Apis.Bigquery.v2.Data;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using static Google.Apis.Bigquery.v2.ProjectsResource;

namespace Google.Cloud.BigQuery.V2
{
    public partial class BigQueryClientImpl
    {
        private sealed class ProjectsPageManager : IPageManager<ListRequest, ProjectList, CloudProject>
        {
            private readonly BigQueryClient _client;

            internal ProjectsPageManager(BigQueryClient client)
            {
                _client = client;
            }

            public string GetNextPageToken(ProjectList response) => response.NextPageToken;
            public IEnumerable<CloudProject> GetResources(ProjectList response) => response.Projects?.Select(resource => new CloudProject(_client, resource));
            public void SetPageSize(ListRequest request, int pageSize) => request.MaxResults = pageSize;
            public void SetPageToken(ListRequest request, string pageToken) => request.PageToken = pageToken;
        }

        /// <inheritdoc />
        public override PagedEnumerable<ProjectList, CloudProject> ListProjects(ListProjectsOptions options = null)
        {
            var pageManager = new ProjectsPageManager(this);
            return new RestPagedEnumerable<ListRequest, ProjectList, CloudProject>(
                () => CreateListProjectsRequest(options),
                pageManager);
        }

        /// <inheritdoc />
        public override PagedAsyncEnumerable<ProjectList, CloudProject> ListProjectsAsync(ListProjectsOptions options = null)
        {
            var pageManager = new ProjectsPageManager(this);
            return new RestPagedAsyncEnumerable<ListRequest, ProjectList, CloudProject>(
                () => CreateListProjectsRequest(options),
                pageManager);
        }

        /// <inheritdoc />
        private ListRequest CreateListProjectsRequest(ListProjectsOptions options)
        {
            var request = Service.Projects.List();
            request.ModifyRequest += _versionHeaderAction;
            options?.ModifyRequest(request);
            return request;
        }
    }
}
