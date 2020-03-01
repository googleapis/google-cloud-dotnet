// Copyright 2020 Google LLC
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
using System;

namespace Google.Cloud.Storage.V1
{
    public sealed partial class UrlSigner
    {
        /// <summary>
        /// Options for the UrlSigner.
        /// Options can be duration or expiration based regarding the validity of the signed URL.
        /// </summary>
        public sealed class Options
        {
            /// <summary>
            /// The length of time for which the signed URL should remain usable,
            /// counting from the moment the signed URL is created.
            /// May be null, in which case <see cref="Expiration"/> must be set.
            /// </summary>
            public TimeSpan? Duration { get; }

            /// <summary>
            /// The point in time after which the signed URL will be invalid.
            /// May be null, in which case <see cref="Duration"/> must be set.
            /// </summary>
            public DateTimeOffset? Expiration { get; }

            /// <summary>
            /// The style of signed URL to generate.
            /// Defaults to <see cref="UrlStyle.Path"/>.
            /// </summary>
            public UrlStyle UrlStyle { get; }

            /// <summary>
            /// The Scheme to use for the request. Usually http or https.
            /// Defaults to https.
            /// </summary>
            public string Scheme { get; }

            /// <summary>
            /// A bucket bound host to use for generating the signed URL.
            /// If <see cref="UrlStyle"/> is <see cref="UrlStyle.BucketBoundDomain"/> this won't be null.
            /// It will be null otherwise.
            /// Use <see cref="WithBucketBoundDomain(string)"/> to set.
            /// </summary>
            public string BucketBoundDomain { get; }

            private Options(
                TimeSpan? duration, DateTimeOffset? expiration, UrlStyle? urlStyle, string scheme, string bucketBoundDomain)
            {
                GaxPreconditions.CheckArgument(
                    duration.HasValue != expiration.HasValue,
                    nameof(duration), 
                    "One and only one of {0} or {1} must be specified",
                    nameof(duration),
                    nameof(expiration));
                GaxPreconditions.CheckArgument(
                    (bucketBoundDomain == null && urlStyle != UrlStyle.BucketBoundDomain) ||
                    (bucketBoundDomain != null && urlStyle == UrlStyle.BucketBoundDomain),
                    nameof(bucketBoundDomain),
                    $"For using a bucket bound domain to generate the signed URL, please use the {nameof(WithBucketBoundDomain)} method.");

                Duration = duration;
                Expiration = expiration;
                UrlStyle = urlStyle ?? UrlStyle.Path;
                Scheme = scheme ?? "https";
                BucketBoundDomain = bucketBoundDomain;
            }

            /// <summary>
            /// Creates a new <see cref="UrlSigner.Options"/> from the given duration.
            /// </summary>
            /// <param name="duration">The duration to create these options with.</param>
            /// <returns>A new options set.</returns>
            public static Options FromDuration(TimeSpan duration) =>
                new Options(duration, null, null, null, null);

            /// <summary>
            /// Creates a new <see cref="UrlSigner.Options"/> from the given expiration.
            /// </summary>
            /// <param name="expiration">The expiration to create these options with.</param>
            /// <returns>A new options set.</returns>
            public static Options FromExpiration(DateTimeOffset expiration) =>
                new Options(null, expiration, null, null, null);

            /// <summary>
            /// If this set of options was duration based, this method will return a new set
            /// of options whose expiration will be calculated based on this instance duration
            /// and the given clock.
            /// If this set of options was expiration based this same instance will be returned.
            /// </summary>
            /// <param name="clock">The clock to use to calculate the expiration.</param>
            /// <returns>An expiration based set of options.</returns>
            public Options ToExpiration(IClock clock) =>
                Expiration.HasValue ? this : WithExpiration(clock.GetCurrentDateTimeUtc() + Duration.Value);

            /// <summary>
            /// Returns a new set of options with the same values as this one but duration based.
            /// </summary>
            /// <param name="duration">The new duration.</param>
            /// <returns>A new set of options with the given duration.</returns>
            public Options WithDuration(TimeSpan duration) =>
                new Options(duration, null, UrlStyle, Scheme, BucketBoundDomain);

            /// <summary>
            /// Returns a new set of options with the same values as this one but expiration based.
            /// </summary>
            /// <param name="expiration">The new expiration.</param>
            /// <returns>A new set of options with the given expiration.</returns>
            public Options WithExpiration(DateTimeOffset expiration) =>
                new Options(null, expiration, UrlStyle, Scheme, BucketBoundDomain);

            /// <summary>
            /// Returns a new set of options with the same values as this one except for the
            /// <see cref="UrlStyle"/> value.
            /// </summary>
            /// <param name="urlStyle">The new url style.</param>
            /// <returns>A new set ofoptions with the given url style.</returns>
            public Options WithUrlStyle(UrlStyle urlStyle) =>
                new Options(Duration, Expiration, urlStyle, Scheme, null);

            /// <summary>
            /// Returns a new set of options with the same values as this one except for the scheme.
            /// </summary>
            /// <param name="scheme">The new scheme.</param>
            /// <returns>A new set of options with the given scheme.</returns>
            public Options WithScheme(string scheme) =>
                new Options(Duration, Expiration, UrlStyle, scheme, BucketBoundDomain);

            /// <summary>
            /// Returns a new set of options with the same values as this one except for bucket bound domain
            /// and the url style which will be set to <see cref="UrlStyle.BucketBoundDomain"/>.
            /// </summary>
            /// <param name="bucketBoundDomain">The new bucket bound domain.</param>
            /// <returns>A new set of options with the given bucket bound domain and the url style set to
            /// <see cref="UrlStyle.BucketBoundDomain"/>.</returns>
            public Options WithBucketBoundDomain(string bucketBoundDomain) =>
                new Options(Duration, Expiration, UrlStyle.BucketBoundDomain, Scheme, bucketBoundDomain);
        }
    }
}
