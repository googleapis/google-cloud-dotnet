// Copyright 2022 Google LLC
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

using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Google.Cloud.Spanner.Data.Tests;
public class SpannerExceptionTests
{
    private static readonly Status s_status = new Status(StatusCode.InvalidArgument, "Bad request");

    [Fact]
    public void SpannerExceptionContainsRpcExceptionAsInnerException()
    {
        var rpcExceptionMessage = "Test RpcException Message";
        var rpcexception = new RpcException(s_status, rpcExceptionMessage);

        var spannerExceptionWithInnerExcpetion_1 = new SpannerException(rpcexception);
        var spannerExceptionWithInnerExcpetion_2 = new SpannerException(ErrorCode.InvalidArgument, rpcexception);

        var spannerExceptionWithoutInnerExcpetion = new SpannerException(ErrorCode.InvalidArgument, "Invalid Argument Message");

        Assert.NotNull(spannerExceptionWithInnerExcpetion_1.RpcException);
        Assert.Equal(rpcExceptionMessage, spannerExceptionWithInnerExcpetion_1.RpcException.Message);
        Assert.NotNull(spannerExceptionWithInnerExcpetion_2.RpcException);
        Assert.Equal(rpcExceptionMessage, spannerExceptionWithInnerExcpetion_2.RpcException.Message);

        Assert.Null(spannerExceptionWithoutInnerExcpetion.RpcException);
    }
}
