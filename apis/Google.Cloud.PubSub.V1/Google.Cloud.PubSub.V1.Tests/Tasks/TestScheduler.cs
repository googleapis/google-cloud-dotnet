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
            public TestTaskScheduler(int threadCount, SimpleThreadPool threadPool = null)
            {
                threadPool = threadPool ?? CachingSimpleThreadPool.Instance;
                MaximumConcurrencyLevel = threadCount;
                lock (_lock)
                {
                    _activeThreadCount = threadCount;
                }
                _events = Enumerable.Range(0, threadCount).Select(_ => new AutoResetEvent(false)).ToArray();
                _runEvent = new AutoResetEvent(false);
                _threads = Enumerable.Range(0, threadCount).Select(i => threadPool.Start(() => RunThread(_events[i]))).ToArray();
            }

            private readonly object _lock = new object();
            private readonly AutoResetEvent[] _events;
            private readonly Task[] _threads;
            private readonly AutoResetEvent _runEvent;

            private readonly Queue<Task> _taskQueue = new Queue<Task>();
            private readonly Dictionary<Task, Task> _waitingTasks = new Dictionary<Task, Task>(); // Key: Task that is waiting; Value: task that is being waited on

            private int _activeThreadCount;
            private bool _running;
            private CancellationTokenSource _disposedCts = new CancellationTokenSource();

            [ThreadStatic]
            private static Task t_currentTask;

            public override int MaximumConcurrencyLevel { get; }

            private void RunThread(AutoResetEvent ev)
            {
                while (true)
                {
                    t_currentTask = null;
                    lock (_lock)
                    {
                        _activeThreadCount -= 1;
                    }
                    while (true)
                    {
                        if (_disposedCts.IsCancellationRequested)
                        {
                            return;
                        }
                        lock (_lock)
                        {
                            if (_taskQueue.Count > 0 && _running)
                            {
                                t_currentTask = _taskQueue.Dequeue();
                                _activeThreadCount += 1;
                                break;
                            }
                        }
                        _runEvent.Set();
                        ev.WaitOne();
                    }
                    TryExecuteTask(t_currentTask);
                }
            }

            protected override IEnumerable<Task> GetScheduledTasks()
            {
                lock (_lock)
                {
                    return _taskQueue.ToArray();
                }
            }

            private void SetAllEvents()
            {
                foreach (var ev in _events)
                {
                    ev.Set();
                }
            }

            protected override void QueueTask(Task task)
            {
                lock (_lock)
                {
                    _taskQueue.Enqueue(task);
                }
                SetAllEvents();
            }

            protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
            {
                lock (_lock)
                {
                    _taskQueue.Enqueue(task);
                }
                SetAllEvents();
                return false;
            }

            public void Wait(Task task)
            {
                // Task is in a blocking wait. Track tasks being blocked on.
                lock (_lock)
                {
                    _waitingTasks.Add(t_currentTask, task);
                }
                _runEvent.Set();
                try
                {
                    task.Wait(_disposedCts.Token);
                }
                finally
                {
                    lock (_lock)
                    {
                        _waitingTasks.Remove(t_currentTask);
                    }
                }
            }

            public bool RunUntilIdle(CancellationToken ct)
            {
                lock (_lock)
                {
                    _running = true;
                }
                SetAllEvents(); // Get threads started
                while (true)
                {
                    bool moreTodo;
                    lock (_lock)
                    {
                        moreTodo = _taskQueue.Count + _activeThreadCount - _waitingTasks.Count > 0 || _waitingTasks.Values.Any(x => x.IsCompleted);
                    }
                    if (!moreTodo)
                    {
                        lock (_lock)
                        {
                            _running = false;
                        }
                        return true; // All Tasks run, now idle
                    }
                    WaitHandle.WaitAny(new[] { ct.WaitHandle, _runEvent });
                    lock (_lock)
                    {
                        if (ct.IsCancellationRequested)
                        {
                            _taskQueue.Clear();
                            _running = false;
                            SetAllEvents();
                            return false;
                        }
                        if (_waitingTasks.Count == _threads.Length)
                        {
                            _running = false;
                            throw new SchedulerException($"All {_threads.Length} threads blocking. This code requires more threads in the thread-pool.");
                        }
                    }
                }
            }

            public void Dispose()
            {
                _disposedCts.Cancel();
                SetAllEvents();
                Task.WaitAll(_threads);
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

            public override async Task<T> Run<T>(Func<Task<T>> function) =>
                await ConfigureAwait(await ConfigureAwait(Task<Task<T>>.Factory.StartNew(function, CancellationToken.None, TaskCreationOptions.None, _scheduler._taskScheduler)));

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
                    await this.ConfigureAwaitHideErrors(task);
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
                        await this.ConfigureAwaitHideErrors(task);
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

        private readonly object _lock = new object();
        private readonly LinkedList<DelayTask> _delays = new LinkedList<DelayTask>();
        private readonly TestTaskScheduler _taskScheduler;

        private int _waitCount;

        public TaskHelper TaskHelper { get; }
        public FakeClock Clock { get; } = new FakeClock();
        public int WaitCount => Interlocked.CompareExchange(ref _waitCount, 0, -1); // Just read, never xchg

        public Task Delay(TimeSpan delay, CancellationToken cancellationToken)
        {
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
            return Task.FromResult(0);
        });

        public void Run(Func<Task> taskProvider) => Run(async () =>
        {
            await TaskHelper.ConfigureAwait(taskProvider());
            return 0;
        });

        public T Run<T>(Func<Task<T>> taskProvider)
        {
            var simulatedTimeout = Clock.GetCurrentDateTimeUtc() + TimeSpan.FromHours(24);
            var realCts = new CancellationTokenSource(TimeSpan.FromSeconds(10));
            Task<Task<T>> mainTask = Task<Task<T>>.Factory.StartNew(taskProvider, CancellationToken.None, TaskCreationOptions.None, _taskScheduler);
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
                    if (mainTask.Exception != null)
                    {
                        throw mainTask.Exception;
                    }
                    if (mainTask.Result.IsCompleted)
                    {
                        if (mainTask.Result.Exception != null)
                        {
                            throw mainTask.Result.Exception;
                        }
                        return mainTask.Result.Result;
                    }
                }
                // Cancel Tasks, or move to next clock time
                var tasksToComplete = new List<TaskCompletionSource<int>>();
                lock (_lock)
                {
                    if (_delays.Count == 0)
                    {
                        throw new SchedulerException("Inconsistent state, delay queue should have content. This is probably caused by a misconfigured await.");
                    }
                    bool anyCancelled = false;
                    var node = _delays.First;
                    while (node != null)
                    {
                        var next = node.Next;
                        if (node.Value.CancellationToken.IsCancellationRequested)
                        {
                            node.Value.Tcs.SetCanceled();
                            _delays.Remove(node);
                            anyCancelled = true;
                        }
                        node = next;
                    }
                    if (!anyCancelled)
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
