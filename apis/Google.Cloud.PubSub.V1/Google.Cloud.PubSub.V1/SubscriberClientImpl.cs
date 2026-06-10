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

using Google.Api.Gax;
using Google.Cloud.PubSub.V1.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

// This class uses TaskHelper.ConfigureAwait, rather than directly calling .ConfigureAwait().
// When running in a non-test environment this indirectly calls .ConfigureAwait(false).
// Disable the ConfigureAwaitChecker warning:
#pragma warning disable CAC001
#pragma warning disable CAC002

namespace Google.Cloud.PubSub.V1;

/// <summary>
/// Implementation of <see cref="SubscriberClient"/>.
/// </summary>
public sealed partial class SubscriberClientImpl : SubscriberClient
{
    // TODO: Logging
    internal const string DeliveryAttemptAttrKey = "googclient_deliveryattempt";
    // If shutting down with WaitForProcessing we automatically switch to NackImmediately
    // this time before the hard stop triggers.
    private static readonly TimeSpan s_nackImmediatelyBeforeHardStopWindow = TimeSpan.FromSeconds(30);

    /// <summary>
    /// Instantiate a <see cref="SubscriberClientImpl"/> associated with the specified <see cref="SubscriptionName"/>.
    /// </summary>
    /// <param name="subscriptionName">The <see cref="SubscriptionName"/> to receive messages from.</param>
    /// <param name="clients">The <see cref="SubscriberServiceApiClient"/>s to use in a <see cref="SubscriberClient"/>.
    /// For high performance, these should all use distinct <see cref="ChannelBase"/>s.</param>
    /// <param name="settings"><see cref="SubscriberClient.Settings"/> for creating a <see cref="SubscriberClient"/>.</param>
    /// <param name="shutdown">Function to call on this <see cref="SubscriberClientImpl"/> shutdown.</param>
    public SubscriberClientImpl(SubscriptionName subscriptionName, IEnumerable<SubscriberServiceApiClient> clients, Settings settings, Func<Task> shutdown)
        : this(subscriptionName, clients, settings, shutdown, TaskHelper.Default) { }

    internal SubscriberClientImpl(SubscriptionName subscriptionName, IEnumerable<SubscriberServiceApiClient> clients, Settings settings, Func<Task> shutdown, TaskHelper taskHelper, TimeSpan? streamPongPeriod = null)
    {
        SubscriptionName = GaxPreconditions.CheckNotNull(subscriptionName, nameof(subscriptionName));
        GaxPreconditions.CheckNotNull(clients, nameof(clients));
        _clients = clients.ToArray();
        GaxPreconditions.CheckArgument(_clients.Length > 0, nameof(clients), "Must contain at least one client");
        GaxPreconditions.CheckArgument(_clients.All(x => x != null), nameof(clients), "All elements must be non-null");
        GaxPreconditions.CheckNotNull(settings, nameof(settings));
        settings.Validate();
        // These values are validated in Settings.Validate() above, so no need to re-validate here.
        _normalLeaseTiming = new LeaseTiming(settings.AckDeadline ?? DefaultAckDeadline, settings.AckExtensionWindow ?? DefaultAckExtensionWindow);
        _exactlyOnceDeliveryLeaseTiming = new LeaseTiming(settings.AckDeadline ?? DefaultAckDeadlineForExactlyOnceDelivery, settings.AckExtensionWindow ?? DefaultAckExtensionWindow);
        _maxExtensionDuration = settings.MaxTotalAckExtension ?? DefaultMaxTotalAckExtension;
        _shutdown = shutdown;
        _scheduler = settings.Scheduler ?? SystemScheduler.Instance;
        _clock = settings.Clock ?? SystemClock.Instance;
        _taskHelper = GaxPreconditions.CheckNotNull(taskHelper, nameof(taskHelper));
        _flowControlSettings = settings.FlowControlSettings ?? DefaultFlowControlSettings;
        _useLegacyFlowControl = settings.UseLegacyFlowControl;
        _maxAckExtendQueue = (int) Math.Min(_flowControlSettings.MaxOutstandingElementCount ?? long.MaxValue, 20_000);
        _disposeShutdownOptions = new ShutdownOptions
        {
            Mode = ShutdownMode.WaitForProcessing,
            Timeout = settings.DisposeTimeout ?? DefaultDisposeTimeout
        };
        Logger = settings.Logger;
        StreamPongPeriod = streamPongPeriod;
    }

    /// <summary>
    /// For testing only. The deadline duration before the next expected Keep-Alive Pong from the server is due. 
    /// Defaults to 15 seconds if not specified.
    /// </summary>
    internal TimeSpan? StreamPongPeriod { get; }

    private readonly object _lock = new object();
    private readonly SubscriberServiceApiClient[] _clients;
    private readonly Func<Task> _shutdown;
    private readonly TimeSpan _maxExtensionDuration; // Maximum duration for which a message lease will be extended.
    private readonly LeaseTiming _normalLeaseTiming;
    private readonly LeaseTiming _exactlyOnceDeliveryLeaseTiming;
    private readonly int _maxAckExtendQueue; // Maximum count of acks/extends to push to server in a single messages
    private readonly IScheduler _scheduler;
    private readonly IClock _clock;
    private readonly TaskHelper _taskHelper;
    private readonly FlowControlSettings _flowControlSettings;
    private readonly bool _useLegacyFlowControl;
    private readonly ShutdownOptions _disposeShutdownOptions;

