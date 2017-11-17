// Copyright 2017 Google Inc. All Rights Reserved.
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
using Google.Apis.Storage.v1.Data;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Storage.V1
{
    // Operations associated with PubSub notifications. See
    // https://cloud.google.com/storage/docs/reporting-changes
    // for details.
    public partial class StorageClient
    {
        /// <summary>
        /// Retrieves the service account email address that Google Cloud Storage uses for operations on
        /// other services such as Google Cloud Pub/Sub.
        /// </summary>
        /// <param name="projectId">ID of the project to retrieve the service account for. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The email address of the service account.</returns>
        public virtual string GetStorageServiceAccountEmail(string projectId, GetStorageServiceAccountEmailOptions options = null) => throw new NotImplementedException();

        /// <summary>
        /// Asynchronously retrieves the service account email address that Google Cloud Storage uses for operations on
        /// other services such as Google Cloud Pub/Sub.
        /// </summary>
        /// <param name="projectId">ID of the project to retrieve the service account for. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation, with a result returning the
        /// email address of the service account.</returns>
        public virtual Task<string> GetStorageServiceAccountEmailAsync(string projectId, GetStorageServiceAccountEmailOptions options = null, CancellationToken cancellationToken = default) =>
            throw new NotImplementedException();

        /// <summary>
        /// Creates a notification configuration.
        /// </summary>
        /// <param name="bucket">The bucket for which to create the notification configuration. Must not be null.</param>
        /// <param name="notification">The notification configuration to create. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The <see cref="Notification"/> representation of the newly-created notification configuration.</returns>
        public virtual Notification CreateNotification(string bucket, Notification notification, CreateNotificationOptions options = null) =>
            throw new NotImplementedException();

        /// <summary>
        /// Asynchronously creates a notification configuration.
        /// </summary>
        /// <param name="bucket">The bucket for which to create the notification configuration. Must not be null.</param>
        /// <param name="notification">The notification configuration to create. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation, with a result returning the
        /// <see cref="Notification"/> representation of the newly-created notification configuration.</returns>
        public virtual Task<Notification> CreateNotificationAsync(string bucket, Notification notification, CreateNotificationOptions options = null, CancellationToken cancellationToken = default) =>
            throw new NotImplementedException();

        /// <summary>
        /// Fetches a notification configuration.
        /// </summary>
        /// <param name="bucket">The bucket associated with the notification configuration. Must not be null.</param>
        /// <param name="notificationId">ID of the notification configuration to fetch. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The <see cref="Notification"/> representation of the notification configuration.</returns>
        public virtual Notification GetNotification(string bucket, string notificationId, GetNotificationOptions options = null) => throw new NotImplementedException();

        /// <summary>
        /// Asynchronously fetches a notification configuration.
        /// </summary>
        /// <param name="bucket">The bucket associated with the notification configuration. Must not be null.</param>
        /// <param name="notificationId">ID of the notification configuration to fetch. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation, with a result returning the
        /// <see cref="Notification"/> representation of the notification configuration.</returns>
        public virtual Task<Notification> GetNotificationAsync(string bucket, string notificationId, GetNotificationOptions options = null, CancellationToken cancellationToken = default) =>
            throw new NotImplementedException();

        /// <summary>
        /// Lists notification configurations associated with a bucket.
        /// </summary>
        /// <param name="bucket">The bucket for which to list associated notification configurations. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A sequence of notification configurations associated with the specified bucket.</returns>
        public virtual PagedEnumerable<Notifications, Notification> ListNotifications(string bucket, ListNotificationsOptions options = null) =>
            throw new NotImplementedException();

        /// <summary>
        /// Asynchronously lists notification configurations associated with a bucket.
        /// </summary>
        /// <param name="bucket">The bucket for which to list associated notification configurations. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>An asynchronous sequence of notification configurations associated with the specified bucket.</returns>
        public virtual PagedAsyncEnumerable<Notifications, Notification> ListNotificationsAsync(string bucket, ListNotificationsOptions options = null) =>
            throw new NotImplementedException();

        /// <summary>
        /// Deletes a notification configuration.
        /// </summary>
        /// <param name="bucket">The bucket associated with the notification configuration. Must not be null.</param>
        /// <param name="notificationId">ID of the notification configuration to delete. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        public virtual void DeleteNotification(string bucket, string notificationId, DeleteNotificationOptions options = null) => throw new NotImplementedException();

        /// <summary>
        /// Asynchronously deletes a notification configuration.
        /// </summary>
        /// <param name="bucket">The bucket associated with the notification configuration. Must not be null.</param>
        /// <param name="notificationId">ID of the notification configuration to delete. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public virtual Task DeleteNotificationAsync(string bucket, string notificationId, DeleteNotificationOptions options = null, CancellationToken cancellationToken = default) => throw new NotImplementedException();
    }
}
