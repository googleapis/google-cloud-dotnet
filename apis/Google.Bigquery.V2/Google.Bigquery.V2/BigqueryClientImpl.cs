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

using Google.Api.Gax.Rest;
using Google.Apis.Bigquery.v2;
using Google.Apis.Bigquery.v2.Data;

namespace Google.Bigquery.V2
{
    /// <summary>
    /// Wrapper around <see cref="BigqueryService"/> to provide simpler operations.
    /// </summary>
    /// <remarks>
    /// This is the "default" implementation of <see cref="BigqueryClient"/>. Most client code
    /// should refer to <see cref="BigqueryClient"/>, creating instances with
    /// <see cref="BigqueryClient.Create(string, Apis.Auth.OAuth2.GoogleCredential)"/> and
    /// <see cref="BigqueryClient.CreateAsync(string, Apis.Auth.OAuth2.GoogleCredential)"/>. The constructor
    /// of this class is public for the sake of constructor-based dependency injection.
    /// </remarks>
    public sealed partial class BigqueryClientImpl : BigqueryClient
    {
        private static readonly object _applicationNameLock = new object();
        private static string _applicationName = UserAgentHelper.GetDefaultUserAgent(typeof(BigqueryClient));

        /// <summary>
        /// The default application name used when creating a <see cref="BigqueryService"/>.
        /// Defaults to "google-cloud-dotnet"; must not be null.
        /// </summary>
        /// <remarks>
        /// Most applications will never want to set this, which is why it's in this class rather than
        /// <see cref="BigqueryClient"/>.
        /// </remarks>
        public static string ApplicationName
        {
            get
            {
                lock (_applicationNameLock)
                {
                    return _applicationName;
                }
            }
            set
            {
                GaxRestPreconditions.CheckNotNull(value, nameof(value));
                lock (_applicationNameLock)
                {
                    _applicationName = value;
                }
            }
        }

        /// <inheritdoc />
        public override BigqueryService Service { get; }

        /// <inheritdoc />
        public override string ProjectId { get; }

        /// <summary>
        /// Constructs a new client wrapping the given <see cref="BigqueryService"/>.
        /// </summary>
        /// <param name="projectId">The ID of the project to work with. Must not be null.</param>
        /// <param name="service">The service to wrap. Must not be null.</param>
        public BigqueryClientImpl(string projectId, BigqueryService service)
        {            
            ProjectId = GaxRestPreconditions.CheckNotNull(projectId, nameof(projectId));
            Service = GaxRestPreconditions.CheckNotNull(service, nameof(service));
        }

        /// <summary>
        /// Constructs a new client wrapping the given <see cref="BigqueryService"/>.
        /// </summary>
        /// <param name="projectReference">A fully-qualified identifier for the project. Must not be null.</param>
        /// <param name="service">The service to wrap. Must not be null.</param>
        public BigqueryClientImpl(ProjectReference projectReference, BigqueryService service)
            : this(GaxRestPreconditions.CheckNotNull(projectReference, nameof(projectReference)).ProjectId, service)
        {
        }
    }
}
