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
            /// which is currently the same as <see cref="SigningVersion.V4"/>.
            /// </summary>
            public SigningVersion SigningVersion { get; }

            /// <summary>
            /// The style of signed URL to generate.
            /// Defaults to <see cref="UrlStyle.PathStyle"/>.
            /// </summary>
            /// <remarks>
            /// When using <see cref="SigningVersion.V2"/> only <see cref="UrlStyle.PathStyle"/> and <see cref="UrlStyle.VirtualHostedStyle"/>
            /// are supported and <see cref="UrlSigner.Sign(RequestTemplate, Options)"/> and
            /// <see cref="UrlSigner.SignAsync(RequestTemplate, Options, System.Threading.CancellationToken)"/>
            /// will throw <see cref="ArgumentException"/> if <see cref="UrlStyle"/> is other than one of these two values.
            /// </remarks>
            public UrlStyle UrlStyle { get; }

            /// <summary>
            /// The Scheme to use for the request. Only http or https supported.
            /// This will never be null. If null is specified in <see cref="WithScheme(string)"/>
            /// then https will be used.
            /// Defaults to https.
            /// </summary>
            public string Scheme { get; }

            /// <summary>
            /// A bucket bound host to use for generating the signed URL.
            /// If <see cref="UrlStyle"/> is <see cref="UrlStyle.BucketBoundHostname"/> this won't be null.
            /// It will be null otherwise.
            /// Use <see cref="WithBucketBoundHostname(string)"/> to set.
            /// </summary>
            /// <remarks>
            /// When using <see cref="SigningVersion.V2"/> bucket bound host names are not supported
            /// and <see cref="UrlSigner.Sign(RequestTemplate, Options)"/> and
            /// <see cref="UrlSigner.SignAsync(RequestTemplate, Options, System.Threading.CancellationToken)"/>
            /// will throw <see cref="ArgumentException"/> if <see cref="BucketBoundHostname"/> is not null.
            /// </remarks>
            public string BucketBoundHostname { get; }

            private Options(
                TimeSpan? duration, DateTimeOffset? expiration, SigningVersion version, UrlStyle? urlStyle, string scheme, string bucketBoundHostname)
            {
                GaxPreconditions.CheckArgument(
                    duration.HasValue != expiration.HasValue,
                    nameof(duration), 
                    "One and only one of {0} or {1} must be specified",
                    nameof(duration),
                    nameof(expiration));
                GaxPreconditions.CheckArgument(
                    (bucketBoundHostname == null && urlStyle != UrlStyle.BucketBoundHostname) ||
                    (bucketBoundHostname != null && urlStyle == UrlStyle.BucketBoundHostname),
                    nameof(bucketBoundHostname),
                    $"For using a bucket bound domain to generate the signed URL, please use the {nameof(WithBucketBoundHostname)} method.");
                if (scheme != null)
                {
                    scheme = scheme.ToLowerInvariant();
                    GaxPreconditions.CheckArgument(
                        scheme.Equals("http") || scheme.Equals("https"),
                        nameof(scheme),
                        "Only http and https are supported.");
                }
                if (urlStyle.HasValue)
                {
                    GaxPreconditions.CheckEnumValue(urlStyle.Value, nameof(urlStyle));
                }

                Duration = duration;
                Expiration = expiration;
                SigningVersion = version;
                UrlStyle = urlStyle ?? UrlStyle.PathStyle;
                Scheme = scheme ?? "https";
                BucketBoundHostname = bucketBoundHostname;
            }

            /// <summary>
            /// Creates a new <see cref="UrlSigner.Options"/> from the given duration.
            /// </summary>
            /// <param name="duration">The duration to create these options with.</param>
            /// <returns>A new options set.</returns>
            public static Options FromDuration(TimeSpan duration) =>
                new Options(duration, null, SigningVersion.Default, null, null, null);

            /// <summary>
            /// Creates a new <see cref="UrlSigner.Options"/> from the given expiration.
            /// </summary>
            /// <param name="expiration">The expiration to create these options with.</param>
            /// <returns>A new options set.</returns>
            public static Options FromExpiration(DateTimeOffset expiration) =>
                new Options(null, expiration, SigningVersion.Default, null, null, null);

            /// <summary>
            /// If this set of options was duration based, this method will return a new set
            /// of options whose expiration will be calculated based on this instance duration
            /// and the given <see cref="DateTimeOffset"/>.
            /// If this set of options was expiration based this same instance will be returned.
            /// </summary>
            /// <param name="now">The <see cref="DateTimeOffset"/> that represents the current instant in time.</param>
            /// <returns>An expiration based set of options.</returns>
            internal Options ToExpiration(DateTimeOffset now) =>
                Expiration.HasValue ? this : WithExpiration(now + Duration.Value);

            /// <summary>
            /// Returns a new set of options with the same values as this one but duration based.
            /// </summary>
            /// <param name="duration">The new duration.</param>
            /// <returns>A new set of options with the given duration.</returns>
            public Options WithDuration(TimeSpan duration) =>
                new Options(duration, null, SigningVersion, UrlStyle, Scheme, BucketBoundHostname);

            /// <summary>
            /// Returns a new set of options with the same values as this one but expiration based.
            /// </summary>
            /// <param name="expiration">The new expiration.</param>
            /// <returns>A new set of options with the given expiration.</returns>
            public Options WithExpiration(DateTimeOffset expiration) =>
                new Options(null, expiration, SigningVersion, UrlStyle, Scheme, BucketBoundHostname);

            /// <summary>
            /// Returns a new set of options with the same values as this one except for the signing version.
            /// </summary>
            /// <param name="version">The new signing version.</param>
            /// <returns>A set of options with the given signing version.</returns>
            public Options WithSigningVersion(SigningVersion version) =>
                new Options(Duration, Expiration, GaxPreconditions.CheckEnumValue(version, nameof(version)), UrlStyle, Scheme, BucketBoundHostname);

            /// <summary>
            /// Returns a new set of options with the same values as this one except for the
            /// <see cref="UrlStyle"/> value.
            /// </summary>
            /// <param name="urlStyle">The new url style.</param>
            /// <returns>A new set ofoptions with the given url style.</returns>
            public Options WithUrlStyle(UrlStyle urlStyle) =>
                new Options(Duration, Expiration, SigningVersion, urlStyle, Scheme, null);

            /// <summary>
            /// Returns a new set of options with the same values as this one except for the scheme.
            /// </summary>
            /// <param name="scheme">The new scheme. May be null in which case https will be used.</param>
            /// <returns>A new set of options with the given scheme.</returns>
            public Options WithScheme(string scheme) =>
                new Options(Duration, Expiration, SigningVersion, UrlStyle, scheme, BucketBoundHostname);

            /// <summary>
            /// Returns a new set of options with the same values as this one except for bucket bound domain
            /// and the url style which will be set to <see cref="UrlStyle.BucketBoundHostname"/>.
            /// </summary>
            /// <param name="bucketBoundHostname">The new bucket bound domain.</param>
            /// <returns>A new set of options with the given bucket bound domain and the url style set to
            /// <see cref="UrlStyle.BucketBoundHostname"/>.</returns>
            public Options WithBucketBoundHostname(string bucketBoundHostname) =>
                new Options(Duration, Expiration, SigningVersion, UrlStyle.BucketBoundHostname, Scheme, bucketBoundHostname);
        }
    }
}
