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

using Google.Rpc;
using Grpc.Core;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.V1.Internal
{
    /// <summary>
    /// Helper class to wrap operations.
    /// </summary>
    public static class ExecuteHelper
    {
        internal const string SessionResourceType = "type.googleapis.com/google.spanner.v1.Session";
        internal const string ResourceInfoMetadataKey = "google.rpc.resourceinfo-bin";

        /// <summary>
        /// Determines whether <paramref name="rpcException"/> is due to a session expiry.
        /// </summary>
        public static bool IsSessionExpiredError(this RpcException rpcException) =>
            rpcException?.StatusCode == StatusCode.NotFound &&
            GetResourceInfoTypeFromTrailers(rpcException) == SessionResourceType;

        private static string GetResourceInfoTypeFromTrailers(RpcException exception)
        {
            var entry = exception.Trailers.Get(ResourceInfoMetadataKey);
            if (entry is null)
            {
                return null;
            }
            try
            {
                return ResourceInfo.Parser.ParseFrom(entry.ValueBytes).ResourceType;
            }
            // If anything goes wrong when parsing, just treat it as if the entry was absent.
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Returns a task which can be cancelled by the given cancellation token, but otherwise observes the original
        /// task's state. This does *not* cancel any work that the original task was doing, and should be used carefully.
        /// </summary>
        internal static Task WithCancellationToken(this Task task, CancellationToken cancellationToken)
        {
            if (!cancellationToken.CanBeCanceled)
            {
                return task;
            }

            return ImplAsync();

            // Separate async method to allow the above optimization to avoid creating any new state machines etc.
            async Task ImplAsync()
            {
                var cts = new TaskCompletionSource<int>();
                using (cancellationToken.Register(() => cts.TrySetCanceled()))
                {
                    var completedTask = await Task.WhenAny(task, cts.Task).ConfigureAwait(false);
                    await completedTask.ConfigureAwait(false);
                }
            }
        }
    }
}
