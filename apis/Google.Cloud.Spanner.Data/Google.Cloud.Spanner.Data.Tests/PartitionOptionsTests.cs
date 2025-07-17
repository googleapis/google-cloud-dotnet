// Copyright 2023 Google Inc. All Rights Reserved.
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

using Xunit;

namespace Google.Cloud.Spanner.Data.Tests;

public class PartitionOptionsTests
{
    [Fact]
    public void CheckDefaultValues()
    {
        var defaultOptions = PartitionOptions.Default;

        Assert.Null(defaultOptions.MaxPartitions);
        Assert.Null(defaultOptions.PartitionSizeBytes);
        Assert.False(defaultOptions.DataBoostEnabled);
    }

    [Fact]
    public void WithMethods()
    {
        var options = PartitionOptions.Default.WithPartitionSizeBytes(10).WithMaxPartitions(20).WithDataBoostEnabled(false);
        var newOptions = options.WithPartitionSizeBytes(100).WithMaxPartitions(200).WithDataBoostEnabled(true);

        Assert.Equal(10, options.PartitionSizeBytes);
        Assert.Equal(20, options.MaxPartitions);
        Assert.Equal(false, options.DataBoostEnabled);

        Assert.Equal(100, newOptions.PartitionSizeBytes);
        Assert.Equal(200, newOptions.MaxPartitions);
        Assert.Equal(true, newOptions.DataBoostEnabled);
    }
}
