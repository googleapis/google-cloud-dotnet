// Copyright 2020 Google Inc. All Rights Reserved.
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

using Google.Api.Gax.Testing;
using System;
using Xunit;
using static Google.Cloud.Storage.V1.UrlSigner;

namespace Google.Cloud.Storage.V1.Tests
{
    public partial class UrlSignerTest
    {
        public class OptionsTest
        {
            [Fact]
            public void FromDuration()
            {
                var options = Options.FromDuration(TimeSpan.FromMinutes(1));

                Assert.Null(options.Expiration);
                Assert.Equal(TimeSpan.FromMinutes(1), options.Duration);
                Assert.Equal(UrlStyle.Path, options.UrlStyle);
                Assert.Equal("https", options.Scheme);
            }

            [Fact]
            public void FromExpiration()
            {
                var now = DateTimeOffset.UtcNow;

                var options = Options.FromExpiration(now);

                Assert.Null(options.Duration);
                Assert.Equal(now, options.Expiration);
                Assert.Equal(UrlStyle.Path, options.UrlStyle);
                Assert.Equal("https", options.Scheme);
            }

            [Fact]
            public void WithDuration()
            {
                var now = DateTimeOffset.UtcNow;
                var expiration = Options.FromExpiration(now);

                var duration = expiration.WithDuration(TimeSpan.FromMinutes(1));
                
                Assert.NotSame(expiration, duration);
                Assert.Null(duration.Expiration);
                Assert.Equal(TimeSpan.FromMinutes(1), duration.Duration);
            }

            [Fact]
            public void WithExpiration()
            {
                var now = DateTimeOffset.UtcNow;
                var duration = Options.FromDuration(TimeSpan.FromMinutes(1));

                var expiration = duration.WithExpiration(now);

                Assert.NotSame(duration, expiration);
                Assert.Null(expiration.Duration);
                Assert.Equal(now, expiration.Expiration);
            }

            [Fact]
            public void FromDurationToExpiration()
            {
                var duration = Options.FromDuration(TimeSpan.FromMinutes(1));
                var clock = new FakeClock(new DateTime(2018, 11, 19, 5, 56, 54, DateTimeKind.Utc));

                var expiration = duration.ToExpiration(clock);

                Assert.NotSame(duration, expiration);
                Assert.Null(expiration.Duration);
                Assert.Equal(new DateTimeOffset(new DateTime(2018, 11, 19, 5, 56 + 1, 54, DateTimeKind.Utc)), expiration.Expiration);
            }

            [Fact]
            public void FromExpirationToExpiration()
            {
                var clock = new FakeClock(new DateTime(2018, 11, 19, 5, 56, 54, DateTimeKind.Utc));
                var now = DateTimeOffset.UtcNow;
                var expiration = Options.FromExpiration(now);

                var anotherExpiration = expiration.ToExpiration(clock);

                Assert.Same(expiration, anotherExpiration);
                Assert.Null(anotherExpiration.Duration);
                Assert.Equal(now, anotherExpiration.Expiration);
            }

            [Fact]
            public void WithUrlStyle()
            {
                var options = Options.FromDuration(TimeSpan.FromMinutes(1));

                var newUrlStyle = options.WithUrlStyle(UrlStyle.VirtualHosted);

                Assert.NotSame(options, newUrlStyle);
                Assert.Equal(UrlStyle.VirtualHosted, newUrlStyle.UrlStyle);
            }

            [Fact]
            public void WithScheme()
            {
                var options = Options.FromDuration(TimeSpan.FromMinutes(1));

                var newScheme = options.WithScheme("http");

                Assert.NotSame(options, newScheme);
                Assert.Equal("http", newScheme.Scheme);
            }
        }
    }
}
