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

// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Logging.V2
{

    /// <summary>
    /// Extension methods to assist with using <see cref="ConfigServiceV2Client"/>.
    /// </summary>
    public static partial class ConfigServiceV2Extensions
    {
        /// <summary>
        /// Wrap a GRPC ConfigServiceV2 client for more convenient use.
        /// </summary>
        /// <param name="grpcClient">A GRPC client to wrap.</param>
        /// <param name="settings">
        /// An optional <see cref="ConfigServiceV2Settings"/> to configure this wrapper.
        /// If null or not specified, then the default settings are used.
        /// </param>
        /// <returns>A <see cref="ConfigServiceV2Client"/> that wraps the specified GRPC client.</returns>
        public static ConfigServiceV2Client ToClient(
            this ConfigServiceV2.IConfigServiceV2Client grpcClient,
            ConfigServiceV2Settings settings = null
        ) => new ConfigServiceV2ClientImpl(grpcClient, settings);
    }

    /// <summary>
    /// Settings for a ConfigServiceV2 wrapper.
    /// </summary>
    public sealed partial class ConfigServiceV2Settings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="ConfigServiceV2Settings"/>.
        /// </summary>
        /// <returns>A new instance of the default ConfigServiceV2Settings.</returns>
        public static ConfigServiceV2Settings GetDefault() => new ConfigServiceV2Settings();

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this set of ConfigServiceV2 settings.</returns>
        public ConfigServiceV2Settings Clone() => CloneInto(new ConfigServiceV2Settings
        {
        });
    }

    /// <summary>
    /// ConfigServiceV2 client wrapper, for convenient use.
    /// </summary>
    public abstract partial class ConfigServiceV2Client
    {
        /// <summary>
        /// The default endpoint for the ConfigServiceV2 service, which is a host of "logging.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("logging.googleapis.com", 443);

        /// <summary>
        /// The default ConfigServiceV2 scopes
        /// </summary>
        /// <remarks>
        /// The default ConfigServiceV2 scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/logging.write"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/logging.admin"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/logging.read"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform.read-only"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// </list>
        /// </remarks>
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new[] {
            "https://www.googleapis.com/auth/logging.write",
            "https://www.googleapis.com/auth/logging.admin",
            "https://www.googleapis.com/auth/logging.read",
            "https://www.googleapis.com/auth/cloud-platform.read-only",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>
        /// Path template for a project resource. Parameters:
        /// <list type="bullet">
        /// <item><description>project</description></item>
        /// </list>
        /// </summary>
        public static PathTemplate ProjectTemplate { get; } = new PathTemplate("projects/{project}");

        /// <summary>
        /// Creates a project resource name from its component IDs.
        /// </summary>
        /// <param name="projectId">The project ID.</param>
        /// <returns>The full project resource name.</returns>
        public static string GetProjectName(string projectId) => ProjectTemplate.Expand(projectId);

        /// <summary>
        /// Path template for a sink resource. Parameters:
        /// <list type="bullet">
        /// <item><description>project</description></item>
        /// <item><description>sink</description></item>
        /// </list>
        /// </summary>
        public static PathTemplate SinkTemplate { get; } = new PathTemplate("projects/{project}/sinks/{sink}");

        /// <summary>
        /// Creates a sink resource name from its component IDs.
        /// </summary>
        /// <param name="projectId">The project ID.</param>
        /// <param name="sinkId">The sink ID.</param>
        /// <returns>The full sink resource name.</returns>
        public static string GetSinkName(string projectId, string sinkId) => SinkTemplate.Expand(projectId, sinkId);

        // Note: we could have parameterless overloads of Create and CreateAsync,
        // documented to just use the default endpoint, settings and credentials.
        // Pros:
        // - Might be more reassuring on first use
        // - Allows method group conversions
        // Con: overloads!

        /// <summary>
        /// Asynchronously creates a <see cref="ConfigServiceV2Client"/>, applying defaults for all unspecified settings.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ConfigServiceV2Settings"/>.</param>
        /// <param name="credentials">Optional <see cref="ChannelCredentials"/>.</param>
        /// <returns>The task representing the created <see cref="ConfigServiceV2Client"/>.</returns>
        public static async Task<ConfigServiceV2Client> CreateAsync(
            ServiceEndpoint endpoint = null,
            ConfigServiceV2Settings settings = null,
            ChannelCredentials credentials = null)
        {
            Channel channel = await ClientHelper.CreateChannelAsync(endpoint ?? DefaultEndpoint, credentials).ConfigureAwait(false);
            ConfigServiceV2.ConfigServiceV2Client grpcClient = new ConfigServiceV2.ConfigServiceV2Client(channel);
            return new ConfigServiceV2ClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="ConfigServiceV2Client"/>, applying defaults for all unspecified settings.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ConfigServiceV2Settings"/>.</param>
        /// <param name="credentials">Optional <see cref="ChannelCredentials"/>.</param>
        /// <returns>The created <see cref="ConfigServiceV2Client"/>.</returns>
        public static ConfigServiceV2Client Create(
            ServiceEndpoint endpoint = null,
            ConfigServiceV2Settings settings = null,
            ChannelCredentials credentials = null)
        {
            Channel channel = ClientHelper.CreateChannel(endpoint ?? DefaultEndpoint, credentials);
            ConfigServiceV2.ConfigServiceV2Client grpcClient = new ConfigServiceV2.ConfigServiceV2Client(channel);
            return new ConfigServiceV2ClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// The underlying GRPC ConfigServiceV2 client.
        /// </summary>
        public virtual ConfigServiceV2.IConfigServiceV2Client GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="project_name">
        /// Required. The resource name of the project containing the sinks.
        /// Example: `"projects/my-logging-project"`, `"projects/01234567890"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual IAsyncEnumerable<LogSink> ListSinksAsync(
            string projectName,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="project_name">
        /// Required. The resource name of the project containing the sinks.
        /// Example: `"projects/my-logging-project"`, `"projects/01234567890"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IEnumerable<LogSink> ListSinks(
            string projectName,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a sink.
        /// </summary>
        /// <param name="sink_name">
        /// The resource name of the sink to return.
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<LogSink> GetSinkAsync(
            string sinkName,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a sink.
        /// </summary>
        /// <param name="sink_name">
        /// The resource name of the sink to return.
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<LogSink> GetSinkAsync(
            string sinkName,
            CancellationToken cancellationToken) => GetSinkAsync(
                sinkName,
                new CallSettings { CancellationToken = cancellationToken });
        /// <summary>
        /// Gets a sink.
        /// </summary>
        /// <param name="sink_name">
        /// The resource name of the sink to return.
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogSink GetSink(
            string sinkName,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a sink.
        /// </summary>
        /// <param name="project_name">
        /// The resource name of the project in which to create the sink.
        /// Example: `"projects/my-project-id"`.
        ///
        /// The new sink must be provided in the request.
        /// </param>
        /// <param name="sink">
        /// The new sink, which must not have an identifier that already
        /// exists.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<LogSink> CreateSinkAsync(
            string projectName,
            LogSink sink,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a sink.
        /// </summary>
        /// <param name="project_name">
        /// The resource name of the project in which to create the sink.
        /// Example: `"projects/my-project-id"`.
        ///
        /// The new sink must be provided in the request.
        /// </param>
        /// <param name="sink">
        /// The new sink, which must not have an identifier that already
        /// exists.
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<LogSink> CreateSinkAsync(
            string projectName,
            LogSink sink,
            CancellationToken cancellationToken) => CreateSinkAsync(
                projectName,
                sink,
                new CallSettings { CancellationToken = cancellationToken });
        /// <summary>
        /// Creates a sink.
        /// </summary>
        /// <param name="project_name">
        /// The resource name of the project in which to create the sink.
        /// Example: `"projects/my-project-id"`.
        ///
        /// The new sink must be provided in the request.
        /// </param>
        /// <param name="sink">
        /// The new sink, which must not have an identifier that already
        /// exists.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogSink CreateSink(
            string projectName,
            LogSink sink,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates or updates a sink.
        /// </summary>
        /// <param name="sink_name">
        /// The resource name of the sink to update.
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        ///
        /// The updated sink must be provided in the request and have the
        /// same name that is specified in `sinkName`.  If the sink does not
        /// exist, it is created.
        /// </param>
        /// <param name="sink">
        /// The updated sink, whose name must be the same as the sink
        /// identifier in `sinkName`.  If `sinkName` does not exist, then
        /// this method creates a new sink.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<LogSink> UpdateSinkAsync(
            string sinkName,
            LogSink sink,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates or updates a sink.
        /// </summary>
        /// <param name="sink_name">
        /// The resource name of the sink to update.
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        ///
        /// The updated sink must be provided in the request and have the
        /// same name that is specified in `sinkName`.  If the sink does not
        /// exist, it is created.
        /// </param>
        /// <param name="sink">
        /// The updated sink, whose name must be the same as the sink
        /// identifier in `sinkName`.  If `sinkName` does not exist, then
        /// this method creates a new sink.
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<LogSink> UpdateSinkAsync(
            string sinkName,
            LogSink sink,
            CancellationToken cancellationToken) => UpdateSinkAsync(
                sinkName,
                sink,
                new CallSettings { CancellationToken = cancellationToken });
        /// <summary>
        /// Creates or updates a sink.
        /// </summary>
        /// <param name="sink_name">
        /// The resource name of the sink to update.
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        ///
        /// The updated sink must be provided in the request and have the
        /// same name that is specified in `sinkName`.  If the sink does not
        /// exist, it is created.
        /// </param>
        /// <param name="sink">
        /// The updated sink, whose name must be the same as the sink
        /// identifier in `sinkName`.  If `sinkName` does not exist, then
        /// this method creates a new sink.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogSink UpdateSink(
            string sinkName,
            LogSink sink,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a sink.
        /// </summary>
        /// <param name="sink_name">
        /// The resource name of the sink to delete.
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task DeleteSinkAsync(
            string sinkName,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a sink.
        /// </summary>
        /// <param name="sink_name">
        /// The resource name of the sink to delete.
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task DeleteSinkAsync(
            string sinkName,
            CancellationToken cancellationToken) => DeleteSinkAsync(
                sinkName,
                new CallSettings { CancellationToken = cancellationToken });
        /// <summary>
        /// Deletes a sink.
        /// </summary>
        /// <param name="sink_name">
        /// The resource name of the sink to delete.
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSink(
            string sinkName,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    public sealed partial class ConfigServiceV2ClientImpl : ConfigServiceV2Client
    {
        private static readonly PageStreamer<LogSink, ListSinksRequest, ListSinksResponse, string> s_listSinksPageStreamer =
            new PageStreamer<LogSink, ListSinksRequest, ListSinksResponse, string>(
                (request, token) => {
                    request.PageToken = token;
                    return request;
                },
                response => response.NextPageToken,
                response => response.Sinks,
                "" // An empty page-token
            );

        private readonly ClientHelper _clientHelper;

        public ConfigServiceV2ClientImpl(ConfigServiceV2.IConfigServiceV2Client grpcClient, ConfigServiceV2Settings settings)
        {
            this.GrpcClient = grpcClient;
            ConfigServiceV2Settings effectiveSettings = settings ?? ConfigServiceV2Settings.GetDefault();
            _clientHelper = new ClientHelper(effectiveSettings);
        }

        public override ConfigServiceV2.IConfigServiceV2Client GrpcClient { get; }

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="project_name">
        /// Required. The resource name of the project containing the sinks.
        /// Example: `"projects/my-logging-project"`, `"projects/01234567890"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override IAsyncEnumerable<LogSink> ListSinksAsync(
            string projectName,
            CallSettings callSettings = null)
        {
            ListSinksRequest request = new ListSinksRequest
            {
                ProjectName = projectName,
            };
            return s_listSinksPageStreamer.FetchAsync(
                request,
                (pageStreamRequest, cancellationToken) => GrpcClient.ListSinksAsync(
                    pageStreamRequest,
                    _clientHelper.BuildCallOptions(cancellationToken, callSettings)
                ).ResponseAsync
            );
        }

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="project_name">
        /// Required. The resource name of the project containing the sinks.
        /// Example: `"projects/my-logging-project"`, `"projects/01234567890"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override IEnumerable<LogSink> ListSinks(
            string projectName,
            CallSettings callSettings = null)
        {
            ListSinksRequest request = new ListSinksRequest
            {
                ProjectName = projectName,
            };
            return s_listSinksPageStreamer.Fetch(
                request,
                pageStreamRequest => GrpcClient.ListSinks(
                    pageStreamRequest,
                    _clientHelper.BuildCallOptions(null, callSettings))
            );
        }

        /// <summary>
        /// Gets a sink.
        /// </summary>
        /// <param name="sink_name">
        /// The resource name of the sink to return.
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<LogSink> GetSinkAsync(
            string sinkName,
            CallSettings callSettings = null)
        {
            GetSinkRequest request = new GetSinkRequest
            {
                SinkName = sinkName,
            };
            return GrpcClient.GetSinkAsync(
                request,
                _clientHelper.BuildCallOptions(null, callSettings)
            ).ResponseAsync;
        }

        /// <summary>
        /// Gets a sink.
        /// </summary>
        /// <param name="sink_name">
        /// The resource name of the sink to return.
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LogSink GetSink(
            string sinkName,
            CallSettings callSettings = null)
        {
            GetSinkRequest request = new GetSinkRequest
            {
                SinkName = sinkName,
            };
            return GrpcClient.GetSink(
                request,
                _clientHelper.BuildCallOptions(null, callSettings));
        }

        /// <summary>
        /// Creates a sink.
        /// </summary>
        /// <param name="project_name">
        /// The resource name of the project in which to create the sink.
        /// Example: `"projects/my-project-id"`.
        ///
        /// The new sink must be provided in the request.
        /// </param>
        /// <param name="sink">
        /// The new sink, which must not have an identifier that already
        /// exists.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<LogSink> CreateSinkAsync(
            string projectName,
            LogSink sink,
            CallSettings callSettings = null)
        {
            CreateSinkRequest request = new CreateSinkRequest
            {
                ProjectName = projectName,
                Sink = sink,
            };
            return GrpcClient.CreateSinkAsync(
                request,
                _clientHelper.BuildCallOptions(null, callSettings)
            ).ResponseAsync;
        }

        /// <summary>
        /// Creates a sink.
        /// </summary>
        /// <param name="project_name">
        /// The resource name of the project in which to create the sink.
        /// Example: `"projects/my-project-id"`.
        ///
        /// The new sink must be provided in the request.
        /// </param>
        /// <param name="sink">
        /// The new sink, which must not have an identifier that already
        /// exists.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LogSink CreateSink(
            string projectName,
            LogSink sink,
            CallSettings callSettings = null)
        {
            CreateSinkRequest request = new CreateSinkRequest
            {
                ProjectName = projectName,
                Sink = sink,
            };
            return GrpcClient.CreateSink(
                request,
                _clientHelper.BuildCallOptions(null, callSettings));
        }

        /// <summary>
        /// Creates or updates a sink.
        /// </summary>
        /// <param name="sink_name">
        /// The resource name of the sink to update.
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        ///
        /// The updated sink must be provided in the request and have the
        /// same name that is specified in `sinkName`.  If the sink does not
        /// exist, it is created.
        /// </param>
        /// <param name="sink">
        /// The updated sink, whose name must be the same as the sink
        /// identifier in `sinkName`.  If `sinkName` does not exist, then
        /// this method creates a new sink.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<LogSink> UpdateSinkAsync(
            string sinkName,
            LogSink sink,
            CallSettings callSettings = null)
        {
            UpdateSinkRequest request = new UpdateSinkRequest
            {
                SinkName = sinkName,
                Sink = sink,
            };
            return GrpcClient.UpdateSinkAsync(
                request,
                _clientHelper.BuildCallOptions(null, callSettings)
            ).ResponseAsync;
        }

        /// <summary>
        /// Creates or updates a sink.
        /// </summary>
        /// <param name="sink_name">
        /// The resource name of the sink to update.
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        ///
        /// The updated sink must be provided in the request and have the
        /// same name that is specified in `sinkName`.  If the sink does not
        /// exist, it is created.
        /// </param>
        /// <param name="sink">
        /// The updated sink, whose name must be the same as the sink
        /// identifier in `sinkName`.  If `sinkName` does not exist, then
        /// this method creates a new sink.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LogSink UpdateSink(
            string sinkName,
            LogSink sink,
            CallSettings callSettings = null)
        {
            UpdateSinkRequest request = new UpdateSinkRequest
            {
                SinkName = sinkName,
                Sink = sink,
            };
            return GrpcClient.UpdateSink(
                request,
                _clientHelper.BuildCallOptions(null, callSettings));
        }

        /// <summary>
        /// Deletes a sink.
        /// </summary>
        /// <param name="sink_name">
        /// The resource name of the sink to delete.
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task DeleteSinkAsync(
            string sinkName,
            CallSettings callSettings = null)
        {
            DeleteSinkRequest request = new DeleteSinkRequest
            {
                SinkName = sinkName,
            };
            return GrpcClient.DeleteSinkAsync(
                request,
                _clientHelper.BuildCallOptions(null, callSettings)
            ).ResponseAsync;
        }

        /// <summary>
        /// Deletes a sink.
        /// </summary>
        /// <param name="sink_name">
        /// The resource name of the sink to delete.
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteSink(
            string sinkName,
            CallSettings callSettings = null)
        {
            DeleteSinkRequest request = new DeleteSinkRequest
            {
                SinkName = sinkName,
            };
            GrpcClient.DeleteSink(
                request,
                _clientHelper.BuildCallOptions(null, callSettings));
        }

    }
}