    private TaskCompletionSource<int> _mainTcs;
    private CancellationTokenSource _globalHardStopCts; // Immediately stops all processing, dropping any unhandled messages.
    private CancellationTokenSource _globalNackImmediatelyCts;
    private CancellationTokenSource _globalWaitForProcessingCts;

    // A boolean that is true if stop has been initiated with the StopAsync methods.
    private bool IsStopStarted => _globalHardStopCts.IsCancellationRequested ||
        _globalNackImmediatelyCts.IsCancellationRequested ||
        _globalWaitForProcessingCts.IsCancellationRequested;

    // This property only exists for testing.
    // This is the delay between obtaining a lease on a message and then further extending the lease on that message
    // (assuming it hasn't been handled).
    // This is calculated from the AckDeadline, AckExtensionWindow, and MinimumLeaseExtensionDelay
    internal TimeSpan AutoExtendDelay => _normalLeaseTiming.AutoExtendDelay;

    // This property only exists for testing.
    // This is the delay between obtaining a lease on a message and then further extending the lease on that message
    // for exactly-once delivery (assuming it hasn't been handled).
    // This is calculated from AckDeadline, AckExtensionWindow, MinimumAckExtensionWindowForExactlyOnce and MinimumLeaseExtensionDelay.
    internal TimeSpan AutoExtendDelayForExactlyOnceDelivery => _exactlyOnceDeliveryLeaseTiming.AutoExtendDelay;

    internal ILogger Logger { get; }

    /// <inheritdoc />
    public override SubscriptionName SubscriptionName { get; }

    /// <inheritdoc />
    public override Task StartAsync(Func<PubsubMessage, CancellationToken, Task<Reply>> handlerAsync) =>
        StartAsync(new SimpleSubscriptionHandler(handlerAsync));

    /// <inheritdoc />
    public override Task StartAsync(SubscriptionHandler handler)
    {
        lock (_lock)
        {
            GaxPreconditions.CheckState(_mainTcs == null, "Can only start an instance once.");
            _mainTcs = new TaskCompletionSource<int>();
            _globalHardStopCts = new CancellationTokenSource();
            _globalNackImmediatelyCts = new CancellationTokenSource();
            _globalWaitForProcessingCts = new CancellationTokenSource();
        }
        var registeredTasks = new HashSet<Task>();
        Action<Task> registerTask = task =>
        {
            registeredTasks.Locked(() => registeredTasks.Add(task));
            Action<Task> unregisterTask = t => registeredTasks.Locked(() => registeredTasks.Remove(t));
            task.ContinueWith(unregisterTask, CancellationToken.None, TaskContinuationOptions.ExecuteSynchronously, _taskHelper.TaskScheduler);
        };
        Flow flow = new Flow(_flowControlSettings.MaxOutstandingByteCount ?? long.MaxValue,
            _flowControlSettings.MaxOutstandingElementCount ?? long.MaxValue, registerTask, _taskHelper);
        // Start all subscribers
        var subscriberTasks = _clients.Select((client, index) =>
        {
            var singleChannel = new SingleChannel(this, client, index + 1, handler, flow, _useLegacyFlowControl, registerTask, _clock);
            return _taskHelper.Run(() => singleChannel.StartAsync());
        }).ToArray();
        // Set up finish task; code that executes when this subscriber is being shutdown (for whatever reason).
        _taskHelper.Run(() => StopCompletionAsync(subscriberTasks, registeredTasks));
        return _mainTcs.Task;
    }

    private async Task StopCompletionAsync(Task[] subscriberTasks, HashSet<Task> registeredTasks)
    {
        // WhenAny() always returns a non-faulted task, so the await will never throw.
        var task = await _taskHelper.ConfigureAwait(_taskHelper.WhenAny(subscriberTasks));
        if (task.IsFaulted)
        {
            _globalHardStopCts.Cancel();
        }
        // Wait for all subscribers to stop
        var exception = await _taskHelper.ConfigureAwaitHideErrors(() => _taskHelper.WhenAll(subscriberTasks));
        // Wait for all registered Tasks to stop
        await _taskHelper.ConfigureAwaitHideErrors(
            () => _taskHelper.WhenAll(registeredTasks.Locked(() => registeredTasks.ToArray())));
        // Call shutdown function
        if (_shutdown != null)
        {
            await _taskHelper.ConfigureAwaitHideErrors(_shutdown);
        }
        // Return final result
        var exceptions = ((exception as AggregateException)?.Flatten().InnerExceptions) ??
            Enumerable.Repeat(exception, exception == null ? 0 : 1);
        if (exceptions.Any())
        {
            _mainTcs.SetException(exceptions);
        }
        else if (_globalHardStopCts.IsCancellationRequested)
        {
            _mainTcs.SetCanceled();
        }
        else
        {
            _mainTcs.SetResult(0);
        }
    }

