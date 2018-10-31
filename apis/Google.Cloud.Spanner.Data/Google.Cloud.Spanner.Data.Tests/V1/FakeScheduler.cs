// Copyright 2018 Google LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     https://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// NOTE: This file is only temporarily in this project, while we pin down the changes.
// Those changes will be backported to Google.Api.Gax.Testing.

using Google.Api.Gax;
using Google.Cloud.ClientTesting;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using FakeClock = Google.Api.Gax.Testing.FakeClock;

namespace Google.Cloud.Spanner.V1.Tests
{
    /// <summary>
    /// Experimental - please read remarks. Fake implementation of <see cref="IScheduler" />, designed to work with
    /// <see cref="FakeClock"/>.
    /// </summary>
    /// <remarks>
    /// This class is currently hard to use robustly, and cancellation in particular is hard.
    /// The API and behavior may change in future versions without a major version bump - in other words,
    /// this is not considered part of the stable API of the package.
    /// </remarks>
    public sealed class FakeScheduler : IScheduler
    {
        /// <summary>
        /// How long the scheduler can run in real time before timing out.
        /// </summary>
        public TimeSpan RealTimeTimeout { get; set; } = TimeSpan.FromSeconds(10);

        /// <summary>
        /// How long the scheduler can run in simulated time before timing out.
        /// </summary>
        public TimeSpan SimulatedTimeTimeout { get; set; } = TimeSpan.FromDays(10);

        /// <summary>
        /// When running the scheduler, we pause until no more tasks have been scheduled
        /// for a certain time, to allow continuations to execute before the clock is advanced.
        /// By default this is 10ms, but tests which expect a greater amount of processing
        /// may increase this.
        /// </summary>
        public TimeSpan IdleTimeBeforeAdvancing { get; set; } = TimeSpan.FromMilliseconds(10);

        /// <summary>
        /// Time to allow test code to execute continuations after the scheduler loop has completed.
        /// This is a one-time delay per RunAsync/RunAndPause call, to reduce flakiness.
        /// </summary>
        public TimeSpan PostLoopSettleTime { get; set; } = TimeSpan.FromMilliseconds(100);

        /// <summary>
        /// The clock associated with this scheduler. The clock is advanced as the scheduler runs.
        /// </summary>
        public FakeClock Clock { get; }

        private readonly object _monitor = new object();
        private LinkedList<DelayTimer> _actions = new LinkedList<DelayTimer>();
        private bool _stopped;

        /// <summary>
        /// Constructs a fake scheduler which works with the given clock.
        /// </summary>
        /// <param name="clock">Fake clock to observe for timing purposes.</param>
        public FakeScheduler(FakeClock clock)
        {
            Clock = GaxPreconditions.CheckNotNull(clock, nameof(clock));
        }

        /// <summary>
        /// Constructs a fake scheduler with a new fake clock starting at 0 ticks.
        /// </summary>
        public FakeScheduler() : this(new FakeClock(0L))
        {
        }

        // Defaulting cancellation token makes it simpler to use for some tests.
        /// <inheritdoc />
        public Task Delay(TimeSpan delay, CancellationToken cancellationToken = default(CancellationToken)) =>
            AddTimer(Clock.GetCurrentDateTimeUtc() + delay, cancellationToken);

        /// <summary>
        /// Specialization of <see cref="Run{T}(Func{T})"/> for tasks, to prevent a common usage error.
        /// </summary>
        /// <remarks>
        /// If you pass in a delegate which returns a task, that's almost always because you want to run it
        /// until that task completes - which is what <see cref="RunAsync(Func{Task})"/> does.
        /// </remarks>
        /// <param name="taskProvider">A task provider.</param>
        [Obsolete("Use RunAsync to run a function returning a task", true)]
        public void Run(Func<Task> taskProvider)
        {
            throw new InvalidOperationException("Use RunAsync to run a function returning a task");
        }

        /// <summary>
        /// Specialization of <see cref="Run{T}(Func{T})"/> for tasks, to prevent a common usage error.
        /// </summary>
        /// <remarks>
        /// If you pass in a delegate which returns a task, that's almost always because you want to run it
        /// until that task completes - which is what <see cref="RunAsync{T}(Func{Task{T}})"/> does.
        /// </remarks>
        /// <param name="taskProvider">A task provider.</param>
        [Obsolete("Use RunAsync to run a function returning a task", true)]
        public void Run<T>(Func<Task<T>> taskProvider)
        {
            throw new InvalidOperationException("Use RunAsync to run a function returning a task");
        }

