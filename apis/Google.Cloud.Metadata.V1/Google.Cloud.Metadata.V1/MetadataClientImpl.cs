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

using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Compute.v1.Data;
using Google.Apis.Http;
using Google.Apis.Logging;
using Google.Apis.Util;
using Microsoft.CSharp.RuntimeBinder;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using static Google.Apis.Compute.v1.Data.Metadata;

namespace Google.Cloud.Metadata.V1
{
    /// <summary>
    /// Wrapper around metadata server requests to provide simpler operations.
    /// </summary>
    /// <remarks>
    /// This is the "default" implementation of <see cref="MetadataClient"/>. Most client code
    /// should refer to <see cref="MetadataClient"/>, creating instances with
    /// <see cref="MetadataClient.Create(ConfigurableHttpClient)"/> and
    /// <see cref="MetadataClient.Create(IHttpClientFactory)"/>. The constructor
    /// of this class is public for the sake of constructor-based dependency injection.
    /// </remarks>
    public sealed class MetadataClientImpl : MetadataClient
    {
        private const string DefaultMetadataHost = "metadata";
        private const string EmulatorEnvironmentVariable = "METADATA_EMULATOR_HOST";
        private const string MetadataFlavor = "Metadata-Flavor";
        private const string GoogleMetadataHeader = "Google";

        private static readonly CreateHttpClientArgs HttpClientArgs = new CreateHttpClientArgs();
        private static readonly Regex CustomKeyRegex = new Regex(@"\A[a-zA-Z0-9-_]{1,127}\Z", RegexOptions.Compiled);
        private static readonly Regex ETagRegex = new Regex(@"\A[a-zA-Z0-9]{16}\Z", RegexOptions.Compiled);
        private static readonly ILogger Logger = ApplicationContext.Logger.ForType<MetadataClientImpl>();
        private static readonly Lazy<string> MetadataHost = new Lazy<string>(() =>
        {
            var emulatorHost = Environment.GetEnvironmentVariable(EmulatorEnvironmentVariable);
            return string.IsNullOrEmpty(emulatorHost) ? DefaultMetadataHost : emulatorHost;
        });

        private readonly object eventLock = new object();
        private ValueWatcher instanceWatcher;
        private ValueWatcher maintenanceStatusWatcher;
        private ValueWatcher projectWatcher;

        /// <inheritdoc/>
        public override ConfigurableHttpClient HttpClient { get; }

        /// <summary>
        /// Constructs a new client for the metadata server.
        /// </summary>
        /// <param name="httpClient">The <see cref="ConfigurableHttpClient"/> to use when making requests, or null to create a default instance.</param>
        public MetadataClientImpl(ConfigurableHttpClient httpClient = null)
        {
            HttpClient = httpClient ?? new HttpClientFactory().CreateHttpClient(HttpClientArgs);
        }

        /// <summary>
        /// Constructs a new client for the metadata server.
        /// </summary>
        /// <param name="httpClientFactory">
        /// An <see cref="IHttpClientFactory"/> used to create a <see cref="ConfigurableHttpClient"/> for making requests, or null to
        /// create a default instance.
        /// </param>
        public MetadataClientImpl(IHttpClientFactory httpClientFactory)
            : this((httpClientFactory ?? new HttpClientFactory()).CreateHttpClient(HttpClientArgs))
        {
        }

        private static string CreateAbsoluteUrl(string relativeUrl) =>
            $"http://{MetadataHost.Value}/computeMetadata/v1/{relativeUrl}";

        private static string GetETag(HttpResponseMessage response)
        {
            IEnumerable<string> eTagValues;
            response.Headers.TryGetValues("ETag", out eTagValues);
            return eTagValues?.FirstOrDefault();
        }

        private static T GetResult<T>(Func<CancellationToken, Task<T>> operation)
        {
            try
            {
                return operation(CancellationToken.None).Result;
            }
            catch (AggregateException e)
            {
                throw e.InnerExceptions.FirstOrDefault() ?? e;
            }
        }