    /// <inheritdoc />
    public override ValueTask DisposeAsync()
    {
        lock (_lock)
        {
            if (_mainTcs is null)
            {
                // No-op. We don't want to throw exceptions if DisposeAsync is called before StartAsync.
                return new ValueTask(Task.CompletedTask);
            }
        }
        return new ValueTask(StopAsync(_disposeShutdownOptions));
    }

    /// <inheritdoc />
    public override Task StopAsync(ShutdownOptions shutdownOptions, CancellationToken cancellationToken = default)
    {
        GaxPreconditions.CheckNotNull(shutdownOptions, nameof(shutdownOptions));

        TimeSpan hardStopIn;
        TimeSpan nackImmediatelyIn;
        bool hardStop = false;
        bool nackImmediately = false;
        CancellationTokenSource tokenToCancel;
        lock (_lock)
        {
            GaxPreconditions.CheckState(_mainTcs != null, "Can only stop a started instance.");
            // Only the first call to StopAsync is observed
            if (IsStopStarted)
            {
                // No-op. We don't want to throw exceptions if DisposeAsync or StopAsync is called a second time.
                return _mainTcs.Task;
            }

            hardStopIn = shutdownOptions.Timeout ?? _maxExtensionDuration;
            nackImmediatelyIn = hardStopIn - s_nackImmediatelyBeforeHardStopWindow;

            if (hardStopIn <= TimeSpan.Zero || cancellationToken.IsCancellationRequested)
            {
                tokenToCancel = _globalHardStopCts;
                hardStop = true;
            }
            else if (nackImmediatelyIn <= TimeSpan.Zero || shutdownOptions.Mode == ShutdownMode.NackImmediately)
            {
                tokenToCancel = _globalNackImmediatelyCts;
                nackImmediately = true;
            }
            else
            {
                tokenToCancel = _globalWaitForProcessingCts;
            }
        }
        // Cancel outside the lock because callbacks may execute synchronously.
        tokenToCancel.Cancel();

        if (!hardStop)
        {
            // If this is not a hard stop we trigger hard stop, eventually
            CancelTargetOnTrigger(targetSourceToCancel: _globalHardStopCts, triggerToken: cancellationToken);
            CancelAfterDelay(_globalHardStopCts, hardStopIn);
            if (!nackImmediately)
            {
                // If this is neither hard stop nor nack immediately, we are in wait for processing,
                // we need to trigger nack immediately, eventually.
                CancelAfterDelay(_globalNackImmediatelyCts, nackImmediatelyIn);
            }
        }
        // In case we are in an other than expected shutdown mode, let's log.
        if (hardStop)
        {
            Logger?.LogWarning("Shutdown timeout is {ShutdownTimeout}. " +
                "Can't fulfill request for shutdown mode {ShutdownMode}. " +
                "Shutting down immediately.", hardStopIn, shutdownOptions.Mode);
        }
        else if (nackImmediately && shutdownOptions.Mode != ShutdownMode.NackImmediately)
        {
            Logger?.LogWarning("Shutdown timeout is {ShutdownTimeout}. " +
                "Not enough time to fulfill request for shutdown mode {ShutdownMode} " +
                "and {NackImmediately} grace period before shutdown of {GracePeriod} " +
                "Going to {ActualMode} shutdown mode immediately.",
                hardStopIn, shutdownOptions.Mode, ShutdownMode.NackImmediately, s_nackImmediatelyBeforeHardStopWindow, ShutdownMode.NackImmediately);
        }

        return _mainTcs.Task;

        void CancelTargetOnTrigger(CancellationTokenSource targetSourceToCancel, CancellationToken triggerToken)
        {
            var registration = triggerToken.Register(() => targetSourceToCancel.Cancel());
            // Do not register this Task to be awaited on at shutdown.
            // It completes *after* _mainTcs, and all registered tasks must complete before _mainTcs
            _taskHelper.Run(async () =>
                await _taskHelper.ConfigureAwaitWithFinally(() => _mainTcs.Task, () => registration.Dispose()));
        }

        // Triggers cancellation after provided delay. This is used instead of .CancelAfter to integrate with
        // IScheduler, allowing this shutdown method to be tested.
        void CancelAfterDelay(CancellationTokenSource cts, TimeSpan delay) =>
            _taskHelper.Run(async () =>
            {
                using var delayCancellation = new CancellationTokenSource();
                var delayTask = _scheduler.Delay(delay, delayCancellation.Token);
                await _taskHelper.WhenAny(delayTask, _mainTcs.Task);

                // If the main task completed we don't need to continue waiting on the delay, let's cancel that for cleanup.
                // We also don't need to cancel the original cts, because the whole subscriber is done now.
                if (_mainTcs.Task.IsCompleted)
                {
                    delayCancellation.Cancel();
                }
                // If the main task is not completed then our delay elapsed an we cancel the original cts.
                else
                {
                    cts.Cancel();
                }
            });
    }
}
