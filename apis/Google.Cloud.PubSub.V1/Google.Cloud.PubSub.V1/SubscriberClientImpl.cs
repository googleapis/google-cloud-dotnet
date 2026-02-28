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

    internal SubscriberClientImpl(SubscriptionName subscriptionName, IEnumerable<SubscriberServiceApiClient> clients, Settings settings, Func<Task> shutdown, TaskHelper taskHelper)
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
        _disposeTimeout = settings.DisposeTimeout ?? DefaultDisposeTimeout;
        Logger = settings.Logger;
    }

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
    private readonly TimeSpan _disposeTimeout;
    private static readonly TimeSpan s_nackGracePeriod = TimeSpan.FromSeconds(30);
    private bool _isStopInitiated => _globalWaitForProcessingCts.IsCancellationRequested;

    private TaskCompletionSource<int> _mainTcs;
    private CancellationTokenSource _globalSoftStopCts; // soft-stop is guarenteed to occur before hard-stop.
    private CancellationTokenSource _globalHardStopCts;
    private CancellationTokenSource _globalWaitForProcessingCts;
    private CancellationTokenSource _globalNackImmediatelyCts;

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
            _globalSoftStopCts = CancellationTokenSource.CreateLinkedTokenSource(_globalHardStopCts.Token);
            _globalNackImmediatelyCts = CancellationTokenSource.CreateLinkedTokenSource(_globalHardStopCts.Token);
            _globalWaitForProcessingCts = CancellationTokenSource.CreateLinkedTokenSource(_globalNackImmediatelyCts.Token, _globalSoftStopCts.Token);
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
        _taskHelper.Run(async () => await StopCompletionAsync(subscriberTasks, registeredTasks));
        return _mainTcs.Task;
    }

    private async Task StopCompletionAsync(Task[] subscriberTasks, HashSet<Task> registeredTasks)
    {
        // WhenAny() always returns a non-faulted task, so the await will never throw.
        var task = await _taskHelper.ConfigureAwait(_taskHelper.WhenAny(subscriberTasks));
        if (task.IsFaulted)
        {
            _globalSoftStopCts.Cancel();
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
            // TODO: Remove this 2 second delay.
            // This is a temporary patch to avoid race condition between gRPC call cancellation and channel dispose.
            // Please see https://github.com/grpc/grpc-dotnet/issues/2119 for the deadlock issue in Grpc.Net.Client.
            await _scheduler.Delay(TimeSpan.FromSeconds(2), CancellationToken.None);
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
#pragma warning disable CS0618 // allow use of obsolete method
        return new ValueTask(StopAsync( _disposeTimeout));
#pragma warning restore CS0618
    }

    /// <inheritdoc />
    [Obsolete("Use StopAsync(SubscriberShutdownSetting, TimeSpan?, CancellationToken) instead.")]
    public override Task StopAsync(CancellationToken hardStopToken)
    {
        lock (_lock)
        {
            // Note: If multiple stop requests are made, only the first cancellation token is observed.
            if (_mainTcs is not null && _isStopInitiated)
            {
                // No-op. We don't want to throw exceptions if DisposeAsync or StopAsync is called a second time.
                return _mainTcs.Task;
            }
            GaxPreconditions.CheckState(_mainTcs != null, "Can only stop a started instance.");
            _globalSoftStopCts.Cancel();
        }

        CancelTargetOnTrigger(targetSourceToCancel: _globalHardStopCts, triggerToken: hardStopToken);
        return _mainTcs.Task;
    }

    /// <inheritdoc />
    public override Task StopAsync(SubscriberShutdownSetting shutdownSetting, TimeSpan? timeout = null, CancellationToken cancellationToken = default)
    {
        lock (_lock)
        {
            GaxPreconditions.CheckState(_mainTcs != null, "Can only stop a started instance.");
            // Only the first call to StopAsync is observed
            if (_isStopInitiated)
            {
                // No-op. We don't want to throw exceptions if DisposeAsync or StopAsync is called a second time.
                return _mainTcs.Task;
            }
            // Signal to stop retrieving new messages immediately.
            _globalWaitForProcessingCts.Cancel();
        }

        TimeSpan shutdownTimeout = timeout ?? DefaultMaxTotalAckExtension;
        if (shutdownTimeout <= TimeSpan.Zero)
        {
            Logger?.LogWarning("Shutdown timeout is 0! Stopping {Client} immediately; work may be dropped.", nameof(SubscriberClient));
        }

        CancelAfterDelay(_globalNackImmediatelyCts, CalculateNackDelay());
        CancelAfterDelay(_globalHardStopCts, shutdownTimeout);
        CancelTargetOnTrigger(targetSourceToCancel: _globalHardStopCts, triggerToken: cancellationToken);

        return _mainTcs.Task;

        // Triggers cancellation after provided delay. This is used instead of .CancelAfterDelay to integrate with
        // IScheduler, allowing this shutdown method to be tested.
        void CancelAfterDelay(CancellationTokenSource cts, TimeSpan delay)
        {
            if (delay == TimeSpan.Zero)
            {
                cts.Cancel();
                return;
            }
            _taskHelper.Run(async () =>
            {
                await _taskHelper.ConfigureAwait(_scheduler.Delay(delay, CancellationToken.None));
                cts.Cancel();
            });
        }

        // Calculates the time until we switch to NackImmediately mode.
        TimeSpan CalculateNackDelay()
        {
            switch (shutdownSetting)
            {
                case SubscriberShutdownSetting.NackImmediately:
                    return TimeSpan.Zero;
                case SubscriberShutdownSetting.WaitForProcessing:
                    // WaitForProcessing enters a Nack grace period before final shutdown if it was unable to finish
                    // handling all received messages.
                    TimeSpan delay = shutdownTimeout > s_nackGracePeriod ? shutdownTimeout - s_nackGracePeriod : TimeSpan.Zero;
                    if (delay == TimeSpan.Zero && shutdownTimeout > TimeSpan.Zero)
                    {
                        Logger?.LogWarning("Shutdown timeout ({Timeout}) <= GracePeriod ({GracePeriod}). Nacking immediately.",
                            shutdownTimeout, s_nackGracePeriod);
                    }
                    return delay;
                default:
                    throw new ArgumentOutOfRangeException(nameof(shutdownSetting), shutdownSetting, null);
            }
        }
    }

    /// <summary>
    /// Configures a <see cref="CancellationTokenSource"/> to be cancelled automatically
    /// whenever a specific <see cref="CancellationToken"/> is triggered.
    /// The registration is automatically disposed when _mainTcs completes.
    /// </summary>
    /// <param name="targetSourceToCancel">The destination <see cref="CancellationTokenSource"/> that should be cancelled.</param>
    /// <param name="triggerToken">The source <see cref="CancellationToken"/> that provides the cancellation signal.</param>
    private void CancelTargetOnTrigger(
        CancellationTokenSource targetSourceToCancel,
        CancellationToken triggerToken)
    {
        var registration = triggerToken.Register(() => targetSourceToCancel.Cancel());
        // Do not register this Task to be awaited on at shutdown.
        // It completes *after* _mainTcs, and all registered tasks must complete before _mainTcs
        _taskHelper.Run(async () =>
            await _taskHelper.ConfigureAwaitWithFinally(() => _mainTcs.Task, () => registration.Dispose()));
    }
}