        /// <summary>
        /// <para>
        /// Invokes the given action in a separate thread, and then runs the scheduler until one of four conditions is met:
        /// </para>
        /// <list type="bullet">
        ///   <item>The action completes successfully</item>
        ///   <item>The action completes with an exception</item>
        ///   <item><see cref="RealTimeTimeout"/> of real time has elapsed</item>
        ///   <item><see cref="SimulatedTimeTimeout"/> of simulated time has elapsed</item>
        /// </list>
        /// <para>
        /// Only the first of these results in the method completing normally; otherwise, an exception is thrown.
        /// If the action completes with an exception, that exception is the result of the method.
        /// If the action has effectively hung, the thread is not terminated; it is expected that the test will
        /// fail without the broken method causing any more harm.
        /// </para>
        /// </summary>
        /// <exception cref="SchedulerTimeoutException">The scheduler timed out.</exception>
        /// <param name="action">The action to execute with the scheduler.</param>
        public void Run(Action action) => Run(() => { action(); return 1; });

        /// <summary>
        /// <para>
        /// Invokes the given action in a separate thread, and then runs the scheduler until one of four conditions is met:
        /// </para>
        /// <list type="bullet">
        ///   <item>The action completes successfully</item>
        ///   <item>The action completes with an exception</item>
        ///   <item><see cref="RealTimeTimeout"/> of real time has elapsed</item>
        ///   <item><see cref="SimulatedTimeTimeout"/> of simulated time has elapsed</item>
        /// </list>
        /// <para>
        /// Only the first of these results in the method completing normally; otherwise, an exception is thrown.
        /// If the action completes with an exception, that exception is the result of the method.
        /// If the action has effectively hung, the thread is not terminated; it is expected that the test will
        /// fail without the broken method causing any more harm.
        /// </para>
        /// </summary>
        /// <exception cref="SchedulerTimeoutException">The scheduler timed out.</exception>
        /// <param name="func">The function to execute with the scheduler.</param>
        public T Run<T>(Func<T> func) => RunAsync(() => Task.FromResult(func())).Result;

        /// <summary>
        /// <para>
        /// Invokes the given action in a separate thread, and then runs the scheduler until one of four conditions is met:
        /// </para>
        /// <list type="bullet">
        ///   <item>The action completes successfully</item>
        ///   <item>The action completes with an exception</item>
        ///   <item><see cref="RealTimeTimeout"/> of real time has elapsed</item>
        ///   <item><see cref="SimulatedTimeTimeout"/> of simulated time has elapsed</item>
        /// </list>
        /// <para>
        /// Only the first of these results in the method completing normally; otherwise, an exception is thrown.
        /// If the action completes with an exception, that exception is the result of the method.
        /// If the action has effectively hung, the thread is not terminated; it is expected that the test will
        /// fail without the broken method causing any more harm.
        /// </para>
        /// </summary>
        /// <exception cref="SchedulerTimeoutException">The scheduler timed out.</exception>
        /// <param name="taskProvider">A delegate providing an asynchronous action to execute with the scheduler.</param>
        public Task RunAsync(Func<Task> taskProvider) => RunAsync(async () => { await taskProvider().ConfigureAwait(false); return 0; });

