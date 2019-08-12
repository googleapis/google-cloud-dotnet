// Copyright 2018 Google LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     https://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using Google.Apis.Bigquery.v2.Data;
using System.Threading;
using System.Threading.Tasks;
using static Google.Apis.Bigquery.v2.ProjectsResource;

namespace Google.Cloud.BigQuery.V2
{
    public partial class BigQueryClientImpl
    {
        /// <inheritdoc />
        public override string GetBigQueryServiceAccountEmail(ProjectReference projectReference, GetBigQueryServiceAccountEmailOptions options = null) =>
            CreateGetServiceAccountEmailRequest(projectReference, options).Execute().Email;

        /// <inheritdoc />
        public override async Task<string> GetBigQueryServiceAccountEmailAsync(ProjectReference projectReference, GetBigQueryServiceAccountEmailOptions options = null, CancellationToken cancellationToken = default)
        {
            var request = CreateGetServiceAccountEmailRequest(projectReference, options);
            var response = await request.ExecuteAsync(cancellationToken).ConfigureAwait(false);
            return response.Email;
        }

        private GetServiceAccountRequest CreateGetServiceAccountEmailRequest(ProjectReference projectReference, GetBigQueryServiceAccountEmailOptions options)
        {
            GaxPreconditions.CheckNotNull(projectReference, nameof(projectReference));

            var request = Service.Projects.GetServiceAccount(projectReference.ProjectId);
            options?.ModifyRequest(request);
            RetryHandler.MarkAsRetriable(request);
            return request;
        }
    }
}
