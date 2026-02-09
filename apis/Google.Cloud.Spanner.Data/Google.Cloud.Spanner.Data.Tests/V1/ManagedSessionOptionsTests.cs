// Copyright 2025 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License"):
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

using Google.Cloud.Spanner.Common.V1;
using Google.Cloud.Spanner.V1;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Google.Cloud.Spanner.V1.Tests;
using System;
using Xunit;

namespace Google.Cloud.Spanner.Data.Tests;

public class ManagedSessionOptionsTests
{
    private static readonly DatabaseName SampleDatabaseName = new DatabaseName("project", "instance", "database");
    private readonly SpannerClient _mockClient = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);

    [Fact]
    public void Create_ValidatesParameters()
    {
        Assert.Throws<ArgumentNullException>(() => ManagedSessionOptions.Create(null, _mockClient));
        Assert.Throws<ArgumentNullException>(() => ManagedSessionOptions.Create(SampleDatabaseName, null));
    }

    [Fact]
    public void Create_DefaultValues()
    {
        var options = ManagedSessionOptions.Create(SampleDatabaseName, _mockClient);
        Assert.Equal(SampleDatabaseName, options.DatabaseName);
        Assert.Same(_mockClient, options.Client);
        Assert.Null(options.DatabaseRole);
        Assert.Null(options.Timeout);
        Assert.Equal(TimeSpan.FromMinutes(1), options.EffectiveTimeout);
    }

    [Fact]
    public void WithDatabaseRole()
    {
        var options = ManagedSessionOptions.Create(SampleDatabaseName, _mockClient)
            .WithTimeout(TimeSpan.FromSeconds(10));
        var optionsWithRole = options.WithDatabaseRole("new-role");

        Assert.NotSame(options, optionsWithRole);
        Assert.Equal("new-role", optionsWithRole.DatabaseRole);
        // Verify other properties are preserved
        Assert.Equal(SampleDatabaseName, optionsWithRole.DatabaseName);
        Assert.Same(_mockClient, optionsWithRole.Client);
        Assert.Equal(TimeSpan.FromSeconds(10), optionsWithRole.Timeout);

        // Verify original options are unchanged
        Assert.Null(options.DatabaseRole);
        Assert.Equal(TimeSpan.FromSeconds(10), options.Timeout);
    }

    [Fact]
    public void WithTimeout_ValidatesParameters()
    {
        var options = ManagedSessionOptions.Create(SampleDatabaseName, _mockClient);
        Assert.Throws<ArgumentOutOfRangeException>(() => options.WithTimeout(TimeSpan.Zero));
        Assert.Throws<ArgumentOutOfRangeException>(() => options.WithTimeout(TimeSpan.FromSeconds(-1)));
    }

    [Fact]
    public void WithTimeout()
    {
        var options = ManagedSessionOptions.Create(SampleDatabaseName, _mockClient)
            .WithDatabaseRole("role");
        var timeout = TimeSpan.FromSeconds(30);
        var optionsWithTimeout = options.WithTimeout(timeout);

        Assert.NotSame(options, optionsWithTimeout);
        Assert.Equal(timeout, optionsWithTimeout.Timeout);
        Assert.Equal(timeout, optionsWithTimeout.EffectiveTimeout);
        // Verify other properties are preserved
        Assert.Equal(SampleDatabaseName, optionsWithTimeout.DatabaseName);
        Assert.Same(_mockClient, optionsWithTimeout.Client);
        Assert.Equal("role", optionsWithTimeout.DatabaseRole);

        // Verify original options are unchanged
        Assert.Null(options.Timeout);
        Assert.Equal("role", options.DatabaseRole);
    }

    [Fact]
    public void WithTimeout_Null()
    {
        var options = ManagedSessionOptions.Create(SampleDatabaseName, _mockClient)
            .WithDatabaseRole("role")
            .WithTimeout(TimeSpan.FromSeconds(30));
        var optionsWithNullTimeout = options.WithTimeout(null);

        Assert.NotSame(options, optionsWithNullTimeout);
        Assert.Null(optionsWithNullTimeout.Timeout);
        Assert.Equal(TimeSpan.FromMinutes(1), optionsWithNullTimeout.EffectiveTimeout);
        // Verify other properties are preserved
        Assert.Equal(SampleDatabaseName, optionsWithNullTimeout.DatabaseName);
        Assert.Same(_mockClient, optionsWithNullTimeout.Client);
        Assert.Equal("role", optionsWithNullTimeout.DatabaseRole);

        // Verify original options are unchanged
        Assert.Equal(TimeSpan.FromSeconds(30), options.Timeout);
        Assert.Equal("role", options.DatabaseRole);
    }
}