        /// <summary>
        /// Runs a task in a separate thread, and the scheduler alongside it to simulate sleeping and delaying.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The task provider is run in a separate thread, so that even synchronous task providers (e.g. using 
        /// <see cref="Task.FromResult{TResult}(TResult)"/>) work appropriately. The scheduler is run
        /// until one of four conditions is met:
        /// </para>
        /// <list type="bullet">
        ///   <item>The task completes successfully</item>
        ///   <item>The task completes with an exception</item>
        ///   <item><see cref="RealTimeTimeout"/> of real time has elapsed</item>
        ///   <item><see cref="SimulatedTimeTimeout"/> of simulated time has elapsed</item>
        /// </list>
        /// <para>
        /// Only the first of these results in the method completing normally; otherwise, an exception is thrown.
        /// If the task completes with an exception, that exception is the result of the method.
        /// If the task has effectively hung, the thread is not terminated; it is expected that the test will
        /// fail without the broken method causing any more harm.
        /// </para>
        /// </remarks>
        /// <exception cref="SchedulerTimeoutException">The scheduler timed out.</exception>
        /// <param name="taskProvider">A delegate providing an asynchronous function to execute with the scheduler.</param>
        public async Task<T> RunAsync<T>(Func<Task<T>> taskProvider)
        {
            var funcTask = Task.Run(taskProvider);
            var simulatedTimeTask = StartLoopAsync(Clock.GetCurrentDateTimeUtc() + SimulatedTimeTimeout, true);
            var delayTask = Task.Delay(RealTimeTimeout);
            await Task.WhenAny(funcTask, simulatedTimeTask, delayTask).ConfigureAwait(false);
            // Allow the test code a little more time to execute, just in case we're waiting for slow logging etc.
            await Task.WhenAny(funcTask, Task.Delay(PostLoopSettleTime)).ConfigureAwait(false);
            lock (_monitor)
            {
                _stopped = true;
                Monitor.PulseAll(_monitor);
            }
            if (funcTask.IsCompleted)
            {
                return await funcTask.ConfigureAwait(false);
            }
            else if (delayTask.IsCompleted)
            {
                throw new SchedulerTimeoutException("Real time time-out; deadlock in user code?");
            }
            else if (simulatedTimeTask.IsCompleted)
            {
                throw new SchedulerTimeoutException("Simulated time time-out; busy loop in user code?");
            }
            else
            {
                throw new InvalidOperationException($"Unexpected return from Task.WhenAny - none of the expected tasks completed.");
            }
        }

        /// <summary>
        /// Runs the scheduler for the given number of seconds. If the task completes normally,
        /// the clock should have advanced by the given number of seconds.
        /// </summary>
        /// <param name="seconds">How many seconds (in simulated time) to run for</param>
        /// <returns>A task which will complete when scheduler has processed tasks up until
        /// the given time.</returns>
        public Task RunAndPauseForSeconds(int seconds) => RunAndPause(TimeSpan.FromSeconds(seconds));

        /// <summary>
        /// Runs the scheduler for the given amount of time. If the task completes normally,
        /// the clock should have advanced by the given TimeSpan.
        /// </summary>
        /// <param name="time">How long (in simulated time) to run for</param>
        /// <returns>A task which will complete when scheduler has processed tasks up until
        /// the given time.</returns>
        public async Task RunAndPause(TimeSpan time)
        {
            var simulatedTimeTask = StartLoopAsync(Clock.GetCurrentDateTimeUtc() + time, false);
            var delayTask = Task.Delay(RealTimeTimeout);
            var completedTask = await Task.WhenAny(simulatedTimeTask, delayTask).ConfigureAwait(false);
            if (completedTask == delayTask)
            {
                throw new SchedulerTimeoutException("Real time time-out; deadlock in user code?");
            }
            // Let any finally-released tasks a bit of time to execute before returning.
            await Task.Delay(PostLoopSettleTime).ConfigureAwait(false);
        }

