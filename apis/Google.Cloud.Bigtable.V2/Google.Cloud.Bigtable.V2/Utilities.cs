// Copyright 2017 Google Inc. All rights reserved.
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
using Google.Api.Gax.Grpc;
using Google.Protobuf;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Google.Cloud.Bigtable.V2
{
    internal static class Utilities
    {
        private const byte EscapeByte = (byte)'\\';
        private static readonly byte[] EscapedNullBytes = Encoding.UTF8.GetBytes(@"\x00");
        private static readonly Regex FamilyNameRegex =
            new Regex("^[-_.a-zA-Z0-9]+$", RegexOptions.Compiled);

        internal static ByteString Concat(this ByteString left, ByteString right)
        {
            if ((right?.Length).GetValueOrDefault(0) == 0)
            {
                return left;
            }

            if ((left?.Length).GetValueOrDefault(0) == 0)
            {
                return right;
            }

            var buffer = new byte[left.Length + right.Length];
            left.CopyTo(buffer, 0);
            right.CopyTo(buffer, left.Length);
            return ByteString.CopyFrom(buffer);
        }

        internal static bool IsIdempotent(this MutateRowRequest request) =>
            request.Mutations.All(IsIdempotent);

        internal static bool IsIdempotent(this MutateRowsRequest request) =>
            request.Entries.All(IsIdempotent);

        internal static bool IsIdempotent(this MutateRowsRequest.Types.Entry entry) =>
            entry.Mutations.All(IsIdempotent);

        internal static bool IsIdempotent(this Mutation mutation) =>
            mutation.SetCell?.TimestampMicros != -1;

        internal static ByteString RegexEscape(ByteString value)
        {
            // Logic taken from
            // https://github.com/google/re2/blob/70f66454c255080a54a8da806c52d1f618707f8a/re2/re2.cc#L456
            var result = new List<byte>(value.Length * 2);
            foreach (byte b in value)
            {
                // Special handling for null chars.
                if (b == 0)
                {
                    // Note that this special handling is not strictly required for RE2,
                    // but this quoting is required for other regexp libraries such as
                    // PCRE.
                    // Can't use @"\0" since the next character might be a digit.
                    result.AddRange(EscapedNullBytes);
                }
                else
                {
                    if (ShouldEscape(b))
                    {
                        result.Add(EscapeByte);
                    }
                    result.Add(b);
                }
            }

            return ByteString.CopyFrom(result.ToArray());

            // Escape any ascii character not in [A-Za-z_0-9].
            //
            // Note that it's legal to escape a character even if it has no
            // special meaning in a regular expression -- so this function does
            // that.  (This also makes it identical to the perl function of the
            // same name except for the null-character special case;
            // see `perldoc -f quotemeta`.)
            bool ShouldEscape(byte b)
            {
                if (b == '_' ||
                    // If this is the part of a UTF8 or Latin1 character, we need
                    // to copy this byte without escaping.  Experimentally this is
                    // what works correctly with the regexp library.
                    (b & 0x80) == 0x80 ||
                    ('a' <= b && b <= 'z') ||
                    ('A' <= b && b <= 'Z') ||
                    ('0' <= b && b <= '9'))
                {
                    return false;
                }
                return true;
            }
        }

        internal static async Task RetryOperationUntilCompleted(
            Func<Task<bool>> fn,
            IClock clock,
            IScheduler scheduler,
            CallSettings callSettings,
            RetrySettings retrySettings)
        {
            DateTime? overallDeadline = retrySettings.TotalExpiration.CalculateDeadline(clock);
            TimeSpan retryDelay = retrySettings.RetryBackoff.Delay;
            TimeSpan callTimeout = retrySettings.TimeoutBackoff.Delay;
            while (true)
            {
                DateTime attemptDeadline = clock.GetCurrentDateTimeUtc() + callTimeout;
                // Note: this handles a null total deadline due to "<" returning false if overallDeadline is null.
                DateTime combinedDeadline = overallDeadline < attemptDeadline ? overallDeadline.Value : attemptDeadline;
                CallSettings attemptCallSettings = callSettings.WithCallTiming(CallTiming.FromDeadline(combinedDeadline));
                TimeSpan actualDelay = retrySettings.DelayJitter.GetDelay(retryDelay);
                DateTime expectedRetryTime;
                try
                {
                    bool isResponseOk = await fn().ConfigureAwait(false);
                    if (isResponseOk)
                    {
                        return;
                    }

                    expectedRetryTime = clock.GetCurrentDateTimeUtc() + actualDelay;
                    if (expectedRetryTime > overallDeadline)
                    {
                        // TODO: Can we get this string from somewhere?
                        throw new RpcException(new Status(StatusCode.DeadlineExceeded, "Deadline Exceeded"));
                    }
                }
                catch (RpcException e) when (retrySettings.RetryFilter(e))
                {
                    expectedRetryTime = clock.GetCurrentDateTimeUtc() + actualDelay;
                    if (expectedRetryTime > overallDeadline)
                    {
                        throw;
                    }
                }
                await scheduler.Delay(actualDelay, callSettings.CancellationToken.GetValueOrDefault()).ConfigureAwait(false);
                retryDelay = retrySettings.RetryBackoff.NextDelay(retryDelay);
                callTimeout = retrySettings.TimeoutBackoff.NextDelay(callTimeout);
            }
        }

        internal static IEnumerable<T> ValidateCollection<T>(
            IEnumerable<T> items,
            string paramName,
            bool allowNullCollection = false)
        {
            if (allowNullCollection && items == null)
            {
                return Enumerable.Empty<T>();
            }

            GaxPreconditions.CheckNotNull(items, paramName);
            var result = items.Select(mutation =>
            {
                GaxPreconditions.CheckArgument(mutation != null, paramName, "Entries must not be null");
                return mutation;
            });
            return result;
        }

        internal static string ValidateFamilyName(string familyName)
        {
            GaxPreconditions.CheckArgument(
                familyName != null && FamilyNameRegex.IsMatch(familyName),
                nameof(familyName),
                "The family name must be non-null and match [-_.a-zA-Z0-9]+");

            return familyName;
        }
    }
}
