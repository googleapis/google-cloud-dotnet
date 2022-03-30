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
using Google.Api.Gax.Rest;
using Google.Apis.Storage.v1;
using Google.Apis.Storage.v1.Data;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;
using static Google.Apis.Storage.v1.ProjectsResource;

namespace Google.Cloud.Storage.V1
{
    // Implementation of notifications operations
    public partial class StorageClientImpl
    {
        /// <inheritdoc />
        public override string GetStorageServiceAccountEmail(string projectId, GetStorageServiceAccountEmailOptions options = null) =>
            CreateGetServiceAccountEmailRequest(projectId, options).Execute().EmailAddress;

        /// <inheritdoc />
        public override async Task<string> GetStorageServiceAccountEmailAsync(string projectId, GetStorageServiceAccountEmailOptions options = null, CancellationToken cancellationToken = default)
        {
            var request = CreateGetServiceAccountEmailRequest(projectId, options);
            var response = await request.ExecuteAsync(cancellationToken).ConfigureAwait(false);
            return response.EmailAddress;
        }

        /// <inheritdoc />
        public override Notification CreateNotification(string bucket, Notification notification, CreateNotificationOptions options = null) =>
            CreateCreateNotificationRequest(bucket, notification, options).Execute();

        /// <inheritdoc />
        public override Task<Notification> CreateNotificationAsync(string bucket, Notification notification, CreateNotificationOptions options = null, CancellationToken cancellationToken = default) =>
            CreateCreateNotificationRequest(bucket, notification, options).ExecuteAsync(cancellationToken);

        /// <inheritdoc />
        public override IReadOnlyList<Notification> ListNotifications(string bucket, ListNotificationsOptions options = null)
        {
            ValidateBucketName(bucket);
            var list = CreateListNotificationsRequest(bucket, options).Execute().Items ?? new List<Notification>();
            return new ReadOnlyCollection<Notification>(list);
        }

        /// <inheritdoc />
        public override async Task<IReadOnlyList<Notification>> ListNotificationsAsync(string bucket, ListNotificationsOptions options = null, CancellationToken cancellationToken = default)
        {
            ValidateBucketName(bucket);
            var request = CreateListNotificationsRequest(bucket, options);
            var response = await request.ExecuteAsync(cancellationToken).ConfigureAwait(false);
            var list = response.Items ?? new List<Notification>();
            return new ReadOnlyCollection<Notification>(list);
        }

        /// <inheritdoc />
        public override Notification GetNotification(string bucket, string notificationId, GetNotificationOptions options = null) =>
            CreateGetNotificationRequest(bucket, notificationId, options).Execute();

        /// <inheritdoc />
        public override Task<Notification> GetNotificationAsync(string bucket, string notificationId, GetNotificationOptions options = null, CancellationToken cancellationToken = default) =>
            CreateGetNotificationRequest(bucket, notificationId, options).ExecuteAsync(cancellationToken);

        /// <inheritdoc />
        public override void DeleteNotification(string bucket, string notificationId, DeleteNotificationOptions options = null) =>
            CreateDeleteNotificationRequest(bucket, notificationId, options).Execute();

        /// <inheritdoc />
        public override Task DeleteNotificationAsync(string bucket, string notificationId, DeleteNotificationOptions options = null, CancellationToken cancellationToken = default) =>
            CreateDeleteNotificationRequest(bucket, notificationId, options).ExecuteAsync(cancellationToken);

        private ServiceAccountResource.GetRequest CreateGetServiceAccountEmailRequest(string projectId, GetStorageServiceAccountEmailOptions options)
        {
            GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            var request = Service.Projects.ServiceAccount.Get(projectId);
            options?.ModifyRequest(request);
            RetryHandler.MarkAsRetriable(request);
            return request;
        }

        private NotificationsResource.InsertRequest CreateCreateNotificationRequest(string bucket, Notification notification, CreateNotificationOptions options)
        {
            ValidateBucketName(bucket);
            GaxPreconditions.CheckNotNull(notification, nameof(notification));
            var request = Service.Notifications.Insert(notification, bucket);
            options?.ModifyRequest(request);
            return request;
        }

        private NotificationsResource.GetRequest CreateGetNotificationRequest(string bucket, string notificationId, GetNotificationOptions options)
        {
            ValidateBucketName(bucket);
            GaxPreconditions.CheckNotNull(notificationId, nameof(notificationId));
            var request = Service.Notifications.Get(bucket, notificationId);
            options?.ModifyRequest(request);
            RetryHandler.MarkAsRetriable(request);
            return request;
        }

        private NotificationsResource.DeleteRequest CreateDeleteNotificationRequest(string bucket, string notificationId, DeleteNotificationOptions options)
        {
            ValidateBucketName(bucket);
            GaxPreconditions.CheckNotNull(notificationId, nameof(notificationId));
            var request = Service.Notifications.Delete(bucket, notificationId);
            options?.ModifyRequest(request);
            RetryHandler.MarkAsRetriable(request);
            return request;
        }

        private NotificationsResource.ListRequest CreateListNotificationsRequest(string bucket, ListNotificationsOptions options)
        {
            var request = Service.Notifications.List(bucket);
            options?.ModifyRequest(request);
            RetryHandler.MarkAsRetriable(request);
            return request;
        }
    }
}
