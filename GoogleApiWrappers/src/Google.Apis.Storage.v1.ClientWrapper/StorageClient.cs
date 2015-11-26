// Copyright 2015 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.
using Google.Apis.Auth.OAuth2;
using Google.Apis.Common;
using Google.Apis.Services;
using Google.Apis.Storage.v1.Data;
using Google.Common;
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
        private static readonly Paginator<Bucket, BucketsResource.ListRequest, Buckets, string> s_paginator =
            new Paginator<Bucket, BucketsResource.ListRequest, Buckets, string>(
                (request, token) => { request.PageToken = token; return request; },
                buckets => buckets.NextPageToken,
                buckets => buckets.Items,
                null);

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
            Preconditions.CheckNotNull(service, nameof(service));
            Service = service;
        }

        /// <summary>
        /// Constructs a new client by creating a <see cref="StorageService"/> which uses the
        /// given <see cref="BaseClientService.Initializer"/> for request initialization.
        /// </summary>
        /// <param name="initializer">The initializer to use in the service. Must not be null.</param>
        public StorageClient(BaseClientService.Initializer initializer)
            : this(new StorageService(Preconditions.CheckNotNull(initializer, nameof(initializer))))
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
            Preconditions.CheckNotNull(applicationName, nameof(applicationName));
            var initializer = new BaseClientService.Initializer
            {
                HttpClientInitializer = await GoogleCredential.GetApplicationDefaultAsync(),
                ApplicationName = applicationName,
            };
            return new StorageClient(initializer);
        }

        /// <summary>
        /// Asynchronously lists the buckets for a given project.
        /// </summary>
        /// <remarks>
        /// This lists the buckets within a project asynchronously and lazily.
        /// </remarks>
        /// <remarks>
        /// This is a convenience method for calling <see cref="ListAllBucketsAsync(string, ListBucketsOptions, CancellationToken)"/>.
        /// </remarks>
        /// <param name="project">The project to list the buckets from. Must not be null.</param>
        public IAsyncEnumerable<Bucket> ListBucketsAsync(string project)
        {
            Preconditions.CheckNotNull(project, nameof(project));
            return ListBucketsAsync(project, null);
        }

        /// <summary>
        /// Asynchronously lists the buckets for a given project.
        /// </summary>
        /// <remarks>
        /// This lists the buckets within a project asynchronously and lazily.
        /// </remarks>
        /// <param name="project">The project to list the buckets from. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case
        /// defaults will be supplied.</param>
        /// <returns>A list of all buckets within the project.</returns>
        public IAsyncEnumerable<Bucket> ListBucketsAsync(string project, ListBucketsOptions options)
        {
            Preconditions.CheckNotNull(project, nameof(project));
            var initialRequest = CreateRequest(project, options);
            return s_paginator.FetchAsync(initialRequest, (req, cancellationToken) => req.ExecuteAsync(cancellationToken));
        }

        /// <summary>
        /// Lists the buckets for a given project, synchronously but lazily.
        /// </summary>
        /// <remarks>
        /// This method fetches the buckets lazily, making requests to the underlying service
        /// for a page of results at a time, as required. To retrieve all the buckets in a single collection,
        /// simply call LINQ's <c>ToList()</c> method on the returned sequence.
        /// </remarks>
        /// <param name="project">The project to list the buckets from. Must not be null.</param>
        /// <returns>A sequence of all buckets within the project.</returns>
        public IEnumerable<Bucket> ListBuckets(string project)
        {
            return ListBuckets(project, null);
        }

        /// <summary>
        /// Lists the buckets for a given project, synchronously but lazily.
        /// </summary>
        /// <remarks>
        /// This method fetches the buckets lazily, making requests to the underlying service
        /// for a page of results at a time, as required. To retrieve all the buckets in a single collection,
        /// simply call LINQ's <c>ToList()</c> method on the returned sequence.
        /// </remarks>
        /// <param name="project">The project to list the buckets from. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case
        /// defaults will be supplied.</param>
        /// <returns>A sequence of all buckets within the project.</returns>
        public IEnumerable<Bucket> ListBuckets(string project, ListBucketsOptions options)
        {
            Preconditions.CheckNotNull(project, nameof(project));
            var initialRequest = CreateRequest(project, options);
            return s_paginator.Fetch(initialRequest, req => req.Execute());
        }

        private BucketsResource.ListRequest CreateRequest(string project, ListBucketsOptions options)
        {
            var request = Service.Buckets.List(project);
            options?.ModifyRequest(request);
            return request;
        }
    }
}
