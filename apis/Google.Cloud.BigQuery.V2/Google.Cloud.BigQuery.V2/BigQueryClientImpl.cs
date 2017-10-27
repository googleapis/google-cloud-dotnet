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
using Google.Apis.Bigquery.v2;
using Google.Apis.Bigquery.v2.Data;
using System;
using System.Net.Http;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// Wrapper around <see cref="BigqueryService"/> to provide simpler operations.
    /// </summary>
    /// <remarks>
    /// This is the "default" implementation of <see cref="BigQueryClient"/>. Most client code
    /// should refer to <see cref="BigQueryClient"/>, creating instances with
    /// <see cref="BigQueryClient.Create(string, Apis.Auth.OAuth2.GoogleCredential)"/> and
    /// <see cref="BigQueryClient.CreateAsync(string, Apis.Auth.OAuth2.GoogleCredential)"/>. The constructor
    /// of this class is public for the sake of constructor-based dependency injection.
    /// </remarks>
    public sealed partial class BigQueryClientImpl : BigQueryClient
    {
        private static readonly object _applicationNameLock = new object();
        private static string _applicationName = UserAgentHelper.GetDefaultUserAgent(typeof(BigQueryClient));
        private static readonly Action<HttpRequestMessage> _versionHeaderAction = UserAgentHelper.CreateRequestModifier(typeof(BigQueryClient));

        // TODO: Allow these to be specified for testability.
        private IClock Clock => SystemClock.Instance;
        private IScheduler Scheduler => SystemScheduler.Instance;

        /// <summary>
        /// The default application name used when creating a <see cref="BigqueryService"/>.
        /// Defaults to "google-cloud-dotnet"; must not be null.
        /// </summary>
        /// <remarks>
        /// Most applications will never want to set this, which is why it's in this class rather than
        /// <see cref="BigQueryClient"/>.
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
                GaxPreconditions.CheckNotNull(value, nameof(value));
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
        /// <remarks>
        /// Care should be taken when constructing the service: if the default serializer settings are used,
        /// result values which can be parsed as date/time values can cause problems. Where possible, either use
        /// <see cref="BigQueryClient.Create(string, Apis.Auth.OAuth2.GoogleCredential)"/> or construct a service
        /// using serializer settings from <see cref="BigQueryClient.CreateJsonSerializersSettings"/>.
        /// </remarks>
        /// <param name="projectId">The ID of the project to work with. Must not be null.</param>
        /// <param name="service">The service to wrap. Must not be null.</param>
        public BigQueryClientImpl(string projectId, BigqueryService service)
        {            
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            Service = GaxPreconditions.CheckNotNull(service, nameof(service));
        }

        /// <summary>
        /// Constructs a new client wrapping the given <see cref="BigqueryService"/>.
        /// </summary>
        /// <remarks>
        /// Care should be taken when constructing the service: if the default serializer settings are used,
        /// result values which can be parsed as date/time values can cause problems. Where possible, either use
        /// <see cref="BigQueryClient.Create(string, Apis.Auth.OAuth2.GoogleCredential)"/> or construct a service
        /// using serializer settings from <see cref="BigQueryClient.CreateJsonSerializersSettings"/>.
        /// </remarks>
        /// <param name="projectReference">A fully-qualified identifier for the project. Must not be null.</param>
        /// <param name="service">The service to wrap. Must not be null.</param>
        public BigQueryClientImpl(ProjectReference projectReference, BigqueryService service)
            : this(GaxPreconditions.CheckNotNull(projectReference, nameof(projectReference)).ProjectId, service)
        {
        }
    }
}