        private static Instance ParseInstanceMetadata(string content)
        {
            try
            {
                dynamic obj = JObject.Parse(content);
                return new Instance
                {
                    CpuPlatform = obj.cpuPlatform,
                    Description = obj.description,
                    Disks = ((JArray)obj.disks)?.ToList(disk => new AttachedDisk
                    {
                        DeviceName = disk.deviceName,
                        Index = disk.index,
                        Mode = disk.mode,
                        Type = disk.type
                    }),
                    Id = obj.id,
                    MachineType = obj.machineType,
                    Metadata = new Apis.Compute.v1.Data.Metadata()
                    {
                        Items = ((JObject)obj.attributes)?.ToList(attribute => new ItemsData
                        {
                            Key = attribute.Name,
                            Value = attribute.Value
                        })
                    },
                    Name = obj.hostname,
                    NetworkInterfaces = ((JArray)obj.networkInterfaces)?.ToList(networkInterface => new NetworkInterface
                    {
                        AccessConfigs = ((JArray)networkInterface.accessConfigs)?.ToList(accessConfig => new AccessConfig
                        {
                            NatIP = accessConfig.externalIp,
                            Type = accessConfig.type
                        }),
                        Network = networkInterface.network,
                        NetworkIP = networkInterface.ip
                    }),
                    Scheduling = new Scheduling
                    {
                        AutomaticRestart = obj.scheduling?.automaticRestart,
                        OnHostMaintenance = obj.scheduling?.onHostMaintenance,
                        Preemptible = obj.scheduling?.preemptible
                    },
                    ServiceAccounts = ((JObject)obj.serviceAccounts)?.ToList(serviceAccount => new ServiceAccount
                    {
                        Email = serviceAccount.Name,
                        Scopes = ((JArray)serviceAccount.Value?.scopes)?.ToList(scope => (string)scope.Value)
                    }),
                    Tags = new Tags
                    {
                        Items = ((JArray)obj.tags)?.ToList(tag => (string)tag.Value)
                    },
                    Zone = obj.zone
                };
            }
            catch (JsonException e)
            {
                Logger.Error(e, $"Exception was caught when deserializing {nameof(Instance)}. Content is: {content}");
                throw new FormatException("Unexpected instance metadata format.", e);
            }
            catch (RuntimeBinderException e)
            {
                Logger.Error(e, $"Exception was caught when deserializing {nameof(Instance)}. Content is: {content}");
                throw new FormatException("Unexpected instance metadata format.", e);
            }
        }

        private static MaintenanceStatus ParseMaintenanceStatus(string content)
        {
            switch (content)
            {
                case "NONE": return MaintenanceStatus.None;
                case "MIGRATE_ON_HOST_MAINTENANCE": return MaintenanceStatus.Migrate;
                default: return MaintenanceStatus.Unknown;
            }
        }

        private static Project ParseProjectMetadata(string content)
        {
            try
            {
                dynamic obj = JObject.Parse(content);
                return new Project
                {
                    CommonInstanceMetadata = new Apis.Compute.v1.Data.Metadata
                    {
                        Items = ((JObject)obj.attributes)?.ToList(attribute => new ItemsData
                        {
                            Key = attribute.Name,
                            Value = attribute.Value
                        })
                    },
                    Id = obj.numericProjectId,
                    Name = obj.projectId
                };
            }
            catch (JsonException e)
            {
                Logger.Error(e, $"Exception was caught when deserializing {nameof(Project)}. Content is: {content}");
                throw new FormatException("Unexpected project metadata format.", e);
            }
            catch (RuntimeBinderException e)
            {
                Logger.Error(e, $"Exception was caught when deserializing {nameof(Project)}. Content is: {content}");
                throw new FormatException("Unexpected project metadata format.", e);
            }
        }

