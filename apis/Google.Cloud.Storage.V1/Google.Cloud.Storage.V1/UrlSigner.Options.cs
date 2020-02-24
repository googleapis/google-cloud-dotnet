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
            /// Exactly one of <see cref="Duration"/> and <see cref="Expiration"/>
            /// will be set.
            /// </summary>
            public TimeSpan? Duration { get; }

            /// <summary>
            /// The point in time after which the signed URL will be invalid.
            /// Exactly one of <see cref="Duration"/> and <see cref="Expiration"/>
            /// will be set.
            /// </summary>
            public DateTimeOffset? Expiration { get; }

            /// <summary>
            /// The signing version to use for generating the signed URL.
            /// This will default to <see cref="SigningVersion.Default"/>
            /// which is currently the same as <see cref="SigningVersion.V2"/>.
            /// </summary>
            public SigningVersion SigningVersion { get; }

            private Options(TimeSpan? duration, DateTimeOffset? expiration, SigningVersion version)
            {
                GaxPreconditions.CheckArgument(
                    duration.HasValue != expiration.HasValue,
                    nameof(duration), 
                    "One and only one of {0} or {1} must be specified",
                    nameof(duration),
                    nameof(expiration));

                Duration = duration;
                Expiration = expiration;
                SigningVersion = version;
            }

            /// <summary>
            /// Creates a new <see cref="UrlSigner.Options"/> from the given duration.
            /// </summary>
            /// <param name="duration">The duration to create these options with.</param>
            /// <returns>A new options set.</returns>
            public static Options FromDuration(TimeSpan duration) =>
                new Options(duration, null, SigningVersion.Default);

            /// <summary>
            /// Creates a new <see cref="UrlSigner.Options"/> from the given expiration.
            /// </summary>
            /// <param name="expiration">The expiration to create these options with.</param>
            /// <returns>A new options set.</returns>
            public static Options FromExpiration(DateTimeOffset expiration) =>
                new Options(null, expiration, SigningVersion.Default);

            /// <summary>
            /// If this set of options was duration based, this method will return a new set
            /// of options whose expiration will be calculated based on this instance duration
            /// and the given clock.
            /// If this set of options was expiration based this same instance will be returned.
            /// </summary>
            /// <param name="clock">The clock to use to calculate the expiration.</param>
            /// <returns>An expiration based set of options.</returns>
            internal Options ToExpiration(IClock clock) =>
                Expiration.HasValue ? this : WithExpiration(clock.GetCurrentDateTimeUtc() + Duration.Value);

            /// <summary>
            /// Returns a new set of options with the same values as this one but duration based.
            /// </summary>
            /// <param name="duration">The new duration.</param>
            /// <returns>A new set of options with the given duration.</returns>
            public Options WithDuration(TimeSpan duration) =>
                new Options(duration, null, SigningVersion);

            /// <summary>
            /// Returns a new set of options with the same values as this one but expiration based.
            /// </summary>
            /// <param name="expiration">The new expiration.</param>
            /// <returns>A new set of options with the given expiration.</returns>
            public Options WithExpiration(DateTimeOffset expiration) =>
                new Options(null, expiration, SigningVersion);

            /// <summary>
            /// Returns a new set of options with the same values as this one except for the signing version.
            /// </summary>
            /// <param name="version">The new signing version.</param>
            /// <returns>A set of options with the given signing version.</returns>
            public Options WithSigningVersion(SigningVersion version) =>
                new Options(Duration, Expiration, GaxPreconditions.CheckEnumValue(version, nameof(version)));
        }
    }
}