        /// <summary>
        /// Runs the inner loop of the scheduler. If the returned task completes normally, the clock will be
        /// set to <paramref name="simulatedTimeout"/>.
        /// </summary>
        /// <param name="simulatedTimeout">Maximum time to run for. Delays scheduled for later than this
        /// time will not be executed.</param>
        /// <param name="runTestCode">true if test code is running as well, and should be given some extra time to
        /// execute on each iteration. false if only the scheduled tasks are running.</param>
        private Task StartLoopAsync(DateTime simulatedTimeout, bool runTestCode) =>
            Task.Run(() =>
            {
                // In-method protection against infinite loops. Each caller provides the actual timeout check,
                // throwing an exception appropriately.
                DateTime realDeadline = DateTime.UtcNow + RealTimeTimeout + TimeSpan.FromSeconds(2);

                DateTime nextClockTime = Clock.GetCurrentDateTimeUtc();

                while (nextClockTime <= simulatedTimeout)
                {
                    FileLogger.Log($"Advancing time to {nextClockTime:mm:ss}");
                    // Pointless on the first iteration, but on later iterations this will
                    // be the time of the next timer waiting to execute.
                    Clock.AdvanceTo(nextClockTime);

                    // Return if the test has completed already (not necessarily successfully)
                    lock (_monitor)
                    {
                        if (_stopped)
                        {
                            return;
                        }
                    }

                    var now = Clock.GetCurrentDateTimeUtc();
                    // Find all timers that are due now.
                    List<DelayTimer> timers = new List<DelayTimer>();
                    lock (_monitor)
                    {
                        while (_actions.Count != 0 && _actions.First.Value.ScheduledTime <= now)
                        {
                            timers.Add(_actions.First.Value);
                            _actions.RemoveFirst();
                        }
                    }
                    
                    // Release all due, non-cancelled timers. (A cancelled TCS will ignore this.)
                    timers.ForEach(t => t.CompletionSource.TrySetResult(0));

                    lock (_monitor)
                    {
                        // If the test code is running (RunAsync) give that a bit of time - wait for at least
                        // one more delay to be scheduled, or the test to complete.
                        if (runTestCode)
                        {
                            while (!_stopped && _actions.Count == 0)
                            {
                                if (!Monitor.Wait(_monitor, RealTimeTimeout + TimeSpan.FromSeconds(2)))
                                {
                                    throw new SchedulerTimeoutException("Scheduler timed out (real time)");
                                }
                            }
                        }

                        if (_stopped)
                        {
                            break;
                        }

                        // Give some time for tasks to execute.
                        // Repeats until no further delays are created within IdleTimeBeforeAdvancing.
                        // It would be much better to track all created Tasks and make sure they've all completed;
                        // But that's fairly invasive.
                        while (DateTime.UtcNow < realDeadline && Monitor.Wait(_monitor, IdleTimeBeforeAdvancing)) ;

                        // We don't expect this to be observed, as the calling code will probably have timed
                        // out already, but it's clearer than returning normally.
                        if (DateTime.UtcNow >= realDeadline)
                        {
                            throw new SchedulerTimeoutException("Scheduler timed out (real time)");
                        }

                        // If we have a new timer, and if it should be released before (or at) the timeout,
                        // go round the loop again.
                        if (_actions.Count != 0 && _actions.First.Value.ScheduledTime <= simulatedTimeout)
                        {
                            nextClockTime = _actions.First.Value.ScheduledTime;
                            continue;
                        }
                        else
                        {
                            // Either we're idle, or the next timer is beyond our simulated timeout, so
                            // quit the loop.
                            break;
                        }
                    }
                }
                Clock.AdvanceTo(simulatedTimeout);
            });

        private Task AddTimer(DateTime scheduledTime, CancellationToken cancellationToken)
        {
            var timer = new DelayTimer(scheduledTime, new TaskCompletionSource<int>(), cancellationToken);

            lock (_monitor)
            {
                var node = _actions.First;
                while (node != null)
                {
                    if (node.Value.ScheduledTime > scheduledTime)
                    {
                        _actions.AddBefore(node, timer);
                        break;
                    }
                    node = node.Next;
                }
                if (node == null)
                {
                    _actions.AddLast(timer);
                }
                Monitor.PulseAll(_monitor);
            }
            return timer.CompletionSource.Task;
        }

        private sealed class DelayTimer
        {
            internal DateTime ScheduledTime { get; }
            internal TaskCompletionSource<int> CompletionSource { get; }

            internal DelayTimer(DateTime scheduledTime, TaskCompletionSource<int> tcs, CancellationToken cancellationToken)
            {
                ScheduledTime = scheduledTime;
                CompletionSource = tcs;
                if (cancellationToken.CanBeCanceled)
                {
                    cancellationToken.Register(() => CompletionSource.TrySetCanceled());
                }
            }
        }

        /// <summary>
        /// Exception designed not to be caught by tests (which may deliberately expect a timeout of another kind, for example).
        /// This exception indicates that the scheduler timed out either in simulated time (e.g. a busy loop with a condition
        /// never being satisfied) or in wall time (e.g. user code was waiting for a task which was never going to complete, due
        /// to a deadlock).
        /// </summary>
        public sealed class SchedulerTimeoutException : Exception
        {
            /// <summary>
            /// Constructs a new exception with the given message.
            /// </summary>
            /// <param name="message">Message for the exception.</param>
            public SchedulerTimeoutException(string message) : base(message)
            {
            }
        }
    }
}