        private async Task<HttpResponseMessage> RequestMetadataAsync(string relativeUrl, CancellationToken cancellationToken, bool requireMetadataFlavorHeader = true)
        {
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, CreateAbsoluteUrl(relativeUrl));
            httpRequest.Headers.Add(MetadataFlavor, GoogleMetadataHeader);
            var response = await HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            if (requireMetadataFlavorHeader)
            {
                IEnumerable<string> metadataFlavorHeaders;
                if (!response.Headers.TryGetValues(MetadataFlavor, out metadataFlavorHeaders) ||
                    !metadataFlavorHeaders.Contains(GoogleMetadataHeader))
                {
                    throw new HttpRequestException("The response from the metadata server was not valid.");
                }
            }
            return response;
        }

        private static void ValidateMetadataKey(string key)
        {
            if (Uri.IsWellFormedUriString(key, UriKind.Relative))
            {
                var absoluteUrl = CreateAbsoluteUrl(key);

                Uri uri;
                if (Uri.TryCreate(absoluteUrl, UriKind.Absolute, out uri))
                {
                    if (StringComparer.OrdinalIgnoreCase.Equals(absoluteUrl, uri.AbsoluteUri) &&
                        string.IsNullOrEmpty(uri.Query))
                    {
                        return;
                    }
                }
            }

            throw new ArgumentException("Invalid metadata key.", nameof(key));
        }

        private static void ValidateCustomMetadataKey(string key)
        {
            if (!CustomKeyRegex.IsMatch(key))
            {
                throw new ArgumentException("Invalid custom metadata key.", nameof(key));
            }
        }

        private static void ValidateETag(string eTag, string paramName)
        {
            if (eTag != null && !ETagRegex.IsMatch(eTag))
            {
                throw new ArgumentException("Invalid ETag.", paramName);
            }
        }

        /// <inheritdoc/>
        public override TokenResponse GetAccessToken() => GetResult(GetAccessTokenAsync);

        /// <inheritdoc/>
        public override async Task<TokenResponse> GetAccessTokenAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            var response = await RequestMetadataAsync("instance/service-accounts/default/token", cancellationToken, requireMetadataFlavorHeader: false).ConfigureAwait(false);
            return await TokenResponse.FromHttpResponseAsync(response, SystemClock.Default, Logger).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public override string GetCustomInstanceMetadata(string key) => GetResult(token => GetCustomInstanceMetadataAsync(key, token));

        /// <inheritdoc/>
        public override async Task<string> GetCustomInstanceMetadataAsync(string key, CancellationToken cancellationToken = default(CancellationToken))
        {
            ValidateCustomMetadataKey(key);
            var response = await RequestMetadataAsync("instance/attributes/" + key, cancellationToken).ConfigureAwait(false);
            return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public override string GetCustomProjectMetadata(string key) => GetResult(token => GetCustomProjectMetadataAsync(key, token));

        /// <inheritdoc/>
        public override async Task<string> GetCustomProjectMetadataAsync(string key, CancellationToken cancellationToken = default(CancellationToken))
        {
            ValidateCustomMetadataKey(key);
            var response = await RequestMetadataAsync("project/attributes/" + key, cancellationToken).ConfigureAwait(false);
            return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public override Instance GetInstanceMetadata() => GetResult(GetInstanceMetadataAsync);

        /// <inheritdoc/>
        public override async Task<Instance> GetInstanceMetadataAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            var response = await RequestMetadataAsync("instance?recursive=true", cancellationToken).ConfigureAwait(false);
            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return ParseInstanceMetadata(content);
        }

        /// <inheritdoc/>
        public override MaintenanceStatus GetMaintenanceStatus() => GetResult(GetMaintenanceStatusAsync);

        /// <inheritdoc/>
        public override async Task<MaintenanceStatus> GetMaintenanceStatusAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            var response = await RequestMetadataAsync("instance/maintenance-event", cancellationToken).ConfigureAwait(false);
            return ParseMaintenanceStatus(await response.Content.ReadAsStringAsync().ConfigureAwait(false));
        }

