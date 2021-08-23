// Copyright 2019, Google Inc. All rights reserved.
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
using Google.Api.Gax.Grpc;
using System;

namespace Google.Cloud.Firestore.V1
{
    // Partial classes to expose FirestoreSettings
    public partial class FirestoreClient
    {
        /// <summary>
        /// Returns the effective <see cref="CallSettings"/> used for each API call.
        /// This can be used to create a modified instance of <see cref="CallSettings"/> to pass
        /// for a single API request.
        /// </summary>
        public virtual FirestoreSettings Settings { get; protected set; }
    }

    public partial class FirestoreClientImpl
    {
        partial void OnConstruction(Firestore.FirestoreClient grpcClient, FirestoreSettings effectiveSettings, ClientHelper clientHelper)
        {
            Settings = effectiveSettings;
        }
    }

    // Partial class to set up resource-based routing.
    public partial class FirestoreClientImpl
    {
        /// <summary>
        /// The name of the header used for efficiently routing requests.
        /// </summary>
        /// <remarks>
        /// This should be set to the database resource name ("projects/{projectId}/databases/{databaseId}") for any RPC.
        /// For non-streaming calls, <see cref="FirestoreClientImpl"/> performs this automatically. This cannot be performed
        /// automatically for streaming calls due to the separation between initializing the stream and sending requests, so
        /// client code should set the value in a <see cref="CallSettings"/>. Typically this is performed with either the
        /// <see cref="CallSettings.FromHeader(string, string)"/> factory method or the
        /// <see cref="CallSettingsExtensions.WithHeader(CallSettings, string, string)"/> extension method.
        /// </remarks>
        public const string ResourcePrefixHeader = "google-cloud-resource-prefix";

        partial void Modify_BatchGetDocumentsRequest(ref BatchGetDocumentsRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.Database);

        partial void Modify_BeginTransactionRequest(ref BeginTransactionRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.Database);

        partial void Modify_CommitRequest(ref CommitRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.Database);

        partial void Modify_CreateDocumentRequest(ref CreateDocumentRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.Parent);

        partial void Modify_DeleteDocumentRequest(ref DeleteDocumentRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.Name);

        partial void Modify_GetDocumentRequest(ref GetDocumentRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.Name);

        partial void Modify_ListCollectionIdsRequest(ref ListCollectionIdsRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.Parent);

        partial void Modify_ListDocumentsRequest(ref ListDocumentsRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.Parent);

        partial void Modify_RollbackRequest(ref RollbackRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.Database);

        partial void Modify_RunQueryRequest(ref RunQueryRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.Parent);

        partial void Modify_UpdateDocumentRequest(ref UpdateDocumentRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.Document?.Name);

        private static void ApplyResourcePrefixHeader(ref CallSettings settings, string resource)
        {
            // If we haven't been given a resource name, just let the request as it is.
            if (string.IsNullOrEmpty(resource))
            {
                return;
            }
            string database = GetDatabaseResourceName(resource);
            settings = settings.WithHeader(ResourcePrefixHeader, database);
        }
        
        // Visible for testing

        /// <summary>
        /// Retrieves the database resource name from a full resource name.
        /// Validation is performed as far as the database ID but no further; the database ID is deemed to end at the first slash.
        /// </summary>
        /// <param name="resource">The resource name, which must start with projects/{project_id}/databases/{database_id}</param>
        /// <returns>The database resource name</returns>
        internal static string GetDatabaseResourceName(string resource)
        {
            const string projectsPrefix = "projects/";
            const string databasesPrefix = "databases/";
            if (string.CompareOrdinal(resource, 0, projectsPrefix, 0, projectsPrefix.Length) != 0)
            {
                // "projects/" doesn't match
                ThrowInvalidResource();
            }
            int endOfProjectId = resource.IndexOf('/', projectsPrefix.Length);
            if (endOfProjectId == -1 || endOfProjectId == projectsPrefix.Length)
            {
                // Empty project ID or no slash at the end of it
                ThrowInvalidResource();
            }
            if (string.CompareOrdinal(resource, endOfProjectId + 1, databasesPrefix, 0, databasesPrefix.Length) != 0)
            {
                // "databases/" doesn't match
                ThrowInvalidResource();
            }
            int startOfDatabaseId = endOfProjectId + 1 + databasesPrefix.Length;
            if (startOfDatabaseId == resource.Length)
            {
                // No database ID
                ThrowInvalidResource();
            }
            int endOfDatabaseId = resource.IndexOf('/', startOfDatabaseId);
            if (endOfDatabaseId == startOfDatabaseId)
            {
                ThrowInvalidResource();
            }
            // It's valid for the whole resource name to be the database name
            return endOfDatabaseId == -1 ? resource : resource.Substring(0, endOfDatabaseId);

            void ThrowInvalidResource() => throw new ArgumentException($"{resource} is not a valid Firestore resource name", nameof(resource));
        }
    }

    // Support for FirestoreDbBuilder.
    public sealed partial class FirestoreClientBuilder : ClientBuilderBase<FirestoreClient>
    {       
        /// <summary>
        /// Creates a <see cref="FirestoreClientBuilder"/> by copying common settings from another builder.
        /// This method is intended for use in Google.Cloud.Firestore with FirestoreDbBuilder. It will
        /// work in other scenarios, but is usually not necessary.
        /// </summary>
        /// <typeparam name="T">The client type of the builder.</typeparam>
        /// <param name="builder">The builder to copy settings from. Must not be null.</param>
        /// <returns>A FirestoreClientBuilder with common settings from <paramref name="builder"/>.</returns>
        public static FirestoreClientBuilder FromOtherBuilder<T>(ClientBuilderBase<T> builder)
        {
            GaxPreconditions.CheckNotNull(builder, nameof(builder));
            var ret = new FirestoreClientBuilder();
            ret.CopyCommonSettings(builder);
            return ret;
        }
    }
}
