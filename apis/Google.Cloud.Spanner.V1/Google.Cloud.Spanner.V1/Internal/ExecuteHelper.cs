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

using Grpc.Core;
using System;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.V1.Internal
{
    /// <summary>
    /// Helper class to wrap operations.
    /// </summary>
    public static class ExecuteHelper
    {
        /// <summary>
        /// Waits for <paramref name="task"/> to complete, handling session expiry by marking the session appropriately.
        /// </summary>
        public static async Task<T> WithSessionChecking<T>(this Task<T> task, Func<Session> sessionFunc)
        {
            try
            {
                return await task.ConfigureAwait(false);
            }
            catch (RpcException ex) when (ex.CheckForSessionExpiredError(sessionFunc))
            {
                throw;
            }
        }

        /// <summary>
        /// Waits for <paramref name="task"/> to complete, handling session expiry by marking the session appropriately.
        /// </summary>
        public static async Task WithSessionChecking(this Task task, Func<Session> sessionFunc)
        {
            try
            {
                await task.ConfigureAwait(false);
            }
            catch (RpcException ex) when (ex.CheckForSessionExpiredError(sessionFunc))
            {
                throw;
            }
        }

        private static bool CheckForSessionExpiredError(this RpcException rpcException, Func<Session> sessionFunc)
        {
            if (rpcException.IsSessionExpiredError())
            {
                SessionPool.MarkSessionExpired(sessionFunc());
            }
            return false;
        }

        /// <summary>
        /// Determines whether <paramref name="rpcException"/> is due to a session expiry.
        /// </summary>
        public static bool IsSessionExpiredError(this RpcException rpcException)
        {
            return rpcException != null && rpcException.Status.StatusCode == StatusCode.NotFound &&
                   rpcException.Message.Contains("Session not found");
        }
    }
}