        /// <inheritdoc/>
        public override MetadataResult GetMetadata(string key) => GetResult(token => GetMetadataAsync(key, token));

        /// <inheritdoc/>
        public override Task<MetadataResult> GetMetadataAsync(string key, CancellationToken cancellationToken = default(CancellationToken))
        {
            ValidateMetadataKey(key);

            // Always add recursive. It is ignored for values and required for directories when waiting for changes.
            return GetMetadataCoreAsync(key + "?recursive=true", cancellationToken);
        }

        private async Task<MetadataResult> GetMetadataCoreAsync(string key, CancellationToken cancellationToken)
        {
            var response = await RequestMetadataAsync(key, cancellationToken).ConfigureAwait(false);
            return new MetadataResult(
                await response.Content.ReadAsStringAsync().ConfigureAwait(false),
                GetETag(response));
        }

        /// <inheritdoc/>
        public override Project GetProjectMetadata() => GetResult(GetProjectMetadataAsync);

        /// <inheritdoc/>
        public override async Task<Project> GetProjectMetadataAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            var response = await RequestMetadataAsync("project?recursive=true", cancellationToken).ConfigureAwait(false);
            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return ParseProjectMetadata(content);
        }

        /// <inheritdoc/>
        public override bool IsServerAvailable() => GetResult(IsServerAvailableAsync);

        /// <inheritdoc/>
        public override async Task<bool> IsServerAvailableAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                var response = await RequestMetadataAsync("", cancellationToken).ConfigureAwait(false);
                if (!response.IsSuccessStatusCode)
                {
                    return false;
                }
                IEnumerable<string> values;
                return response.Headers.TryGetValues(MetadataFlavor, out values) && values.Contains(GoogleMetadataHeader);
            }
            catch (HttpRequestException)
            {
                return false;
            }
        }
        
        private void HookChangeEvent(ref ValueWatcher watcher, Delegate value, string path, Action<ValueWatcher, string> changeAction)
        {
            lock (eventLock)
            {
                if (watcher == null)
                {
                    watcher = new ValueWatcher(this, path, changeAction);
                }

                watcher.Event = Delegate.Combine(watcher.Event, value);
            }
        }

        private void UnhookChangeEvent(ref ValueWatcher watcher, Delegate value)
        {
            lock (eventLock)
            {
                if (watcher == null)
                {
                    return;
                }

                watcher.Event = Delegate.Remove(watcher.Event, value);
                if (watcher.Event == null)
                {
                    watcher.Stop();
                    watcher = null;
                }
            }
        }

        /// <inheritdoc/>
        public override event EventHandler<InstanceMetadataChangedEventArgs> InstanceMetadataChanged
        {
            add
            {
                HookChangeEvent(ref instanceWatcher, value, "instance", (sender, newValue) =>
                {
                    var temp = sender.Event as EventHandler<InstanceMetadataChangedEventArgs>;
                    temp?.Invoke(this, new InstanceMetadataChangedEventArgs(ParseInstanceMetadata(newValue)));
                });
            }
            remove
            {
                UnhookChangeEvent(ref instanceWatcher, value);
            }
        }

        /// <inheritdoc/>
        public override event EventHandler<MaintenanceStatusChangedEventArgs> MaintenanceStatusChanged
        {
            add
            {
                HookChangeEvent(ref maintenanceStatusWatcher, value, "instance/maintenance-event", (sender, newValue) =>
                {
                    var temp = sender.Event as EventHandler<MaintenanceStatusChangedEventArgs>;
                    temp?.Invoke(this, new MaintenanceStatusChangedEventArgs(ParseMaintenanceStatus(newValue)));
                });
            }
            remove
            {
                UnhookChangeEvent(ref maintenanceStatusWatcher, value);
            }
        }

        /// <inheritdoc/>
        public override event EventHandler<ProjectMetadataChangedEventArgs> ProjectMetadataChanged
        {
            add
            {
                HookChangeEvent(ref projectWatcher, value, "project", (sender, newValue) =>
                {
                    var temp = sender.Event as EventHandler<ProjectMetadataChangedEventArgs>;
                    temp?.Invoke(this, new ProjectMetadataChangedEventArgs(ParseProjectMetadata(newValue)));
                });
            }
            remove
            {
                UnhookChangeEvent(ref projectWatcher, value);
            }
        }

        /// <inheritdoc/>
        public override MetadataResult WaitForChange(string key, string lastETag = null, TimeSpan timeout = default(TimeSpan)) =>
            GetResult(token => WaitForChangeAsync(key, lastETag, timeout, token));

        /// <inheritdoc/>
        public override Task<MetadataResult> WaitForChangeAsync(string key, string lastETag = null, TimeSpan timeout = default(TimeSpan), CancellationToken cancellationToken = default(CancellationToken))
        {
            ValidateMetadataKey(key);
            ValidateETag(lastETag, nameof(lastETag));

            if (timeout.Ticks < 0)
            {
                throw new ArgumentException("The specified timeout represents a negative duration.", nameof(timeout));
            }

            if (timeout == TimeSpan.Zero)
            {
                timeout = new TimeSpan(HttpClient.Timeout.Ticks / 2);
            }

            // Always add recursive. It is ignored for values and required for directories when waiting for changes.
            key += $"?wait_for_change=true&recursive=true&timeout_sec={(int)timeout.TotalSeconds}";
            if (lastETag != null)
            {
                key += $"&last_etag={lastETag}";
            }
            return GetMetadataCoreAsync(key, cancellationToken);
        }

        private class ValueWatcher
        {
            private readonly CancellationTokenSource cancellationTokenSource;
            private readonly Action<ValueWatcher, string> changeAction;
            private readonly MetadataClientImpl client;
            private readonly string path;
            private readonly ManualResetEventSlim ready;
            private readonly Task waitTask;

            public Delegate Event { get; set; }

            public ValueWatcher(MetadataClientImpl client, string path, Action<ValueWatcher, string> changeAction)
            {
                this.changeAction = changeAction;
                this.client = client;
                this.path = path;
                
                cancellationTokenSource = new CancellationTokenSource();
                ready = new ManualResetEventSlim(false);
                waitTask = Task.Run(WaitForChange);

                if (!ready.Wait(TimeSpan.FromSeconds(10)))
                {
                    var exception = waitTask.Exception;
                    var innerException = exception?.InnerExceptions.FirstOrDefault() ?? exception;
                    throw new InvalidOperationException($"Unable to wait for changes on {path}", innerException);
                }
            }

            public void Stop()
            {
                cancellationTokenSource.Cancel();
            }

            private async Task WaitForChange()
            {
                // Always add recursive. It is ignored for values and required for directories when waiting for changes and ETags differ between
                // recursive and non-recursive requests for directories.
                var response = await client.RequestMetadataAsync(path + "?recursive=true", cancellationTokenSource.Token).ConfigureAwait(false);
                var lastETag = GetETag(response);
                ready.Set();

                var timeout = new TimeSpan(client.HttpClient.Timeout.Ticks / 2);

                while (!cancellationTokenSource.Token.IsCancellationRequested)
                {
                    try
                    {
                        var result = await client.WaitForChangeAsync(path, lastETag, timeout, cancellationTokenSource.Token).ConfigureAwait(false);

                        if (lastETag != result.ETag)
                        {
                            changeAction(this, result.Content);
                            lastETag = result.ETag;
                        }
                    }
                    catch (OperationCanceledException) { }
                }
            }
        }
    }
}
