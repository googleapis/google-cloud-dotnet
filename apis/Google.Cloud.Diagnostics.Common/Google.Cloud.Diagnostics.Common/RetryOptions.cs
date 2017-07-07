// Copyright 2017 Google Inc. All Rights Reserved.
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
using System;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>The type of retry to make.</summary>
    public enum RetryType
    {
        /// <summary>Requests will not be retried.</summary>
        None,

        /// <summary>Requests will be retried.</summary>
        Retry,
    }

    /// <summary>How to handle a full buffer holding items from calls to be retried.</summary>
    public enum BufferOverflow
    {
        /// <summary>Throws an exception when the buffer is full.</summary>
        ThrowException,

        /// <summary>Ignores new entries.</summary>
        IgnoreNewEntries
    }

    /// <summary>How to handle exceptions from calls.</summary>
    public enum ExceptionHandling
    {
        /// <summary>
        /// Let the errors propagate up after they have been retried if they continually fail.
        /// This may kill the running process, if an exception occurs when the retry limit has been reached.
        /// </summary>
        Propagate,

        /// <summary>Ignores the errors.</summary>
        Ignore,
    }

    /// <summary>
    /// Options that define retry logic for requests that failed.
    /// </summary>
    public sealed class RetryOptions
    {
        /// <summary>The default buffer size in bytes. 2^18 = 262144.</summary>
        public static readonly int DefaultBufferSize = 262144;

        /// <summary>The default number of retry attempts.</summary>
        public static readonly int DefaultRetryAttempts = 10;

        /// <summary>The default wait time between retries.</summary>
        public static readonly TimeSpan DefaultRetryInterval = TimeSpan.FromSeconds(2);

        /// <summary>The type of retry to make.</summary>
        public RetryType RetryType { get; }

        /// <summary>How exceptions are handled.</summary>
        public ExceptionHandling ExceptionHandling { get; }

        /// <summary>How to handle a full buffer, only used for <see cref="RetryType.Retry"/>.</summary>
        public BufferOverflow BufferOverflow { get; }

        /// <summary>The size of the buffer in bytes, only used for <see cref="RetryType.Retry"/>.</summary>
        public int BufferSizeBytes { get; }

        /// <summary>The number of attempts to retry sending information, only used for <see cref="RetryType.Retry"/>.</summary>
        public int RetryAttempts { get; }

        /// <summary>The amount of time to wait between retries, only used for <see cref="RetryType.Retry"/>.</summary>
        public TimeSpan RetryInterval { get; }

        internal RetryOptions(RetryType retryType, ExceptionHandling exceptionHandling, BufferOverflow bufferOverflow,
            int? bufferSizeBytes = null, int? retryAttempts = null, TimeSpan? retryInterval = null)
        {
            RetryType = GaxPreconditions.CheckEnumValue(retryType, nameof(retryType));
            ExceptionHandling = GaxPreconditions.CheckEnumValue(exceptionHandling, nameof(exceptionHandling));
            BufferOverflow = GaxPreconditions.CheckEnumValue(bufferOverflow, nameof(bufferOverflow));
            BufferSizeBytes = GaxPreconditions.CheckArgumentRange(
                bufferSizeBytes ?? 0, nameof(bufferSizeBytes), 0, int.MaxValue);
            RetryAttempts = GaxPreconditions.CheckArgumentRange(
                retryAttempts ?? 0, nameof(retryAttempts), 0, int.MaxValue);
            RetryInterval = retryInterval ?? TimeSpan.Zero;
            GaxPreconditions.CheckArgument(RetryInterval >= TimeSpan.Zero, nameof(retryInterval),
                $"{nameof(retryInterval)} must be greater than 0");
        }

        /// <summary>
        /// Creates a <see cref="RetryOptions"/> for <see cref="RetryType.None"/>.
        /// </summary>
        /// <param name="exceptionHandling">Optional, how exceptions should be handled.
        ///     Defaults to <see cref="ExceptionHandling.Ignore"/>.</param>
        public static RetryOptions NoRetry(ExceptionHandling exceptionHandling = ExceptionHandling.Ignore)
            => new RetryOptions(RetryType.None, exceptionHandling, BufferOverflow.IgnoreNewEntries);

        /// <summary>
        /// Creates a <see cref="RetryOptions"/> for <see cref="RetryType.Retry"/>.
        /// </summary>
        /// <param name="exceptionHandling">Optional, how exceptions should be handled.
        ///     Defaults to <see cref="ExceptionHandling.Ignore"/>.</param>
        /// <param name="bufferOverflow">Optional, how a buffer overflow should be handled.
        ///     Defaults to <see cref="BufferOverflow.IgnoreNewEntries"/>.</param>
        /// <param name="bufferSizeBytes">Optional, the size of the buffer to be used in bytes.
        ///     Defaults to <see cref="DefaultBufferSize"/>.</param>
        /// <param name="retryInterval">Optional, the time between retries. Default to <see cref="DefaultRetryInterval"/>.</param>
        /// <param name="retryAttempts">Optional, the number of retry attempts. Defaults to <see cref="DefaultRetryAttempts"/>.</param>
        public static RetryOptions Retry(
            ExceptionHandling exceptionHandling = ExceptionHandling.Ignore,
            BufferOverflow bufferOverflow = BufferOverflow.IgnoreNewEntries,
            int? bufferSizeBytes = null, TimeSpan? retryInterval = null, int? retryAttempts = null)
                => new RetryOptions(RetryType.Retry, exceptionHandling, bufferOverflow,
                    bufferSizeBytes ?? DefaultBufferSize, retryAttempts ?? DefaultRetryAttempts,
                    retryInterval ?? DefaultRetryInterval);
    }
}