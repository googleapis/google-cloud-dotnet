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
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Metadata.V1
{
    /// <summary>
    /// Abstract class providing operations for using metadata for Google Compute Engine.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This abstract class is provided to enable testability while permitting
    /// additional operations to be added in the future. You can construct a <see cref="MetadataClientImpl"/> directly.
    /// </para>
    /// <para>
    /// All instance methods declared in this class are virtual, with an implementation which simply
    /// throws <see cref="NotImplementedException"/>. All these methods are overridden in <see cref="MetadataClientImpl"/>.
    /// </para>
    /// </remarks>
    public abstract class MetadataClient
    {
        /// <summary>
        /// Creates a new <see cref="MetadataClient"/>
        /// </summary>
        /// <returns>The created <see cref="MetadataClient"/>.</returns>
        public static MetadataClient Create(ConfigurableHttpClient httpClient = null) => new MetadataClientImpl(httpClient);

        /// <summary>
        /// Creates a new <see cref="MetadataClient"/>
        /// </summary>
        /// <returns>The created <see cref="MetadataClient"/>.</returns>
        public static MetadataClient Create(IHttpClientFactory httpClientFactory) => new MetadataClientImpl(httpClientFactory);

        /// <summary>The HTTP client which is used to create requests.</summary>
        public virtual ConfigurableHttpClient HttpClient { get { throw new NotImplementedException(); } }

        /// <summary>
        /// Gets a token response which contains an access token to authorize a request synchronously.
        /// </summary>
        /// <exception cref="TokenResponseException">A status code other than success was returned from the server.</exception>
        /// <returns>The token response.</returns>
        public virtual TokenResponse GetAccessToken()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a token response which contains an access token to authorize a request asynchronously.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <exception cref="TokenResponseException">A status code other than success was returned from the server.</exception>
        /// <returns>The token response.</returns>
        public virtual Task<TokenResponse> GetAccessTokenAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the instance's custom metadata value with the specified key synchronously.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Custom metadata are just opaque key/value pairs which allow for custom configuration parameters, scripts, or other
        /// relatively small pieces of data to be associated with the instance.
        /// </para>
        /// <para>
        /// The key must conform to the following regular expression: [a-zA-Z0-9-_]+ and must be less than 128 bytes in length.
        /// </para>
        /// </remarks>
        /// <param name="key">The key of the instance's custom metadata value to get.</param>
        /// <exception cref="ArgumentException">The key is not in the proper format.</exception>
        /// <seealso cref="Instance.Metadata"/>
        public virtual string GetCustomInstanceMetadata(string key)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the instance's custom metadata value with the specified key asynchronously.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Custom metadata are just opaque key/value pairs which allow for custom configuration parameters, scripts, or other
        /// relatively small pieces of data to be associated with the instance.
        /// </para>
        /// <para>
        /// The key must conform to the following regular expression: [a-zA-Z0-9-_]+ and must be less than 128 bytes in length.
        /// </para>
        /// </remarks>
        /// <param name="key">The key of the instance's custom metadata value to get.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <exception cref="ArgumentException">The key is not in the proper format.</exception>
        /// <returns>A task representing the asynchronous operation.</returns>
        /// <seealso cref="Instance.Metadata"/>
        public virtual Task<string> GetCustomInstanceMetadataAsync(string key, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the project's custom metadata value with the specified key synchronously.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Custom metadata are just opaque key/value pairs which allow for custom configuration parameters, scripts, or other
        /// relatively small pieces of data to be associated with the project.
        /// </para>
        /// <para>
        /// The key must conform to the following regular expression: [a-zA-Z0-9-_]+ and must be less than 128 bytes in length.
        /// </para>
        /// </remarks>
        /// <param name="key">The key of the project's custom metadata to get.</param>
        /// <exception cref="ArgumentException">The key is not in the proper format.</exception>
        /// <seealso cref="Project.CommonInstanceMetadata"/>
        public virtual string GetCustomProjectMetadata(string key)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the project's custom metadata value with the specified key asynchronously.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Custom metadata are just opaque key/value pairs which allow for custom configuration parameters, scripts, or other
        /// relatively small pieces of data to be associated with the project.
        /// </para>
        /// <para>
        /// The key must conform to the following regular expression: [a-zA-Z0-9-_]+ and must be less than 128 bytes in length.
        /// </para>
        /// </remarks>
        /// <param name="key">The key of the project's custom metadata value to get.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <exception cref="ArgumentException">The key is not in the proper format.</exception>
        /// <returns>A task representing the asynchronous operation.</returns>
        /// <seealso cref="Project.CommonInstanceMetadata"/>
        public virtual Task<string> GetCustomProjectMetadataAsync(string key, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Synchronously gets the metadata for the VM currently running this code.
        /// </summary>
        /// <remarks>
        /// The instance metadata contains information about the instance, such as the host name, instance ID, and custom metadata and it can be
        /// accessed without authentication from an application running on the instance. Check <see cref="IsServerAvailable"/> or
        /// <see cref="IsServerAvailableAsync(CancellationToken)"/> to determine if the metadata can be accessed.
        /// </remarks>
        /// <returns>The <see cref="Instance"/> representing the metadata.</returns>
        public virtual Instance GetInstanceMetadata()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously gets the metadata for the VM currently running this code.
        /// </summary>
        /// <remarks>
        /// The instance metadata contains information about the instance, such as the host name, instance ID, and custom metadata and it can be
        /// accessed without authentication from an application running on the instance. Check <see cref="IsServerAvailable"/> or
        /// <see cref="IsServerAvailableAsync(CancellationToken)"/> to determine if the metadata can be accessed.
        /// </remarks>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task containing the <see cref="Instance"/> representing the metadata.</returns>
        public virtual Task<Instance> GetInstanceMetadataAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Synchronously gets the maintenance status for the VM currently running this code.
        /// </summary>
        /// <remarks>
        /// If the <see cref="Instance.Scheduling"/>'s <see cref="Scheduling.OnHostMaintenance"/> is set to "MIGRATE", the maintenance status will change
        /// to <see cref="MaintenanceStatus.Migrate"/> 60 seconds before a maintenance event starts. This will give the application an opportunity
        /// to perform any tasks in preparation for the event, such as backing up data or updating logs. Otherwise, the value will be
        /// <see cref="MaintenanceStatus.None"/>.
        /// </remarks>
        /// <returns>The current maintenance status.</returns>
        /// <seealso cref="Scheduling.OnHostMaintenance"/>
        public virtual MaintenanceStatus GetMaintenanceStatus()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously gets the maintenance status for the VM currently running this code.
        /// </summary>
        /// <remarks>
        /// If the <see cref="Instance.Scheduling"/>'s <see cref="Scheduling.OnHostMaintenance"/> is set to "MIGRATE", the maintenance status will change
        /// to <see cref="MaintenanceStatus.Migrate"/> 60 seconds before a maintenance event starts. This will give the application an opportunity
        /// to perform any tasks in preparation for the event, such as backing up data or updating logs. Otherwise, the value will be
        /// <see cref="MaintenanceStatus.None"/>.
        /// </remarks>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task containing the current maintenance status.</returns>
        /// <seealso cref="Scheduling.OnHostMaintenance"/>
        public virtual Task<MaintenanceStatus> GetMaintenanceStatusAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the metadata value(s) specified by the relative URL synchronously.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If the key specified is a metadata endpoint, the result will be the value, possibly separated by newlines if there are multiple values.
        /// If the key specified is a directory, a recursive request will be made and the result will be a JSON object containing all values in the directory.
        /// </para>
        /// <para>
        /// See https://cloud.google.com/compute/docs/storing-retrieving-metadata#project_and_instance_metadata for more information on available keys.
        /// </para>
        /// </remarks>
        /// <param name="key">The metadata key of the value(s) to get, such as "instance/scheduling/automatic-restart"</param>
        /// <exception cref="ArgumentException">
        /// <paramref name="key"/> does not have the proper format for a metadata key, which is a relative URL.
        /// </exception>
        /// <returns>The <see cref="MetadataResult"/> with the current value(s) for an endpoint or a JSON object with the contents of the directory.</returns>
        /// <seealso cref="WaitForChange"/>
        public virtual MetadataResult GetMetadata(string key)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the metadata value(s) specified by the relative URL asynchronously.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If the key specified is a metadata endpoint, the result will be the value, possibly separated by newlines if there are multiple values.
        /// If the key specified is a directory, a recursive request will be made and the result will be a JSON object containing all values in the directory.
        /// </para>
        /// <para>
        /// See https://cloud.google.com/compute/docs/storing-retrieving-metadata#project_and_instance_metadata for more information on available keys.
        /// </para>
        /// </remarks>
        /// <param name="key">The metadata key of the value(s) to get, such as "instance/scheduling/automatic-restart"</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <exception cref="ArgumentException">
        /// <paramref name="key"/> does not have the proper format for a metadata key, which is a relative URL.
        /// </exception>
        /// <returns>A task containing the <see cref="MetadataResult"/> with the current value(s) for an endpoint or a JSON object with the contents of the directory.</returns>
        /// <seealso cref="WaitForChangeAsync"/>
        public virtual Task<MetadataResult> GetMetadataAsync(string key, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Synchronously gets the metadata for the project of the VM currently running this code.
        /// </summary>
        /// <remarks>
        /// The project metadata contains information about the project, such as its ID, and custom metadata and it can be
        /// accessed without authentication from an application running on an instance of that project. Check <see cref="IsServerAvailable"/> or
        /// <see cref="IsServerAvailableAsync(CancellationToken)"/> to determine if the metadata can be accessed.
        /// </remarks>
        /// <returns>The <see cref="Project"/> representing the metadata.</returns>
        public virtual Project GetProjectMetadata()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously gets the metadata for the project of the VM currently running this code.
        /// </summary>
        /// <remarks>
        /// The project metadata contains information about the project, such as its ID, and custom metadata and it can be
        /// accessed without authentication from an application running on an instance of that project. Check <see cref="IsServerAvailable"/> or
        /// <see cref="IsServerAvailableAsync(CancellationToken)"/> to determine if the metadata can be accessed.
        /// </remarks>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task containing the <see cref="Project"/> representing the metadata.</returns>
        public virtual Task<Project> GetProjectMetadataAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the value indicating whether the metadata server or an emulator for the server is available synchronously.
        /// </summary>
        /// <remarks>
        /// Normally, the metadata server can only be accessed from an application running on a Google Compute Engine VM instance or
        /// Google App Engine Flexible Environment, but if an metadata server emulator is available, this will also return true.
        /// </remarks>
        /// <returns>True if the normal metadata server or an emulator is available; false otherwise.</returns>
        public virtual bool IsServerAvailable()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the value indicating whether the metadata server or an emulator for the server is available asynchronously.
        /// </summary>
        /// <remarks>
        /// Normally, the metadata server can only be accessed from an application running on a Google Compute Engine VM instance or
        /// Google App Engine Flexible Environment, but if an metadata server emulator is available, this will also return true.
        /// </remarks>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task containing true if the normal metadata server or an emulator is available; false otherwise.</returns>
        public virtual Task<bool> IsServerAvailableAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Occurs when the the instance's metadata has changed.
        /// </summary>
        /// <remarks>
        /// <para>
        /// To wait on changes for individual parts of the metadata, see <see cref="WaitForChange"/> or <see cref="WaitForChangeAsync"/>.
        /// </para>
        /// <para>
        /// Note: the event may be fired on a different thread from the one used to add the handler.
        /// </para>
        /// </remarks>
        /// <seealso cref="GetInstanceMetadata"/>
        /// <seealso cref="GetInstanceMetadataAsync"/>
        /// <seealso cref="WaitForChange"/>
        /// <seealso cref="WaitForChangeAsync"/>
        public virtual event EventHandler<InstanceMetadataChangedEventArgs> InstanceMetadataChanged
        {
            add { throw new NotImplementedException(); }
            remove { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Occurs when the the instance's maintenance status has changed.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note: the event may be fired on a different thread from the one used to add the handler.
        /// </para>
        /// </remarks>
        /// <seealso cref="GetMaintenanceStatus"/>
        /// <seealso cref="GetMaintenanceStatusAsync(CancellationToken)"/>
        public virtual event EventHandler<MaintenanceStatusChangedEventArgs> MaintenanceStatusChanged
        {
            add { throw new NotImplementedException(); }
            remove { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Occurs when the the project's metadata has changed.
        /// </summary>
        /// <remarks>
        /// <para>
        /// To wait on changes for individual parts of the metadata, see <see cref="WaitForChange"/> or <see cref="WaitForChangeAsync"/>.
        /// </para>
        /// <para>
        /// Note: the event may be fired on a different thread from the one used to add the handler.
        /// </para>
        /// </remarks>
        /// <seealso cref="GetProjectMetadata"/>
        /// <seealso cref="GetProjectMetadataAsync"/>
        /// <seealso cref="WaitForChange"/>
        /// <seealso cref="WaitForChangeAsync"/>
        public virtual event EventHandler<ProjectMetadataChangedEventArgs> ProjectMetadataChanged
        {
            add { throw new NotImplementedException(); }
            remove { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Waits for changes to the value or values specified by the relative URL synchronously.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If the key specified is a metadata endpoint, the result will be the value, possibly separated by newlines if there are multiple values.
        /// If the key specified is a directory, a recursive request will be made and the result will be a JSON object containing all values in the directory.
        /// </para>
        /// <para>
        /// If the <paramref name="lastETag"/> is specified and it differs from the ETag of the value currently on the server, it indicates that the value has already
        /// changed since the last known value as obtained, and the changed value will be returned immediately.
        /// </para>
        /// <para>
        /// If the <paramref name="timeout"/> expires before changes are made, the current value will be returned. If unspecified, half the length of the timeout in
        /// the <see cref="HttpClient"/> will be used instead. Note that if the the timeout in the <see cref="HttpClient"/> elapses before the wait timeout elapses
        /// on the server a <see cref="TaskCanceledException"/> exception will occur.
        /// </para>
        /// <para>
        /// See https://cloud.google.com/compute/docs/storing-retrieving-metadata#project_and_instance_metadata for more information on available keys.
        /// </para>
        /// <para>
        /// To detect any changes at the project or instance level, use a <paramref name="key"/> of "project" or "instance".
        /// Alternatively, use <seealso cref="ProjectMetadataChanged"/> or <seealso cref="InstanceMetadataChanged"/>, respectively.
        /// </para>
        /// </remarks>
        /// <param name="key">The metadata key on which to wait for changes, such as "instance/scheduling/automatic-restart"</param>
        /// <param name="lastETag">The ETag of the last known value. May be null.</param>
        /// <param name="timeout">The amount of time to wait for changes.</param>
        /// <exception cref="ArgumentException">
        /// <paramref name="key"/> does not have the proper format for a metadata key, which is a relative URL, <paramref name="timeout"/> represents a negative duration,
        /// or <paramref name="lastETag"/> is invalid.
        /// </exception>
        /// <exception cref="TaskCanceledException">
        /// The timeout in the <see cref="HttpClient"/> elapses before the response comes back from the server.
        /// </exception>
        /// <returns>The <see cref="MetadataResult"/> with the changed value(s) for an endpoint or a JSON object with the changed contents of the directory.</returns>
        /// <seealso cref="InstanceMetadataChanged"/>
        /// <seealso cref="ProjectMetadataChanged"/>
        /// <seealso cref="GetMetadata"/>
        public virtual MetadataResult WaitForChange(string key, string lastETag = null, TimeSpan timeout = default(TimeSpan))
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Waits for changes to the value or values specified by the relative URL asynchronously.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If the key specified is a metadata endpoint, the result will be the value, possibly separated by newlines if there are multiple values.
        /// If the key specified is a directory, a recursive request will be made and the result will be a JSON object containing all values in the directory.
        /// </para>
        /// <para>
        /// If the <paramref name="lastETag"/> is specified and it differs from the ETag of the value currently on the server, it indicates that the value has already
        /// changed since the last known value as obtained, and the changed value will be returned immediately.
        /// </para>
        /// <para>
        /// If the <paramref name="timeout"/> expires before changes are made, the current value will be returned. If unspecified, half the length of the timeout in
        /// the <see cref="HttpClient"/> will be used instead. Note that if the the timeout in the <see cref="HttpClient"/> elapses before the wait timeout elapses
        /// on the server a <see cref="TaskCanceledException"/> exception will occur.
        /// </para>
        /// <para>
        /// See https://cloud.google.com/compute/docs/storing-retrieving-metadata#project_and_instance_metadata for more information on available keys.
        /// </para>
        /// <para>
        /// To detect any changes at the project or instance level, use a <paramref name="key"/> of "project" or "instance".
        /// Alternatively, use <seealso cref="ProjectMetadataChanged"/> or <seealso cref="InstanceMetadataChanged"/>, respectively.
        /// </para>
        /// </remarks>
        /// <param name="key">The metadata key on which to wait for changes, such as "instance/scheduling/automatic-restart"</param>
        /// <param name="lastETag">The ETag of the last known value. May be null.</param>
        /// <param name="timeout">The amount of time to wait for changes.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <exception cref="ArgumentException">
        /// <paramref name="key"/> does not have the proper format for a metadata key, which is a relative URL, <paramref name="timeout"/> represents a negative duration,
        /// or <paramref name="lastETag"/> is invalid.
        /// </exception>
        /// <exception cref="TaskCanceledException">
        /// The timeout in the <see cref="HttpClient"/> elapses before the response comes back from the server.
        /// </exception>
        /// <returns>
        /// A task containing the <see cref="MetadataResult"/> with the changed value(s) for an endpoint or a JSON object with the changed contents of the directory.
        /// </returns>
        /// <seealso cref="InstanceMetadataChanged"/>
        /// <seealso cref="ProjectMetadataChanged"/>
        /// <seealso cref="GetMetadataAsync"/>
        public virtual Task<MetadataResult> WaitForChangeAsync(
            string key, string lastETag = null, TimeSpan timeout = default(TimeSpan), CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }
    }
}
