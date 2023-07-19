// Copyright 2023 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at 
//
// https://www.apache.org/licenses/LICENSE-2.0 
//
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and 
// limitations under the License.

using Google.Protobuf;
using Google.Rpc;
using Grpc.Core;
using Xunit;

namespace Google.Cloud.Spanner.V1.Internal.Tests;

public class ExecuteHelperTests
{
    private static readonly ResourceInfo s_sessionResourceInfo = new ResourceInfo { ResourceType = ExecuteHelper.SessionResourceType };

    [Fact]
    public void IsSessionExpiredError_WrongStatusCode() =>
        Assert.False(CreateException(StatusCode.Aborted, s_sessionResourceInfo.ToByteArray()).IsSessionExpiredError());

    [Fact]
    public void IsSessionExpiredError_NoResourceInfo() =>
        Assert.False(CreateException(StatusCode.NotFound, null).IsSessionExpiredError());

    [Fact]
    public void IsSessionExpiredError_WrongResourceInfo() =>
        Assert.False(CreateException(StatusCode.NotFound, new ResourceInfo { ResourceType = "not-a-session" }.ToByteArray()).IsSessionExpiredError());

    [Fact]
    public void IsSessionExpiredError_InvalidResourceInfo() =>
        Assert.False(CreateException(StatusCode.NotFound, new byte[1]).IsSessionExpiredError());

    [Fact]
    public void IsSessionExpiredError_Valid() =>
        Assert.True(CreateException(StatusCode.NotFound, s_sessionResourceInfo.ToByteArray()).IsSessionExpiredError());

    private static RpcException CreateException(StatusCode code, byte[] resourceInfoData)
    {
        var trailers = new Metadata();
        if (resourceInfoData is not null)
        {
            trailers.Add(ExecuteHelper.ResourceInfoMetadataKey, resourceInfoData);
        }
        return new RpcException(new Grpc.Core.Status(code, "Bang"), trailers);
    }
}
