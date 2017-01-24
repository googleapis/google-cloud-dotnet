/*
 * Copyright 2016 Google Inc. All Rights Reserved.
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE file or at
 * https://developers.google.com/open-source/licenses/bsd
 */

using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Google.Api.Gax.Grpc
{
    // TODO: Check whether cancellation token associated with original RPC is honoured throughout
    // TODO: Check whether CallOptions are honoured throughout
    // TODO: Check that the "further calls to Write after failure" handling is appropriate. (And document it!)

    /// <summary>
    /// A wrapper around <see cref="IClientStreamWriter{T}"/> which removes the "one write at a time"
    /// restriction by buffering messages (and the completion signal) up to a given capacity.
    /// </summary>
    /// <typeparam name="T">The type of message in the stream.</typeparam>
    public class BufferedClientStreamWriter<T> where T : class
    {
        private readonly IClientStreamWriter<T> _writer;
        private readonly object _lock = new object();
        /// <summary>
        /// Queue of requests. If this is non-empty, there's at least one request in-flight, which
        /// is always the head of the queue.
        /// </summary>
        private readonly LinkedList<Request> _queue;

        // TODO: Make these internal properties public?

        /// <summary>
        /// The capacity of the writer.
        /// </summary>
        internal int Capacity { get; }

        /// <summary>
        /// The number of write calls that have been buffered.
        /// </summary>
        /// <remarks>
        /// The value of this property may change due to activity from other threads. It should only be used
        /// for testing and similar scenarios where the system state is well understood.
        /// </remarks>
        internal int BufferedWriteCount
        {
            get
            {
                lock (_lock)
                {
                    return _queue.Count;
                }
            }
        }

        private bool _completed;
        private Task _failedTask;

        /// <summary>
        /// Constructs an instance which writes to the specified writer, and with the given capacity.
        /// </summary>
        /// <param name="writer">The writer to delegate to.</param>
        /// <param name="capacity">The maximum number of messages to buffer.</param>
        public BufferedClientStreamWriter(IClientStreamWriter<T> writer, int capacity)
        {
            _writer = GaxPreconditions.CheckNotNull(writer, nameof(writer));
            _queue = new LinkedList<Request>();
            Capacity = capacity;
            GaxPreconditions.CheckArgument(capacity >= 1, nameof(capacity), "Capacity cannot be less than 1.");
        }

        /// <summary>
        /// Writes a message to the stream, if there is enough space in the buffer and <see cref="CompleteAsync"/>
        /// hasn't already been called. The same write options will be used as for the previous message.
        /// </summary>
        /// <param name="message">The message to write.</param>
        /// <returns><c>null</c> if the message queue is full or the stream has already been completed;
        /// otherwise, a <see cref="Task"/> which will complete when the message has been written to the stream.</returns>
        public Task TryWriteAsync(T message) => WriteAsyncImpl(message, null, false, false);

        /// <summary>
        /// Writes a message to the stream, if there is enough space in the buffer and <see cref="CompleteAsync"/>
        /// hasn't already been called.
        /// </summary>
        /// <param name="message">The message to write.</param>
        /// <param name="options">The write options to use for this message.</param>
        /// <returns><c>null</c> if the message queue is full or the stream has already been completed.</returns>
        public Task TryWriteAsync(T message, WriteOptions options) => WriteAsyncImpl(message, options, true, false);

        /// <summary>
        /// Writes a message to the stream, if there is enough space in the buffer and <see cref="CompleteAsync"/>
        /// hasn't already been called. The same write options will be used as for the previous message.
        /// </summary>
        /// <param name="message">The message to write.</param>
        /// <exception cref="InvalidOperationException">There isn't enough space left in the buffer,
        /// or the stream has been completed.</exception>
        /// <returns>A <see cref="Task"/> which will complete when the message has been written to the stream.</returns>
        public Task WriteAsync(T message) => WriteAsyncImpl(message, null, false, true);

        /// <summary>
        /// Writes a message to the stream, if there is enough space in the buffer and <see cref="CompleteAsync"/>
        /// hasn't already been called.
        /// </summary>
        /// <param name="message">The message to write.</param>
        /// <param name="options">The write options to use for this message.</param>
        /// <exception cref="InvalidOperationException">There isn't enough space left in the buffer,
        /// or <see cref="CompleteAsync"/> has already been called.</exception>
        /// <returns>A <see cref="Task"/> which will complete when the message has been written to the stream.</returns>
        public Task WriteAsync(T message, WriteOptions options) => WriteAsyncImpl(message, options, true, true);

        private Task WriteAsyncImpl(T message, WriteOptions options, bool modifyOptions, bool throwOnError)
        {
            GaxPreconditions.CheckNotNull(message, nameof(message));
            lock (_lock)
            {
                if (!ValidateStateForWrite(throwOnError))
                {
                    return null;
                }
                // Not part of state validation, as it's slightly different.
                if (_failedTask != null)
                {
                    return _failedTask;
                }
                var lastRequest = _queue.Last?.Value;
                var effectiveOptions = modifyOptions ? options
                    : lastRequest != null ? lastRequest.WriteOptions
                    : _writer.WriteOptions;
                var request = new Request(message, effectiveOptions);
                if (lastRequest == null)
                {
                    // If there's nothing in flight, send immediately. Otherwise,
                    // we'll let HandleWriteComplete trigger sending us at the right time.
                    request.WriteTo(_writer);
                }
                _queue.AddLast(request);
                request.CompletionSource.Task.ContinueWith(HandleWriteComplete);
                return request.CompletionSource.Task;
            }
        }

        /// <summary>
        /// One of the writes completes - possibly successfully, possibly not. On success,
        /// we start the next write (or complete) sending if there is one. On failure, we propagate the result
        /// of this task to all other tasks. Those will in turn trigger further calls to this method,
        /// but by that time we'll have retained the failed task so we can just exit quickly.
        /// </summary>
        /// <param name="writeResult"></param>
        private void HandleWriteComplete(Task writeResult)
        {
            lock (_lock)
            {
                if (_failedTask != null)
                {
                    return;
                }
                switch (writeResult.Status)
                {
                    case TaskStatus.RanToCompletion:
                        _queue.RemoveFirst();
                        _queue.First?.Value?.WriteTo(_writer);
                        break;
                    default:
                        _failedTask = writeResult;
                        // Collect all the pending tasks - skipping the head, which is the one we've already got.
                        var sourcesToPropagateTo = _queue.Skip(1).Select(r => r.CompletionSource).ToList();
                        _queue.Clear();
                        foreach (var source in sourcesToPropagateTo)
                        {
                            PropagateTaskResult(writeResult, source);
                        }
                        break;
                }
            }
        }

        /// <summary>
        /// Validates that we can write to the stream, optionally throwing if there's an error.
        /// This is basically to avoid a big chunk of code appearing in WriteAsyncImpl.
        /// </summary>
        private bool ValidateStateForWrite(bool throwOnError)
        {
            if (_completed)
            {
                if (throwOnError)
                {
                    throw new InvalidOperationException($"Cannot call {nameof(WriteAsync)} after {nameof(CompleteAsync)}");
                }
                else
                {
                    return false;
                }
            }
            if (_queue.Count == Capacity)
            {
                if (throwOnError)
                {
                    throw new InvalidOperationException("Queue is full");
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Completes the stream when all buffered messages have been sent. This method can only be called
        /// once, and further messages cannot be written after it has been called.
        /// </summary>
        /// <exception cref="InvalidOperationException">This method has already been called.</exception>
        /// <returns>A <see cref="Task"/> which will complete when the stream has finished being completed.</returns>
        public Task CompleteAsync()
        {
            lock (_lock)
            {
                if (_completed)
                {
                    throw new InvalidOperationException($"Cannot call {nameof(CompleteAsync)} twice");
                }
                _completed = true;
                if (_failedTask != null)
                {
                    return _failedTask;
                }

                var lastRequest = _queue.Last?.Value;
                var request = new Request(null, null);
                if (lastRequest == null)
                {
                    // If there's nothing in flight, send immediately. Otherwise,
                    // we'll let HandleWriteComplete trigger sending us at the right time.
                    request.WriteTo(_writer);
                }
                _queue.AddLast(request);
                // No need to hook to HandleWriteComplete, as there are no more tasks to start.
                return request.CompletionSource.Task;
            }
        }

        private static void PropagateTaskResult(Task task, TaskCompletionSource<int> completionSource)
        {
            switch (task.Status)
            {
                case TaskStatus.Canceled:
                    completionSource.SetCanceled();
                    break;
                case TaskStatus.Faulted:
                    completionSource.SetException(task.Exception.InnerExceptions);
                    break;
                case TaskStatus.RanToCompletion:
                    completionSource.SetResult(0);
                    break;
                default:
                    throw new InvalidOperationException($"Invalid status for completed task: {task.Status}");
            }
        }

        private class Request
        {
            // The message to write, or null to call Complete instead.
            internal T Message { get; }
            internal WriteOptions WriteOptions { get; }
            internal TaskCompletionSource<int> CompletionSource { get; }

            public Request(T message, WriteOptions options)
            {
                Message = message;
                WriteOptions = options;
                CompletionSource = new TaskCompletionSource<int>();
            }

            internal void WriteTo(IClientStreamWriter<T> writer)
            {
                writer.WriteOptions = WriteOptions;
                Task task = Message == null ? writer.CompleteAsync() : writer.WriteAsync(Message);
                task.ContinueWith(t => PropagateTaskResult(t, CompletionSource));
            }
        }
    }
}
