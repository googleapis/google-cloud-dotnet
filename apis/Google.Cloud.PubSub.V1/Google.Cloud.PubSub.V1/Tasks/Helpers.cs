using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.PubSub.V1.Tasks
{
    static class Helpers
    {
        public static void Locked(this object o, Action action)
        {
            lock (o)
            {
                action();
            }
        }

        public static T Locked<T>(this object o, Func<T> fn)
        {
            lock (o)
            {
                return fn();
            }
        }

        public static void EnqueueAll<T>(this Queue<T> queue, IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                queue.Enqueue(item);
            }
        }

        public static void CancelIf(this CancellationTokenSource cts, bool cancel)
        {
            if (cancel)
            {
                cts.Cancel();
            }
        }

        public static bool Is<T>(this Exception e) where T : Exception =>
            e is T ||
                (e is AggregateException ae && ae.Flatten().InnerException is T);

        public static bool IsCancellation(this Exception e) => e.Is<OperationCanceledException>();

        public static T As<T>(this Exception e) where T : Exception =>
            (e as T) ?? ((e as AggregateException)?.Flatten().InnerException as T);

        public static bool IsRecoverable(this RpcException e)
        {
            // TODO: Does this method already exist somewhere?
            // TODO: Exactly which status codes are recoverable?
            switch (e.Status.StatusCode)
            {
                case StatusCode.DeadlineExceeded:
                    return true;
                default:
                    return false;
            }
        }

        public static TaskAwaitable ConfigureAwaitWithFinally(this TaskHelper taskHelper, Task task, Action finally_)
        {
            async Task Inner()
            {
                try
                {
                    await taskHelper.ConfigureAwait(task);
                }
                finally
                {
                    finally_();
                }
            }
            return taskHelper.ConfigureAwait(Inner());
        }

        public static TaskAwaitable<T> ConfigureAwaitWithFinally<T>(this TaskHelper taskHelper, Task<T> task, Action finally_)
        {
            async Task<T> Inner()
            {
                try
                {
                    return await taskHelper.ConfigureAwait(task);
                }
                finally
                {
                    finally_();
                }
            }
            return taskHelper.ConfigureAwait(Inner());
        }

        public static TaskAwaitable<bool> ConfigureAwaitHideCancellation(this TaskHelper taskHelper, Task task)
        {
            async Task<bool> Inner()
            {
                try
                {
                    await taskHelper.ConfigureAwait(task);
                    return false;
                }
                catch (AggregateException e) when (e.IsCancellation())
                {
                    return true;
                }
            }
            return taskHelper.ConfigureAwait(Inner());
        }

        public static TaskAwaitable<T> ConfigureAwaitHideCancellation<T>(this TaskHelper taskHelper, Task<T> task, T resultOnCancellation)
        {
            async Task<T> Inner()
            {
                try
                {
                    return await taskHelper.ConfigureAwait(task);
                }
                catch (AggregateException e) when (e.IsCancellation())
                {
                    return resultOnCancellation;
                }
            }
            return taskHelper.ConfigureAwait(Inner());
        }

        public static TaskAwaitable<Exception> ConfigureAwaitHideErrors(this TaskHelper taskHelper, Task task)
        {
            async Task<Exception> Inner()
            {
                try
                {
                    await taskHelper.ConfigureAwait(task);
                    return null;
                }
                catch (Exception e)
                {
                    return e;
                }
            }
            return taskHelper.ConfigureAwait(Inner());
        }

        public static TaskAwaitable<T> ConfigureAwaitHideErrors<T>(this TaskHelper taskHelper, Task<T> task, T resultOnError)
        {
            async Task<T> Inner()
            {
                try
                {
                    return await taskHelper.ConfigureAwait(task);
                }
                catch
                {
                    return resultOnError;
                }
            }
            return taskHelper.ConfigureAwait(Inner());
        }
    }
}
