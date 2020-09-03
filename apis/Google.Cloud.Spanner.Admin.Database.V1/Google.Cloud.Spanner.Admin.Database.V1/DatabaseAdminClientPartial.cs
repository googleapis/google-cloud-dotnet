// Copyright 2020 Google LLC
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
using Google.Api.Gax.Grpc;
using Google.Cloud.Spanner.Common.V1;
using System;

namespace Google.Cloud.Spanner.Admin.Database.V1
{
    // Partial class to set up resource-based routing.
    public partial class DatabaseAdminClientImpl
    {
        /// <summary>
        /// The name of the header used for efficiently routing requests.
        /// </summary>
        /// <remarks>
        /// This should be set to the instance resource name ("projects/{projectId}/instances/{instanceId}") for some RPCs
        /// and to the database resource name for others ("projects/{projectId}/instances/{instanceId}/databases/{databaseId}").
        /// For non-streaming calls, <see cref="DatabaseAdminClientImpl"/> performs this automatically. This cannot be performed
        /// automatically for streaming calls due to the separation between initializing the stream and sending requests, so
        /// client code should set the value in a <see cref="CallSettings"/>. Typically this is performed with either the
        /// <see cref="CallSettings.FromHeader(string, string)"/> factory method or the
        /// <see cref="CallSettingsExtensions.WithHeader(CallSettings, string, string)"/> extension method.
        /// </remarks>
        public const string ResourcePrefixHeader = "google-cloud-resource-prefix";

        partial void Modify_ListDatabasesRequest(ref ListDatabasesRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeaderFromInstance(ref settings, request.Parent);

        partial void Modify_CreateDatabaseRequest(ref CreateDatabaseRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeaderFromInstance(ref settings, request.Parent);

        partial void Modify_GetDatabaseRequest(ref GetDatabaseRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeaderFromDatabase(ref settings, request.Name);

        partial void Modify_UpdateDatabaseDdlRequest(ref UpdateDatabaseDdlRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeaderFromDatabase(ref settings, request.Database);

        partial void Modify_DropDatabaseRequest(ref DropDatabaseRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeaderFromDatabase(ref settings, request.Database);

        partial void Modify_GetDatabaseDdlRequest(ref GetDatabaseDdlRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeaderFromDatabase(ref settings, request.Database);

        partial void Modify_CreateBackupRequest(ref CreateBackupRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeaderFromInstance(ref settings, request.Parent);

        partial void Modify_GetBackupRequest(ref GetBackupRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeaderFromBackup(ref settings, request.Name);

        partial void Modify_UpdateBackupRequest(ref UpdateBackupRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeaderFromBackup(ref settings, request.Backup.Name);

        partial void Modify_DeleteBackupRequest(ref DeleteBackupRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeaderFromBackup(ref settings, request.Name);

        partial void Modify_ListBackupsRequest(ref ListBackupsRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeaderFromInstance(ref settings, request.Parent);

        partial void Modify_RestoreDatabaseRequest(ref RestoreDatabaseRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeaderFromInstance(ref settings, request.Parent);

        partial void Modify_ListDatabaseOperationsRequest(ref ListDatabaseOperationsRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeaderFromInstance(ref settings, request.Parent);

        partial void Modify_ListBackupOperationsRequest(ref ListBackupOperationsRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeaderFromInstance(ref settings, request.Parent);

        private static void ApplyResourcePrefixHeaderFromInstance(ref CallSettings settings, string resource)
        {
            // If we haven't been given a resource name, just leave the request as it is.
            if (string.IsNullOrEmpty(resource))
            {
                return;
            }

            if (InstanceName.TryParse(resource, out InstanceName instance))
            {
                settings = settings.WithHeader(ResourcePrefixHeader, instance.ToString());
            }
        }

        private static void ApplyResourcePrefixHeaderFromDatabase(ref CallSettings settings, string resource)
        {
            // If we haven't been given a resource name, just leave the request as it is.
            if (string.IsNullOrEmpty(resource))
            {
                return;
            }

            if (DatabaseName.TryParse(resource, out DatabaseName database))
            {
                settings = settings.WithHeader(ResourcePrefixHeader, database.ToString());
            }
        }

        private static void ApplyResourcePrefixHeaderFromBackup(ref CallSettings settings, string resource)
        {
            // If we haven't been given a resource name, just leave the request as it is.
            if (string.IsNullOrEmpty(resource))
            {
                return;
            }

            if (BackupName.TryParse(resource, out BackupName backup))
            {
                var instance = InstanceName.FromProjectInstance(backup.ProjectId, backup.InstanceId);
                settings = settings.WithHeader(ResourcePrefixHeader, instance.ToString());
            }
        }
    }
}
