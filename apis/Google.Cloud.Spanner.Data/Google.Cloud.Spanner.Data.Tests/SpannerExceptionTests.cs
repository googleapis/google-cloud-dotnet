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
    [Fact]
    public void SpannerExceptionContainsRpcExceptionAsInnerException()
    {
        var status = new Status(StatusCode.InvalidArgument, "Bad request");

        var rpcExceptionMessage = "Test RpcException Message";
        var rpcException = new RpcException(status, rpcExceptionMessage);

        var spannerExceptionWithInnerExcpetion1 = new SpannerException(rpcException);
        var spannerExceptionWithInnerExcpetion2 = new SpannerException(ErrorCode.InvalidArgument, rpcException);

        var spannerExceptionWithoutInnerException = new SpannerException(ErrorCode.InvalidArgument, "Invalid Argument Message");

        Assert.Same(rpcException, spannerExceptionWithInnerExcpetion1.RpcException);
        Assert.Same(rpcException, spannerExceptionWithInnerExcpetion2.RpcException);

        Assert.Null(spannerExceptionWithoutInnerException.RpcException);
    }
}
