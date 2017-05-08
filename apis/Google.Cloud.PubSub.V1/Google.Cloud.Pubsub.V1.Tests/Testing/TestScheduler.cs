using Google.Api.Gax;
using Google.Api.Gax.Testing;
using Google.Cloud.PubSub.V1.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.PubSub.V1.Tests.Testing
{
    /// <summary>
    /// Test scheduler that contains a <see cref="TaskScheduler"/> to track all
    /// queued and executing <see cref="Task"/>s.
    /// This *must* be used in conjuction with the <see cref="TaskHelper"/>.
    /// </summary>
    internal class TestScheduler : IScheduler
    {
        public sealed class SchedulerException : Exception
        {
            public SchedulerException(string message) : base(message) { }
        }

        private class TestTaskScheduler : TaskScheduler
        {
            public TestTaskScheduler(int threadCount)
            {
                MaximumConcurrencyLevel = threadCount;
                lock (_lock)
                {
                    _activeThreadCount = threadCount;
                }
                _threads = Enumerable.Range(0, threadCount).Select(_ =>
                {
                    var thread = new Thread(RunThread);
                    thread.IsBackground = true;
                    thread.Start();
                    return thread;
                }).ToArray();
            }

            private object _lock = new object();
            private Queue<Task> _taskQueue = new Queue<Task>();
            private Thread[] _threads;
            private int _activeThreadCount;
            private Dictionary<Task, Task> _waitingTasks = new Dictionary<Task, Task>(); // Key: Task that is waiting; Value: task that is being waited on

            [ThreadStatic]
            private static Task t_currentTask;

            public override int MaximumConcurrencyLevel { get; }

            private void RunThread()
            {
                while (true)
                {
                    lock (_lock)
                    {
                        t_currentTask = null;
                        _activeThreadCount -= 1;
                        Monitor.PulseAll(_lock);
                        while (_taskQueue.Count == 0)
                        {
                            Monitor.Wait(_lock);
                        }
                        t_currentTask = _taskQueue.Dequeue();
                        _activeThreadCount += 1;
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

            protected override void QueueTask(Task task)
            {
                lock (_lock)
                {
                    _taskQueue.Enqueue(task);
                    Monitor.PulseAll(_lock);
                }
            }

            protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
            {
                lock (_lock)
                {
                    _taskQueue.Enqueue(task);
                    Monitor.PulseAll(_lock);
                }
                return false;
            }

            public void Wait(Task task)
            {
                // Task is in a blocking wait. Track tasks being blocked on.
                lock (_lock)
                {
                    _waitingTasks.Add(t_currentTask, task);
                    Monitor.PulseAll(_lock);
                }
                task.Wait();
                lock (_lock)
                {
                    _waitingTasks.Remove(t_currentTask);
                }
            }

            public bool RunUntilIdle(CancellationToken ct)
            {
                lock (_lock)
                {
                    // Get all threads started
                    Monitor.PulseAll(_lock);
                    while (_taskQueue.Count + _activeThreadCount - _waitingTasks.Count > 0 || _waitingTasks.Values.Any(x => x.IsCompleted))
                    {
                        if (ct.IsCancellationRequested)
                        {
                            return false;
                        }
                        Monitor.Wait(_lock);
                        if (_waitingTasks.Count == _threads.Length)
                        {
                            throw new SchedulerException($"All {_threads.Length} threads blocking. This code requires more threads in the thread-pool.");
                        }
                    }
                    return true;
                }
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
        }

        private struct DelayTask
        {
            public DelayTask(DateTime scheduled)
            {
                Scheduled = scheduled;
                Tcs = new TaskCompletionSource<int>();
            }
            public DateTime Scheduled { get; }
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
            // TODO: Handle cancellation
            lock (_lock)
            {
                var delayTask = new DelayTask(Clock.GetCurrentDateTimeUtc() + delay);
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
            //TaskHelper.Run(taskProvider);
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
                // Move to next clock time
                lock (_lock)
                {
                    if (_delays.Count == 0)
                    {
                        throw new SchedulerException("Inconsistent state, delay queue should have content. This is probably caused by a misconfigured await.");
                    }
                    var delayTask = _delays.First.Value;
                    _delays.RemoveFirst();
                    Clock.AdvanceTo(delayTask.Scheduled);
                    if (Clock.GetCurrentDateTimeUtc() > simulatedTimeout)
                    {
                        throw new SchedulerException("Simulated time has reached timeout.");
                    }
                    delayTask.Tcs.SetResult(0);
                }
            }
        }

    }
}
