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
using System.Collections.Generic;
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
        /// <seealso cref="Project.Metadata"/>
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
        /// <seealso cref="Project.Metadata"/>
        public virtual Task<string> GetCustomProjectMetadataAsync(string key, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the metadata for the VM currently running this code synchronously.
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
        /// Gets the metadata for the VM currently running this code asynchronously.
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
        /// Gets the maintenance status for the VM currently running this code synchronously.
        /// </summary>
        /// <remarks>
        /// If the <see cref="Instance.Scheduling"/>'s <see cref="Scheduling.OnHostMaintenance"/> is set to "MIGRATE", the maintenance status will change
        /// to <see cref="MaintenanceStatus.MigrateOnHost"/> 60 seconds before a maintenance event starts. This will give the application an opportunity
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
        /// Gets the maintenance status for the VM currently running this code asynchronously.
        /// </summary>
        /// <remarks>
        /// If the <see cref="Instance.Scheduling"/>'s <see cref="Scheduling.OnHostMaintenance"/> is set to "MIGRATE", the maintenance status will change
        /// to <see cref="MaintenanceStatus.MigrateOnHost"/> 60 seconds before a maintenance event starts. This will give the application an opportunity
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
        /// Gets the metadata for the project of the VM currently running this code synchronously.
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
        /// Gets the metadata for the project of the VM currently running this code asynchronously.
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

        // TODO: Do we want separate events for when standard and custom metadata changes? Same question for project metadata.
        // TODO: Should we suppress firing these when the custom metadata is updated from here?

        /// <summary>
        /// Occurs when the the instance's metadata has changed.
        /// </summary>
        /// <remarks>
        /// To wait on changes for individual parts of the metadata, see <see cref="WaitForChanges"/> or <see cref="WaitForChangesAsync"/>.
        /// </remarks>
        /// <seealso cref="GetInstanceMetadata"/>
        /// <seealso cref="GetInstanceMetadataAsync"/>
        /// <seealso cref="WaitForChanges"/>
        /// <seealso cref="WaitForChangesAsync"/>
        public virtual event EventHandler InstanceMetadataChanged
        {
            add { throw new NotImplementedException(); }
            remove { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Occurs when the the instance's maintenance status has changed.
        /// </summary>
        /// <seealso cref="GetMaintenanceStatus"/>
        /// <seealso cref="GetMaintenanceStatusAsync(CancellationToken)"/>
        /// <seealso cref="SchedulingMetadata.MaintenanceEventBehavior"/>
        public virtual event EventHandler<MaintenanceStatus> MaintenanceStatusChanged
        {
            add { throw new NotImplementedException(); }
            remove { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Occurs when the the project's metadata has changed.
        /// </summary>
        /// <remarks>
        /// To wait on changes for individual parts of the metadata, see <see cref="WaitForChanges"/> or <see cref="WaitForChangesAsync"/>.
        /// </remarks>
        /// <seealso cref="GetProjectMetadata"/>
        /// <seealso cref="GetProjectMetadataAsync"/>
        /// <seealso cref="WaitForChanges"/>
        /// <seealso cref="WaitForChangesAsync"/>
        public virtual event EventHandler ProjectMetadataChanged
        {
            add { throw new NotImplementedException(); }
            remove { throw new NotImplementedException(); }
        }

        // TODO(mdour): To support ETags (https://cloud.google.com/compute/docs/storing-retrieving-metadata#etags), we may want to have a result object
        //              returned here instead and then have overloads which take the previous result or an ETag exposed off the previous result.

        /// <summary>
        /// Waits for changes to the value or values specified by the relative URL synchronously.
        /// </summary>
        /// <param name="key">The metadata key on which to wait for changes, such as "instance/scheduling/automatic-restart"</param>
        /// <remarks>
        /// <para>
        /// If the key specified is a metadata endpoint, the result will be the value, possibly separated by newlines if there are multiple values.
        /// If the key specified is a directory, a recursive request will be made and the result will be a JSON object containing all values in the directory.
        /// </para>
        /// <para>
        /// If the timeout in the <see cref="HttpClient"/> elapses before any changes occur, this will return the current value.
        /// </para>
        /// <para>
        /// See https://cloud.google.com/compute/docs/storing-retrieving-metadata#project_and_instance_metadata for more information on available keys.
        /// </para>
        /// <para>
        /// To detect any changes at the project or instance level, use a <paramref name="key"/> of "project" or "instance".
        /// Alternatively, use <seealso cref="ProjectMetadataChanged"/> or <seealso cref="InstanceMetadataChanged"/>, respectively.
        /// </para>
        /// </remarks>
        /// <returns>The changed value(s) for an endpoint or a JSON object with the changed contents of the directory.</returns>
        /// <seealso cref="InstanceMetadataChanged"/>
        /// <seealso cref="ProjectMetadataChanged"/>
        public virtual string WaitForChanges(string key)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Waits for changes to the value or values specified by the relative URL asynchronously.
        /// </summary>
        /// <param name="key">The metadata key on which to wait for changes, such as "instance/scheduling/automatic-restart"</param>
        /// <remarks>
        /// <para>
        /// If the key specified is a metadata endpoint, the result will be the value, possibly separated by newlines if there are multiple values.
        /// If the key specified is a directory, a recursive request will be made and the result will be a JSON object containing all values in the directory.
        /// </para>
        /// <para>
        /// If the timeout in the <see cref="HttpClient"/> elapses before any changes occur, this will return the current value.
        /// </para>
        /// <para>
        /// See https://cloud.google.com/compute/docs/storing-retrieving-metadata#project_and_instance_metadata for more information on available keys.
        /// </para>
        /// <para>
        /// To detect any changes at the project or instance level, use a <paramref name="key"/> of "project" or "instance".
        /// Alternatively, use <seealso cref="ProjectMetadataChanged"/> or <seealso cref="InstanceMetadataChanged"/>, respectively.
        /// </para>
        /// </remarks>
        /// <returns>A task containing the changed value(s) for an endpoint or a JSON object with the changed contents of the directory.</returns>
        /// <seealso cref="InstanceMetadataChanged"/>
        /// <seealso cref="ProjectMetadataChanged"/>
        public virtual Task<string> WaitForChangesAsync(string key, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }
    }
}
