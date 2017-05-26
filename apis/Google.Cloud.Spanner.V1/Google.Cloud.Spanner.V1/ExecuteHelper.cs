using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;

namespace Google.Cloud.Spanner.V1
{
    internal static class ExecuteHelper
    {
        public static Task<T> WithSessionChecking<T>(this Task<T> task, Func<Session> sessionFunc)
        {
            return task.ContinueWith(t =>
            {
                if (t.IsFaulted)
                {
                    RpcException rpcException = t.Exception?.InnerExceptions.OfType<RpcException>().FirstOrDefault();
                    if (rpcException.IsSessionExpiredError())
                    {
                        SessionPool.MarkSessionExpired(sessionFunc());
                    }
                }
                return t.Result;
            });
        }

        public static Task WithSessionChecking(this Task task, Func<Session> sessionFunc)
        {
            return task.ContinueWith(t =>
            {
                if (t.IsFaulted)
                {
                    RpcException rpcException = t.Exception?.InnerExceptions.OfType<RpcException>().FirstOrDefault();
                    if (rpcException.IsSessionExpiredError())
                    {
                        SessionPool.MarkSessionExpired(sessionFunc());
                    }
                    if (t.Exception != null)
                    {
                        throw t.Exception;
                    }
                }
            });
        }

        internal static bool IsSessionExpiredError(this RpcException rpcException)
        {
            return rpcException!= null && rpcException.Status.StatusCode == StatusCode.NotFound && rpcException.Message.Contains("Session not found");
        }
    }
}
