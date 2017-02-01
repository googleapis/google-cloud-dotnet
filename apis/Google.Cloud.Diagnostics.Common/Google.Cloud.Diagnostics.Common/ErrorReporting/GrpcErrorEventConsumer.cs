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

using Google.Api.Gax;
using Google.Cloud.ErrorReporting.V1Beta1;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// An <see cref="IConsumer{T}"/> that will send received logs to the Stackdriver Error Reporting API.
    /// </summary>
    internal sealed class GrpcErrorEventConsumer : IConsumer<ReportedErrorEvent>
    {
        private readonly ReportErrorsServiceClient _client;
        private readonly ProjectName _projectName;

        /// <summary>
        /// Creates a new instance of <see cref="GrpcErrorEventConsumer"/>.
        /// </summary>
        /// <param name="client">The error reporting client that will push logs to 
        ///     the Stackdriver Error Reporting API. Cannot be null.</param>
        /// <param name="projectId">The Google Cloud Platform project ID. Cannot be null.</param>
        public GrpcErrorEventConsumer(ReportErrorsServiceClient client, string projectId)
        {
            _client = GaxPreconditions.CheckNotNull(client, nameof(client));
            _projectName = new ProjectName(GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)));
        }

        /// <inheritdoc />
        public void Receive(IEnumerable<ReportedErrorEvent> events)
        {
            if (!events.Any())
            {
                return;
            }

            foreach (var errorEvent in events)
            {
                _client.ReportErrorEvent(_projectName, errorEvent);
            }
        }

        /// <inheritdoc />
        public async Task ReceiveAsync(
            IEnumerable<ReportedErrorEvent> events, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (!events.Any())
            {
                return;
            }

            foreach (var errorEvent in events)
            {
                await _client.ReportErrorEventAsync(_projectName, errorEvent, cancellationToken);
            }
        }
    }
}
