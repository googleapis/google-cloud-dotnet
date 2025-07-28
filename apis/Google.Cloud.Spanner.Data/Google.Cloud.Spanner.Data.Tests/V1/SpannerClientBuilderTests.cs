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

using Google.Api.Gax.Grpc.Gcp;
using Google.Cloud.Spanner.V1;
using Xunit;

namespace Google.Cloud.Spanner.Data.Tests;
public class SpannerClientBuilderTests
{
    [Fact]
    public void EmulatorBuilder_RespectsCustomSettings()
    {
        var affinityConfig = new ChannelPoolConfig
        {
            MaxSize = 10,
            MaxConcurrentStreamsLowWatermark = 2,
        };

        var builder = new SpannerClientBuilder
        {
            EmulatorDetection = Api.Gax.EmulatorDetection.EmulatorOnly,
            EnvironmentVariableProvider = name => name,
            LeaderRoutingEnabled = false,
            DirectedReadOptions = DirectedReadTests.IncludeDirectedReadOptions,
            AffinityChannelPoolConfiguration = affinityConfig,
        };

        var emulatorBuilder = builder.MaybeCreateEmulatorClientBuilder();

        Assert.NotNull(emulatorBuilder);
        Assert.False(emulatorBuilder.LeaderRoutingEnabled);
        Assert.Same(DirectedReadTests.IncludeDirectedReadOptions, emulatorBuilder.DirectedReadOptions);
        Assert.Same(affinityConfig, emulatorBuilder.AffinityChannelPoolConfiguration);
    }
}
