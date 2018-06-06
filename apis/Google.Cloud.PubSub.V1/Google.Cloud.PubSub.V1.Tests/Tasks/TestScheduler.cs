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

using Google.Api.Gax;
using Google.Api.Gax.Testing;
using Google.Cloud.PubSub.V1.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.PubSub.V1.Tests.Tasks
{
    /// <summary>
    /// Test scheduler that contains a <see cref="TaskScheduler"/> to track all
    /// queued and executing <see cref="Task"/>s.
    /// This *must* be used in conjuction with the <see cref="TaskHelper"/>.
    /// </summary>
    internal class TestScheduler : IScheduler, IDisposable
    {
        public sealed class SchedulerException : Exception
        {
            public SchedulerException(string message) : base(message) { }
        }

        public abstract class SimpleThreadPool
        {
            // Task completes successfully when Thread action has finished (normal exit or exception)
            public virtual Task Start(Action action) => throw new NotImplementedException();
        }

        public class DefaultSimpleThreadPool : SimpleThreadPool
        {
            public static DefaultSimpleThreadPool Instance { get; } = new DefaultSimpleThreadPool();

            private DefaultSimpleThreadPool() { }

            public override Task Start(Action action)
            {
                var threadTcs = new TaskCompletionSource<int>();
                void ActionWrapper()
                {
                    try
                    {
                        action();
                    }
                    finally
                    {
                        threadTcs.SetResult(0);
                    }
                }
                var thread = new Thread(ActionWrapper);
                thread.IsBackground = true;
                thread.Start();
                return threadTcs.Task;
            }
        }

        public class CachingSimpleThreadPool : SimpleThreadPool
        {
            public static CachingSimpleThreadPool Instance { get; } = new CachingSimpleThreadPool();

            private class ThreadRunner : IDisposable
            {
                public ThreadRunner()
                {
                    _thread = new Thread(ThreadFn);
                    _thread.IsBackground = true;
                    _thread.Start();
                }

                private Thread _thread;
                private Queue<Action> _actions = new Queue<Action>();
                private volatile bool _disposed;
                private volatile TaskCompletionSource<int> _signal = new TaskCompletionSource<int>();

                private void ThreadFn()
                {
                    while (!_disposed)
                    {
                        _signal.Task.Wait();
                        _signal = new TaskCompletionSource<int>();
                        _actions.Locked(() => _actions.Count > 0 ? _actions.Dequeue() : null)?.Invoke();
                    }
                }

                public void Run(Action action)
                {
                    _actions.Locked(() => _actions.Enqueue(action));
                    _signal.TrySetResult(0);
                }

                public void Dispose()
                {
                    _disposed = true;
                    _signal.TrySetResult(0);
                }
            }

            private const int CacheSize = 30;

            private CachingSimpleThreadPool() { }

            private Stack<ThreadRunner> _cache = new Stack<ThreadRunner>();

            public override Task Start(Action action)
            {
                var runner = _cache.Locked(() => _cache.Count == 0 ? new ThreadRunner() : _cache.Pop());
                var threadTcs = new TaskCompletionSource<int>();
                void ActionWrapper()
                {
                    try
                    {
                        action();
                    }
                    finally
                    {
                        lock (_cache)
                        {
                            if (_cache.Count >= CacheSize)
                            {
                                runner.Dispose();
                            }
                            else
                            {
                                _cache.Push(runner);
                            }
                        }
                        threadTcs.SetResult(0);
                    }
                }
                runner.Run(ActionWrapper);
                return threadTcs.Task;
            }
        }

        private class TestTaskScheduler : TaskScheduler, IDisposable
        {
            [ThreadStatic]
            private static bool t_isExecutionThread;
            [ThreadStatic]
            private static int t_threadIndex;

            private readonly object _lock = new object();
            private readonly SimpleThreadPool _threadPool;
            private readonly Task[] _threadCompletionTasks;
            private readonly CancellationTokenSource _disposeCts;
            private readonly CancellationToken _disposeToken;
            private readonly AutoResetEvent _mayBeIdleEvent = new AutoResetEvent(false);

            private readonly AutoResetEvent[] _threadEvents; // An event per thread, used to trigger threads to execute tasks.
            private readonly Task[] _threadExecutingTasks; // Tasks currently being executed by threads.
            private readonly Task[] _threadWaiting; // Contained tasks are the task being waited on.
            private readonly Queue<int> _readyThreadIndexes = new Queue<int>(); // The thead indexes that are ready to execute new tasks.
            private readonly LinkedList<Task> _taskQueue = new LinkedList<Task>(); // All tasks that need executing.

            public TestTaskScheduler(int threadCount, SimpleThreadPool threadPool = null)
            {
                _disposeCts = new CancellationTokenSource();
                _disposeToken = _disposeCts.Token;
                MaximumConcurrencyLevel = threadCount;
                _threadPool = threadPool ?? DefaultSimpleThreadPool.Instance;
                _threadEvents = new AutoResetEvent[threadCount];
                _threadCompletionTasks = new Task[threadCount];
                _threadExecutingTasks = new Task[threadCount];
                _threadWaiting = new Task[threadCount];
                for (int i = 0; i < threadCount; i++)
                {
                    int threadIndex = i;
                    _threadExecutingTasks[i] = null;
                    _threadWaiting[i] = null;
                    var ev = new AutoResetEvent(false);
                    _threadEvents[i] = ev;
                    _threadCompletionTasks[i] = _threadPool.Start(() => RunThread(threadIndex, ev));
                    _readyThreadIndexes.Enqueue(i);
                }
            }

            public override int MaximumConcurrencyLevel { get; }

            private void RunThread(int threadIndex, AutoResetEvent ev)
            {
                t_isExecutionThread = true;
                t_threadIndex = threadIndex;
                try
                {
                    var waiters = new[] { _disposeToken.WaitHandle, ev };
                    while (true)
                    {
                        var ready = WaitHandle.WaitAny(waiters);
                        if (ready == 0)
                        {
                            break;
                        }
                        Task taskToExecute;
                        lock (_lock)
                        {
                            taskToExecute = _threadExecutingTasks[threadIndex];
                        }
                        TryExecuteTask(taskToExecute);
                        lock (_lock)
                        {
                            _threadExecutingTasks[threadIndex] = null;
                            _readyThreadIndexes.Enqueue(threadIndex);
                            if (_taskQueue.Count == 0)
                            {
                                _mayBeIdleEvent.Set();
                            }
                            MaybeExecuteNextTask();
                        }
                    }
                }
                finally
                {
                    t_isExecutionThread = false;
                    t_threadIndex = 0;
                }
            }

            private void MaybeExecuteNextTask()
            {
                // Must be locked
                if (_taskQueue.Count == 0 || _readyThreadIndexes.Count == 0)
                {
                    return;
                }
                var task = _taskQueue.First.Value;
                _taskQueue.RemoveFirst();
                var threadIndex = _readyThreadIndexes.Dequeue();
                _threadExecutingTasks[threadIndex] = task;
                _threadEvents[threadIndex].Set();
            }

            protected override void QueueTask(Task task)
            {
                lock (_lock)
                {
                    _taskQueue.AddLast(task);
                    MaybeExecuteNextTask();
                }
            }

            protected override bool TryDequeue(Task task)
            {
                lock (_lock)
                {
                    return _taskQueue.Remove(task);
                }
            }

            protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
            {
                if (!t_isExecutionThread)
                {
                    return false;
                }
                if (taskWasPreviouslyQueued)
                {
                    TryDequeue(task);
                }
                return TryExecuteTask(task);
            }

            protected override IEnumerable<Task> GetScheduledTasks()
            {
                bool lockTaken = false;
                try
                {
                    Monitor.TryEnter(_lock, ref lockTaken);
                    if (lockTaken)
                    {
                        return _taskQueue.ToArray();
                    }
                    else
                    {
                        throw new NotSupportedException();
                    }
                }
                finally
                {
                    if (lockTaken)
                    {
                        Monitor.Exit(_lock);
                    }
                }
            }

            public void Wait(Task task)
            {
                if (!t_isExecutionThread)
                {
                    throw new InvalidOperationException("A non-execution thread should not be Wait()ing");
                }
                lock (_lock)
                {
                    _threadWaiting[t_threadIndex] = task;
                }
                _mayBeIdleEvent.Set();
                try
                {
                    task.Wait(_disposeToken);
                }
                finally
                {
                    lock (_lock)
                    {
                        _threadWaiting[t_threadIndex] = null;
                    }
                }
            }

            // Return true if all threads are idle, false if cancelled.
            public bool RunUntilIdle(CancellationToken ct)
            {
                _mayBeIdleEvent.Set(); // In case this is called with no tasks in the queue.
                var waiters = new[] { _disposeToken.WaitHandle, ct.WaitHandle, _mayBeIdleEvent };
                while (true)
                {
                    int ready = WaitHandle.WaitAny(waiters);
                    if (ready == 0 || ready == 1)
                    {
                        return false;
                    }
                    lock (_lock)
                    {
                        int waitingCount = _threadWaiting.Count(x => x != null);
                        bool anyWaitsCompleted = _threadWaiting.Any(x => x != null && x.IsCompleted);
                        if (waitingCount == MaximumConcurrencyLevel && !anyWaitsCompleted)
                        {
                            throw new SchedulerException($"All {waitingCount} threads blocking. This code requires more threads in the thread-pool.");
                        }
                        int activeCount = _threadExecutingTasks.Count(x => x != null);
                        if (_taskQueue.Count == 0 && activeCount == waitingCount && !anyWaitsCompleted)
                        {
                            // Everything idle.
                            return true;
                        }
                    }
                }
            }

            public void Dispose()
            {
                _disposeCts.Cancel();
                Task.WaitAll(_threadCompletionTasks);
            }
        }

        private class TestTaskHelper : TaskHelper
        {
            public TestTaskHelper(TestScheduler scheduler)
            {
                _scheduler = scheduler;
            }

            private readonly TestScheduler _scheduler;

            public override TaskScheduler TaskScheduler => _scheduler._taskScheduler;

            public override async Task<T> Run<T>(Func<Task<T>> function)
            {
                return await ConfigureAwait(await ConfigureAwait(Task.Factory.StartNew(function, CancellationToken.None, TaskCreationOptions.None, _scheduler._taskScheduler)));
            }

            public override void Wait(Task task)
            {
                Interlocked.Increment(ref _scheduler._waitCount);
                _scheduler._taskScheduler.Wait(task);
            }

            public override TaskAwaitable ConfigureAwait(Task task) => new TaskAwaitable(new TestAwaiter(task, _scheduler._taskScheduler));

            public override TaskAwaitable<T> ConfigureAwait<T>(Task<T> task) => new TaskAwaitable<T>(new TestAwaiter<T>(task, _scheduler._taskScheduler));

            public override async Task WhenAll(IEnumerable<Task> tasks)
            {
                var exceptions = new List<Exception>();
                var cancelled = false;
                foreach (var task in tasks)
                {
                    await this.ConfigureAwaitHideErrors(() => task);
                    switch (task.Status)
                    {
                        case TaskStatus.RanToCompletion:
                            break;
                        case TaskStatus.Faulted:
                            exceptions.AddRange(task.Exception.InnerExceptions);
                            break;
                        case TaskStatus.Canceled:
                            cancelled = true;
                            break;
                        default:
                            throw new InvalidOperationException($"Impossible Task status: {task.Status}");
                    }
                }
                if (exceptions.Count > 0)
                {
                    throw new AggregateException(exceptions);
                }
                if (cancelled)
                {
                    throw new TaskCanceledException();
                }
            }

            public override Task<Task> WhenAny(IEnumerable<Task> tasks)
            {
                var tcs = new TaskCompletionSource<Task>();
                foreach (var task in tasks)
                {
                    Run(async () =>
                    {
                        await this.ConfigureAwaitHideErrors(() => task);
                        tcs.TrySetResult(task);
                    });
                }
                return tcs.Task;
            }
        }

        private struct DelayTask
        {
            public DelayTask(DateTime scheduled, CancellationToken cancellationToken)
            {
                Scheduled = scheduled;
                CancellationToken = cancellationToken;
                Tcs = new TaskCompletionSource<int>();
            }
            public DateTime Scheduled { get; }
            public CancellationToken CancellationToken { get; }
            public TaskCompletionSource<int> Tcs { get; }
        }

        internal TestScheduler(int threadCount = 1)
        {
            _taskScheduler = new TestTaskScheduler(threadCount);
            TaskHelper = new TestTaskHelper(this);
        }

        private readonly Task _completedTask = Task.FromResult(0);
        private readonly object _lock = new object();
        private readonly LinkedList<DelayTask> _delays = new LinkedList<DelayTask>();
        private readonly TestTaskScheduler _taskScheduler;

        private int _waitCount;

        public TaskHelper TaskHelper { get; }
        public FakeClock Clock { get; } = new FakeClock();
        public int WaitCount => Interlocked.CompareExchange(ref _waitCount, 0, -1); // Just read, never xchg

        public Task Delay(TimeSpan delay, CancellationToken cancellationToken)
        {
            if (delay <= TimeSpan.Zero)
            {
                return _completedTask;
            }
            lock (_lock)
            {
                var delayTask = new DelayTask(Clock.GetCurrentDateTimeUtc() + delay, cancellationToken);
                var delayNode = _delays.First;
                while (delayNode != null && delayNode.Value.Scheduled < delayTask.Scheduled)
                {
                    delayNode = delayNode.Next;
                }
                if (delayNode == null)
                {
                    _delays.AddLast(delayTask);
                }
                else
                {
                    _delays.AddBefore(delayNode, delayTask);
                }
                return delayTask.Tcs.Task;
            }
        }

        public void Run(Action action) => Run(() =>
        {
            action();
            return _completedTask;
        });

        public void Run(Func<Task> taskProvider) => Run(async () =>
        {
            await TaskHelper.ConfigureAwait(taskProvider());
            return 0;
        });

        public T Run<T>(Func<Task<T>> taskProvider)
        {
            var simulatedTimeout = Clock.GetCurrentDateTimeUtc() + TimeSpan.FromHours(24);
            var realCts = new CancellationTokenSource(TimeSpan.FromSeconds(60));
            var mainTask = TaskHelper.Run(taskProvider);
            while (true)
            {
                // Run all tasks
                bool ranAll = _taskScheduler.RunUntilIdle(realCts.Token);
                if (!ranAll)
                {
                    throw new SchedulerException("Real time has reached timeout. Probably caused by recusive task creation.");
                }
                if (mainTask.IsCompleted)
                {
                    return mainTask.Result;
                }
                // Cancel Tasks, or move to next clock time
                var tasksToCancel = new List<TaskCompletionSource<int>>();
                var tasksToComplete = new List<TaskCompletionSource<int>>();
                lock (_lock)
                {
                    if (_delays.Count == 0)
                    {
                        throw new SchedulerException("Inconsistent state, delay queue should have content. This is probably caused by a misconfigured await.");
                    }
                    var node = _delays.First;
                    while (node != null)
                    {
                        var next = node.Next;
                        if (node.Value.CancellationToken.IsCancellationRequested)
                        {
                            tasksToCancel.Add(node.Value.Tcs);
                            _delays.Remove(node);
                        }
                        node = next;
                    }
                    if (tasksToCancel.Count == 0)
                    {
                        var delayTask = _delays.First.Value;
                        while (_delays.Count > 0 && _delays.First.Value.Scheduled <= delayTask.Scheduled)
                        {
                            tasksToComplete.Add(_delays.First.Value.Tcs);
                            _delays.RemoveFirst();
                        }
                        Clock.AdvanceTo(delayTask.Scheduled);
                        if (Clock.GetCurrentDateTimeUtc() > simulatedTimeout)
                        {
                            throw new SchedulerException("Simulated time has reached timeout.");
                        }
                    }
                }
                // Results must be set after the clock has changed, and outside the lock
                foreach (var tcs in tasksToCancel)
                {
                    tcs.SetCanceled();
                }
                foreach (var tcs in tasksToComplete)
                {
                    tcs.SetResult(0);
                }
            }
        }

        public void Dispose()
        {
            _taskScheduler.Dispose();
        }
    }
}
