// Copyright 2016 Google Inc. All Rights Reserved.
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

using Google.Api.Gax.Rest;
using System;

namespace Google.Bigquery.V2
{
    /// <summary>
    /// Options for operations that poll jobs until they have completed. When no options are specified, the
    /// default behavior is to poll forever, at one second intervals.
    /// </summary>
    public sealed class PollJobOptions
    {
        private TimeSpan? _interval;

        /// <summary>
        /// The interval to delay between poll 
        /// requests.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="value"/> is negative.</exception>
        public TimeSpan? Interval
        {
            get { return _interval; }
            set
            {
                if (value < TimeSpan.Zero)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), $"{nameof(Interval)} cannot be negative");
                }
                _interval = value;
            }
        }

        /// <summary>
        /// The maximum number of poll requests to make.
        /// </summary>
        /// <remarks>
        /// If the job has not completed after this number of requests has been made,
        /// the poll operation will fail with a <see cref="TimeoutException"/> as if
        /// a timeout had been set.
        /// </remarks>
        public int? MaxRequests { get; set; }

        /// <summary>
        /// The maximum overall time to poll for. Populating this property
        /// is equivalent to setting the <see cref="Deadline"/> property
        /// to "the time of calling <c>PollJobUntilCompleted</c>, plus the timeout".
        /// </summary>
        /// <remarks>
        /// A <see cref="PollJobOptions"/> with both <see cref="Timeout"/>
        /// and <see cref="Deadline"/> set to non-null values is invalid,
        /// and will cause an exception to be thrown.
        /// </remarks>
        public TimeSpan? Timeout { get; set; }

        private DateTime? _deadline;
        /// <summary>
        /// A deadline for polling; no requests will be made after this point
        /// in time. Must have a <see cref="DateTime.Kind"/> of <see cref="DateTimeKind.Utc"/>.
        /// </summary>
        /// <remarks>
        /// Currently, requests are not cancelled at this deadline; it only
        /// affects when the last request is started.
        /// </remarks>
        public DateTime? Deadline
        {
            get { return _deadline; }
            set
            {
                GaxRestPreconditions.CheckArgument(
                    value == null || value.Value.Kind == DateTimeKind.Utc,
                    nameof(value),
                    "Only UTC deadlines are supported");
                _deadline = value;
            }
        }

        internal void Validate()
        {
            GaxRestPreconditions.CheckArgument(Timeout == null || Deadline == null, "options",
                $"Cannot set both {nameof(Timeout)} and {nameof(Deadline)} to non-null values");
        }

        internal DateTime? GetEffectiveDeadline() => Deadline ?? DateTime.UtcNow + Timeout;
    }
}
