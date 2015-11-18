// Copyright 2015 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Storage.v1.Data;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Storage.v1.ClientWrapper
{
    /// <summary>
    /// Wrapper around <see cref="StorageService"/> to provide simpler operations.
    /// </summary>
    public class StorageClient
    {
        /// <summary>
        /// The underlying storage service object used by this client.
        /// </summary>
        /// <remarks>
        /// The <see cref="StorageClient"/> class only provides convenience operations built on top of
        /// an existing service object. Any more complex operations which are not supported by this wrapper may wish
        /// to use the same service object as the wrapper, in order to take advantage of its configuration (for authentication,
        /// application naming etc).
        /// </remarks>
        public StorageService Service { get; }

        /// <summary>
        /// Constructs a new client wrapping the given <see cref="StorageService"/>.
        /// </summary>
        /// <param name="service">The service to wrap. Must not be null.</param>
        public StorageClient(StorageService service)
        {
            Service = service;
        }

        /// <summary>
        /// Constructs a new client by creating a <see cref="StorageService"/> for the given <see cref="BaseClientService.Initializer"/>.
        /// </summary>
        /// <param name="initializer">The initializer to use in the service. Must not be null.</param>
        public StorageClient(BaseClientService.Initializer initializer) : this(new StorageService(initializer))
        {
        }

        /// <summary>
        /// Asynchronously creates a new <see cref="StorageClient"/> from the default application credentials.
        /// </summary>
        /// <remarks>
        /// The application credentials are available to developers by running <c>gcloud auth</c> from the
        /// command line, and are available automatically on Google Cloud Platform hosts.
        /// </remarks>
        /// <param name="applicationName">The name of the application to create a client for. Must not be null.</param>
        /// <returns>A client configured with the application-default credentials.</returns>
        public static async Task<StorageClient> FromApplicationCredentials(string applicationName)
        {
            var initializer = new BaseClientService.Initializer
            {
                HttpClientInitializer = await GoogleCredential.GetApplicationDefaultAsync(),
                ApplicationName = applicationName,
            };
            return new StorageClient(initializer);
        }

        /// <summary>
        /// Asynchronously lists all the buckets for a given project.
        /// </summary>
        /// <remarks>
        /// This is a convenience method for calling <see cref="ListAllBucketsAsync(string, CancellationToken)"/>.
        /// </remarks>
        /// <param name="project">The project to list the buckets from. Must not be null.</param>
        public Task<List<Bucket>> ListAllBucketsAsync(string project)
        {
            return ListAllBucketsAsync(project, token: default(CancellationToken));
        }

        /// <summary>
        /// Asynchronously lists all the buckets for a given project.
        /// </summary>
        /// <remarks>
        /// This lists all the buckets within a project before the returned task completes.
        /// This does not support reporting progress, or streaming the results.
        /// </remarks>
        /// <param name="project">The project to list the buckets from. Must not be null.</param>
        /// <param name="token">The token to monitor for cancellation requests. The default value is None.</param>
        /// <returns>A list of all buckets within the project.</returns>
        public async Task<List<Bucket>> ListAllBucketsAsync(string project, CancellationToken token = default(CancellationToken))
        {
            List<Bucket> result = new List<Bucket>();
            string pageToken = null;
            do
            {
                var request = Service.Buckets.List(project);
                if (pageToken != null)
                {
                    request.PageToken = pageToken;
                }
                var page = await request.ExecuteAsync(token).ConfigureAwait(false);
                result.AddRange(page.Items);
                pageToken = page.NextPageToken;
            } while (pageToken != null);
            return result;
        }
    }
}
