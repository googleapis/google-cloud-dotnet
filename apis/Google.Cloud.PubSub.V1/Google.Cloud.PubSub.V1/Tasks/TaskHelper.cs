// Copyright 2017, Google Inc. All rights reserved.
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// This class uses TaskHelper.ConfigureAwait, rather than directly calling .ConfigureAwait().
// When running in a non-test environment this indirectly calls .ConfigureAwait(false).
// Disable the ConfigureAwaitChecker warning:
#pragma warning disable ConfigureAwaitChecker // CAC001

namespace Google.Cloud.PubSub.V1.Tasks
{
    internal abstract class TaskHelper
    {
        private class DefaultTaskHelper : TaskHelper
        {
            public override TaskScheduler TaskScheduler => TaskScheduler.Default;
            public override Task<T> Run<T>(Func<Task<T>> function) => Task.Run(function);
            public override void Wait(Task task) => task.Wait();
            public override TaskAwaitable ConfigureAwait(Task task) =>
                new TaskAwaitable(new ForwardingAwaiter(task.ConfigureAwait(false).GetAwaiter()));
            public override TaskAwaitable<T> ConfigureAwait<T>(Task<T> task) =>
                new TaskAwaitable<T>(new ForwardingAwaiter<T>(task.ConfigureAwait(false).GetAwaiter()));
            public override Task WhenAll(IEnumerable<Task> tasks) => Task.WhenAll(tasks);
            public override Task<Task> WhenAny(IEnumerable<Task> tasks) => Task.WhenAny(tasks);
        }

        public static TaskHelper Default { get; } = new DefaultTaskHelper();

        public virtual TaskScheduler TaskScheduler => throw new NotImplementedException();
        public virtual Task<T> Run<T>(Func<Task<T>> function) => throw new NotImplementedException();
        public virtual void Wait(Task task) => throw new NotImplementedException();
        public virtual TaskAwaitable ConfigureAwait(Task task) => throw new NotImplementedException();
        public virtual TaskAwaitable<T> ConfigureAwait<T>(Task<T> task) => throw new NotImplementedException();
        public virtual Task WhenAll(IEnumerable<Task> tasks) => throw new NotImplementedException();
        public virtual Task<Task> WhenAny(IEnumerable<Task> tasks) => throw new NotImplementedException();

        public virtual Task Run(Func<Task> function) => Run(async () =>
        {
            await ConfigureAwait(function());
            return Task.FromResult(0);
        });

        public virtual Task WhenAll(params Task[] tasks) => WhenAll((IEnumerable<Task>)tasks);

        public virtual async Task<T[]> WhenAll<T>(IEnumerable<Task<T>> tasks)
        {
            await ConfigureAwait(WhenAll((IEnumerable<Task>)tasks));
            return tasks.Select(x => x.Result).ToArray();
        }

        public virtual Task<T[]> WhenAll<T>(params Task<T>[] tasks) => WhenAll((IEnumerable<Task<T>>)tasks);

        public virtual Task<Task> WhenAny(params Task[] tasks) => WhenAny((IEnumerable<Task>)tasks);

        public virtual async Task<Task<T>> WhenAny<T>(IEnumerable<Task<T>> tasks) =>
            (Task<T>)(await ConfigureAwait(WhenAny((IEnumerable<Task>)tasks)));

        public virtual Task<Task<T>> WhenAny<T>(params Task<T>[] tasks) => WhenAny((IEnumerable<Task<T>>)tasks);
    }

    internal static class Extensions
    {
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
                catch (Exception e) when (e.IsCancellation())
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
                catch (Exception e) when (e.IsCancellation())
                {
                    return resultOnCancellation;
                }
            }
            return taskHelper.ConfigureAwait(Inner());
        }

        public static TaskAwaitable<Exception> ConfigureAwaitHideErrors(this TaskHelper taskHelper, Func<Task> task)
        {
            async Task<Exception> Inner()
            {
                try
                {
                    await taskHelper.ConfigureAwait(task());
                    return null;
                }
                catch (Exception e)
                {
                    return e;
                }
            }
            return taskHelper.ConfigureAwait(Inner());
        }

        public static TaskAwaitable<Exception> ConfigureAwaitHideErrors(this TaskHelper taskHelper, Task task) =>
            taskHelper.ConfigureAwaitHideErrors(() => task);

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
