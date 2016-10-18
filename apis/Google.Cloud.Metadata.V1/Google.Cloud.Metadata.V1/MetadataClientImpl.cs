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
using Google.Apis.Json;
using Google.Apis.Logging;
using Microsoft.CSharp.RuntimeBinder;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        // TODO: Should this be created with a MetadataClient instead?
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

        private static MaintenanceStatus GetMaintenanceStatus(string result)
        {
            switch (result)
            {
                case "NONE": return MaintenanceStatus.None;
                case "MIGRATE_ON_HOST_MAINTENANCE": return MaintenanceStatus.Migrate;
                default: return MaintenanceStatus.Unknown;
            }
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

        private Task<HttpResponseMessage> RequestMetadataAsync(string relativeUrl, CancellationToken cancellationToken)
        {
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, CreateAbsoluteUrl(relativeUrl));
            httpRequest.Headers.Add(MetadataFlavor, GoogleMetadataHeader);
            return HttpClient.SendAsync(httpRequest, cancellationToken);
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

        /// <inheritdoc/>
        public override TokenResponse GetAccessToken() => GetResult(GetAccessTokenAsync);

        /// <inheritdoc/>
        public override async Task<TokenResponse> GetAccessTokenAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            // TODO: Most of this is taken from Google.Apis.Auth.OAuth2.ComputeCredential.RequestAccessTokenAsync. Perhaps move that to a helper which can be shared.
            var response = await RequestMetadataAsync("instance/service-accounts/default/token", cancellationToken).ConfigureAwait(false);

            // Read the response.
            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            var typeName = "";
            try
            {
                if (!response.IsSuccessStatusCode)
                {
                    typeName = nameof(TokenErrorResponse);
                    var error = NewtonsoftJsonSerializer.Instance.Deserialize<TokenErrorResponse>(content);
                    throw new TokenResponseException(error);
                }

                // Gets the token and sets its issued time.
                typeName = nameof(TokenResponse);
                var newToken = NewtonsoftJsonSerializer.Instance.Deserialize<TokenResponse>(content);
                newToken.Issued = DateTime.UtcNow; // TODO: This was using an IClock before.
                return newToken;
            }
            catch (JsonException ex)
            {
                Logger.Error(ex, $"Exception was caught when deserializing {typeName}. Content is: {content}");
                throw new TokenResponseException(new TokenErrorResponse
                {
                    Error = "Server response does not contain a JSON object. Status code is: " + response.StatusCode
                });
            }
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
            try
            {
                dynamic obj = JObject.Parse(content);
                // TODO: Detect when format is missing keys here
                return new Instance
                {
                    CpuPlatform = obj.cpuPlatform,
                    Description = obj.description,
                    Disks = ((JArray)obj.disks).ToList(disk => new AttachedDisk
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
                        Items = ((JObject)obj.attributes).ToList(attribute => new ItemsData
                        {
                            Key = attribute.Name,
                            Value = attribute.Value
                        })
                    },
                    Name = obj.hostname,
                    NetworkInterfaces = ((JArray)obj.networkInterfaces).ToList(networkInterface => new NetworkInterface
                    {
                        AccessConfigs = ((JArray)networkInterface.accessConfigs).ToList(accessConfig => new AccessConfig
                        {
                            NatIP = accessConfig.externalIp,
                            Type = accessConfig.type
                        }),
                        Network = networkInterface.network,
                        NetworkIP = networkInterface.ip
                    }),
                    Scheduling = new Scheduling
                    {
                        AutomaticRestart = obj.scheduling.automaticRestart,
                        OnHostMaintenance = obj.scheduling.onHostMaintenance,
                        Preemptible = obj.scheduling.preemptible
                    },
                    ServiceAccounts = ((JObject)obj.serviceAccounts).ToList(serviceAccount => new ServiceAccount
                    {
                        Email = serviceAccount.Name,
                        Scopes = ((JArray)serviceAccount.Value.scopes).ToList(scope => (string)scope.Value)
                    }),
                    Tags = new Tags
                    {
                        Items = ((JArray)obj.tags).ToList(tag => (string)tag.Value)
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

        /// <inheritdoc/>
        public override MaintenanceStatus GetMaintenanceStatus() => GetResult(GetMaintenanceStatusAsync);

        /// <inheritdoc/>
        public override async Task<MaintenanceStatus> GetMaintenanceStatusAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            var response = await RequestMetadataAsync("instance/maintenance-event", cancellationToken).ConfigureAwait(false);
            return GetMaintenanceStatus(await response.Content.ReadAsStringAsync().ConfigureAwait(false));
        }

        /// <inheritdoc/>
        public override Project GetProjectMetadata() => GetResult(GetProjectMetadataAsync);

        /// <inheritdoc/>
        public override async Task<Project> GetProjectMetadataAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            var response = await RequestMetadataAsync("project?recursive=true", cancellationToken).ConfigureAwait(false);
            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            try
            {
                dynamic obj = JObject.Parse(content);
                // TODO: Detect when format is missing keys here
                return new Project
                {
                    CommonInstanceMetadata = new Apis.Compute.v1.Data.Metadata
                    {
                        Items = ((JObject)obj.attributes).ToList(attribute => new ItemsData
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
        public override event EventHandler InstanceMetadataChanged
        {
            add
            {
                HookChangeEvent(ref instanceWatcher, value, "instance?recursive=true", (sender, newValue) =>
                {
                    var temp = sender.Event as EventHandler;
                    temp?.Invoke(this, EventArgs.Empty);
                });
            }
            remove
            {
                UnhookChangeEvent(ref instanceWatcher, value);
            }
        }

        /// <inheritdoc/>
        public override event EventHandler<MaintenanceStatus> MaintenanceStatusChanged
        {
            add
            {
                HookChangeEvent(ref maintenanceStatusWatcher, value, "instance/maintenance-event", (sender, newValue) =>
                {
                    var temp = sender.Event as EventHandler<MaintenanceStatus>;
                    temp?.Invoke(this, GetMaintenanceStatus(newValue));
                });
            }
            remove
            {
                UnhookChangeEvent(ref maintenanceStatusWatcher, value);
            }
        }

        /// <inheritdoc/>
        public override event EventHandler ProjectMetadataChanged
        {
            add
            {
                HookChangeEvent(ref projectWatcher, value, "project?recursive=true", (sender, newValue) =>
                {
                    var temp = sender.Event as EventHandler;
                    temp?.Invoke(this, EventArgs.Empty);
                });
            }
            remove
            {
                UnhookChangeEvent(ref projectWatcher, value);
            }
        }

        /// <inheritdoc/>
        public override string WaitForChange(string key, TimeSpan timeout = default(TimeSpan)) => GetResult(token => WaitForChangeAsync(key, timeout, token));

        /// <inheritdoc/>
        public override async Task<string> WaitForChangeAsync(string key, TimeSpan timeout = default(TimeSpan), CancellationToken cancellationToken = default(CancellationToken))
        {
            ValidateMetadataKey(key);

            if (timeout.Ticks < 0)
            {
                throw new ArgumentException("The specified timeout represents a negative duration.", nameof(timeout));
            }

            if (timeout == TimeSpan.Zero)
            {
                timeout = new TimeSpan(HttpClient.Timeout.Ticks / 2);
            }

            key += $"?wait_for_change=true&timeout_sec={(int)timeout.TotalSeconds}";
            var response = await RequestMetadataAsync(key, cancellationToken).ConfigureAwait(false);
            return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
        }

        private class ValueWatcher
        {
            private readonly CancellationTokenSource cancellationTokenSource;
            private readonly Action<ValueWatcher, string> changeAction;
            private readonly MetadataClientImpl client;
            private readonly string path;
            private readonly Task waitTask;

            public Delegate Event { get; set; }

            public ValueWatcher(MetadataClientImpl client, string path, Action<ValueWatcher, string> changeAction)
            {
                this.changeAction = changeAction;
                this.client = client;
                this.path = path;
                
                cancellationTokenSource = new CancellationTokenSource();
                waitTask = Task.Run(WaitForChange);
            }

            public void Stop()
            {
                cancellationTokenSource.Cancel();
            }

            private string GetETag(HttpResponseMessage response)
            {
                IEnumerable<string> eTagValues;
                if (response.Headers.TryGetValues("ETag", out eTagValues))
                {
                    return eTagValues.FirstOrDefault();
                }

                return null;
            }

            private async Task WaitForChange()
            {
                var response = await client.RequestMetadataAsync(path, cancellationTokenSource.Token).ConfigureAwait(false);
                var lastETag = GetETag(response);

                var connector = path.Contains('?') ? '&' : '?';
                var pathForWaiting = $"{path}{connector}wait_for_change=true&timeout_sec={client.HttpClient.Timeout.TotalSeconds / 2}&last_etag=";

                while (!cancellationTokenSource.Token.IsCancellationRequested)
                {
                    try
                    {
                        response = await client.RequestMetadataAsync(pathForWaiting + lastETag, cancellationTokenSource.Token).ConfigureAwait(false);

                        var eTag = GetETag(response);
                        if (lastETag != eTag)
                        {
                            changeAction(this, await response.Content.ReadAsStringAsync().ConfigureAwait(false));
                            lastETag = eTag;
                        }
                    }
                    catch (OperationCanceledException) { }
                }
            }
        }
    }
}
